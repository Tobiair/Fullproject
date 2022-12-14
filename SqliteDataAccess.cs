using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;  
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace sqlite
{
    public class SqliteDataAccess
    {
        public static List<CharactersModel> loadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection (LoadConnectionString()))
            {
                var output = cnn.Query<CharactersModel>("SELECT * FROM Characters ", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<HexModel> loadHex( string column, string row)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sql = $"SELECT * FROM Hex where Number = '{column},{row}'";
                var output = cnn.Query<HexModel>(sql, new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SavePerson(CharactersModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Characters (name, specialrules, faction) values (@name, @specialrules, @faction)", person);
            }
        }
        public static void MakeHex(HexModel Hex)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Hex (Number, CompanyPresent, Terrain) values (@Number, @CompanyPresent, @Terrain)", Hex);
            }
        }
        public static void DeleteAllHex()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Delete from Hex");
            }
        }
        public static void SaveSettings(GameSettings settings)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into gameSettings (Points, VictoryPoints) values (@Points, @VictoryPoints)", settings);
            }
        }
        public static void SavePlayer(Player p)
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into PlayerArmy (PlayerName, ArmyName, NamedCharacters) values (@PlayerName, @ArmyName, @NamedCharacter)", p);
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
