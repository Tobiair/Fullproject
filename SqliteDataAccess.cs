using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;  
using System.Linq;
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

        public static void SavePerson(CharactersModel person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Characters (name, specialrules, faction) values (@name, @specialrules, @faction)", person);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
