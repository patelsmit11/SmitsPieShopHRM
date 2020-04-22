using BlazorInputFile;
using Microsoft.AspNetCore.Components;
using SmitsPieShopHRM.server.Services;
using SmitsPieShopHRM.Shared;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SmitsPieShopHRM.server.Components
{
    public class AddEmployeeDialogBase: ComponentBase
    {
        public Employee Employee { get; set; } = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Inject]
        public IFileUpload fileUpload { get; set; }
        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }
        protected IFileListEntry file { get; set; }
        public bool ShowDialog { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }
        
        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            Employee = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.Now, JoinedDate = DateTime.Now };
        }

        protected async Task HandleValidSubmit()
        {
            if (file != null)
            {
                await fileUpload.UploadAsync(file);
                Employee.FileName = file.Name;
            }

            await EmployeeDataService.AddEmployee(Employee);
            await CloseEventCallback.InvokeAsync(true);
            ShowDialog = false;
            StateHasChanged();
        }

        protected void HandleFileSelected(IFileListEntry[] files)
        {
            file = files.FirstOrDefault();
        }
    }
}
