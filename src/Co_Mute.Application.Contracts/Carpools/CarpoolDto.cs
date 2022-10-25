using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Co_Mute.Carpools
{
    
    public class CarpoolDto : AuditedEntityDto<Guid>
    {
        
        public DateTime DepartureTime { get; set; }
        
        public DateTime ExpectedArrivalTime { get; set; }
        
        public string Origin { get; set; }
        
        public string Destination { get; set; }
        public int DaysAvailable { get; set; }
        
        public int AvailableSeats { get; set; }
        
        public string OwnerLeader { get; set; }
        public string Notes { get; set; }
    }

}
