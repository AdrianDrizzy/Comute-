using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Co_Mute.Carpools
{
    public class Co_MuteDataSeederContributor
       : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Carpool, Guid> _carpoolRepository;

        public Co_MuteDataSeederContributor(IRepository<Carpool, Guid> carpoolRepository)
        {
            _carpoolRepository = carpoolRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _carpoolRepository.GetCountAsync() <= 0)
            {
                await _carpoolRepository.InsertAsync(
                    new Carpool()
                    {
                        DepartureTime = new DateTime(2022,6,6),
                        ExpectedArrivalTime = new DateTime( 2022,6,12),
                        Origin =" Cape Town",
                        DaysAvailable = 4,  
                        Destination = "Parow",
                        AvailableSeats = 5,
                        OwnerLeader = "Brian",
                        Notes =" None Applicable"
                    },
                    autoSave: true);    
            }
        }
    }
}
