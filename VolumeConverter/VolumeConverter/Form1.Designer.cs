
namespace VolumeConverter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.temp_button = new System.Windows.Forms.Button();
            this.vol_button = new System.Windows.Forms.Button();
            this.len_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.weight_button = new System.Windows.Forms.Button();
            this.area_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(75, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centiliter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(396, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(71, 236);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(175, 29);
            this.TextBox1.TabIndex = 2;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.DimGray;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBox2.Location = new System.Drawing.Point(390, 236);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(181, 29);
            this.TextBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.button1.Image = global::VolumeConverter.Properties.Resources.bg_orange;
            this.button1.Location = new System.Drawing.Point(278, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(472, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::VolumeConverter.Properties.Resources.btn_switch;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(295, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(36, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 55);
            this.label4.TabIndex = 8;
            this.label4.Text = "!";
            this.label4.Visible = false;
            // 
            // temp_button
            // 
            this.temp_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.temp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp_button.FlatAppearance.BorderSize = 0;
            this.temp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temp_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp_button.ForeColor = System.Drawing.Color.NavajoWhite;
            this.temp_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            this.temp_button.Location = new System.Drawing.Point(71, 114);
            this.temp_button.Name = "temp_button";
            this.temp_button.Size = new System.Drawing.Size(105, 23);
            this.temp_button.TabIndex = 11;
            this.temp_button.Text = "Temperature";
            this.temp_button.UseVisualStyleBackColor = false;
            this.temp_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // vol_button
            // 
            this.vol_button.BackColor = System.Drawing.Color.ForestGreen;
            this.vol_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vol_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.vol_button.FlatAppearance.BorderSize = 0;
            this.vol_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vol_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vol_button.ForeColor = System.Drawing.Color.NavajoWhite;
            this.vol_button.Image = global::VolumeConverter.Properties.Resources.bg_orange;
            this.vol_button.Location = new System.Drawing.Point(186, 114);
            this.vol_button.Name = "vol_button";
            this.vol_button.Size = new System.Drawing.Size(89, 23);
            this.vol_button.TabIndex = 12;
            this.vol_button.Text = "Volume";
            this.vol_button.UseVisualStyleBackColor = false;
            this.vol_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // len_button
            // 
            this.len_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.len_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.len_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.len_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.len_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.len_button.ForeColor = System.Drawing.Color.NavajoWhite;
            this.len_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            this.len_button.Location = new System.Drawing.Point(284, 114);
            this.len_button.Name = "len_button";
            this.len_button.Size = new System.Drawing.Size(89, 23);
            this.len_button.TabIndex = 13;
            this.len_button.Text = "Length";
            this.len_button.UseVisualStyleBackColor = false;
            this.len_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label5.Location = new System.Drawing.Point(252, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(577, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 15;
            // 
            // weight_button
            // 
            this.weight_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.weight_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weight_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.weight_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weight_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_button.ForeColor = System.Drawing.Color.NavajoWhite;
            this.weight_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            this.weight_button.Location = new System.Drawing.Point(383, 114);
            this.weight_button.Name = "weight_button";
            this.weight_button.Size = new System.Drawing.Size(89, 23);
            this.weight_button.TabIndex = 16;
            this.weight_button.Text = "Weight";
            this.weight_button.UseVisualStyleBackColor = false;
            this.weight_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // area_button
            // 
            this.area_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.area_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.area_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.area_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.area_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_button.ForeColor = System.Drawing.Color.NavajoWhite;
            this.area_button.Image = global::VolumeConverter.Properties.Resources.bg_black;
            this.area_button.Location = new System.Drawing.Point(482, 114);
            this.area_button.Name = "area_button";
            this.area_button.Size = new System.Drawing.Size(89, 23);
            this.area_button.TabIndex = 17;
            this.area_button.Text = "Area";
            this.area_button.UseVisualStyleBackColor = false;
            this.area_button.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label3.Location = new System.Drawing.Point(26, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "Unit";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(48, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Converter";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::VolumeConverter.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 449);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.area_button);
            this.Controls.Add(this.weight_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.len_button);
            this.Controls.Add(this.vol_button);
            this.Controls.Add(this.temp_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Unit Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button temp_button;
        private System.Windows.Forms.Button vol_button;
        private System.Windows.Forms.Button len_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button weight_button;
        private System.Windows.Forms.Button area_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}

