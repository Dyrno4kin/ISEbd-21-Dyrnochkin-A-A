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
    }
}
