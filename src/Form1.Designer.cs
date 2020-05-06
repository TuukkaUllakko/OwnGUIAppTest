using System;

namespace src
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Tuukka's test app";
            //Text box 1 start
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox1.Text = "How's it going?";
            this.textBox1.ReadOnly = true;
            this.textBox1.Location = new System.Drawing.Point((this.Width - this.textBox1.Width) / 2, (this.Height - this.textBox1.Height) / 2);
            this.Controls.Add(this.textBox1);
            //Text box 1 end
            //Button 1 start
            this.button1 = new System.Windows.Forms.Button();
            this.button1.Text = "Boop!";
            this.button1.Click += new System.EventHandler(Boop);
            Controls.Add(this.button1);
        }

        //Button 1 function
        private void Boop(object sender, System.EventArgs eventArgs)
        {
            Random randomLocation = new Random();

            this.textBox1.Location = new System.Drawing.Point(randomLocation.Next(200, 300), randomLocation.Next(200,300));
        }

        #endregion
    }
}

