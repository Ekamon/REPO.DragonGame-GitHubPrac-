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
            //Comment added through GitHub editing

            if (txtPlayerName.Text != "" && txtDragonName.Text != "") 
            {

                playerName = txtPlayerName.Text;
                dragonName = txtDragonName.Text;

                rtbOutput.Text = "Player Name: " + playerName +
                                 "\nDragon Name: " + dragonName;
            }
            else
            {
                rtbOutput.Text = "You didnt do anything and a homeless man kills you";
            }

        }
    }
}
