namespace WindowsFormsGasolineTanker
{
    partial class FormParking
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
            this.pictureParking = new System.Windows.Forms.PictureBox();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.buttonTakeTruck = new System.Windows.Forms.Button();
            this.pictureTake = new System.Windows.Forms.PictureBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxTake = new System.Windows.Forms.MaskedTextBox();
            this.labelTakeTruck = new System.Windows.Forms.Label();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureParking)).BeginInit();
            this.groupBoxTake.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTake)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureParking
            // 
            this.pictureParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureParking.Location = new System.Drawing.Point(0, 0);
            this.pictureParking.Name = "pictureParking";
            this.pictureParking.Size = new System.Drawing.Size(884, 660);
            this.pictureParking.TabIndex = 0;
            this.pictureParking.TabStop = false;
            // 
            // groupBoxTake
            // 
            this.groupBoxTake.Controls.Add(this.buttonTakeTruck);
            this.groupBoxTake.Controls.Add(this.pictureTake);
            this.groupBoxTake.Controls.Add(this.labelPlace);
            this.groupBoxTake.Controls.Add(this.maskedTextBoxTake);
            this.groupBoxTake.Controls.Add(this.labelTakeTruck);
            this.groupBoxTake.Location = new System.Drawing.Point(917, 431);
            this.groupBoxTake.Name = "groupBoxTake";
            this.groupBoxTake.Size = new System.Drawing.Size(235, 220);
            this.groupBoxTake.TabIndex = 3;
            this.groupBoxTake.TabStop = false;
            // 
            // buttonTakeTruck
            // 
            this.buttonTakeTruck.Location = new System.Drawing.Point(78, 76);
            this.buttonTakeTruck.Name = "buttonTakeTruck";
            this.buttonTakeTruck.Size = new System.Drawing.Size(87, 24);
            this.buttonTakeTruck.TabIndex = 4;
            this.buttonTakeTruck.Text = "Забрать";
            this.buttonTakeTruck.UseVisualStyleBackColor = true;
            this.buttonTakeTruck.Click += new System.EventHandler(this.buttonTakeTruck_Click);
            // 
            // pictureTake
            // 
            this.pictureTake.Location = new System.Drawing.Point(0, 106);
            this.pictureTake.Name = "pictureTake";
            this.pictureTake.Size = new System.Drawing.Size(229, 108);
            this.pictureTake.TabIndex = 3;
            this.pictureTake.TabStop = false;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(61, 48);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(49, 17);
            this.labelPlace.TabIndex = 2;
            this.labelPlace.Text = "Место";
            // 
            // maskedTextBoxTake
            // 
            this.maskedTextBoxTake.Location = new System.Drawing.Point(130, 48);
            this.maskedTextBoxTake.Name = "maskedTextBoxTake";
            this.maskedTextBoxTake.Size = new System.Drawing.Size(59, 22);
            this.maskedTextBoxTake.TabIndex = 1;
            // 
            // labelTakeTruck
            // 
            this.labelTakeTruck.AutoSize = true;
            this.labelTakeTruck.Location = new System.Drawing.Point(61, 18);
            this.labelTakeTruck.Name = "labelTakeTruck";
            this.labelTakeTruck.Size = new System.Drawing.Size(128, 17);
            this.labelTakeTruck.TabIndex = 0;
            this.labelTakeTruck.Text = "Забрать бензовоз";
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(890, 17);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(255, 148);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(952, 207);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 54);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить автомобиль";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 663);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.pictureParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureParking)).EndInit();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureParking;
        private System.Windows.Forms.GroupBox groupBoxTake;
        private System.Windows.Forms.Button buttonTakeTruck;
        private System.Windows.Forms.PictureBox pictureTake;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTake;
        private System.Windows.Forms.Label labelTakeTruck;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonAdd;
    }
}