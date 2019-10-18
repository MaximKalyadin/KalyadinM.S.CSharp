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
        MultiLevelParking parking;
        private const int countLevel = 5;
        public FormParking()
        {
            InitializeComponent();
            parking = new MultiLevelParking(countLevel, pictureParking.Width,
           pictureParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBox1.Items.Add("Уровень " + (i + 1));
            }
            listBox1.SelectedIndex = 0;

        }
        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureParking.Width, pictureParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBox1.SelectedIndex].Draw(gr);
                pictureParking.Image = bmp;
            }
        }
        private void buttonSeTruck_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var truck = new BaseClassTruck(100, 1000, dialog.Color);
                    int place = parking[listBox1.SelectedIndex] + truck;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }
        private void buttonSetFullTruck_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var truck = new Truck(100, 1000, dialog.Color,
                       dialogDop.Color, true, true, true);
                        int place = parking[listBox1.SelectedIndex] + truck;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }

            }
        }
        private void buttonTakeTruck_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var truck = parking[listBox1.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
                    if (truck != null)
                    {
                        Bitmap bmp = new Bitmap(pictureTake.Width, pictureTake.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        truck.SetPosition(5, 5, pictureTake.Width, pictureTake.Height);
                        truck.DrawTruck(gr);
                        pictureTake.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureTake.Width, pictureTake.Height);
                        pictureTake.Image = bmp;
                    }
                    Draw();
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();

        }
    }
}
