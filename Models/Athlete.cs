using System;
using System.ComponentModel.DataAnnotations;
namespace MySportTeam.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        public string Family { get; set; }
         public string Given { get; set; }

        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }
        public string Gender { get; set; }

        public string Identifier { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        
        
       }
}