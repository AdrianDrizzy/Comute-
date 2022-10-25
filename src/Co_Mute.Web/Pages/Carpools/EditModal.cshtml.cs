using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System;
using Co_Mute.Carpools;

namespace Co_Mute.Web.Pages.Carpools
{
    public class EditModalModel : Co_MutePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateCarpoolDto Carpool { get; set; }

        private readonly ICarpoolAppService _carpoolAppService;

        public EditModalModel(ICarpoolAppService carpoolAppService)
        {
            _carpoolAppService = carpoolAppService;
        }

        public async Task OnGetAsync()
        {
            var carpoolDto = await _carpoolAppService.GetAsync(Id);
            Carpool = ObjectMapper.Map<CarpoolDto, CreateUpdateCarpoolDto>(carpoolDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _carpoolAppService.UpdateAsync(Id, Carpool);
            return NoContent();
        }
    }
}
