using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsGasolineTanker
{
    public class BaseClassTruck : Gasoline
    {
        protected const int carWidth = 100;
        protected const int carHeight = 60;
        public BaseClassTruck(int maxSpeed, float weight, Color mainColor){
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
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
        public override void DrawTruck(Graphics g)
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
            //фрары
            g.DrawRectangle(pen, _startPosX + 143, _startPosY + 35, 7, 7);
            g.FillRectangle(headlights, _startPosX + 143, _startPosY + 35, 7, 7);
            //колесо у кабины
            g.DrawEllipse(pen, _startPosX + 110, _startPosY + 40, 23, 23);
            g.FillEllipse(wheel, _startPosX + 110, _startPosY + 40, 23, 23);
            //задние колеса
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 40, 23, 23);
            g.FillEllipse(wheel, _startPosX + 20, _startPosY + 40, 23, 23);
            //платформа
            g.DrawRectangle(pen, _startPosX + 15, _startPosY + 34, 85, 10);
            g.FillRectangle(wheel, _startPosX + 15, _startPosY + 34, 85, 10);

        }
    }
}
