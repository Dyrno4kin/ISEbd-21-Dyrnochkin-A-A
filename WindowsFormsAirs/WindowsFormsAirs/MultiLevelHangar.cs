using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirs
{
    /// <summary>
    /// Класс-хранидище ангар
    /// </summary>
    public class MultiLevelHangar
    {
        /// <summary>
        /// Список с уровнями ангара
        /// </summary>
        List<Hangar<IAir>> hangarStages;
        /// <summary>
        /// Сколько мест на каждом уровне
        /// </summary>
        private const int countPlaces = 10;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй в анагре</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            hangarStages = new List<Hangar<IAir>>();
            for (int i = 0; i < countStages; ++i)
            {
                hangarStages.Add(new Hangar<IAir>(countPlaces, pictureWidth,
               pictureHeight));
            }
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Hangar<IAir> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < hangarStages.Count)
                {
                    return hangarStages[ind];
                }
                return null;
            }
        }
    }
}
