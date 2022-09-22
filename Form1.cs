namespace sqlite
{
    public partial class Form1 : Form
    {
        List<CharactersModel> characters = new List<CharactersModel>();
        public Form1()
        {
            InitializeComponent();

            LoadPeopleList();
        }
        private void LoadFactionList()
        {
            characters = SqliteDataAccess.loadPeople();
            WireUpfactionList();
        }

        private void WireUpfactionList()
        {
            listBox2.DataSource = null;
            listBox2.DataSource = characters;
            listBox2.DisplayMember = "faction";
        }
        private void LoadPeopleList()
        {
            characters = SqliteDataAccess.loadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = characters;
            listBox1.DisplayMember = "name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
            LoadFactionList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CharactersModel p = new CharactersModel();

            p.name = name.Text;
            p.specialrules = SpecialRules.Text;
            p.faction = Faction.Text;

            SqliteDataAccess.SavePerson(p);


            name.Text = "";
            SpecialRules.Text = "";
            Faction.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu Menu = new menu();
            Menu.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}