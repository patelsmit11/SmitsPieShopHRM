using Microsoft.AspNetCore.Components;
using SmitsPieShopHRM.ComponentsLibrary.Map;
using SmitsPieShopHRM.server.Services;
using SmitsPieShopHRM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmitsPieShopHRM.server.Pages
{
    public class EmployeeDetailBase : ComponentBase
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();
        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
            MapMarkers = new List<Marker>
            {
                new Marker{Description = $"{Employee.FirstName} {Employee.LastName}",  ShowPopup = false, X = Employee.Longitude, Y = Employee.Latitude}
            };
        }
    }
}