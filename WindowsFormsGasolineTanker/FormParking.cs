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
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(20, pictureParking.Width, pictureParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureParking.Width, pictureParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureParking.Image = bmp;
        }
        private void buttonSeTruck_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var truck = new BaseClassTruck(100, 1000, dialog.Color);
                int place = parking + truck;
                Draw();
            }
        }
        private void buttonSetFullTruck_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var truck = new FullTruck(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    int place = parking + truck;
                    Draw();
                }
            }
        }
        private void buttonTakeTruck_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var truck = parking - Convert.ToInt32(maskedTextBox.Text);
                if (truck != null)
                {
                    Bitmap bmp = new Bitmap(pictureTake.Width,
                   pictureTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    truck.SetPosition(5, 5, pictureTake.Width,
                   pictureTake.Height);
                    truck.DrawTruck(gr);
                    pictureTake.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureTake.Width,
                   pictureTake.Height);
                    pictureTake.Image = bmp;
                }
                Draw();
            }
        }


    }
}
