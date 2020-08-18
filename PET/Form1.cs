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

        public int i = 0;
        public int Full = 100;
        public int Eating = 0;
        public int Hour = 0;
        public string Space = "Left";
        public string NextSpace = "Left";

        public Form1()
        {
            InitializeComponent();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            i++;
            Full--;
            Space = NextSpace;

            Hour = Int32.Parse(DateTime.Now.ToString("HH"));

            if (Space == "Left")
            {
                BabyLeft();

                NextSpace = "GoRight";
            }

            if (Space == "Right")
            {
                BabyRight();

                NextSpace = "GoLeft";
            }

            if (Space == "GoLeft")
            {
                BabyMiddle();

                NextSpace = "Left";

            }

            if (Space == "GoRight")
            {
                BabyMiddle();

                NextSpace = "Right";
            }

            if (Eating > 0)
            {
               if (Eating == 1)
                {
                    BabyEat2();
                    Eating--;
                }
                if (Eating == 2)
                {
                    BabyEat1();
                    Eating--;
                }
                if (Eating == 3)
                {
                    BabyEat2();
                    Eating--;
                }
            }


            if (Hour > 20 || Hour < 8)
            {
                if (i % 2 == 0)
                {
                    BabySleep1();
                }
                else
                {
                    BabySleep2();
                }
            }

            if (i == 1)
            {
                Egg();
            }

            if (i == 2)
            {
                Egg2();
            }

            if (i == 3)
            {
                Egg3();
            }

            if (i == 4)
            {
                Egg4();
            }

            if (Full < 1)
            {
                Dead();
                return;
            }

            Status();
        }

        public void Status()
        {
            Display.Items.Add("Full: " + Full.ToString());
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
            Full += 5;
            Eating = 3;
        }
    }
}
