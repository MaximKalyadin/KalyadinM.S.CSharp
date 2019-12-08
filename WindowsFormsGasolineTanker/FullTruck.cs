using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsGasolineTanker
{
    class FullTruck : BaseClassTruck
    {
        public Color DopColor { private set; get; }
        public bool Vat { private set; get; }
        public bool Stairs { private set; get; }
        public bool Strip { private set; get; }
        private int dopwheel;
        public int DopWheel
        {
            set
            {
                if (value >= 2 && value <= 4) dopwheel = value;
            }
            get { return dopwheel; }
        }

        public FullTruck(int maxSpeed, float weight, Color mainColor, Color dopColor, bool vat, bool stairs, bool strip) : base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Vat = vat;
            Stairs = stairs;
            Strip = strip;
            Random rnd = new Random();
            DopWheel = rnd.Next(2, 5);
        }
        public FullTruck(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                DopColor = Color.FromName(strs[0]);
                Vat = Convert.ToBoolean(strs[1]);
                Stairs = Convert.ToBoolean(strs[2]);
                Strip = Convert.ToBoolean(strs[3]);
                DopWheel = Convert.ToInt32(strs[4]);
            }
        }
        public override void DrawTruck(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush Kab = new SolidBrush(MainColor);
            Brush Window = new SolidBrush(Color.White);
            Brush wheel = new SolidBrush(Color.Black);
            Brush headlights = new SolidBrush(Color.Yellow);

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
            switch (dopwheel)
            {
                case 2:
                    //колесо у кабины
                    g.DrawEllipse(pen, _startPosX + 110, _startPosY + 40, 23, 23);
                    g.FillEllipse(wheel, _startPosX + 110, _startPosY + 40, 23, 23);
                    //задние колеса
                    g.DrawEllipse(pen, _startPosX + 20, _startPosY + 40, 23, 23);
                    g.FillEllipse(wheel, _startPosX + 20, _startPosY + 40, 23, 23);
                    break;
                case 3:
                    //колесо у кабины
                    g.DrawEllipse(pen, _startPosX + 110, _startPosY + 40, 23, 23);
                    g.FillEllipse(wheel, _startPosX + 110, _startPosY + 40, 23, 23);
                    //задние колеса
                    g.DrawEllipse(pen, _startPosX + 20, _startPosY + 40, 23, 23);
                    g.FillEllipse(wheel, _startPosX + 20, _startPosY + 40, 23, 23);
                    g.DrawEllipse(pen, _startPosX + 70, _startPosY + 40, 23, 23);
                    g.FillEllipse(wheel, _startPosX + 70, _startPosY + 40, 23, 23);
                    break;
                case 4:
                    //колесо у кабины
                    g.DrawEllipse(pen, _startPosX + 110, _startPosY + 40, 23, 23);
                    g.FillEllipse(wheel, _startPosX + 110, _startPosY + 40, 23, 23);
                    //задние колеса
                    g.DrawEllipse(pen, _startPosX + 20, _startPosY + 40, 23, 23);
                    g.FillEllipse(wheel, _startPosX + 20, _startPosY + 40, 23, 23);
                    g.DrawEllipse(pen, _startPosX + 45, _startPosY + 40, 23, 23);
                    g.FillEllipse(wheel, _startPosX + 45, _startPosY + 40, 23, 23);
                    g.DrawEllipse(pen, _startPosX + 70, _startPosY + 40, 23, 23);
                    g.FillEllipse(wheel, _startPosX + 70, _startPosY + 40, 23, 23);
                    break;
            }
            base.DrawTruck(g);
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Vat + ";" +
           Stairs + ";" + Strip;
        }

    }
}