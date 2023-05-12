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
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string City { get; set; }

            //TODO: Create Trainer class and give Trainer object as property
        [MaxLength(20)]
        public string Trainer { get; set; }
        public List<string> Colors { get; set; }

        //CONSTRUCTOR
        public Team(string name, string city, string trainer, List<string> colors) 
        {
            Name = name;    
            City = city;
            Trainer = trainer;
            Colors = colors;

        }
    }
}
