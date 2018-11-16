using System.Windows.Forms;

namespace WindowsFormsAirs
{
    partial class FormHangar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.pictureBoxTakeAir = new System.Windows.Forms.PictureBox();
            this.labelTakeAir = new System.Windows.Forms.Label();
            this.labelNumberMesto = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.TextBox();
            this.buttonTakeAir = new System.Windows.Forms.Button();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonSetAir = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeAir)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBoxHangar.Location = new System.Drawing.Point(12, 50);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(403, 403);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // pictureBoxTakeAir
            // 
            this.pictureBoxTakeAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTakeAir.Location = new System.Drawing.Point(426, 279);
            this.pictureBoxTakeAir.Name = "pictureBoxTakeAir";
            this.pictureBoxTakeAir.Size = new System.Drawing.Size(179, 140);
            this.pictureBoxTakeAir.TabIndex = 1;
            this.pictureBoxTakeAir.TabStop = false;
            // 
            // labelTakeAir
            // 
            this.labelTakeAir.AutoSize = true;
            this.labelTakeAir.Location = new System.Drawing.Point(457, 231);
            this.labelTakeAir.Name = "labelTakeAir";
            this.labelTakeAir.Size = new System.Drawing.Size(122, 17);
            this.labelTakeAir.TabIndex = 4;
            this.labelTakeAir.Text = "Забрать самолет";
            // 
            // labelNumberMesto
            // 
            this.labelNumberMesto.AutoSize = true;
            this.labelNumberMesto.Location = new System.Drawing.Point(437, 256);
            this.labelNumberMesto.Name = "labelNumberMesto";
            this.labelNumberMesto.Size = new System.Drawing.Size(53, 17);
            this.labelNumberMesto.TabIndex = 5;
            this.labelNumberMesto.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(526, 251);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(73, 22);
            this.maskedTextBox.TabIndex = 6;
            // 
            // buttonTakeAir
            // 
            this.buttonTakeAir.Location = new System.Drawing.Point(428, 425);
            this.buttonTakeAir.Name = "buttonTakeAir";
            this.buttonTakeAir.Size = new System.Drawing.Size(179, 28);
            this.buttonTakeAir.TabIndex = 7;
            this.buttonTakeAir.Text = "Забрать";
            this.buttonTakeAir.UseVisualStyleBackColor = true;
            this.buttonTakeAir.Click += new System.EventHandler(this.buttonTakeAir_Click);
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(421, 50);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(176, 116);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonSetAir
            // 
            this.buttonSetAir.Location = new System.Drawing.Point(426, 181);
            this.buttonSetAir.Name = "buttonSetAir";
            this.buttonSetAir.Size = new System.Drawing.Size(173, 47);
            this.buttonSetAir.TabIndex = 9;
            this.buttonSetAir.Text = "Добавить самолет";
            this.buttonSetAir.UseVisualStyleBackColor = true;
            this.buttonSetAir.Click += new System.EventHandler(this.ButtonSetAir_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(611, 28);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormHangar
            // 
            this.ClientSize = new System.Drawing.Size(611, 465);
            this.Controls.Add(this.buttonSetAir);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.buttonTakeAir);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.labelNumberMesto);
            this.Controls.Add(this.labelTakeAir);
            this.Controls.Add(this.pictureBoxTakeAir);
            this.Controls.Add(this.pictureBoxHangar);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormHangar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeAir)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBoxHangar;
        private PictureBox pictureBoxTakeAir;
        private Label labelTakeAir;
        private Label labelNumberMesto;
        private TextBox maskedTextBox;
        private Button buttonTakeAir;
        private ListBox listBoxLevels;
        private Button buttonSetAir;
        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}