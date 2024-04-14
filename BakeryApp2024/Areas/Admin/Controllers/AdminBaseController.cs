using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BakeryApp2024.Core.Constants.AdministratorConstants;

namespace BakeryApp2024.Areas.Admin.Controllers
{
    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
        
    }
}
