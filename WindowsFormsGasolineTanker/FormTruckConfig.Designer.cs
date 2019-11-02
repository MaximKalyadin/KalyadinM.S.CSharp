namespace WindowsFormsGasolineTanker
{
    partial class FormTruckConfig
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
            this.groupBoxCreate = new System.Windows.Forms.GroupBox();
            this.labelFull = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.pictureBoxSetTruck = new System.Windows.Forms.PictureBox();
            this.panelTruck = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelGold = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetTruck)).BeginInit();
            this.panelTruck.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCreate
            // 
            this.groupBoxCreate.Controls.Add(this.labelFull);
            this.groupBoxCreate.Controls.Add(this.labelBase);
            this.groupBoxCreate.Location = new System.Drawing.Point(22, 22);
            this.groupBoxCreate.Name = "groupBoxCreate";
            this.groupBoxCreate.Size = new System.Drawing.Size(205, 209);
            this.groupBoxCreate.TabIndex = 0;
            this.groupBoxCreate.TabStop = false;
            this.groupBoxCreate.Text = "Тип Бензовоза";
            // 
            // labelFull
            // 
            this.labelFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFull.Location = new System.Drawing.Point(36, 119);
            this.labelFull.Name = "labelFull";
            this.labelFull.Size = new System.Drawing.Size(121, 56);
            this.labelFull.TabIndex = 1;
            this.labelFull.Text = "Full";
            this.labelFull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFull.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelFullTruck_MouseDown);
            // 
            // labelBase
            // 
            this.labelBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBase.Location = new System.Drawing.Point(36, 27);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(121, 56);
            this.labelBase.TabIndex = 0;
            this.labelBase.Text = "Обычный";
            this.labelBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTruck_MouseDown);
            // 
            // pictureBoxSetTruck
            // 
            this.pictureBoxSetTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSetTruck.Location = new System.Drawing.Point(23, 18);
            this.pictureBoxSetTruck.Name = "pictureBoxSetTruck";
            this.pictureBoxSetTruck.Size = new System.Drawing.Size(271, 138);
            this.pictureBoxSetTruck.TabIndex = 1;
            this.pictureBoxSetTruck.TabStop = false;
            // 
            // panelTruck
            // 
            this.panelTruck.AllowDrop = true;
            this.panelTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTruck.Controls.Add(this.labelDopColor);
            this.panelTruck.Controls.Add(this.labelMainColor);
            this.panelTruck.Controls.Add(this.pictureBoxSetTruck);
            this.panelTruck.Location = new System.Drawing.Point(250, 22);
            this.panelTruck.Name = "panelTruck";
            this.panelTruck.Size = new System.Drawing.Size(319, 304);
            this.panelTruck.TabIndex = 2;
            this.panelTruck.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelTruck.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            this.panelTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(53, 237);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(201, 42);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "Дополнительный цвет ";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(53, 181);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(202, 47);
            this.labelMainColor.TabIndex = 2;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelGold);
            this.groupBoxColor.Controls.Add(this.panelGray);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(634, 22);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(149, 259);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelGold
            // 
            this.panelGold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelGold.Location = new System.Drawing.Point(85, 194);
            this.panelGold.Name = "panelGold";
            this.panelGold.Size = new System.Drawing.Size(35, 35);
            this.panelGold.TabIndex = 7;
            this.panelGold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Silver;
            this.panelGray.Location = new System.Drawing.Point(22, 194);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(35, 35);
            this.panelGray.TabIndex = 6;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(85, 140);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(35, 35);
            this.panelYellow.TabIndex = 5;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(22, 140);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(35, 35);
            this.panelRed.TabIndex = 4;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(85, 87);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(35, 35);
            this.panelBlue.TabIndex = 3;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(22, 87);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(35, 35);
            this.panelGreen.TabIndex = 2;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(85, 30);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(35, 35);
            this.panelWhite.TabIndex = 1;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(22, 30);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(35, 35);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(57, 248);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(121, 32);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(57, 296);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 29);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTruckConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 348);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelTruck);
            this.Controls.Add(this.groupBoxCreate);
            this.Name = "FormTruckConfig";
            this.Text = "Выбор машины";
            this.groupBoxCreate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSetTruck)).EndInit();
            this.panelTruck.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCreate;
        private System.Windows.Forms.Label labelFull;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.PictureBox pictureBoxSetTruck;
        private System.Windows.Forms.Panel panelTruck;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelGold;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}