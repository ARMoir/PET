using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET
{
    public partial class Form1 : Form
    {

        public int Count = 0;
        public int Full = 650;
        public int Eating = 0;
        public int Hour = 0;
        public int Poop = 0;
        public int ChanceCheck = 0;
        public bool IsPoop = false;
        public string Hunger = "Satisfied";
        public string Space = "Left";
        public string NextSpace = "Left";
        public Random Chance = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            Count++;
            Full--;
            Space = NextSpace;
            ChanceCheck = Chance.Next(10);
            Hour = Int32.Parse(DateTime.Now.ToString("HH"));

            switch (ChanceCheck)
            {
                case 0:
                    Full--;
                    break;

                case 1:
                    Full--;
                    break;

                case 2:
                    Poop++;
                    break;

                case 3:
                    Poop++;
                    break;
            }

            switch (Space)
            {
                case "Left":
                    BabyLeft();
                    NextSpace = "GoRight";
                    break;

                case "Right":
                    BabyRight();
                    NextSpace = "GoLeft";
                    break;

                case "GoLeft":
                    BabyMiddle();
                    NextSpace = "Left";
                    break;

                case "GoRight":
                    BabyMiddle();
                    NextSpace = "Right";
                    break;
            }

            switch (Eating)
            {
                case 1:
                    BabyEat2();
                    Eating--;
                    break;

                case 2:
                    BabyEat1();
                    Eating--;
                    break;

                case 3:
                    BabyEat2();
                    Eating--;
                    break;
            }

            if(Poop > 10)
            {
                IsPoop = true;
            }
            if(IsPoop)
            {
                if (Count % 2 == 0)
                {
                    BabyPoop1();
                }
                else
                {
                    BabyPoop2();
                }
            }

            if (Hour > 22 || Hour < 8)
            {
                if (Count % 2 == 0)
                {
                    BabySleep1();
                }
                else
                {
                    BabySleep2();
                }
            }

            switch (Count)
            {
                case 1:
                    Egg();
                    break;

                case 2:
                    Egg2();
                    break;

                case 3:
                    Egg3();
                    break;

                case 4:
                    Egg4();
                    break;
            }

            if (Full < 1000)
            {
                Hunger = "In A Food Coma!";
            }
            if (Full < 900)
            {
                Hunger = "Too Full";
            }
            if (Full < 800)
            {
                Hunger = "Very Full";
            }
            if (Full < 700)
            {
                Hunger = "Comfortable";
            }
            if (Full < 600)
            {
                Hunger = "Satisfied";
            }
            if (Full < 500)
            {
                Hunger = "Not That Hungry";
            }
            if (Full < 400)
            {
                Hunger = "A Little Hungry";
            }
            if (Full < 300)
            {
                Hunger = "Very Hungry";
            }
            if (Full < 200)
            {
                Hunger = "Uncomfortably Hungry";
            }
            if (Full < 100)
            {
                Hunger = "Starving!";
            }
            if (Full < 1 || Full > 1050)
            {
                Dead();
                return;
            }

            Status();
        }

        public void Status()
        {
            Display.Items.Add("Hunger: " + Hunger);
           // Display.Items.Add("Time: " + Hour.ToString());
        }

        public void BabyLeft()
        {
            Display.Items.Clear();
            Display.Items.Add("");
            Display.Items.Add("    ■ ■■■■ ■                  ");
            Display.Items.Add("  ■          ■                ");
            Display.Items.Add(" ■  ■      ■  ■               ");
            Display.Items.Add(" ■    ■■■■    ■               ");
            Display.Items.Add(" ■            ■               ");
            Display.Items.Add("  ■          ■                ");
            Display.Items.Add("    ■ ■■■■ ■                  ");
            Display.Items.Add("");
            Display.Items.Add("");

        }

        public void BabyRight()
        {
            Display.Items.Clear();
            Display.Items.Add("");
            Display.Items.Add("                  ■ ■■■■ ■    ");
            Display.Items.Add("                ■          ■  ");
            Display.Items.Add("               ■  ■      ■  ■ ");
            Display.Items.Add("               ■    ■■■■    ■ ");
            Display.Items.Add("               ■            ■ ");
            Display.Items.Add("                ■          ■  ");
            Display.Items.Add("                  ■ ■■■■ ■    ");
            Display.Items.Add("");
            Display.Items.Add("");
        }

        public void BabyMiddle()
        {
            Display.Items.Clear();
            Display.Items.Add("");
            Display.Items.Add("");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("        ■  ■■    ■■  ■        ");
            Display.Items.Add("        ■    ■■■■    ■        ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("");
            Display.Items.Add("");
        }

        public void BabyPoop1()
        {
            Display.Items.Clear();
            Display.Items.Add("                              ");
            Display.Items.Add("                              ");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("        ■  ■■    ■■  ■        ");
            Display.Items.Add("        ■    ■■■■    ■        ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("           ■ ■■■■ ■       @ ! ");
            Display.Items.Add("                        !@@@  ");
            Display.Items.Add("                        @@@@@ ");
        }

        public void BabyPoop2()
        {
            Display.Items.Clear();
            Display.Items.Add("                              ");
            Display.Items.Add("                              ");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("        ■  ■■    ■■  ■        ");
            Display.Items.Add("        ■    ■■■■    ■        ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("           ■ ■■■■ ■     ! @   ");
            Display.Items.Add("                         @@@! ");
            Display.Items.Add("                        @@@@@ ");
        }

        public void BabySleep1()
        {
            Display.Items.Clear();
            Display.Items.Add(" ■■■■■                        ");
            Display.Items.Add("    ■                         ");
            Display.Items.Add("   ■       ■ ■■■■ ■           ");
            Display.Items.Add("  ■      ■          ■         ");
            Display.Items.Add(" ■■■■■  ■  ■■    ■■  ■        ");
            Display.Items.Add("        ■    ■■■■    ■        ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("                              ");
            Display.Items.Add("                              ");
        }

        public void BabySleep2()
        {
            Display.Items.Clear();
            Display.Items.Add("                              ");
            Display.Items.Add("                              ");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("        ■  ■■    ■■  ■        ");
            Display.Items.Add("        ■    ■■■■    ■  ■■■■■ ");
            Display.Items.Add("         ■          ■      ■  ");
            Display.Items.Add("           ■ ■■■■ ■       ■   ");
            Display.Items.Add("                         ■    ");
            Display.Items.Add("                        ■■■■■ ");
        }

        public void BabyEat1()
        {
            Display.Items.Clear();
            Display.Items.Add("");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("        ■  ■      ■  ■        ");
            Display.Items.Add("        ■    ■■■■    ■        ");
            Display.Items.Add("        ■            ■        ");
            Display.Items.Add("         ■   ■■■■   ■         ");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("");
            Display.Items.Add("");
        }

        public void BabyEat2()
        {
            Display.Items.Clear();
            Display.Items.Add("");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("        ■  ■      ■  ■        ");
            Display.Items.Add("        ■    ■■■■    ■        ");
            Display.Items.Add("        ■    ■■■■    ■        ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("           ■ ■■■■ ■           ");
            Display.Items.Add("");
            Display.Items.Add("");
        }

        public void Egg()
        {
            Display.Items.Clear();
            Display.Items.Add("              ■■              ");
            Display.Items.Add("            ■    ■            ");
            Display.Items.Add("          ■        ■          ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("        ■            ■        ");
            Display.Items.Add("       ■              ■       ");
            Display.Items.Add("       ■              ■       ");
            Display.Items.Add("       ■              ■       ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("           ■ ■■■■ ■           ");
        }

        public void Egg2()
        {
            Display.Items.Clear();
            Display.Items.Add("             ■■               ");
            Display.Items.Add("           ■    ■             ");
            Display.Items.Add("         ■        ■           ");
            Display.Items.Add("        ■          ■          ");
            Display.Items.Add("       ■             ■        ");
            Display.Items.Add("      ■               ■       ");
            Display.Items.Add("      ■               ■       ");
            Display.Items.Add("       ■              ■       ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("           ■ ■■■■ ■           ");
        }

        public void Egg3()
        {
            Display.Items.Clear();
            Display.Items.Add("               ■■             ");
            Display.Items.Add("             ■    ■           ");
            Display.Items.Add("           ■        ■         ");
            Display.Items.Add("         ■           ■        ");
            Display.Items.Add("        ■             ■       ");
            Display.Items.Add("       ■               ■      ");
            Display.Items.Add("       ■               ■      ");
            Display.Items.Add("       ■              ■       ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("           ■ ■■■■ ■           ");
        }

        public void Egg4()
        {
            Display.Items.Clear();
            Display.Items.Add("              ■■              ");
            Display.Items.Add("            ■    ■            ");
            Display.Items.Add("          ■        ■          ");
            Display.Items.Add("       ■  ■ ■ ■■ ■ ■  ■       ");
            Display.Items.Add("        ■  ■      ■  ■        ");
            Display.Items.Add("        ■    ■■■■    ■        ");
            Display.Items.Add("       ■  ■ ■ ■■ ■ ■  ■       ");
            Display.Items.Add("       ■              ■       ");
            Display.Items.Add("         ■          ■         ");
            Display.Items.Add("           ■ ■■■■ ■           ");
        }


        public void Dead()
        {
            Display.Items.Clear();
            Display.Items.Add("            ■ ■ ■ ■           ");
            Display.Items.Add("            ■     ■           ");
            Display.Items.Add("      ■ ■ ■ ■     ■ ■ ■ ■     ");
            Display.Items.Add("      ■      R.I.P.     ■     ");
            Display.Items.Add("      ■ ■ ■ ■     ■ ■ ■ ■     ");
            Display.Items.Add("            ■     ■           ");
            Display.Items.Add("            ■     ■           ");
            Display.Items.Add("            ■     ■           ");
            Display.Items.Add("            ■     ■           ");
            Display.Items.Add("            ■ ■ ■ ■           ");
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            Full += 25;
            Poop++;
            Eating = 3;
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Poop = 0;
            IsPoop = false;
        }
    }
}
