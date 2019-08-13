namespace Maps
{
    partial class AddMarker
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
            this.label_Name = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.label_Year = new System.Windows.Forms.Label();
            this.textBox_Latitude = new System.Windows.Forms.TextBox();
            this.label_Latitude = new System.Windows.Forms.Label();
            this.textBox_Longitude = new System.Windows.Forms.TextBox();
            this.label_Longitude = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(153, 78);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(156, 278);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(290, 278);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(212, 78);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 3;
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(212, 112);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(100, 20);
            this.textBox_Year.TabIndex = 5;
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.Location = new System.Drawing.Point(153, 112);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(29, 13);
            this.label_Year.TabIndex = 4;
            this.label_Year.Text = "Year";
            // 
            // textBox_Latitude
            // 
            this.textBox_Latitude.Location = new System.Drawing.Point(212, 148);
            this.textBox_Latitude.Name = "textBox_Latitude";
            this.textBox_Latitude.Size = new System.Drawing.Size(100, 20);
            this.textBox_Latitude.TabIndex = 7;
            // 
            // label_Latitude
            // 
            this.label_Latitude.AutoSize = true;
            this.label_Latitude.Location = new System.Drawing.Point(153, 148);
            this.label_Latitude.Name = "label_Latitude";
            this.label_Latitude.Size = new System.Drawing.Size(45, 13);
            this.label_Latitude.TabIndex = 6;
            this.label_Latitude.Text = "Latitude";
            // 
            // textBox_Longitude
            // 
            this.textBox_Longitude.Location = new System.Drawing.Point(212, 184);
            this.textBox_Longitude.Name = "textBox_Longitude";
            this.textBox_Longitude.Size = new System.Drawing.Size(100, 20);
            this.textBox_Longitude.TabIndex = 9;
            // 
            // label_Longitude
            // 
            this.label_Longitude.AutoSize = true;
            this.label_Longitude.Location = new System.Drawing.Point(153, 184);
            this.label_Longitude.Name = "label_Longitude";
            this.label_Longitude.Size = new System.Drawing.Size(54, 13);
            this.label_Longitude.TabIndex = 8;
            this.label_Longitude.Text = "Longitude";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(212, 220);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(100, 20);
            this.textBox_Description.TabIndex = 11;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(153, 223);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(60, 13);
            this.label_Description.TabIndex = 10;
            this.label_Description.Text = "Description";
            // 
            // AddMarker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 413);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.textBox_Longitude);
            this.Controls.Add(this.label_Longitude);
            this.Controls.Add(this.textBox_Latitude);
            this.Controls.Add(this.label_Latitude);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.label_Year);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label_Name);
            this.Name = "AddMarker";
            this.Text = "AddMarker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.TextBox textBox_Latitude;
        private System.Windows.Forms.Label label_Latitude;
        private System.Windows.Forms.TextBox textBox_Longitude;
        private System.Windows.Forms.Label label_Longitude;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label_Description;
    }
}