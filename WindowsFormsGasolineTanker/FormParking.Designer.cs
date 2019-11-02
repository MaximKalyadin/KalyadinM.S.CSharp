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
            this.buttonParkingTruck = new System.Windows.Forms.Button();
            this.buttonParkingFullTruck = new System.Windows.Forms.Button();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.buttonTakeTruck = new System.Windows.Forms.Button();
            this.pictureTake = new System.Windows.Forms.PictureBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxTake = new System.Windows.Forms.MaskedTextBox();
            this.labelTakeTruck = new System.Windows.Forms.Label();
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
            // buttonParkingTruck
            // 
            this.buttonParkingTruck.Location = new System.Drawing.Point(899, 12);
            this.buttonParkingTruck.Name = "buttonParkingTruck";
            this.buttonParkingTruck.Size = new System.Drawing.Size(119, 77);
            this.buttonParkingTruck.TabIndex = 1;
            this.buttonParkingTruck.Text = "Припарковать бензовоз";
            this.buttonParkingTruck.UseVisualStyleBackColor = true;
            this.buttonParkingTruck.Click += new System.EventHandler(this.buttonSeTruck_Click);
            // 
            // buttonParkingFullTruck
            // 
            this.buttonParkingFullTruck.Location = new System.Drawing.Point(1033, 12);
            this.buttonParkingFullTruck.Name = "buttonParkingFullTruck";
            this.buttonParkingFullTruck.Size = new System.Drawing.Size(119, 77);
            this.buttonParkingFullTruck.TabIndex = 2;
            this.buttonParkingFullTruck.Text = "Припарковать Full бензовоз";
            this.buttonParkingFullTruck.UseVisualStyleBackColor = true;
            this.buttonParkingFullTruck.Click += new System.EventHandler(this.buttonSetFullTruck_Click);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 663);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.buttonParkingFullTruck);
            this.Controls.Add(this.buttonParkingTruck);
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
        private System.Windows.Forms.Button buttonParkingTruck;
        private System.Windows.Forms.Button buttonParkingFullTruck;
        private System.Windows.Forms.GroupBox groupBoxTake;
        private System.Windows.Forms.Button buttonTakeTruck;
        private System.Windows.Forms.PictureBox pictureTake;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTake;
        private System.Windows.Forms.Label labelTakeTruck;
    }
}