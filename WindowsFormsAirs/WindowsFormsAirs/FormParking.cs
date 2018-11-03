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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        Parking<IAir> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<IAir>(10, pictureBoxParking.Width,
           pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать самолет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetAir_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var air = new Air(100, 1000, dialog.Color);
                int place = parking + air;
                Draw();
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать аэробус"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetAirBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var air = new AirBus(100, 1000, dialog.Color, dialogDop.Color,
                   true);
                    int place = parking + air;
                    Draw();
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeAir_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var air = parking - Convert.ToInt32(maskedTextBox.Text);
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
}
