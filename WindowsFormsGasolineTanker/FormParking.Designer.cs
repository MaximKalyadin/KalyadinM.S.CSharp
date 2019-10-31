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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeTruck = new System.Windows.Forms.Button();
            this.pictureTake = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureParking)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.buttonParkingTruck.Location = new System.Drawing.Point(890, 170);
            this.buttonParkingTruck.Name = "buttonParkingTruck";
            this.buttonParkingTruck.Size = new System.Drawing.Size(119, 77);
            this.buttonParkingTruck.TabIndex = 1;
            this.buttonParkingTruck.Text = "Припарковать бензовоз";
            this.buttonParkingTruck.UseVisualStyleBackColor = true;
            this.buttonParkingTruck.Click += new System.EventHandler(this.buttonSeTruck_Click);
            // 
            // buttonParkingFullTruck
            // 
            this.buttonParkingFullTruck.Location = new System.Drawing.Point(1027, 170);
            this.buttonParkingFullTruck.Name = "buttonParkingFullTruck";
            this.buttonParkingFullTruck.Size = new System.Drawing.Size(119, 77);
            this.buttonParkingFullTruck.TabIndex = 2;
            this.buttonParkingFullTruck.Text = "Припарковать Full бензовоз";
            this.buttonParkingFullTruck.UseVisualStyleBackColor = true;
            this.buttonParkingFullTruck.Click += new System.EventHandler(this.buttonSetFullTruck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeTruck);
            this.groupBox1.Controls.Add(this.pictureTake);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(917, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Место";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(130, 48);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(59, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Забрать бензовоз";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(890, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 148);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 663);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonParkingFullTruck);
            this.Controls.Add(this.buttonParkingTruck);
            this.Controls.Add(this.pictureParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTake)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureParking;
        private System.Windows.Forms.Button buttonParkingTruck;
        private System.Windows.Forms.Button buttonParkingFullTruck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeTruck;
        private System.Windows.Forms.PictureBox pictureTake;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}