using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruthDareGame
{
    public partial class formMainGame : Form
    {
        string[] arrPlayers;
        public formMainGame(string[] arrPlayers)
        {
            InitializeComponent();
            this.arrPlayers = arrPlayers;
        }

        int[] randomIndex()
        {
            Random r = new Random();
            int indexPlayer1, indexPlayer2=0;
            indexPlayer1 = r.Next(arrPlayers.Length);

            do
            {
                indexPlayer2 = r.Next(arrPlayers.Length);
            } while ((indexPlayer1 == indexPlayer2) || (indexPlayer1 % 2 != indexPlayer2 % 2));
            int[] arrPlayerIndex = {indexPlayer1,indexPlayer2};
            return arrPlayerIndex;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int[] arrPlayerIndex = randomIndex();
            lblPlayer1.Text = arrPlayers[arrPlayerIndex[0]];
            lblPlayer2.Text = arrPlayers[arrPlayerIndex[1]];
        }
    }
}
