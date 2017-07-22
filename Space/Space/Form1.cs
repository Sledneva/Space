using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space
{
    public partial class Form1 : Form
    {
        Panel panelm;
        Panel panelv;
        Panel panelz;
        Panel panelmr;
        Timer timer;
        Graphics g;

        int time = 0;

        bool redraw = false;
        SolarSystem ss;

        public Form1()
        {
            InitializeComponent();

            BackgroundImage = Properties.Resources.space;
            Paint += new PaintEventHandler(Form1_Paint);
            KeyPreview = true;
            panelm = new Panel();
            panelv = new Panel();
            panelz = new Panel();
            panelmr = new Panel();

            timer = new Timer();
            timer.Tick += new EventHandler(draw);

            ss = new SolarSystem();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (redraw) { BackgroundImage = Properties.Resources.space; redraw = false; }
            ss.Circle(g, ClientRectangle.Width >> 1, ClientRectangle.Height >> 1);
        }

        void draw(object sender, EventArgs e)
        {
            if (time % 2 == 0)
            {
                ss.MovePlanets(g, ClientRectangle.Width, ClientRectangle.Height);
                panelm.Location = ss.panelm.Location;
                panelv.Location = ss.panelv.Location;
                panelz.Location = ss.panelz.Location;
                panelmr.Location = ss.panelmr.Location;
            }
            time++;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("X: {0}; Y: {1}", e.X, e.Y);
        }

        private void sunLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Со́лнце — единственная звезда Солнечной системы. Вокруг Солнца обращаются другие объекты этой системы: планеты и их спутники, карликовые планеты и их спутники, астероиды, метеороиды, кометы и космическая пыль.");
        }

        private void mercLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мерку́рий — самая близкая к Солнцу планета Солнечной системы. Планета названа в честь древнеримского бога торговли — быстроногого Меркурия, поскольку она движется по небесной сфере быстрее других планет.");
        }

        private void venLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вене́ра — вторая планета Солнечной системы. Названа в честь древнеримской богини любви Венеры.");
        }

        private void earthLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Земля́ — третья от Солнца планета. Пятая по размеру среди всех планет Солнечной системы. Она является также крупнейшей по диаметру, массе и плотности среди планет земной группы. Иногда упоминается как Мир, Голубая планета, иногда Терра. ");
        }

        private void marsLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Марс — четвёртая по удалённости от Солнца и седьмая по размерам планета Солнечной системы; масса планеты составляет 10,7 % массы Земли. Названа в честь Марса — древнеримского бога войны, соответствующего древнегреческому Аресу. ");
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    ss.x -= 5;
                    break;
                case Keys.Up:
                    ss.y -= 5;
                    break;
                case Keys.Right:
                    ss.x += 5;
                    break;
                case Keys.Down:
                    ss.y += 5;
                    break;
            }
            redraw = true;
            Paint += new PaintEventHandler(Form1_Paint);
            return base.IsInputKey(keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelm.BackgroundImage = Properties.Resources.mercury;
            panelv.BackgroundImage = Properties.Resources.venus;
            panelz.BackgroundImage = Properties.Resources.Earth;
            panelmr.BackgroundImage = Properties.Resources.mars;
            panelm.Size = new Size(20, 19);
            Controls.Add(panelm);
            panelv.Size = new Size(26, 26);
            Controls.Add(panelv);
            panelz.Size = new Size(30, 23);
            Controls.Add(panelz);
            panelmr.Size = new Size(27, 27);
            Controls.Add(panelmr);
            timer.Start();
            g = CreateGraphics();
        }
    }
}