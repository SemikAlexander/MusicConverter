namespace MusicFromVideo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mp4FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mp3FilePath = new System.Windows.Forms.TextBox();
            this.saveMP3 = new System.Windows.Forms.Button();
            this.openMP4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mp4FilePath
            // 
            this.mp4FilePath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mp4FilePath.Location = new System.Drawing.Point(128, 12);
            this.mp4FilePath.Name = "mp4FilePath";
            this.mp4FilePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mp4FilePath.Size = new System.Drawing.Size(312, 22);
            this.mp4FilePath.TabIndex = 0;
            this.mp4FilePath.TextChanged += new System.EventHandler(this.mp4FilePath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path to video file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path to music file";
            // 
            // mp3FilePath
            // 
            this.mp3FilePath.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mp3FilePath.Location = new System.Drawing.Point(128, 40);
            this.mp3FilePath.Name = "mp3FilePath";
            this.mp3FilePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mp3FilePath.Size = new System.Drawing.Size(312, 22);
            this.mp3FilePath.TabIndex = 2;
            this.mp3FilePath.TextChanged += new System.EventHandler(this.mp3FilePath_TextChanged);
            // 
            // saveMP3
            // 
            this.saveMP3.Location = new System.Drawing.Point(446, 40);
            this.saveMP3.Name = "saveMP3";
            this.saveMP3.Size = new System.Drawing.Size(34, 22);
            this.saveMP3.TabIndex = 4;
            this.saveMP3.Text = "...";
            this.saveMP3.UseVisualStyleBackColor = true;
            this.saveMP3.Click += new System.EventHandler(this.saveMP3_Click);
            // 
            // openMP4
            // 
            this.openMP4.Location = new System.Drawing.Point(446, 12);
            this.openMP4.Name = "openMP4";
            this.openMP4.Size = new System.Drawing.Size(34, 22);
            this.openMP4.TabIndex = 5;
            this.openMP4.Text = "...";
            this.openMP4.UseVisualStyleBackColor = true;
            this.openMP4.Click += new System.EventHandler(this.openMP4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button1.Location = new System.Drawing.Point(116, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 114);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.openMP4);
            this.Controls.Add(this.saveMP3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mp3FilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mp4FilePath);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mp4FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mp3FilePath;
        private System.Windows.Forms.Button saveMP3;
        private System.Windows.Forms.Button openMP4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

