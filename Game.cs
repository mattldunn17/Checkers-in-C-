using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Game : Form
    {
        // Variables
        int turn = 0;
        bool extraJump = false;
        PictureBox selectedBox = null;
        List<PictureBox> blues = new List<PictureBox>();
        List<PictureBox> reds = new List<PictureBox>();
        Player redPlayer;
        Player bluePlayer;

        public Game(string _redname, string _bluename)
        {
            InitializeComponent();

            // creates player instances
            if (_redname == "")
                redPlayer = new Player();
            else
                redPlayer = new Player(_redname);
            if (_bluename == "")
                bluePlayer = new Player();
            else
                bluePlayer = new Player(_bluename);

            // loads checkers list
            loadLists();

            // sets player texts
            redname.Text = redPlayer.name;
            redwins.Text = redPlayer.wins.ToString();
            bluename.Text = bluePlayer.name;
            bluewins.Text = bluePlayer.wins.ToString();
        }

        // destructor
        ~Game()
        {
        }

        private void loadLists()
        {
            // constructing list of blue checks
            blues.Add(blue1);
            blues.Add(blue2);
            blues.Add(blue3);
            blues.Add(blue4);
            blues.Add(blue5);
            blues.Add(blue6);
            blues.Add(blue7);
            blues.Add(blue8);
            blues.Add(blue9);
            blues.Add(blue10);
            blues.Add(blue11);
            blues.Add(blue12);

            // constructing lists of red checks
            reds.Add(red1);
            reds.Add(red2);
            reds.Add(red3);
            reds.Add(red4);
            reds.Add(red5);
            reds.Add(red6);
            reds.Add(red7);
            reds.Add(red8);
            reds.Add(red9);
            reds.Add(red10);
            reds.Add(red11);
            reds.Add(red12);
        }

        // saves selection to a variable
        private void selection(object o)
        {
            if (!extraJump)
            {
                try { selectedBox.BackColor = Color.White; }
                catch { }
                PictureBox s = (PictureBox)o;
                selectedBox = s;
                selectedBox.BackColor = Color.Lime;
                selectedBox.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void mClick(object sender, MouseEventArgs e)
        {
            // calls method for movement
            movement((PictureBox)sender);

            // displays turn indicator
            if (turn % 2 == 0)
            {
                turnTextbox.Text = "RED'S TURN.";
                turnTextbox.ForeColor = Color.Red;
            }
            else
            {
                turnTextbox.Text = "BLUE'S TURN.";
                turnTextbox.ForeColor = Color.Blue;
            }

            // displays the winner if game ended, prompts for a new game
            if (EndOfGame(reds))
            {
                winnerTextbox.Text = "BLUE WINS!!!";
                bluePlayer.wins++;
                startnewgame.Visible = true;
                turnTextbox.Visible = false;
            }
            else if (EndOfGame(blues))
            {
                winnerTextbox.Text = "RED WINS!!!";
                redPlayer.wins++;
                startnewgame.Visible = true;
                turnTextbox.Visible = false;
            }
        }

        // standard movement control
        private void movement(PictureBox p)
        {
            if (selectedBox != null)
            {
                // color of the selected check
                string color = selectedBox.Name.ToString().Substring(0, 3);

                if (validation(selectedBox, p, color)) // validation
                {
                    Point previous = selectedBox.Location;
                    selectedBox.Location = p.Location;
                    int advance = previous.Y - p.Location.Y;

                    if (!extraMovement(color) | Math.Abs(advance) == 100) // check for extra movements, ends turn if false
                    {
                        ifKing(color);
                        turn++;
                        selectedBox.BackColor = Color.White;             
                        selectedBox = null;
                        extraJump = false;
                    }
                    else
                    {
                        extraJump = true;
                    }
                }
            }
        }

        // controls extra jump
        private bool extraMovement(string color)
        {
            List<PictureBox> opposingSide = color == "red" ? blues : reds;                  // list of opposing checks
            List<Point> points = new List<Point>();                                         // list of points around the selected check
            int nextPoint = color == "red" ? -200 : 200;

            points.Add(new Point(selectedBox.Location.X + 200, selectedBox.Location.Y + nextPoint));
            points.Add(new Point(selectedBox.Location.X - 200, selectedBox.Location.Y + nextPoint));
            if (selectedBox.Tag == "king")      // if king, add points behind the check 
            {
                points.Add(new Point(selectedBox.Location.X + 200, selectedBox.Location.Y - nextPoint));
                points.Add(new Point(selectedBox.Location.X - 200, selectedBox.Location.Y - nextPoint));
            }

            bool result = false;
            // returns true of extra jump is found
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].X >= 12 && points[i].X <= 712 && points[i].Y >= 12 && points[i].Y <= 712)
                {
                    if (!occupiedSpace(points[i], reds) && !occupiedSpace(points[i], blues))
                    {
                        Point midpoint = new Point(average(points[i].X, selectedBox.Location.X), average(points[i].Y, selectedBox.Location.Y));
                        if (occupiedSpace(midpoint, opposingSide))
                        {
                            result = true;
                        }
                    }
                }
            }
            return result;
        }

        // checks to see if a space is occupied by a check, returns true if so
        private bool occupiedSpace(Point point, List<PictureBox> sides)
        {
            for (int i = 0; i < sides.Count; i++)
            {
                if (point == sides[i].Location)
                {
                    return true;
                }
            }
            return false;
        }

        // returns average of two ints
        private int average(int n1, int n2)
        {
            int result = n1 + n2;
            result = result / 2;
            return Math.Abs(result);
        }

        private bool validation(PictureBox origin, PictureBox destination, string color)
        {
            Point originPoint = origin.Location;   
            Point destinationPoint = destination.Location;
            int advanceX = originPoint.X - destinationPoint.X;
            int advanceY = originPoint.Y - destinationPoint.Y;
            advanceX = color == "red" ? advanceX : (advanceX * -1);
            advanceX = selectedBox.Tag == "king" ? Math.Abs(advanceX) : advanceX;
            advanceY = color == "red" ? advanceY : (advanceY * -1);
            advanceY = selectedBox.Tag == "king" ? Math.Abs(advanceY) : advanceY;

            // regular movement
            if ((advanceX == 100 && advanceY == 100) || (advanceX == -100 && advanceY == 100))
            {
                return true;
            }
            // elimination jump
            else if ((advanceX == 200 && advanceY == 200) || (advanceX == -200 && advanceY == 200))
            {
                Point midpoint = new Point(average(destinationPoint.X, originPoint.X), average(destinationPoint.Y, originPoint.Y));
                List<PictureBox> opposingSide = color == "red" ? blues : reds;
                for (int i = 0; i < opposingSide.Count; i++)
                {
                    if (opposingSide[i].Location == midpoint)
                    {
                        // sets eliminated check off of board, turns invisible and locks in place
                        opposingSide[i].Location = new Point(1000, 712);
                        opposingSide[i].Visible = false;
                        return true;
                    }
                }
            }
            return false;
        }

        // resets check image to a king check image when triggered
        private void ifKing(string color)
        {
            if (color == "blu" && selectedBox.Location.Y == 712)
            {
                selectedBox.Image = Properties.Resources.blueKing1trans;
                selectedBox.Tag = "king";
            }

            else if (color == "red" && selectedBox.Location.Y == 12)
            {
                selectedBox.Image = Properties.Resources.redKing1trans;
                selectedBox.Tag = "king";
            }
        }

        // selects a red check and awaits selection
        private void redSelect(object sender, MouseEventArgs e)
        {
            if (turn % 2 == 0)
            {
                selection(sender);
            }     
        }

        // selects a blue check and awaits selection
        private void blueSelect(object sender, MouseEventArgs e)
        {
            if (turn % 2 == 1)
            {
                selection(sender);
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            // sets variables
            int turn = 0;
            bool extraJump = false;
            PictureBox selectedBox = null;

            // sets player texts
            redname.Text = redPlayer.name;
            redwins.Text = redPlayer.wins.ToString();
            bluename.Text = bluePlayer.name;
            bluewins.Text = bluePlayer.wins.ToString();

            // hides and shows appropriate textboxes
            turnTextbox.Visible = true;
            startnewgame.Visible = false;

            // resets blue checks to start position
            blues[0].Location = new Point(12, 12);
            blues[1].Location = new Point(212, 12);
            blues[2].Location = new Point(412, 12);
            blues[3].Location = new Point(612, 12);
            blues[4].Location = new Point(112, 112);
            blues[5].Location = new Point(312, 112);
            blues[6].Location = new Point(512, 112);
            blues[7].Location = new Point(712, 112);
            blues[8].Location = new Point(12, 212);
            blues[9].Location = new Point(212, 212);
            blues[10].Location = new Point(412, 212);
            blues[11].Location = new Point(612, 212);

            // resets red checks to start position
            reds[0].Location = new Point(112, 512);
            reds[1].Location = new Point(312, 512);
            reds[2].Location = new Point(512, 512);
            reds[3].Location = new Point(712, 512);
            reds[4].Location = new Point(12, 612);
            reds[5].Location = new Point(212, 612);
            reds[6].Location = new Point(412, 612);
            reds[7].Location = new Point(612, 612);
            reds[8].Location = new Point(112, 712);
            reds[9].Location = new Point(312, 712);
            reds[10].Location = new Point(512, 712);
            reds[11].Location = new Point(712, 712);

            // makes every check visible and nullifies all king checks
            for (int i = 0; i < blues.Count; i++)
            {
                // blue check at index i
                blues[i].Visible = true;
                blues[i].Tag = "";
                blues[i].Image = Properties.Resources.bluetrans;

                // red check at index i
                reds[i].Visible = true;
                reds[i].Tag = "";
                reds[i].Image = Properties.Resources.redtrans;
            }
        }

        // shows rules window
        private void showRules_Click(object sender, EventArgs e)
        {
            // makes new instance of RuleList and opens up window.
            Rules r = new Rules("Open");
        }

        // ends game and closes form
        private void endgame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // returns true if a player has all checks out of play
        public bool EndOfGame(List<PictureBox> checks)
        {
            for (int i = 0; i < checks.Count; i++)
            {
                if (checks[i].Visible == true)
                {
                    return false;
                }
            }
            return true;
        }

        // --------------------------------------------------------------------------------------------------------------------
        // unused functions
        // --------------------------------------------------------------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void red7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
