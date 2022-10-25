using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Co_Mute.Carpools
{
     public class Carpool: AuditedAggregateRoot<Guid>
    {
     
        public DateTime DepartureTime { get; set; }
        public DateTime ExpectedArrivalTime { get; set; }
        public string Origin { get; set; }
        public int DaysAvailable { get; set; }
        public string Destination { get; set; }
        public int AvailableSeats { get; set; }
        public string OwnerLeader { get; set; }
        public string Notes { get; set; }
    }
}
