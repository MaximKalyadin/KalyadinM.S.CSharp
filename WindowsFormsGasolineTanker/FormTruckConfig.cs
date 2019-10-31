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
    public partial class FormTruckConfig : Form
    {
        ITransport truck = null;
        private event truckDelegate eventAddTruck;

        public FormTruckConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
       

        private void DrawTruck()
        {
            if (truck != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxSetTruck.Width, pictureBoxSetTruck.Height);
                Graphics gr = Graphics.FromImage(bmp);
                truck.SetPosition(5, 5, pictureBoxSetTruck.Width, pictureBoxSetTruck.Height);
                truck.DrawTruck(gr);
                pictureBoxSetTruck.Image = bmp;
            }
        }
        public void AddEvent(truckDelegate ev)
        {
            if (eventAddTruck == null)
            {
                eventAddTruck = new truckDelegate(ev);
            }
            else
            {
                eventAddTruck += ev;
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelTruck_MouseDown(object sender, MouseEventArgs e)
        {
            labelBase.DoDragDrop(labelBase.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        private void labelFullTruck_MouseDown(object sender, MouseEventArgs e)
        {
            labelFull.DoDragDrop(labelFull.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный автомобиль":
                    truck = new BaseClassTruck(100, 1000, Color.White);
                    break;
                case "Гоночный автомобиль":
                    truck = new FullTruck(100, 1000, Color.White, Color.Black, true, true, true);
                    break;
            }
            DrawTruck();
        }
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (truck != null)
            {
                truck.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawTruck();
            }
        }
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (truck != null)
            {
                if (truck is FullTruck)
                {
                    (truck as
                   FullTruck).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawTruck();
                }
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTruck?.Invoke(truck);
            Close();
        }
    }
}
