namespace WindowsFormsAirs
{
    partial class FormAirConfig
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
            this.pictureBoxAir = new System.Windows.Forms.PictureBox();
            this.groupBoxTypeAir = new System.Windows.Forms.GroupBox();
            this.labelAirBus = new System.Windows.Forms.Label();
            this.labelAir = new System.Windows.Forms.Label();
            this.panelPictureBoxAir = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBoxTypeColor = new System.Windows.Forms.GroupBox();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelSilver = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).BeginInit();
            this.groupBoxTypeAir.SuspendLayout();
            this.panelPictureBoxAir.SuspendLayout();
            this.groupBoxTypeColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAir
            // 
            this.pictureBoxAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAir.Location = new System.Drawing.Point(32, 23);
            this.pictureBoxAir.Name = "pictureBoxAir";
            this.pictureBoxAir.Size = new System.Drawing.Size(229, 149);
            this.pictureBoxAir.TabIndex = 0;
            this.pictureBoxAir.TabStop = false;
            // 
            // groupBoxTypeAir
            // 
            this.groupBoxTypeAir.Controls.Add(this.labelAirBus);
            this.groupBoxTypeAir.Controls.Add(this.labelAir);
            this.groupBoxTypeAir.Location = new System.Drawing.Point(49, 76);
            this.groupBoxTypeAir.Name = "groupBoxTypeAir";
            this.groupBoxTypeAir.Size = new System.Drawing.Size(170, 183);
            this.groupBoxTypeAir.TabIndex = 1;
            this.groupBoxTypeAir.TabStop = false;
            this.groupBoxTypeAir.Text = "Тип самолета";
            // 
            // labelAirBus
            // 
            this.labelAirBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAirBus.Location = new System.Drawing.Point(18, 112);
            this.labelAirBus.Name = "labelAirBus";
            this.labelAirBus.Size = new System.Drawing.Size(127, 37);
            this.labelAirBus.TabIndex = 2;
            this.labelAirBus.Text = "Аэробус";
            this.labelAirBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAirBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAirBus_MouseDown);
            // 
            // labelAir
            // 
            this.labelAir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAir.Location = new System.Drawing.Point(15, 50);
            this.labelAir.Name = "labelAir";
            this.labelAir.Size = new System.Drawing.Size(130, 37);
            this.labelAir.TabIndex = 2;
            this.labelAir.Text = "Обычный самолет";
            this.labelAir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAir.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAir_DragDrop);
            this.labelAir.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAir_DragEnter);
            this.labelAir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAir_MouseDown);
            // 
            // panelPictureBoxAir
            // 
            this.panelPictureBoxAir.AllowDrop = true;
            this.panelPictureBoxAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPictureBoxAir.Controls.Add(this.labelDopColor);
            this.panelPictureBoxAir.Controls.Add(this.labelBaseColor);
            this.panelPictureBoxAir.Controls.Add(this.pictureBoxAir);
            this.panelPictureBoxAir.Location = new System.Drawing.Point(264, 12);
            this.panelPictureBoxAir.Name = "panelPictureBoxAir";
            this.panelPictureBoxAir.Size = new System.Drawing.Size(301, 345);
            this.panelPictureBoxAir.TabIndex = 2;
            this.panelPictureBoxAir.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAir_DragDrop);
            this.panelPictureBoxAir.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAir_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(79, 265);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(140, 59);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(79, 186);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(140, 59);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxTypeColor
            // 
            this.groupBoxTypeColor.Controls.Add(this.panelPurple);
            this.groupBoxTypeColor.Controls.Add(this.panelSilver);
            this.groupBoxTypeColor.Controls.Add(this.panelYellow);
            this.groupBoxTypeColor.Controls.Add(this.panelBlue);
            this.groupBoxTypeColor.Controls.Add(this.panelRed);
            this.groupBoxTypeColor.Controls.Add(this.panelGreen);
            this.groupBoxTypeColor.Controls.Add(this.panelWhite);
            this.groupBoxTypeColor.Controls.Add(this.panelBlack);
            this.groupBoxTypeColor.Location = new System.Drawing.Point(623, 76);
            this.groupBoxTypeColor.Name = "groupBoxTypeColor";
            this.groupBoxTypeColor.Size = new System.Drawing.Size(165, 216);
            this.groupBoxTypeColor.TabIndex = 3;
            this.groupBoxTypeColor.TabStop = false;
            this.groupBoxTypeColor.Text = "Цвета";
            // 
            // panelPurple
            // 
            this.panelPurple.AllowDrop = true;
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(105, 165);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(45, 40);
            this.panelPurple.TabIndex = 7;
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelSilver
            // 
            this.panelSilver.AllowDrop = true;
            this.panelSilver.BackColor = System.Drawing.Color.Silver;
            this.panelSilver.Location = new System.Drawing.Point(16, 165);
            this.panelSilver.Name = "panelSilver";
            this.panelSilver.Size = new System.Drawing.Size(45, 40);
            this.panelSilver.TabIndex = 6;
            this.panelSilver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.AllowDrop = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(105, 119);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(45, 40);
            this.panelYellow.TabIndex = 5;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.AllowDrop = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(16, 119);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(45, 40);
            this.panelBlue.TabIndex = 4;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(105, 73);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(45, 40);
            this.panelRed.TabIndex = 3;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.AllowDrop = true;
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(16, 73);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(45, 40);
            this.panelGreen.TabIndex = 2;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.AllowDrop = true;
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(105, 27);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(45, 40);
            this.panelWhite.TabIndex = 1;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(16, 27);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(45, 40);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(78, 278);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(105, 34);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(78, 323);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 34);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAirConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 368);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxTypeColor);
            this.Controls.Add(this.panelPictureBoxAir);
            this.Controls.Add(this.groupBoxTypeAir);
            this.Name = "FormAirConfig";
            this.Text = "FormAirConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).EndInit();
            this.groupBoxTypeAir.ResumeLayout(false);
            this.panelPictureBoxAir.ResumeLayout(false);
            this.groupBoxTypeColor.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxAir;
        private System.Windows.Forms.GroupBox groupBoxTypeAir;
        private System.Windows.Forms.Label labelAirBus;
        private System.Windows.Forms.Label labelAir;
        private System.Windows.Forms.Panel panelPictureBoxAir;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBoxTypeColor;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelSilver;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}