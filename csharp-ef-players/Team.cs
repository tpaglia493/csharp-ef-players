using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    public class Team
    {
        //PROPERTIES
        [Key]
        public int TeamId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string City { get; set; }

            //TODO: Create Trainer class and give Trainer object as property
        [MaxLength(20)]
        public string Trainer { get; set; }
        public string Colors{ get; set; }

            //RELATION WITH MANY PLAYER OBJECTS
        public List<Player> Players { get; set; }

        //CONSTRUCTOR
        public Team(string name, string city, string trainer, string colors) 
        {
            Name = name;    
            City = city;
            Trainer = trainer;
            Colors = colors;
            Players = new List<Player>();
        }

       /* public Team(string name, string city, string trainer, List<string> colors, List<Player> players)
        {
            Name = name;
            City = city;
            Trainer = trainer;
            Colors = new List<string>(colors);
            Players = new List<Player>(players);
        }*/
    }
}
