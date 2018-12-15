using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAirs
{
    public partial class FormHangar : Form
    {
        /// <summary>
        /// Объект от класса многоуровнего ангара
        /// </summary>
        MultiLevelHangar hangar;

        /// <summary>
        /// Форма для добавления
        /// </summary>
        FormAirConfig form;
        /// <summary>
        /// Количество уровней
        /// </summary>
        private const int countLevel = 5;

        /// <summary>
        /// Логгер
        /// </summary>
        private Logger logger;
        public FormHangar()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            hangar = new MultiLevelHangar(countLevel, pictureBoxHangar.Width,
           pictureBoxHangar.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        /// <summary>
        /// Метод отрисовки ангара
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangar[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
        }
        
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeAir_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var air = hangar[listBoxLevels.SelectedIndex] -
                       Convert.ToInt32(maskedTextBox.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTakeAir.Width,
                       pictureBoxTakeAir.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        air.SetPosition(12, 50, pictureBoxTakeAir.Width,
                       pictureBoxTakeAir.Height);
                        air.DrawAir(gr);
                        pictureBoxTakeAir.Image = bmp;
                        logger.Info("Изъят самолет " + air.ToString() + " с места " + maskedTextBox.Text);
                        Draw();
                    }
                    catch (HangarNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakeAir.Width,
                       pictureBoxTakeAir.Height);
                        pictureBoxTakeAir.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить самолет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSetAir_Click(object sender, EventArgs e)
        {
            form = new FormAirConfig();
            form.AddEvent(AddAir);
            form.Show();
        }

        /// <summary>
        /// Метод добавления самолета
        /// </summary>
        /// <param name="air"></param>
        private void AddAir(IAir air)
        {
            if (air != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = hangar[listBoxLevels.SelectedIndex] + air;
                    logger.Info("Добавлен самолет " + air.ToString() + " на место " +
                         place);
                    Draw();
                }
                catch (HangarOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangar.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    hangar.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (HangarOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
                Draw();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            hangar.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}
