namespace takehomeweek3
{
    partial class MainWindform
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
            this.Name = new System.Windows.Forms.Label();
            this.OpenNextForm = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.MyFavouriteArtist = new System.Windows.Forms.Label();
            this.ArtistBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(13, 29);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // OpenNextForm
            // 
            this.OpenNextForm.Location = new System.Drawing.Point(16, 159);
            this.OpenNextForm.Name = "OpenNextForm";
            this.OpenNextForm.Size = new System.Drawing.Size(109, 23);
            this.OpenNextForm.TabIndex = 1;
            this.OpenNextForm.Text = "OpenNextForm";
            this.OpenNextForm.UseVisualStyleBackColor = true;
            this.OpenNextForm.Click += new System.EventHandler(this.OpenNextForm_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(133, 22);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 2;
            // 
            // MyFavouriteArtist
            // 
            this.MyFavouriteArtist.AutoSize = true;
            this.MyFavouriteArtist.Location = new System.Drawing.Point(12, 68);
            this.MyFavouriteArtist.Name = "MyFavouriteArtist";
            this.MyFavouriteArtist.Size = new System.Drawing.Size(88, 13);
            this.MyFavouriteArtist.TabIndex = 3;
            this.MyFavouriteArtist.Text = "MyFavouriteArtist";
            // 
            // ArtistBox
            // 
            this.ArtistBox.Location = new System.Drawing.Point(133, 65);
            this.ArtistBox.Name = "ArtistBox";
            this.ArtistBox.Size = new System.Drawing.Size(100, 20);
            this.ArtistBox.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "All The Context Is True";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Submit
            // 
            this.Submit.Enabled = false;
            this.Submit.Location = new System.Drawing.Point(202, 109);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(109, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // MainWindform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ArtistBox);
            this.Controls.Add(this.MyFavouriteArtist);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.OpenNextForm);
            this.Controls.Add(this.Name);
            this.Text = "MainWindform";
            this.Load += new System.EventHandler(this.MainWindform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button OpenNextForm;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label MyFavouriteArtist;
        private System.Windows.Forms.TextBox ArtistBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Submit;
    }
}

