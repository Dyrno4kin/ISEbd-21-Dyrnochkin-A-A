using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirs
{
    class Air
    {
        /// <summary>
        /// Левая координата отрисовки самолета
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки самолета
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        //Высота окна отрисовки
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        private const int airWidth = 140;
        /// <summary>
        /// Высота отрисовки самолета
        /// </summary>
        private const int airHeight = 90;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес самолета
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет самолета
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес самолета</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>

        public Air(int maxSpeed, float weight, Color mainColor, Color dopColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
        }
        /// <summary>
        /// Установка позиции самолета
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
        public void DrawAir(Graphics g)
        {
            Brush body = new SolidBrush(MainColor);
            g.FillEllipse(body, _startPosX + 80, _startPosY - 6, 60, 40);
            g.FillEllipse(body, _startPosX + 110, _startPosY + 13, 40, 20);
            g.FillRectangle(body, _startPosX + 55, _startPosY - 5, 60, 38);
            g.FillRectangle(body, _startPosX + 19, _startPosY - 5, 60, 10);
            g.FillRectangle(body, _startPosX + 19, _startPosY - 27, 15, 25);
            g.FillRectangle(body, _startPosX + 5, _startPosY - 16, 40, 6);
            Pen pen = new Pen(MainColor);
            g.DrawLine(pen, _startPosX + 60, _startPosY - 5, _startPosX + 20, _startPosY - 5);
            float yPos = 32;
            while (yPos > 4)
            {
                g.DrawLine(pen, _startPosX + 55, _startPosY + yPos, _startPosX + 20, _startPosY + 4);
                yPos--;
            }
            Brush window = new SolidBrush(DopColor);
            g.FillEllipse(window, _startPosX + 120, _startPosY + 3, 10, 10);
        }
    }
}

