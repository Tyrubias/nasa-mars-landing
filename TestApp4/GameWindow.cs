using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class GameWindow : Form
    {
        public static Dictionary<string, int> objectMap = new Dictionary<string, int>();
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            
            objectMap.Add("Box of Matches", 0);
            objectMap.Add("Food Concentrate", 0);
            objectMap.Add("50 ft. of Nylon Rope", 0);
            objectMap.Add("Parachute Silk", 0);
            objectMap.Add("Two .45 Caliber Pistols", 0);
            objectMap.Add("One case of dehydrated milk", 0);
            objectMap.Add("Two 100-pound tanks of oxygen", 0);
            objectMap.Add("Stellar Map", 0);
            objectMap.Add("Self-inflating life raft", 0);
            objectMap.Add("Magnetic compass", 0);
            objectMap.Add("Five Gallons of water", 0);
            objectMap.Add("Signal Flares", 0);
            objectMap.Add("First Aid Kit w/ Injection Needles", 0);
            objectMap.Add("Solar Powered FM Receiver", 0);
            objectMap.Add("Portable Heating Unit", 0);
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label2.Text = "Remember those parachute games you played in preschool? Now you can play them on Mars.";
            pictureBox1.Image = Properties.Resources.Parachute1;
        }

        private void labMatch_Click(object sender, EventArgs e)
        {
            label2.Text = "A box of 577 matches from the Diamond Match Company. I hear they work well on a cold planet like Mars.";
            pictureBox1.Image = Properties.Resources.Matches;
        }

        private void labFoodCon_Click(object sender, EventArgs e)
        {
            label2.Text = "Food is good.";
            pictureBox1.Image = Properties.Resources.FoodCon2;
        }

        private void labRope_Click(object sender, EventArgs e)
        {
            label2.Text = "50 feet fresh, hot, and ready nylon rope, brought straight to you from Ropes R Us, Inc.";
            pictureBox1.Image = Properties.Resources.Rope;
        }

        private void labPist_Click(object sender, EventArgs e)
        {
            label2.Text = "Can be used for defense from potential extraterrestrial life. Also works well as a negiotiation tool.";
            pictureBox1.Image = Properties.Resources.Pistols;
        }

        private void labMilk_Click(object sender, EventArgs e)
        {
            label2.Text = "Tastes even better than expired milk.";
            pictureBox1.Image = Properties.Resources.Milk;
        }

        private void labOxy_Click(object sender, EventArgs e)
        {
            label2.Text = "Oxygen can help you breathe. I hear that's pretty important (hint, hint).";
            pictureBox1.Image = Properties.Resources.Oxygen;
        }

        private void labStell_Click(object sender, EventArgs e)
        {
            label2.Text = "Has all the constellations. I can see Aquarius, Saggitarius, Virgo, Libra, Gemini...";
            pictureBox1.Image = Properties.Resources.StellarMap;
        }

        private void labRaft_Click(object sender, EventArgs e)
        {
            label2.Text = "Recently it was discovered that liquid water exists on Mars. Perhaps a raft could be of use now.";
            pictureBox1.Image = Properties.Resources.Raft;

        }

        private void labComp_Click(object sender, EventArgs e)
        {
            label2.Text = "Gotta make sure you know which cardinal direction you're going in.";
            pictureBox1.Image = Properties.Resources.Compass;
        }

        private void labWater_Click(object sender, EventArgs e)
        {
            label2.Text = "Maximum taste, zero calories.";
            pictureBox1.Image = Properties.Resources.Water;
        }

        private void labFlare_Click(object sender, EventArgs e)
        {
            label2.Text = "Make sure you use these so the alien mothership can find you.";
            pictureBox1.Image = Properties.Resources.Flare;
        }

        private void labAid_Click(object sender, EventArgs e)
        {
            label2.Text = "Pain can hurt. This can unpain the pain.";
            pictureBox1.Image = Properties.Resources.FirstAid;

        }

        private void labReceiver_Click(object sender, EventArgs e)
        {
            label2.Text = "It receives things. Duh.";
            pictureBox1.Image = Properties.Resources.Receiver;

        }

        private void labHeat_Click(object sender, EventArgs e)
        {
            label2.Text = "Gotta stay warm.";
            pictureBox1.Image = Properties.Resources.Heater;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   if (textBox1.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox1.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Box of Matches"] = num1;
                    labError.Text = "";
                }
            }
            catch(FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox2.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Food Concentrate"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox3.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["50 ft. of Nylon Rope"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox4.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Parachute Silk"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox5.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["2 .45 Caliber Pistols"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox6.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["One case of dehydrated milk"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox7.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Two 100-pound tanks of oxygen"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox8.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Stellar Map"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox9.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Self-inflating life raft"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox10.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Magnetic Compass"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox11.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Five Gallons of Water"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox12.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Signal flares"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox13.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["First Aid kit w/ injection needles"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox14.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Solar Powered FM Receiver"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
            {
                labError.Text = "";
            }
            try
            {
                int num1 = Int32.Parse(textBox15.Text);
                if (num1 < 0 || num1 > 15)
                {
                    labError.Text = "Error: Your number is out of range";
                }
                else if (num1 > 0 && num1 <= 15)
                {
                    objectMap["Portable Heating Unit"] = num1;
                    labError.Text = "";
                }
            }
            catch (FormatException)
            {
                labError.Text = "Error: You did not enter a number.";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Results f2 = new Results();
            f2.Show();
        }

        public static Dictionary<string, int> getMap()
        {
            return objectMap;
        }
    }
}
 

