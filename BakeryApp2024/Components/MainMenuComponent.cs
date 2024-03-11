using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Components
{
    public class MainMenuComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
