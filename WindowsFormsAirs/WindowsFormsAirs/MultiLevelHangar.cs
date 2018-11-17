using System;
using System.Collections.Generic;
using System.IO;
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
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="countStages">Количество уровенй в анагре</param>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            hangarStages = new List<Hangar<IAir>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
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

        /// <summary>
        /// Сохранение информации по самолетма в ангаре в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    //Записываем количество уровней
                    WriteToFile("CountLeveles:" + hangarStages.Count +
                   Environment.NewLine, fs);
                    foreach (var level in hangarStages)
                    {
                        //Начинаем уровень
                        WriteToFile("Level" + Environment.NewLine, fs);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var air = level[i];
                            if (air != null)
                            {
                                //если место не пустое
                                //Записываем тип самолета
                                if (air.GetType().Name == "Air")
                                {
                                    WriteToFile(i + ":Air:", fs);
                                }
                                if (air.GetType().Name == "AirBus")
                                {
                                    WriteToFile(i + ":AirBus:", fs);
                                }
                                //Записываемые параметры
                                WriteToFile(air + Environment.NewLine, fs);
                            }
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Загрузка нформации по самолетам в ангаре из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        bufferTextFromFile += temp.GetString(b);
                    }
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                //считываем количество уровней
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (hangarStages != null)
                {
                    hangarStages.Clear();
                }
                hangarStages = new List<Hangar<IAir>>(count);
            }
            else
            {
                //если нет такой записи, то это не те данные
                return false;
            }
            int counter = -1;
            IAir air = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i] == "Level")
                {
                    //начинаем новый уровень
                    counter++;
                    hangarStages.Add(new Hangar<IAir>(countPlaces, pictureWidth,pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "Air")
                {
                    air = new Air(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "AirBus")
                {
                    air = new AirBus(strs[i].Split(':')[2]);
                }
                hangarStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = air;
            }
            return true;
        }
    }
}
