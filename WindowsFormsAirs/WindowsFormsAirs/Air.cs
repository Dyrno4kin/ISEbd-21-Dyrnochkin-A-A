using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirs
{
    public class Air : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        private const int airWidth = 140;
        /// <summary>
        /// Высота отрисовки самолета
        /// </summary>
        private const int airHeight = 90;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Air(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - airWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - airHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка самолета
        /// </summary>
        /// <param name="g"></param>
        public override void DrawAir(Graphics g)
        {
            Brush body = new SolidBrush(MainColor);
            g.FillEllipse(body, _startPosX + 110, _startPosY + 13, 40, 20);
            g.FillRectangle(body, _startPosX + 55, _startPosY + 5, 69, 28);
            g.FillRectangle(body, _startPosX + 21, _startPosY - 25, 15, 31);
            g.FillRectangle(body, _startPosX + 7, _startPosY - 16, 40, 6);
            g.FillEllipse(body, _startPosX + 120, _startPosY + 4, 15, 10);
            g.FillEllipse(body, _startPosX + 125, _startPosY + 11, 15, 10);
            g.FillEllipse(body, _startPosX + 123, _startPosY + 10, 15, 10);
            Pen pen = new Pen(MainColor);
            float yPos = 32;
            while (yPos > 4)
            {
                g.DrawLine(pen, _startPosX + 55, _startPosY + yPos, _startPosX + 20, _startPosY + 4);
                yPos--;
            }
            Brush window = new SolidBrush(Color.LightBlue);
            g.FillEllipse(window, _startPosX + 120, _startPosY + 9, 12, 6);
        }
    }
}

