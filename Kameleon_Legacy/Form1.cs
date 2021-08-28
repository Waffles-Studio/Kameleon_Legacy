using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Kameleon_Legacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int selectmod;
            /*    0- HEX
             *    1- RGB
             *    2- CMYK
             *    3- HSV
             *    4- HSL
             */

        void HsvToRgb(double h, double S, double V, out int r, out int g, out int b)
        {
            double H = h;
            while (H < 0) { H += 360; };
            while (H >= 360) { H -= 360; };
            double R, G, B;
            if (V <= 0)
            { R = G = B = 0; }
            else if (S <= 0)
            {
                R = G = B = V;
            }
            else
            {
                double hf = H / 60.0;
                int i = (int)Math.Floor(hf);
                double f = hf - i;
                double pv = V * (1 - S);
                double qv = V * (1 - S * f);
                double tv = V * (1 - S * (1 - f));
                switch (i)
                {

                    case 0:
                        R = V;
                        G = tv;
                        B = pv;
                        break;

                    case 1:
                        R = qv;
                        G = V;
                        B = pv;
                        break;
                    case 2:
                        R = pv;
                        G = V;
                        B = tv;
                        break;

                    case 3:
                        R = pv;
                        G = qv;
                        B = V;
                        break;
                    case 4:
                        R = tv;
                        G = pv;
                        B = V;
                        break;

                    case 5:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    case 6:
                        R = V;
                        G = tv;
                        B = pv;
                        break;
                    case -1:
                        R = V;
                        G = pv;
                        B = qv;
                        break;

                    default:

                        R = G = B = V;
                        break;
                }
            }
            r = Clamp((int)(R * 255.0));
            g = Clamp((int)(G * 255.0));
            b = Clamp((int)(B * 255.0));
        }   //HSV TO RGB

        private void Form1_Load(object sender, EventArgs e)
        {
            selectmod = 0;
            //HEX ENABLE
            Txt_Hex.Enabled = true;
            //RGB DISABLED
            Txt_RGB_R.Enabled = false;
            Txt_RGB_G.Enabled = false;
            Txt_RGB_B.Enabled = false;
            //CMYK DISABLED
            Txt_CMYK_C.Enabled = false;
            Txt_CMYK_M.Enabled = false;
            Txt_CMYK_Y.Enabled = false;
            Txt_CMYK_K.Enabled = false;
            //HSL DISABLED
            Txt_HSL_H.Enabled = false;
            Txt_HSL_S.Enabled = false;
            Txt_HSL_L.Enabled = false;
            //HSV DISABLED
            Txt_HSV_H.Enabled = false;
            Txt_HSV_S.Enabled = false;
            Txt_HSV_V.Enabled = false;
        }        //LOAD FORM

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (selectmod == 0)
            {
                selectmod = 1;

                //HEX DISABLED
                Txt_Hex.Enabled = false;
                //RGB ENABLE
                Txt_RGB_R.Enabled = true;
                Txt_RGB_G.Enabled = true;
                Txt_RGB_B.Enabled = true;
                //CMYK DISABLED
                Txt_CMYK_C.Enabled = false;
                Txt_CMYK_M.Enabled = false;
                Txt_CMYK_Y.Enabled = false;
                Txt_CMYK_K.Enabled = false;
                //HSL DISABLED
                Txt_HSL_H.Enabled = false;
                Txt_HSL_S.Enabled = false;
                Txt_HSL_L.Enabled = false;
                //HSV DISABLED
                Txt_HSV_H.Enabled = false;
                Txt_HSV_S.Enabled = false;
                Txt_HSV_V.Enabled = false;
                return;
            }
            if (selectmod == 1)
            {
                selectmod = 2;

                //HEX DISABLED
                Txt_Hex.Enabled = false;
                //RGB DISABLED
                Txt_RGB_R.Enabled = false;
                Txt_RGB_G.Enabled = false;
                Txt_RGB_B.Enabled = false;
                //CMYK ENABLE
                Txt_CMYK_C.Enabled = true;
                Txt_CMYK_M.Enabled = true;
                Txt_CMYK_Y.Enabled = true;
                Txt_CMYK_K.Enabled = true;
                //HSL DISABLED
                Txt_HSL_H.Enabled = false;
                Txt_HSL_S.Enabled = false;
                Txt_HSL_L.Enabled = false;
                //HSV DISABLED
                Txt_HSV_H.Enabled = false;
                Txt_HSV_S.Enabled = false;
                Txt_HSV_V.Enabled = false;
                return;
            }
            if (selectmod == 2)
            {
                selectmod = 3;

                //HEX DISABLED
                Txt_Hex.Enabled = false;
                //RGB DISABLED
                Txt_RGB_R.Enabled = false;
                Txt_RGB_G.Enabled = false;
                Txt_RGB_B.Enabled = false;
                //CMYK DISABLED
                Txt_CMYK_C.Enabled = false;
                Txt_CMYK_M.Enabled = false;
                Txt_CMYK_Y.Enabled = false;
                Txt_CMYK_K.Enabled = false;
                //HSL DISABLED
                Txt_HSL_H.Enabled = false;
                Txt_HSL_S.Enabled = false;
                Txt_HSL_L.Enabled = false;
                //HSV ENABLE
                Txt_HSV_H.Enabled = true;
                Txt_HSV_S.Enabled = true;
                Txt_HSV_V.Enabled = true;
                return;
            }
            if (selectmod == 3)
            {
                selectmod = 4;

                //HEX DISABLED
                Txt_Hex.Enabled = false;
                //RGB DISABLED
                Txt_RGB_R.Enabled = false;
                Txt_RGB_G.Enabled = false;
                Txt_RGB_B.Enabled = false;
                //CMYK DISABLED
                Txt_CMYK_C.Enabled = false;
                Txt_CMYK_M.Enabled = false;
                Txt_CMYK_Y.Enabled = false;
                Txt_CMYK_K.Enabled = false;
                //HSL ENABLE
                Txt_HSL_H.Enabled = true;
                Txt_HSL_S.Enabled = true;
                Txt_HSL_L.Enabled = true;
                //HSV DISABLED
                Txt_HSV_H.Enabled = false;
                Txt_HSV_S.Enabled = false;
                Txt_HSV_V.Enabled = false;
                return;
            }
            if (selectmod == 4)
            {
                selectmod = 0;

                //HEX ENABLE
                Txt_Hex.Enabled = true;
                //RGB DISABLED
                Txt_RGB_R.Enabled = false;
                Txt_RGB_G.Enabled = false;
                Txt_RGB_B.Enabled = false;
                //CMYK DISABLED
                Txt_CMYK_C.Enabled = false;
                Txt_CMYK_M.Enabled = false;
                Txt_CMYK_Y.Enabled = false;
                Txt_CMYK_K.Enabled = false;
                //HSL DISABLED
                Txt_HSL_H.Enabled = false;
                Txt_HSL_S.Enabled = false;
                Txt_HSL_L.Enabled = false;
                //HSV DISABLED
                Txt_HSV_H.Enabled = false;
                Txt_HSV_S.Enabled = false;
                Txt_HSV_V.Enabled = false;
                return;
            }
        }     //SWAP BUTTON

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }     //EXIT BUTTON

        private void button2_Click(object sender, EventArgs e)
        {
            //CLEAN
            Txt_Hex.Clear();
            Txt_RGB_R.Clear();
            Txt_RGB_G.Clear();
            Txt_RGB_B.Clear();
            Txt_CMYK_C.Clear();
            Txt_CMYK_M.Clear();
            Txt_CMYK_Y.Clear();
            Txt_CMYK_K.Clear();
            Txt_HSL_H.Clear();
            Txt_HSL_S.Clear();
            Txt_HSL_L.Clear();
            Txt_HSV_H.Clear();
            Txt_HSV_S.Clear();
            Txt_HSV_V.Clear();
            button6.BackColor = Color.White;
        }     //CLEAR BUTTON

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GRAFICACION - ING. SISTEMAS COMPUTACIONALES" + "\n\n          182310497 - Batres Guerrero Brian Armando" + "\n                182310214 - Molina Balderas Darien" + "\n\n\n\n                                           🖤", "KAMELEON TEAM ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }     //ABOUT BUTTON

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Hex selected
                if (selectmod == 0)
                {
                    Hex_to_all();
                }
                //RGB selected
                if (selectmod == 1)
                {
                    int RGB1, RGB2, RGB3;
                    RGB1 = int.Parse(Txt_RGB_R.Text);
                    RGB2 = int.Parse(Txt_RGB_G.Text);
                    RGB3 = int.Parse(Txt_RGB_B.Text);

                    int RedV = RGB1;
                    int GreenV = RGB2;
                    int BlueV = RGB3;

                    string hexValue = RedV.ToString("X2") + GreenV.ToString("X2") + BlueV.ToString("X2");

                    Txt_Hex.Text = "#" + hexValue;
                    Hex_to_all();

                }
                //CMYK selected
                if (selectmod == 2)
                {
                    CMYKtoRGBtoHEx();

                }
                //HSV selected
                if (selectmod == 3)
                {

                    decimal pa1 = Decimal.Parse(Txt_HSV_H.Text);
                    decimal pa2 = Decimal.Parse(Txt_HSV_S.Text);
                    decimal pa3 = Decimal.Parse(Txt_HSV_V.Text);

                    double pe1 = Decimal.ToDouble(pa1);
                    double pe2 = Decimal.ToDouble(pa2 / 100);
                    double pe3 = Decimal.ToDouble(pa3 / 100);


                    int rg, gg, bg;
                    HsvToRgb(pe1, pe2, pe3, out rg, out gg, out bg);

                    string hexValue = rg.ToString("X2") + gg.ToString("X2") + bg.ToString("X2");

                    Txt_Hex.Text = "#" + hexValue;
                    Hex_to_all();



                }
                //HSL selected
                if (selectmod == 4)
                {
                    decimal j1 = Decimal.Parse(Txt_HSL_H.Text);
                    decimal j2 = Decimal.Parse(Txt_HSL_S.Text) / 100;
                    decimal j3 = Decimal.Parse(Txt_HSL_L.Text) / 100;

                    int k1 = Convert.ToInt32(j1);
                    float k2 = Convert.ToSingle(j2);
                    float k3 = Convert.ToSingle(j3);

                    double rg, gg, bg;
                    HSLtoRGB HSLRGB = new HSLtoRGB();
                    HSLRGB.prueba(k1, k2, k3, out rg, out gg, out bg);

                    int as1 = Convert.ToInt32(rg);
                    int as2 = Convert.ToInt32(gg);
                    int as3 = Convert.ToInt32(bg);

                    string hexValue = as1.ToString("X2") + as2.ToString("X2") + as3.ToString("X2");

                    Txt_Hex.Text = "#" + hexValue;
                    Hex_to_all();




                }
            }
            catch (Exception)
            {
                MessageBox.Show("We could not convert the color 😟😪", "Sorry.....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }     //CONVERT BUTTON

        public void CMYKtoRGBtoHEx()
        {


            decimal c, m, y, k;
            c = ((decimal.Parse(Txt_CMYK_C.Text)));
            m = ((decimal.Parse(Txt_CMYK_M.Text)));
            y = ((decimal.Parse(Txt_CMYK_Y.Text)));
            k = ((decimal.Parse(Txt_CMYK_K.Text)));


            decimal r;
            decimal g;
            decimal b;

            r = Math.Round(255 * (1 - (c / 100)) * (1 - (k / 100)));
            g = Math.Round(255 * (1 - (m / 100)) * (1 - (k / 100)));
            b = Math.Round(255 * (1 - (y / 100)) * (1 - (k / 100)));


            int RedV = Decimal.ToInt32(r);
            int GreenV = Decimal.ToInt32(g);
            int BlueV = Decimal.ToInt32(b);

            string hexValue = RedV.ToString("X2") + GreenV.ToString("X2") + BlueV.ToString("X2");

            Txt_Hex.Text = "#" + hexValue;
            Hex_to_all();

        }                               //CMYK TO RGB

        private void Hex_to_all()
        {
            string hex = Txt_Hex.Text;

            //HEX - RGB
            Color color = ColorTranslator.FromHtml(hex);


            Txt_RGB_R.Text = color.R.ToString();
            Txt_RGB_G.Text = color.G.ToString();
            Txt_RGB_B.Text = color.B.ToString();
            
            

            //HEX - CMYK
            string Rp = color.R.ToString();
            decimal Rd = decimal.Parse(Rp);
            string Gp = color.G.ToString();
            decimal Gd = decimal.Parse(Gp);
            string Bp = color.B.ToString();
            decimal Bd = decimal.Parse(Bp);
            
                      //BLACK
            if (Rd == 0 && Gd == 0 && Bd == 0)
            {
                Txt_CMYK_C.Text = "0";
                Txt_CMYK_M.Text = "0";
                Txt_CMYK_Y.Text = "0";
                Txt_CMYK_K.Text = "100";
            }
            else
            {
                decimal Ch = 0;
                decimal Mh = 0;
                decimal Yh = 0;
                decimal Kh = 0;

                Ch = 1 - (Rd / 255);
                Mh = 1 - (Gd / 255);
                Yh = 1 - (Bd / 255);

                var CMYK = Math.Min(Ch, Math.Min(Mh, Yh));

                Ch = Math.Round(((Ch - CMYK) / (1 - CMYK))*100);
                Mh = Math.Round(((Mh - CMYK) / (1 - CMYK))*100);
                Yh = Math.Round(((Yh - CMYK) / (1 - CMYK))*100);
                Kh = Math.Round((CMYK)*100);

                Txt_CMYK_C.Text = Ch.ToString();
                Txt_CMYK_M.Text = Mh.ToString();
                Txt_CMYK_Y.Text = Yh.ToString();
                Txt_CMYK_K.Text = Kh.ToString(); 
            }

            //RGB - HSL
            int Rh = int.Parse(Rp);
            int Gh = int.Parse(Gp);
            int Bh = int.Parse(Bp);

            Color colorhsl = Color.FromArgb(Rh, Gh, Bh);
            double Hr = Math.Round(colorhsl.GetHue());
            double Sr = Math.Round((colorhsl.GetSaturation())*100);
            double Lr = Math.Round((colorhsl.GetBrightness())*100);

            


            Txt_HSL_H.Text = Hr.ToString();
            Txt_HSL_S.Text = Sr.ToString();
            Txt_HSL_L.Text = Lr.ToString();

            //RGB - HSV
            double Hue;
            double Saturation;
            double Value;

            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            Hue = Math.Round(color.GetHue());
            Saturation = ((max == 0) ? 0 : 1d - (1d * min / max)) * 100;
            Saturation = Math.Round(Saturation);
            Value = Math.Round(((max / 255d) * 100));
            
            Txt_HSV_H.Text = Hue.ToString();
            Txt_HSV_S.Text = Saturation.ToString();
            Txt_HSV_V.Text = Value.ToString();


            //COLOR
            Color CB = Color.FromArgb(Rh, Gh, Bh);
            button6.BackColor = CB;
        }                                  //HEX TO ALL

        int Clamp(int i)
        {
            if (i < 0) return 0;
            if (i > 255) return 255;
            return i;
        }                                           //CAMP COUNT


    }
}
