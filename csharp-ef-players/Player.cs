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
       
        public int NumberOfPlayedMatches { get; set; }
        public int NumberOfVictories { get; set; }

        //RELATION WITH TEAM
        public int? TeamId { get; set; }
        public Team? Team { get; set; }


        //CONSTRUCTOR
        public Player(string name, string surname, int numberOfPlayedMatches, int numberOfVictories, double score) 
        {
            Name = name;
            Surname = surname;
            Score = score;
            NumberOfPlayedMatches = numberOfPlayedMatches;
            NumberOfVictories = numberOfVictories;
           
        }
        //METHODS
        public override string ToString()
        {
            string rapprString = $" - Name:{Name} \n - Surname: {Surname}\n - Score: {Score} \n - Number of Matches: {NumberOfPlayedMatches} \n - Number of Vitctories: {NumberOfVictories}";
            return rapprString;
        }
    }
}
