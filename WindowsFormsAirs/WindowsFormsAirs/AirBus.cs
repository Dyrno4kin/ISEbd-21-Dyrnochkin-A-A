using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirs
{
    public class AirBus : Air
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        public bool Bus { private set; get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        public AirBus(int maxSpeed, float weight, Color mainColor, Color dopColor, bool bus) :
        base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Bus = bus;
        }

        public AirBus(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Bus = Convert.ToBoolean(strs[4]);
            }
        }

        public override void DrawAir(Graphics g)
        {
            base.DrawAir(g);
            if (Bus)
            {
                Brush body = new SolidBrush(MainColor);
                g.FillEllipse(body, _startPosX + 80, _startPosY - 6, 60, 40);
                g.FillEllipse(body, _startPosX + 110, _startPosY + 13, 40, 20);
                g.FillRectangle(body, _startPosX + 55, _startPosY - 5, 60, 38);
                g.FillRectangle(body, _startPosX + 19, _startPosY - 5, 60, 10);
                g.FillRectangle(body, _startPosX + 19, _startPosY - 27, 15, 25);
                g.FillRectangle(body, _startPosX + 5, _startPosY - 16, 40, 6);
                Brush window = new SolidBrush(DopColor);
                g.FillEllipse(window, _startPosX + 120, _startPosY + 3, 10, 10);
            }
        }
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Bus;
        }
    }
}
