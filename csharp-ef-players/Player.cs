using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    internal class Player
    {
        //PROPERTIES
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Score { get; set; }
        public ushort NumberOfPlayedMatches { get; set; }
        public ushort NumberOfVictories { get; set; }


        //CONSTRUCTOR
    }
}
