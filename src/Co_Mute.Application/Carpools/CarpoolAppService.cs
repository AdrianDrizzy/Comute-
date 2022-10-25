using Co_Mute.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Co_Mute.Carpools
{
    public class CarpoolAppService :
       CrudAppService< //Defines CRUD methods
           Carpool, //The Carpool Entity
           CarpoolDto, //Used to show carpools
           Guid, //Primary key of the Carpool entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateCarpoolDto>, //Used to create/update a Carpool
        ICarpoolAppService //Implement the ICarpoolAppService

    {
        public CarpoolAppService(IRepository<Carpool, Guid> repository)
            : base(repository)
        {
            GetPolicyName = Co_MutePermissions.Carpools.Default;
            GetListPolicyName = Co_MutePermissions.Carpools.Default;
            CreatePolicyName = Co_MutePermissions.Carpools.Create;
            UpdatePolicyName = Co_MutePermissions.Carpools.Edit;
            DeletePolicyName = Co_MutePermissions.Carpools.Delete;

        }
    }
}
