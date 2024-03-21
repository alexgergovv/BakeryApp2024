using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
