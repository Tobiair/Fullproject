using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite
{
    public class CharactersModel
    {
        public int id { get; set; }
        public string? name { get; set; }

        public string? specialrules { get; set; }

        public string? faction { get; set; }
    }
    public class HexModel
    {
        public string? Number { get; set; }

        public string? Terrain { get; set; } 

        public string? CompanyPresent { get; set; }  
    }
    public class GameSettings
    {
        public int NumOfplayers { get;set; }
        public int Points { get; set; } 
        public int VictoryPoints { get; set; }
        public string? MapSize { get; set; }
    }
    public class Player
    {
        public string? PlayerName { get; set; }

        public string? ArmyName { get; set; }
        
        public string? NamedCharacter { get; set; }
    }
}
