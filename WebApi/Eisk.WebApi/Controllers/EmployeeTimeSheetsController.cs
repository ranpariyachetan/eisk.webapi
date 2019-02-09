using Eisk.Core.DomainService;
using Microsoft.AspNetCore.Mvc;

namespace Eisk.WebApi.Controllers
{
    using Eisk.Core.WebApi;
    using Domains.Entities;

    [Route("api/[controller]")]
    public class EmployeeTimeSheetsController : WebApiControllerBaseAsync<EmployeeTimeSheet,int>
    {
        public EmployeeTimeSheetsController(DomainServiceAsync<EmployeeTimeSheet, int> employeeTimeSheetDomainService) :base(employeeTimeSheetDomainService)
        {
            
        }
    }
}
