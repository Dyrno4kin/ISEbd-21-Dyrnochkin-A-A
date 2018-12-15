using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirs
{
    public class AirBus : Air, IComparable<AirBus>, IEquatable<AirBus>
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
        /// <summary>
        /// Возвращаем строку
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Bus;
        }

        /// <summary>
        /// Метод интерфейса IComparable для класса AirBus
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(AirBus other)
        {
            var res = (this is Air).CompareTo(other is Air);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Bus != other.Bus)
            {
                return Bus.CompareTo(other.Bus);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса AirBus
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(AirBus other)
        {
            var res = (this as Air).Equals(other as Air);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Bus != other.Bus)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            AirBus airObj = obj as AirBus;
            if (airObj == null)
            {
                return false;
            }
            else
            {
                return Equals(airObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
