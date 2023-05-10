using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    public class Player
    {
        //PROPERTIES
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }

        public double Score { get; set; }
       
        public ushort NumberOfPlayedMatches { get; set; }
        public ushort NumberOfVictories { get; set; }


        //CONSTRUCTOR
        public Player(string name, string surname) 
        {
            Name = name;
            Surname = surname;
            Score = 0;
            NumberOfPlayedMatches = 0;
            NumberOfVictories = 0;
           
        }
    }
}
