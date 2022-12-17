
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
            this.components = new System.ComponentModel.Container();
            this.distance_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xServo_angle_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yServo_angle_textBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.new_servo_angles_button = new System.Windows.Forms.Button();
            this.new_xServo_angle_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_yServo_angle_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_left_motor_pwm_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_right_motor_pwm_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.new_wheel_motors_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.left_motor_pwm_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.right_motor_pwm_textBox = new System.Windows.Forms.TextBox();
            this.Controller_toggle = new System.Windows.Forms.CheckBox();
            this.Right_wheel_value = new System.Windows.Forms.Label();
            this.Left_wheel_value = new System.Windows.Forms.Label();
            this.scanner_mode = new System.Windows.Forms.CheckBox();
            this.collisionPreventionToggle = new System.Windows.Forms.CheckBox();
            this.unloadedPwmRadioButton = new System.Windows.Forms.RadioButton();
            this.loadedPwmRadioButton = new System.Windows.Forms.RadioButton();
            this.superLoadedPwmRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.left_motor_line_speed_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.right_motor_line_speed_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.new_xServo_angle_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_yServo_angle_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_left_motor_pwm_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_right_motor_pwm_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // distance_textBox
            // 
            this.distance_textBox.Location = new System.Drawing.Point(161, 49);
            this.distance_textBox.Name = "distance_textBox";
            this.distance_textBox.Size = new System.Drawing.Size(192, 22);
            this.distance_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "xServo_angle";
            // 
            // xServo_angle_textBox
            // 
            this.xServo_angle_textBox.Location = new System.Drawing.Point(161, 77);
            this.xServo_angle_textBox.Name = "xServo_angle_textBox";
            this.xServo_angle_textBox.Size = new System.Drawing.Size(192, 22);
            this.xServo_angle_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "yServo_angle";
            // 
            // yServo_angle_textBox
            // 
            this.yServo_angle_textBox.Location = new System.Drawing.Point(161, 105);
            this.yServo_angle_textBox.Name = "yServo_angle_textBox";
            this.yServo_angle_textBox.Size = new System.Drawing.Size(192, 22);
            this.yServo_angle_textBox.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "new_xServo_angle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "new_yServo_angle";
            // 
            // new_servo_angles_button
            // 
            this.new_servo_angles_button.Location = new System.Drawing.Point(403, 328);
            this.new_servo_angles_button.Name = "new_servo_angles_button";
            this.new_servo_angles_button.Size = new System.Drawing.Size(189, 28);
            this.new_servo_angles_button.TabIndex = 12;
            this.new_servo_angles_button.Text = "Submit";
            this.new_servo_angles_button.UseVisualStyleBackColor = true;
            this.new_servo_angles_button.Click += new System.EventHandler(this.new_servo_angles_button_Click);
            // 
            // new_xServo_angle_numericUpDown
            // 
            this.new_xServo_angle_numericUpDown.Location = new System.Drawing.Point(533, 255);
            this.new_xServo_angle_numericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.new_xServo_angle_numericUpDown.Name = "new_xServo_angle_numericUpDown";
            this.new_xServo_angle_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_xServo_angle_numericUpDown.TabIndex = 13;
            this.new_xServo_angle_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_yServo_angle_numericUpDown
            // 
            this.new_yServo_angle_numericUpDown.Location = new System.Drawing.Point(533, 283);
            this.new_yServo_angle_numericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.new_yServo_angle_numericUpDown.Name = "new_yServo_angle_numericUpDown";
            this.new_yServo_angle_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_yServo_angle_numericUpDown.TabIndex = 14;
            this.new_yServo_angle_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_left_motor_pwm_numericUpDown
            // 
            this.new_left_motor_pwm_numericUpDown.Location = new System.Drawing.Point(244, 285);
            this.new_left_motor_pwm_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.new_left_motor_pwm_numericUpDown.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.new_left_motor_pwm_numericUpDown.Name = "new_left_motor_pwm_numericUpDown";
            this.new_left_motor_pwm_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_left_motor_pwm_numericUpDown.TabIndex = 19;
            this.new_left_motor_pwm_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_right_motor_pwm_numericUpDown
            // 
            this.new_right_motor_pwm_numericUpDown.Location = new System.Drawing.Point(244, 257);
            this.new_right_motor_pwm_numericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.new_right_motor_pwm_numericUpDown.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.new_right_motor_pwm_numericUpDown.Name = "new_right_motor_pwm_numericUpDown";
            this.new_right_motor_pwm_numericUpDown.Size = new System.Drawing.Size(120, 22);
            this.new_right_motor_pwm_numericUpDown.TabIndex = 18;
            this.new_right_motor_pwm_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_wheel_motors_button
            // 
            this.new_wheel_motors_button.Location = new System.Drawing.Point(161, 328);
            this.new_wheel_motors_button.Name = "new_wheel_motors_button";
            this.new_wheel_motors_button.Size = new System.Drawing.Size(189, 28);
            this.new_wheel_motors_button.TabIndex = 17;
            this.new_wheel_motors_button.Text = "Submit";
            this.new_wheel_motors_button.UseVisualStyleBackColor = true;
            this.new_wheel_motors_button.Click += new System.EventHandler(this.new_wheel_motors_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "new_left_motor_pwm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "new_right_motor_pwm";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(989, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Testing Form Window";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "left_motor_pwm";
            // 
            // left_motor_pwm_textBox
            // 
            this.left_motor_pwm_textBox.Location = new System.Drawing.Point(161, 161);
            this.left_motor_pwm_textBox.Name = "left_motor_pwm_textBox";
            this.left_motor_pwm_textBox.Size = new System.Drawing.Size(192, 22);
            this.left_motor_pwm_textBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "right_motor_pwm";
            // 
            // right_motor_pwm_textBox
            // 
            this.right_motor_pwm_textBox.Location = new System.Drawing.Point(161, 133);
            this.right_motor_pwm_textBox.Name = "right_motor_pwm_textBox";
            this.right_motor_pwm_textBox.Size = new System.Drawing.Size(192, 22);
            this.right_motor_pwm_textBox.TabIndex = 21;
            // 
            // Controller_toggle
            // 
            this.Controller_toggle.AutoSize = true;
            this.Controller_toggle.Location = new System.Drawing.Point(777, 45);
            this.Controller_toggle.Name = "Controller_toggle";
            this.Controller_toggle.Size = new System.Drawing.Size(134, 21);
            this.Controller_toggle.TabIndex = 26;
            this.Controller_toggle.Text = "Controller_mode";
            this.Controller_toggle.UseVisualStyleBackColor = true;
            this.Controller_toggle.CheckedChanged += new System.EventHandler(this.Controller_toggle_CheckedChanged);
            // 
            // Right_wheel_value
            // 
            this.Right_wheel_value.AutoSize = true;
            this.Right_wheel_value.Location = new System.Drawing.Point(705, 77);
            this.Right_wheel_value.Name = "Right_wheel_value";
            this.Right_wheel_value.Size = new System.Drawing.Size(127, 17);
            this.Right_wheel_value.TabIndex = 27;
            this.Right_wheel_value.Text = "Right_wheel_value";
            // 
            // Left_wheel_value
            // 
            this.Left_wheel_value.AutoSize = true;
            this.Left_wheel_value.Location = new System.Drawing.Point(859, 77);
            this.Left_wheel_value.Name = "Left_wheel_value";
            this.Left_wheel_value.Size = new System.Drawing.Size(118, 17);
            this.Left_wheel_value.TabIndex = 28;
            this.Left_wheel_value.Text = "Left_wheel_value";
            // 
            // scanner_mode
            // 
            this.scanner_mode.AutoSize = true;
            this.scanner_mode.Location = new System.Drawing.Point(751, 213);
            this.scanner_mode.Name = "scanner_mode";
            this.scanner_mode.Size = new System.Drawing.Size(171, 21);
            this.scanner_mode.TabIndex = 29;
            this.scanner_mode.Text = "Servo_Scanner_mode";
            this.scanner_mode.UseVisualStyleBackColor = true;
            this.scanner_mode.CheckedChanged += new System.EventHandler(this.scanner_mode_CheckedChanged);
            // 
            // collisionPreventionToggle
            // 
            this.collisionPreventionToggle.AutoSize = true;
            this.collisionPreventionToggle.Location = new System.Drawing.Point(768, 129);
            this.collisionPreventionToggle.Name = "collisionPreventionToggle";
            this.collisionPreventionToggle.Size = new System.Drawing.Size(154, 21);
            this.collisionPreventionToggle.TabIndex = 30;
            this.collisionPreventionToggle.Text = "Collision Prevention";
            this.collisionPreventionToggle.UseVisualStyleBackColor = true;
            this.collisionPreventionToggle.CheckedChanged += new System.EventHandler(this.collisionPreventionToggle_CheckedChanged);
            // 
            // unloadedPwmRadioButton
            // 
            this.unloadedPwmRadioButton.AutoSize = true;
            this.unloadedPwmRadioButton.Location = new System.Drawing.Point(403, 52);
            this.unloadedPwmRadioButton.Name = "unloadedPwmRadioButton";
            this.unloadedPwmRadioButton.Size = new System.Drawing.Size(186, 21);
            this.unloadedPwmRadioButton.TabIndex = 31;
            this.unloadedPwmRadioButton.TabStop = true;
            this.unloadedPwmRadioButton.Text = "Unloaded ( 0 - 3Kg) pwm";
            this.unloadedPwmRadioButton.UseVisualStyleBackColor = true;
            this.unloadedPwmRadioButton.CheckedChanged += new System.EventHandler(this.unloadedPwmRadioButton_CheckedChanged);
            // 
            // loadedPwmRadioButton
            // 
            this.loadedPwmRadioButton.AutoSize = true;
            this.loadedPwmRadioButton.Location = new System.Drawing.Point(403, 79);
            this.loadedPwmRadioButton.Name = "loadedPwmRadioButton";
            this.loadedPwmRadioButton.Size = new System.Drawing.Size(177, 21);
            this.loadedPwmRadioButton.TabIndex = 32;
            this.loadedPwmRadioButton.TabStop = true;
            this.loadedPwmRadioButton.Text = "Loaded ( 3 - 6 Kg) pwm";
            this.loadedPwmRadioButton.UseVisualStyleBackColor = true;
            this.loadedPwmRadioButton.CheckedChanged += new System.EventHandler(this.loadedPwmRadioButton_CheckedChanged);
            // 
            // superLoadedPwmRadioButton
            // 
            this.superLoadedPwmRadioButton.AutoSize = true;
            this.superLoadedPwmRadioButton.Location = new System.Drawing.Point(403, 106);
            this.superLoadedPwmRadioButton.Name = "superLoadedPwmRadioButton";
            this.superLoadedPwmRadioButton.Size = new System.Drawing.Size(219, 21);
            this.superLoadedPwmRadioButton.TabIndex = 33;
            this.superLoadedPwmRadioButton.TabStop = true;
            this.superLoadedPwmRadioButton.Text = "SuperLoaded ( 6 - 10Kg) pwm";
            this.superLoadedPwmRadioButton.UseVisualStyleBackColor = true;
            this.superLoadedPwmRadioButton.CheckedChanged += new System.EventHandler(this.superLoadedPwmRadioButton_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "left_motor_line_speed";
            // 
            // left_motor_line_speed_textBox
            // 
            this.left_motor_line_speed_textBox.Location = new System.Drawing.Point(158, 217);
            this.left_motor_line_speed_textBox.Name = "left_motor_line_speed_textBox";
            this.left_motor_line_speed_textBox.Size = new System.Drawing.Size(192, 22);
            this.left_motor_line_speed_textBox.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "right_motor_line_speed";
            // 
            // right_motor_line_speed_textBox
            // 
            this.right_motor_line_speed_textBox.Location = new System.Drawing.Point(158, 189);
            this.right_motor_line_speed_textBox.Name = "right_motor_line_speed_textBox";
            this.right_motor_line_speed_textBox.Size = new System.Drawing.Size(192, 22);
            this.right_motor_line_speed_textBox.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.left_motor_line_speed_textBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.right_motor_line_speed_textBox);
            this.Controls.Add(this.superLoadedPwmRadioButton);
            this.Controls.Add(this.loadedPwmRadioButton);
            this.Controls.Add(this.unloadedPwmRadioButton);
            this.Controls.Add(this.collisionPreventionToggle);
            this.Controls.Add(this.scanner_mode);
            this.Controls.Add(this.Left_wheel_value);
            this.Controls.Add(this.Right_wheel_value);
            this.Controls.Add(this.Controller_toggle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.left_motor_pwm_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.right_motor_pwm_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.new_left_motor_pwm_numericUpDown);
            this.Controls.Add(this.new_right_motor_pwm_numericUpDown);
            this.Controls.Add(this.new_wheel_motors_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.new_yServo_angle_numericUpDown);
            this.Controls.Add(this.new_xServo_angle_numericUpDown);
            this.Controls.Add(this.new_servo_angles_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yServo_angle_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xServo_angle_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distance_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.new_xServo_angle_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_yServo_angle_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_left_motor_pwm_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_right_motor_pwm_numericUpDown)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button new_servo_angles_button;
        private System.Windows.Forms.NumericUpDown new_xServo_angle_numericUpDown;
        private System.Windows.Forms.NumericUpDown new_yServo_angle_numericUpDown;
        private System.Windows.Forms.NumericUpDown new_left_motor_pwm_numericUpDown;
        private System.Windows.Forms.NumericUpDown new_right_motor_pwm_numericUpDown;
        private System.Windows.Forms.Button new_wheel_motors_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox left_motor_pwm_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox right_motor_pwm_textBox;
        private System.Windows.Forms.CheckBox Controller_toggle;
        private System.Windows.Forms.Label Right_wheel_value;
        private System.Windows.Forms.Label Left_wheel_value;
        private System.Windows.Forms.CheckBox scanner_mode;
        private System.Windows.Forms.CheckBox collisionPreventionToggle;
        private System.Windows.Forms.RadioButton unloadedPwmRadioButton;
        private System.Windows.Forms.RadioButton loadedPwmRadioButton;
        private System.Windows.Forms.RadioButton superLoadedPwmRadioButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox left_motor_line_speed_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox right_motor_line_speed_textBox;
    }
}

