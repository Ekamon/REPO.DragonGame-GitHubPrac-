namespace DragonGame_GitHubPrac_
{
    public partial class Form1 : Form
    {
        string playerName;
        string dragonName;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            playerName = txtPlayerName.Text;
            dragonName = txtDragonName.Text;

            rtbOutput.Text = "Player Name: " + playerName +
                             "\nDragon Name: " + dragonName;
        }
    }
}
