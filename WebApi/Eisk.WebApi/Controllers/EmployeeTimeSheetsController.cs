using Microsoft.AspNetCore.Mvc;

namespace Eisk.WebApi.Controllers
{
    using Core.DomainService;
    using Domains.Entities;
    using Eisk.Core.WebApi;

    [Route("api/[controller]")]
    public class EmployeeTimeSheetsController
        :WebApiControllerBaseAsync<EmployeeTimeSheet,int>
    {
        public EmployeeTimeSheetsController(
            DomainServiceAsync<EmployeeTimeSheet, int> 
                employeeTimeSheetDomainService)
                    :base(employeeTimeSheetDomainService)
        {
            
        }
    }
}
