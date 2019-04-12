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
    public partial class Gameplay : Form
    {
        int turn = 0;
        bool extraJump = false;
        PictureBox selectedBox = null;
        List<PictureBox> blues = new List<PictureBox>();
        List<PictureBox> reds = new List<PictureBox>();

        public Gameplay()
        {
            InitializeComponent();
            loadLists();
        }

        private void loadLists()
        {
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

        private void selection(object o)
        {
            if (!extraJump)
            {
                try { selectedBox.BackColor = Color.White; }
                catch { }
                PictureBox s = (PictureBox)o;
                selectedBox = s;
                selectedBox.BackColor = Color.Lime;
            }
        }

        private void mClick(object sender, MouseEventArgs e)
        {
            movement((PictureBox)sender);
        }

        private void movement(PictureBox p)
        {
            if (selectedBox != null)
            {
                string color = selectedBox.Name.ToString().Substring(0, 3);

                if (validation(selectedBox, p, color)) //validation
                {
                    Point previous = selectedBox.Location;
                    selectedBox.Location = p.Location;
                    int advance = previous.Y - p.Location.Y;

                    if (!extraMovement(color) | Math.Abs(advance) == 100) //check extra movements
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

        private bool extraMovement(string color)
        {
            List<PictureBox> opposingSide = color == "red" ? blues : reds;
            List<Point> points = new List<Point>();
            int nextPoint = color == "red" ? -200 : 200;

            points.Add(new Point(selectedBox.Location.X + 200, selectedBox.Location.Y + nextPoint));
            points.Add(new Point(selectedBox.Location.X - 200, selectedBox.Location.Y + nextPoint));
            if (selectedBox.Tag == "king")
            {
                points.Add(new Point(selectedBox.Location.X + 200, selectedBox.Location.Y - nextPoint));
                points.Add(new Point(selectedBox.Location.X - 200, selectedBox.Location.Y - nextPoint));
            }

            bool result = false;
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
            int advance = originPoint.Y - destinationPoint.Y;
            advance = color == "red" ? advance : (advance * -1);
            advance = selectedBox.Tag == "king" ? Math.Abs(advance) : advance;

            if (advance == 100)
            {
                return true;
            }
            else if (advance == 200)
            {
                Point midpoint = new Point(average(destinationPoint.X, originPoint.X), average(destinationPoint.Y, originPoint.Y));
                List<PictureBox> opposingSide = color == "red" ? blues : reds;
                for (int i = 0; i < opposingSide.Count; i++)
                {
                    if (opposingSide[i].Location == midpoint)
                    {
                        opposingSide[i].Location = new Point(0, 0);
                        opposingSide[i].Visible = false;
                        return true;
                    }
                }
            }
            return false;
        }

        private void ifKing(string color)
        {
            if (color == "blu" && selectedBox.Location.Y == 712)
            {
                selectedBox.BackgroundImage = Properties.Resources.blueKing;
                selectedBox.Tag = "king";
            }

            else if (color == "red" && selectedBox.Location.Y == 12)
            {
                selectedBox.BackgroundImage = Properties.Resources.redKing;
                selectedBox.Tag = "king";
            }
        }

        private void redSelect(object sender, MouseEventArgs e)
        {
            if (turn % 2 == 0)
            {
                selection(sender);
            }
            else
            {
                MessageBox.Show("BLUE'S TURN!!");
            }
        }

        private void blueSelect(object sender, MouseEventArgs e)
        {
            if (turn % 2 == 1)
            {
                selection(sender);
            }
            else
            {
                MessageBox.Show("RED'S TURN!!");
            }
        }


        // --------------------------------------------------------------------------------------------------------------------
        // unused functions
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
    }
}
