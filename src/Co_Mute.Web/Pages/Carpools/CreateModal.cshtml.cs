using Co_Mute.Carpools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Co_Mute.Web.Pages.Carpools
{
    public class CreateModalModel : Co_MutePageModel
    {
        [BindProperty]
        public CreateUpdateCarpoolDto Carpool { get; set; }

        private readonly ICarpoolAppService _carpoolAppService;

        public CreateModalModel(ICarpoolAppService carpoolAppService)
        {
            _carpoolAppService = carpoolAppService;
        }

        public void OnGet()
        {
            Carpool = new CreateUpdateCarpoolDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _carpoolAppService.CreateAsync(Carpool);
            return NoContent();
        }
    }
}
