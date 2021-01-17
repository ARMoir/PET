namespace PET
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
            this.components = new System.ComponentModel.Container();
            this.Display = new System.Windows.Forms.ListBox();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Feed = new System.Windows.Forms.Button();
            this.Clean = new System.Windows.Forms.Button();
            this.StatusBox = new System.Windows.Forms.ListBox();
            this.Medicine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.FormattingEnabled = true;
            this.Display.ItemHeight = 17;
            this.Display.Location = new System.Drawing.Point(16, 15);
            this.Display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(265, 174);
            this.Display.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.Enabled = true;
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Feed
            // 
            this.Feed.Location = new System.Drawing.Point(16, 275);
            this.Feed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(133, 31);
            this.Feed.TabIndex = 1;
            this.Feed.Text = "Feed";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(149, 275);
            this.Clean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(133, 31);
            this.Clean.TabIndex = 2;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.ItemHeight = 16;
            this.StatusBox.Location = new System.Drawing.Point(16, 199);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(265, 68);
            this.StatusBox.TabIndex = 3;
            // 
            // Medicine
            // 
            this.Medicine.Location = new System.Drawing.Point(16, 314);
            this.Medicine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(133, 31);
            this.Medicine.TabIndex = 4;
            this.Medicine.Text = "Medicine";
            this.Medicine.UseVisualStyleBackColor = true;
            this.Medicine.Click += new System.EventHandler(this.Medicine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 358);
            this.Controls.Add(this.Medicine);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.Display);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Display;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Button Feed;
        private System.Windows.Forms.Button Clean;
        private System.Windows.Forms.ListBox StatusBox;
        private System.Windows.Forms.Button Medicine;
    }
}

