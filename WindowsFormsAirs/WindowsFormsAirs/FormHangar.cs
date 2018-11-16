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
        /// Количество уровней-парковок
        /// </summary>
        private const int countLevel = 5;
        public FormHangar()
        {
            InitializeComponent();
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
                    var air = hangar[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
                    if (air != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeAir.Width,
                       pictureBoxTakeAir.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        air.SetPosition(12, 50, pictureBoxTakeAir.Width,
                       pictureBoxTakeAir.Height);
                        air.DrawAir(gr);
                        pictureBoxTakeAir.Image = bmp;
                    }
                    else
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeAir.Width,
                       pictureBoxTakeAir.Height);
                        pictureBoxTakeAir.Image = bmp;
                    }
                    Draw();
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
                int place = parking[listBoxLevels.SelectedIndex] + air;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
    }
}
