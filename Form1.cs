using static System.Formats.Asn1.AsnWriter;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool player = true;
        int m = 0;

        private void Mark(object sender, EventArgs e)
        {
            m++;
            ((Button)sender).Text = player ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (m >= 5)
            {
                CheckForWinner();
            }
            player = !player;
            labelMove.Text = player ? "O" : "X";
        }

        private void CheckForWinner()
        {
            if (b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text ||
                b4.Text != "" && b4.Text == b5.Text && b5.Text == b6.Text ||
                b4.Text != "" && b4.Text == b5.Text && b5.Text == b6.Text ||
                b7.Text != "" && b7.Text == b8.Text && b8.Text == b9.Text ||
                b1.Text != "" && b1.Text == b5.Text && b5.Text == b9.Text ||
                b3.Text != "" && b3.Text == b5.Text && b5.Text == b7.Text ||
                b1.Text != "" && b1.Text == b4.Text && b4.Text == b7.Text ||
                b2.Text != "" && b2.Text == b5.Text && b5.Text == b8.Text ||
                b3.Text != "" && b3.Text == b6.Text && b6.Text == b9.Text)
            {
                Win();
            }
            else if (m == 9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restart();
            }
        }

        private void Win()
        {
            MessageBox.Show("Zwyciê¿aj¹: " + (player ? "O" : "X"), "Zwyciêstwo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (player) scoreO.Text = ((int.Parse(scoreO.Text)) + 1).ToString();
            else scoreX.Text = ((int.Parse(scoreX.Text)) + 1).ToString();
            Restart();
        }

        private void Restart()
        {
            m = 0;
            Button[] all = new Button[9];
            all[0] = b1;
            all[1] = b2;
            all[2] = b3;
            all[3] = b4;
            all[4] = b5;
            all[5] = b6;
            all[6] = b7;
            all[7] = b8;
            all[8] = b9;
            // ...make it again clickable and empty
            foreach (Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Restart();
            labelMove.Text = "O";
            scoreO.Text = "0";
            scoreX.Text = "0";
            player = true;
        }
    }
}