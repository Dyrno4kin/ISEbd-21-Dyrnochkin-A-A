namespace WindowsFormsAirs
{
    partial class FormAir
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.pictureBoxAir = new System.Windows.Forms.PictureBox();
            this.buttonAddAir = new System.Windows.Forms.Button();
            this.buttonAddAirBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDown.FlatAppearance.BorderSize = 0;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Image = global::WindowsFormsAirs.Properties.Resources.down1;
            this.buttonDown.Location = new System.Drawing.Point(1368, 626);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(61, 65);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRight.FlatAppearance.BorderSize = 0;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRight.Image = global::WindowsFormsAirs.Properties.Resources.right1;
            this.buttonRight.Location = new System.Drawing.Point(1431, 625);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(67, 65);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLeft.FlatAppearance.BorderSize = 0;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeft.Image = global::WindowsFormsAirs.Properties.Resources.left1;
            this.buttonLeft.Location = new System.Drawing.Point(1297, 625);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(71, 66);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Image = global::WindowsFormsAirs.Properties.Resources.up1;
            this.buttonUp.Location = new System.Drawing.Point(1368, 552);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(61, 67);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxAir
            // 
            this.pictureBoxAir.BackColor = System.Drawing.Color.White;
            this.pictureBoxAir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAir.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAir.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxAir.Name = "pictureBoxAir";
            this.pictureBoxAir.Size = new System.Drawing.Size(1511, 704);
            this.pictureBoxAir.TabIndex = 0;
            this.pictureBoxAir.TabStop = false;
            // 
            // buttonAddAir
            // 
            this.buttonAddAir.Location = new System.Drawing.Point(12, 12);
            this.buttonAddAir.Name = "buttonAddAir";
            this.buttonAddAir.Size = new System.Drawing.Size(126, 28);
            this.buttonAddAir.TabIndex = 6;
            this.buttonAddAir.Text = "Самолет";
            this.buttonAddAir.UseVisualStyleBackColor = true;
            this.buttonAddAir.Click += new System.EventHandler(this.buttonAddAir_Click);
            // 
            // buttonAddAirBus
            // 
            this.buttonAddAirBus.Location = new System.Drawing.Point(162, 12);
            this.buttonAddAirBus.Name = "buttonAddAirBus";
            this.buttonAddAirBus.Size = new System.Drawing.Size(126, 28);
            this.buttonAddAirBus.TabIndex = 7;
            this.buttonAddAirBus.Text = "Аэробус";
            this.buttonAddAirBus.UseVisualStyleBackColor = true;
            this.buttonAddAirBus.Click += new System.EventHandler(this.buttonAddAirBus_Click);
            // 
            // FormAir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 704);
            this.Controls.Add(this.buttonAddAirBus);
            this.Controls.Add(this.buttonAddAir);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.pictureBoxAir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAir;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonAddAir;
        private System.Windows.Forms.Button buttonAddAirBus;
    }
}

