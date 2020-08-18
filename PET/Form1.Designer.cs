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
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Enabled = false;
            this.Display.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.FormattingEnabled = true;
            this.Display.Location = new System.Drawing.Point(12, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(191, 147);
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
            this.Feed.Location = new System.Drawing.Point(13, 166);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(75, 23);
            this.Feed.TabIndex = 1;
            this.Feed.Text = "Feed";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 240);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Display;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Button Feed;
    }
}

