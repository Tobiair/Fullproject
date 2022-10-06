using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlite
{
    public partial class playerOptions : Form
    {
        public playerOptions()
        {
            InitializeComponent();
        }

        private void playerOptions_Load(object sender, EventArgs e)
        {

        }

        private void playerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterName_Click(object sender, EventArgs e)
        {
            Player player = new Player();

            player.PlayerName = playerName.Text;
            player.ArmyName = ArmyName.Text;
            player.NamedCharacter = NamedCharacters.Text;

            SqliteDataAccess.SavePlayer(player);

            playerName.Text = "";
            ArmyName.Text = "";
            NamedCharacters.Text = "";
        }

        private void NamedCharacters_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArmyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            MainHex mainHex = new MainHex();
            mainHex.Show();
            this.Close();
        }
    }
}
