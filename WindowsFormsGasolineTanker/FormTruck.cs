using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGasolineTanker
{
    public partial class FormTruck : Form
    {
        private ITransport truck;
        public FormTruck()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTruck.Width, pictureBoxTruck.Height);
            Graphics gr = Graphics.FromImage(bmp);
            truck.DrawTruck(gr);
            pictureBoxTruck.Image = bmp;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            truck = new BaseClassTruck(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            truck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTruck.Width,
           pictureBoxTruck.Height);
            Draw();
        }
        private void buttonCreateFullTruck_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            truck = new FullTruck(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue,
Color.Yellow, true, true, true);
            truck.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxTruck.Width,
           pictureBoxTruck.Height);
            Draw();
        }
        

        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    truck.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    truck.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    truck.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    truck.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
