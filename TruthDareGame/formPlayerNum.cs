using System;
using System.Windows.Forms;

namespace TruthDareGame
{
    // Data Source = PRATHAM\SQLEXPRESS;Initial Catalog = MyDB; User ID = sa; Password=***********
    public partial class formPlayerNum : Form
    {
        int playerNum;
        public formPlayerNum()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            playerNum = Convert.ToInt32(txtPlayerNum.Text);
            if (playerNum<=6) 
            {
                formAddPlayer f = new formAddPlayer(playerNum);
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Player's number less than or equal to 6!","Truth Dare Game",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPlayerNum.Text = "";
                txtPlayerNum.Focus();
            }
            
        }
    }
}
