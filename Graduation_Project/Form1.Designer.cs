
namespace Graduation_Project
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
            this.distance_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xServo_angle_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yServo_angle_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // distance_textBox
            // 
            this.distance_textBox.Location = new System.Drawing.Point(124, 29);
            this.distance_textBox.Name = "distance_textBox";
            this.distance_textBox.Size = new System.Drawing.Size(192, 22);
            this.distance_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "xServo_angle";
            // 
            // xServo_angle_textBox
            // 
            this.xServo_angle_textBox.Location = new System.Drawing.Point(124, 57);
            this.xServo_angle_textBox.Name = "xServo_angle_textBox";
            this.xServo_angle_textBox.Size = new System.Drawing.Size(192, 22);
            this.xServo_angle_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "yServo_angle";
            // 
            // yServo_angle_textBox
            // 
            this.yServo_angle_textBox.Location = new System.Drawing.Point(124, 85);
            this.yServo_angle_textBox.Name = "yServo_angle_textBox";
            this.yServo_angle_textBox.Size = new System.Drawing.Size(192, 22);
            this.yServo_angle_textBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yServo_angle_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xServo_angle_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distance_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox distance_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xServo_angle_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yServo_angle_textBox;
    }
}

