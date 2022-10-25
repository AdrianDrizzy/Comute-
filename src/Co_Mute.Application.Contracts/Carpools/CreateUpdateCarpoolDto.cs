using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Co_Mute.Carpools
{

    public class CreateUpdateCarpoolDto
    {
        [Required]
        public DateTime DepartureTime { get; set; }
        [Required]
        public DateTime ExpectedArrivalTime { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        public string Destination { get; set; }
        public int DaysAvailable { get; set; }
        [Required]
        public int AvailableSeats { get; set; }
        [Required]
        public string OwnerLeader { get; set; }
        public string Notes { get; set; }
    }
}
