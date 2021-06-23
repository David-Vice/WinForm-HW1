namespace WinForm_HW1
{
    partial class task5
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
            this.joke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joke
            // 
            this.joke.Location = new System.Drawing.Point(351, 204);
            this.joke.Name = "joke";
            this.joke.Size = new System.Drawing.Size(50, 50);
            this.joke.TabIndex = 0;
            this.joke.Text = "Joke";
            this.joke.UseVisualStyleBackColor = true;
            this.joke.MouseMove += new System.Windows.Forms.MouseEventHandler(this.joke_MouseMove);
            // 
            // task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.joke);
            this.Name = "task5";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button joke;
    }
}