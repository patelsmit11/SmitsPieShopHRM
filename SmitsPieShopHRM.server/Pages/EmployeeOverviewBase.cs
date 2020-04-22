using Microsoft.AspNetCore.Components;
using SmitsPieShopHRM.server.Components;
using SmitsPieShopHRM.server.Services;
using SmitsPieShopHRM.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmitsPieShopHRM.server.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
        protected AddEmployeeDialogBase AddEmployeeDialog { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }
        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }
    }
}