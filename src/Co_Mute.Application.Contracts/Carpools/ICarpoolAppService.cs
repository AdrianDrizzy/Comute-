using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Co_Mute.Carpools
{
  
        public interface ICarpoolAppService :
        ICrudAppService< //Defines CRUD methods
            CarpoolDto, //Used to show carpools
            Guid, //Primary key of the Carpool entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCarpoolDto> //Used to create/update a Carpool

        {

        }
    
}
