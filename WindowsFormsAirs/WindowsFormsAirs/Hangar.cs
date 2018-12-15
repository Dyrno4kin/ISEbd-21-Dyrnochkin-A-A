using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirs
{
    /// <summary>
    /// Параметризованны класс для хранения набора объектов от интерфейса IAir
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Hangar<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Hangar<T>> where T : class, IAir
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private Dictionary<int, T> _places;
        /// <summary>
        /// Максимальное количество мест в ангаре
        /// </summary>
        private int _maxCount;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int PictureWidth { get; set; }
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int PictureHeight { get; set; }
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private int _placeSizeWidth = 200;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private int _placeSizeHeight = 80;

        /// <summary>
        /// Текущий элемент для вывода через IEnumerator (будет обращаться по своему индексу к ключу словаря, по которму будет возвращаться запись)
        /// </summary>
        private int _currentIndex;

        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sizes">Количество мест в ангаре</param>
        /// <param name="pictureWidth">Рамзер ангара - ширина</param>
        /// <param name="pictureHeight">Рамзер ангара - высота</param>
        public Hangar(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            _currentIndex = -1;
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: в ангар добавляется самолет
        /// </summary>
        /// <param name="p">Ангар</param>
        /// <param name="air">Добавляемый самолет</param>
        /// <returns></returns>
        public static int operator +(Hangar<T> p, T air)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new HangarOverflowException();
            }
            if (p._places.ContainsValue(air))
            {
                throw new HangarAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, air);
                    p._places[i].SetPosition(5 + i / 5 * p._placeSizeWidth + 5,
                     i % 5 * p._placeSizeHeight + 40, p.PictureWidth,
                    p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: из ангара забираем самолет
        /// </summary>
        /// <param name="p">Ангар</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
        /// <returns></returns>
        public static T operator -(Hangar<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T air = p._places[index];
                p._places.Remove(index);
                return air;
            }
            throw new HangarNotFoundException(index);
        }
        /// <summary>
        /// Метод проверки заполнености парковочного места (ячейки массива)
        /// </summary>
        /// <param name="index">Номер парковочного места (порядковый номер вмассиве)</param>
        /// <returns></returns>
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            foreach (var air in _places)
            {
                air.Value.DrawAir(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы ангара
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 400);
            for (int i = 0; i < _maxCount / 5; i++)
            {//отрисовываем, по 5 мест на линии
                for (int j = 0; j < 6; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 160, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new HangarNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 *
                    _placeSizeHeight + 40, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new HangarOccupiedPlaceException(ind);
                }
            }
        }

        /// <summary>
        /// Метод интерфейса IEnumerator для получения текущего элемента
        /// </summary>
        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для получения текущего элемента
        /// </summary>
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        /// <summary>
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
        /// </summary>
        public void Dispose()
        {
            _places.Clear();
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        /// <summary>
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// <summary>
        /// Метод интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /// <summary>
        /// Метод интерфейса IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Hangar<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is Air && other._places[thisKeys[i]] is
                   AirBus)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is AirBus && other._places[thisKeys[i]] is
                    Air)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is Air && other._places[thisKeys[i]] is Air)
                    {
                        return (_places[thisKeys[i]] is
                       Air).CompareTo(other._places[thisKeys[i]] is Air);
                    }
                    if (_places[thisKeys[i]] is AirBus && other._places[thisKeys[i]] is
                    AirBus)
                    {
                        return (_places[thisKeys[i]] is
                       AirBus).CompareTo(other._places[thisKeys[i]] is AirBus);
                    }
                }
            }
            return 0;
        }
    }
}
