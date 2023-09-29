namespace GooTrans
{
    partial class GooGoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GooGoo));
            this.Eng = new System.Windows.Forms.Button();
            this.Vie = new System.Windows.Forms.Button();
            this.Num = new System.Windows.Forms.TextBox();
            this.ReadNum = new System.Windows.Forms.TextBox();
            this.Audio = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HelpBton = new System.Windows.Forms.Button();
            this.helpbox = new System.Windows.Forms.PictureBox();
            this.helpbox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.helpbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpbox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Eng
            // 
            this.Eng.BackgroundImage = global::GooTrans.Properties.Resources.eng;
            this.Eng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eng.Location = new System.Drawing.Point(24, 22);
            this.Eng.Name = "Eng";
            this.Eng.Size = new System.Drawing.Size(75, 40);
            this.Eng.TabIndex = 0;
            this.Eng.UseVisualStyleBackColor = true;
            this.Eng.Click += new System.EventHandler(this.Eng_Click);
            // 
            // Vie
            // 
            this.Vie.BackgroundImage = global::GooTrans.Properties.Resources.vie;
            this.Vie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Vie.Location = new System.Drawing.Point(108, 22);
            this.Vie.Name = "Vie";
            this.Vie.Size = new System.Drawing.Size(64, 41);
            this.Vie.TabIndex = 1;
            this.Vie.UseVisualStyleBackColor = true;
            this.Vie.Click += new System.EventHandler(this.Vie_Click);
            // 
            // Num
            // 
            this.Num.BackColor = System.Drawing.Color.Aqua;
            this.Num.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.Location = new System.Drawing.Point(208, 30);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(151, 33);
            this.Num.TabIndex = 2;
            this.Num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // ReadNum
            // 
            this.ReadNum.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadNum.Location = new System.Drawing.Point(24, 85);
            this.ReadNum.Multiline = true;
            this.ReadNum.Name = "ReadNum";
            this.ReadNum.Size = new System.Drawing.Size(335, 266);
            this.ReadNum.TabIndex = 3;
            // 
            // Audio
            // 
            this.Audio.BackColor = System.Drawing.Color.Transparent;
            this.Audio.FlatAppearance.BorderSize = 0;
            this.Audio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Audio.Image = global::GooTrans.Properties.Resources.aaa1;
            this.Audio.Location = new System.Drawing.Point(281, 362);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(78, 70);
            this.Audio.TabIndex = 4;
            this.Audio.TabStop = false;
            this.Audio.UseVisualStyleBackColor = false;
            this.Audio.Click += new System.EventHandler(this.Audio_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = global::GooTrans.Properties.Resources.quit;
            this.ExitButton.Location = new System.Drawing.Point(24, 355);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(74, 79);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HelpBton
            // 
            this.HelpBton.BackColor = System.Drawing.Color.Transparent;
            this.HelpBton.FlatAppearance.BorderSize = 0;
            this.HelpBton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBton.ForeColor = System.Drawing.Color.Transparent;
            this.HelpBton.Image = global::GooTrans.Properties.Resources.what;
            this.HelpBton.Location = new System.Drawing.Point(150, 361);
            this.HelpBton.Name = "HelpBton";
            this.HelpBton.Size = new System.Drawing.Size(76, 70);
            this.HelpBton.TabIndex = 6;
            this.HelpBton.UseVisualStyleBackColor = false;
            this.HelpBton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // helpbox
            // 
            this.helpbox.BackColor = System.Drawing.Color.Transparent;
            this.helpbox.Image = global::GooTrans.Properties.Resources.helper;
            this.helpbox.Location = new System.Drawing.Point(-1, -1);
            this.helpbox.Name = "helpbox";
            this.helpbox.Size = new System.Drawing.Size(386, 453);
            this.helpbox.TabIndex = 7;
            this.helpbox.TabStop = false;
            this.helpbox.Visible = false;
            // 
            // helpbox2
            // 
            this.helpbox2.BackColor = System.Drawing.Color.Transparent;
            this.helpbox2.Image = global::GooTrans.Properties.Resources.helper2;
            this.helpbox2.Location = new System.Drawing.Point(-1, -1);
            this.helpbox2.Name = "helpbox2";
            this.helpbox2.Size = new System.Drawing.Size(386, 453);
            this.helpbox2.TabIndex = 8;
            this.helpbox2.TabStop = false;
            this.helpbox2.Visible = false;
            // 
            // GooGoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GooTrans.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(383, 454);
            this.Controls.Add(this.helpbox2);
            this.Controls.Add(this.helpbox);
            this.Controls.Add(this.HelpBton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Audio);
            this.Controls.Add(this.ReadNum);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Vie);
            this.Controls.Add(this.Eng);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GooGoo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GooTrans";
            this.Load += new System.EventHandler(this.GooGoo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.helpbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpbox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eng;
        private System.Windows.Forms.Button Vie;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.TextBox ReadNum;
        private System.Windows.Forms.Button Audio;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button HelpBton;
        private System.Windows.Forms.PictureBox helpbox;
        private System.Windows.Forms.PictureBox helpbox2;
    }
}

