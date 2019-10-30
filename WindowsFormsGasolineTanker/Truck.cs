using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace WindowsFormsGasolineTanker
{
    class Truck
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int carWidth = 100;
        private const int carHeight = 60;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public bool Vat { private set; get; }
        public bool Stairs { private set; get; }
        public bool Strip { private set; get; }
        public Truck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool vat, bool stairs, bool strip)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Vat = vat;
            Stairs = stairs;
            Strip = strip;
        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth - 55)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 10)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight - 15)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawTruck(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush Kab = new SolidBrush(MainColor);
            Brush Window = new SolidBrush(Color.White);
            Brush wheel = new SolidBrush(Color.Black);
            Brush headlights = new SolidBrush(Color.Yellow);
            //кабина 
            g.DrawRectangle(pen, _startPosX + 100, _startPosY - 6, 50, 55);
            g.FillRectangle(Kab, _startPosX + 100, _startPosY - 5, 50, 55);
            g.DrawRectangle(pen, _startPosX + 125, _startPosY + 3, 21, 14);
            g.FillRectangle(Window, _startPosX + 125, _startPosY + 3, 21, 14);
            //door
            g.DrawRectangle(pen, _startPosX + 104, _startPosY + 3, 12, 25);
            //колесо у кабины
            g.DrawEllipse(pen, _startPosX + 110, _startPosY + 40, 23, 23);
            g.FillEllipse(wheel, _startPosX + 110, _startPosY + 40, 23, 23);
            //фрары
            g.DrawRectangle(pen, _startPosX + 143, _startPosY + 35, 7, 7);
            g.FillRectangle(headlights, _startPosX + 143, _startPosY + 35, 7, 7);
            //задние колеса
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 40, 23, 23);
            g.FillEllipse(wheel, _startPosX + 20, _startPosY + 40, 23, 23);
            //платформа
            g.DrawRectangle(pen, _startPosX + 15, _startPosY + 34, 85, 10);
            g.FillRectangle(wheel, _startPosX + 15, _startPosY + 34, 85, 10);
            if (Vat)
            {
                //крышка 
                g.DrawEllipse(pen, _startPosX + 40, _startPosY - 6, 20, 10);
                g.FillEllipse(wheel, _startPosX + 40, _startPosY - 6, 20, 10);
                //сама цистерна
                g.DrawRectangle(pen, _startPosX + 16, _startPosY, 80, 31);
                Brush vat = new SolidBrush(DopColor);
                g.FillRectangle(vat, _startPosX + 16, _startPosY, 80, 31);
            }
            if (Stairs)
            {
                //лестница
                g.FillRectangle(wheel, _startPosX + 10, _startPosY - 3, 3, 50);
                g.FillRectangle(wheel, _startPosX + 10, _startPosY - 3, 10, 3);
            }
            if (Strip)
            {
                //полоса на кузове 
                g.DrawRectangle(pen, _startPosX + 16, _startPosY + 10, 80, 10);
                Brush strip = new SolidBrush(MainColor);
                g.FillRectangle(strip, _startPosX + 16, _startPosY + 10, 80, 10);
            }
        }
    }
}
