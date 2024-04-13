using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static BakeryApp2024.Core.Constants.RoleConstants;

namespace BakeryApp2024.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : Controller
    {
        
    }
}
