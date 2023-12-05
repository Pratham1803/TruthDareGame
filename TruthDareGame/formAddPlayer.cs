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
    public partial class formAddPlayer : Form
    {
        int numPlayer;
        TextBox[] txtPlayerName;
        public formAddPlayer(int numPlayer)
        {
            InitializeComponent();
            this.numPlayer = numPlayer;
            Console.Write("Hello");
        }

        private void formAddPlayer_Load(object sender, EventArgs e)
        {
            txtPlayerName = new TextBox[numPlayer];
            int valign = 70;
            for (int i = 0; i < numPlayer; i++) 
            {
                txtPlayerName[i] = new TextBox();
                txtPlayerName[i].Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtPlayerName[i].Location = new System.Drawing.Point(50,valign);
                txtPlayerName[i].Name = "txtPlayerNum";
                txtPlayerName[i].Size = new System.Drawing.Size(200, 20);
                valign += 40;
                this.Controls.Add(txtPlayerName[i]);
            }
            Button go = new Button();
            go.Font = new System.Drawing.Font("Calibri", 16F);
            go.Location = new System.Drawing.Point(200, valign+25);
            go.Name = "btnGo";
            go.Size = new System.Drawing.Size(108, 40);
            go.TabIndex = 2;
            go.Text = "Go";
            go.UseVisualStyleBackColor = true;
            go.Click += new System.EventHandler(btnGo_Click);
            Controls.Add(go);
        }

        private void btnGo_Click(object sender, System.EventArgs e)
        {
            string[] arrPlayerName = new string[numPlayer];
            for (int i = 0; i < numPlayer; i++)
            {
                arrPlayerName[i] = txtPlayerName[i].Text;
            }
            formMainGame f = new formMainGame(arrPlayerName);
            this.Hide();
            f.Show();
        }
    }
}
