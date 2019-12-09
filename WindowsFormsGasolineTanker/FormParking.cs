using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsGasolineTanker
{
    public partial class FormParking : Form
    {
        MultiLevelParking parking;
        FormTruckConfig form;
        private const int countLevel = 5;
        private Logger logger;
        public FormParking()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            parking = new MultiLevelParking(countLevel, pictureParking.Width,
           pictureParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevel.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevel.SelectedIndex = 0;

        }
        private void Draw()
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                if (listBoxLevel.SelectedIndex > -1)
                {
                    Bitmap bmp = new Bitmap(pictureParking.Width, pictureParking.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    parking[listBoxLevel.SelectedIndex].Draw(gr);
                    pictureParking.Image = bmp;
                }
            }
        }
        private void buttonTakeTruck_Click(object sender, EventArgs e)
        {
            if (listBoxLevel.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var truck = parking[listBoxLevel.SelectedIndex] -
                       Convert.ToInt32(maskedTextBox.Text);
                        Bitmap bmp = new Bitmap(pictureTake.Width, pictureTake.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        truck.SetPosition(5, 5, pictureTake.Width, pictureTake.Height);
                        truck.DrawTruck(gr);
                        pictureTake.Image = bmp;
                        logger.Info("Изъят автомобиль " + truck.ToString() + " с места "
+ maskedTextBox.Text);
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        logger.Warn(ex.Message);
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureTake.Width,
                       pictureTake.Height);
                        pictureTake.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        logger.Warn(ex.Message);
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            form = new FormTruckConfig();
            form.AddEvent(AddTruck);
            form.Show();
        }
        private void AddTruck(ITransport truck)
        {
            if (truck != null && listBoxLevel.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevel.SelectedIndex] + truck;
                    logger.Info("Добавлен автомобиль " + truck.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn(ex.Message);
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}