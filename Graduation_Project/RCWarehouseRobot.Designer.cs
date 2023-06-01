
namespace Graduation_Project
{
    partial class RCWarehouseRobot
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
            this.scanner_mode = new System.Windows.Forms.CheckBox();
            this.collisionPreventionToggle = new System.Windows.Forms.CheckBox();
            this.unloadedPwmRadioButton = new System.Windows.Forms.RadioButton();
            this.loadedPwmRadioButton = new System.Windows.Forms.RadioButton();
            this.superLoadedPwmRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.left_motor_line_speed_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.right_motor_line_speed_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.new_xServo_angle_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_yServo_angle_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_left_motor_pwm_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_right_motor_pwm_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // distance_textBox
            // 
            this.distance_textBox.Location = new System.Drawing.Point(342, 46);
            this.distance_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.distance_textBox.Name = "distance_textBox";
            this.distance_textBox.Size = new System.Drawing.Size(216, 26);
            this.distance_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ultrasonic sensor distance (cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ultrasonic sensor base H-angle (degree)";
            // 
            // xServo_angle_textBox
            // 
            this.xServo_angle_textBox.Location = new System.Drawing.Point(342, 81);
            this.xServo_angle_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xServo_angle_textBox.Name = "xServo_angle_textBox";
            this.xServo_angle_textBox.Size = new System.Drawing.Size(216, 26);
            this.xServo_angle_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ultrasonic sensor base V-angle (degree)";
            // 
            // yServo_angle_textBox
            // 
            this.yServo_angle_textBox.Location = new System.Drawing.Point(342, 116);
            this.yServo_angle_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yServo_angle_textBox.Name = "yServo_angle_textBox";
            this.yServo_angle_textBox.Size = new System.Drawing.Size(216, 26);
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
            this.label4.Location = new System.Drawing.Point(38, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Set ultrasonic sensor H-angle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Set ultrasonic sensor V-angle";
            // 
            // new_servo_angles_button
            // 
            this.new_servo_angles_button.Location = new System.Drawing.Point(147, 128);
            this.new_servo_angles_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.new_servo_angles_button.Name = "new_servo_angles_button";
            this.new_servo_angles_button.Size = new System.Drawing.Size(213, 35);
            this.new_servo_angles_button.TabIndex = 12;
            this.new_servo_angles_button.Text = "Submit";
            this.new_servo_angles_button.UseVisualStyleBackColor = true;
            this.new_servo_angles_button.Click += new System.EventHandler(this.new_servo_angles_button_Click);
            // 
            // new_xServo_angle_numericUpDown
            // 
            this.new_xServo_angle_numericUpDown.Location = new System.Drawing.Point(294, 39);
            this.new_xServo_angle_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.new_xServo_angle_numericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.new_xServo_angle_numericUpDown.Name = "new_xServo_angle_numericUpDown";
            this.new_xServo_angle_numericUpDown.Size = new System.Drawing.Size(135, 26);
            this.new_xServo_angle_numericUpDown.TabIndex = 13;
            this.new_xServo_angle_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_yServo_angle_numericUpDown
            // 
            this.new_yServo_angle_numericUpDown.Location = new System.Drawing.Point(294, 74);
            this.new_yServo_angle_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.new_yServo_angle_numericUpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.new_yServo_angle_numericUpDown.Name = "new_yServo_angle_numericUpDown";
            this.new_yServo_angle_numericUpDown.Size = new System.Drawing.Size(135, 26);
            this.new_yServo_angle_numericUpDown.TabIndex = 14;
            this.new_yServo_angle_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_left_motor_pwm_numericUpDown
            // 
            this.new_left_motor_pwm_numericUpDown.Location = new System.Drawing.Point(216, 71);
            this.new_left_motor_pwm_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.new_left_motor_pwm_numericUpDown.Size = new System.Drawing.Size(135, 26);
            this.new_left_motor_pwm_numericUpDown.TabIndex = 19;
            this.new_left_motor_pwm_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_right_motor_pwm_numericUpDown
            // 
            this.new_right_motor_pwm_numericUpDown.Location = new System.Drawing.Point(216, 36);
            this.new_right_motor_pwm_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.new_right_motor_pwm_numericUpDown.Size = new System.Drawing.Size(135, 26);
            this.new_right_motor_pwm_numericUpDown.TabIndex = 18;
            this.new_right_motor_pwm_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // new_wheel_motors_button
            // 
            this.new_wheel_motors_button.Location = new System.Drawing.Point(123, 125);
            this.new_wheel_motors_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.new_wheel_motors_button.Name = "new_wheel_motors_button";
            this.new_wheel_motors_button.Size = new System.Drawing.Size(213, 35);
            this.new_wheel_motors_button.TabIndex = 17;
            this.new_wheel_motors_button.Text = "Submit";
            this.new_wheel_motors_button.UseVisualStyleBackColor = true;
            this.new_wheel_motors_button.Click += new System.EventHandler(this.new_wheel_motors_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Set left motor PWM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Set right motor PWM";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1432, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "RC Warehouse Robot Control";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Left motor PWM";
            // 
            // left_motor_pwm_textBox
            // 
            this.left_motor_pwm_textBox.Location = new System.Drawing.Point(342, 186);
            this.left_motor_pwm_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.left_motor_pwm_textBox.Name = "left_motor_pwm_textBox";
            this.left_motor_pwm_textBox.Size = new System.Drawing.Size(216, 26);
            this.left_motor_pwm_textBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Right motor PWM";
            // 
            // right_motor_pwm_textBox
            // 
            this.right_motor_pwm_textBox.Location = new System.Drawing.Point(342, 151);
            this.right_motor_pwm_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.right_motor_pwm_textBox.Name = "right_motor_pwm_textBox";
            this.right_motor_pwm_textBox.Size = new System.Drawing.Size(216, 26);
            this.right_motor_pwm_textBox.TabIndex = 21;
            // 
            // Controller_toggle
            // 
            this.Controller_toggle.AutoSize = true;
            this.Controller_toggle.Location = new System.Drawing.Point(30, 42);
            this.Controller_toggle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Controller_toggle.Name = "Controller_toggle";
            this.Controller_toggle.Size = new System.Drawing.Size(152, 24);
            this.Controller_toggle.TabIndex = 26;
            this.Controller_toggle.Text = "Controller_mode";
            this.Controller_toggle.UseVisualStyleBackColor = true;
            this.Controller_toggle.CheckedChanged += new System.EventHandler(this.Controller_toggle_CheckedChanged);
            // 
            // scanner_mode
            // 
            this.scanner_mode.AutoSize = true;
            this.scanner_mode.Location = new System.Drawing.Point(33, 94);
            this.scanner_mode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scanner_mode.Name = "scanner_mode";
            this.scanner_mode.Size = new System.Drawing.Size(194, 24);
            this.scanner_mode.TabIndex = 29;
            this.scanner_mode.Text = "Servo_Scanner_mode";
            this.scanner_mode.UseVisualStyleBackColor = true;
            this.scanner_mode.CheckedChanged += new System.EventHandler(this.scanner_mode_CheckedChanged);
            // 
            // collisionPreventionToggle
            // 
            this.collisionPreventionToggle.AutoSize = true;
            this.collisionPreventionToggle.Location = new System.Drawing.Point(33, 45);
            this.collisionPreventionToggle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.collisionPreventionToggle.Name = "collisionPreventionToggle";
            this.collisionPreventionToggle.Size = new System.Drawing.Size(172, 24);
            this.collisionPreventionToggle.TabIndex = 30;
            this.collisionPreventionToggle.Text = "Collision Prevention";
            this.collisionPreventionToggle.UseVisualStyleBackColor = true;
            this.collisionPreventionToggle.CheckedChanged += new System.EventHandler(this.collisionPreventionToggle_CheckedChanged);
            // 
            // unloadedPwmRadioButton
            // 
            this.unloadedPwmRadioButton.AutoSize = true;
            this.unloadedPwmRadioButton.Location = new System.Drawing.Point(31, 47);
            this.unloadedPwmRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unloadedPwmRadioButton.Name = "unloadedPwmRadioButton";
            this.unloadedPwmRadioButton.Size = new System.Drawing.Size(208, 24);
            this.unloadedPwmRadioButton.TabIndex = 31;
            this.unloadedPwmRadioButton.TabStop = true;
            this.unloadedPwmRadioButton.Text = "Unloaded ( 0 - 3Kg) pwm";
            this.unloadedPwmRadioButton.UseVisualStyleBackColor = true;
            this.unloadedPwmRadioButton.CheckedChanged += new System.EventHandler(this.unloadedPwmRadioButton_CheckedChanged);
            // 
            // loadedPwmRadioButton
            // 
            this.loadedPwmRadioButton.AutoSize = true;
            this.loadedPwmRadioButton.Location = new System.Drawing.Point(31, 95);
            this.loadedPwmRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadedPwmRadioButton.Name = "loadedPwmRadioButton";
            this.loadedPwmRadioButton.Size = new System.Drawing.Size(197, 24);
            this.loadedPwmRadioButton.TabIndex = 32;
            this.loadedPwmRadioButton.TabStop = true;
            this.loadedPwmRadioButton.Text = "Loaded ( 3 - 6 Kg) pwm";
            this.loadedPwmRadioButton.UseVisualStyleBackColor = true;
            this.loadedPwmRadioButton.CheckedChanged += new System.EventHandler(this.loadedPwmRadioButton_CheckedChanged);
            // 
            // superLoadedPwmRadioButton
            // 
            this.superLoadedPwmRadioButton.AutoSize = true;
            this.superLoadedPwmRadioButton.Location = new System.Drawing.Point(31, 144);
            this.superLoadedPwmRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.superLoadedPwmRadioButton.Name = "superLoadedPwmRadioButton";
            this.superLoadedPwmRadioButton.Size = new System.Drawing.Size(245, 24);
            this.superLoadedPwmRadioButton.TabIndex = 33;
            this.superLoadedPwmRadioButton.TabStop = true;
            this.superLoadedPwmRadioButton.Text = "SuperLoaded ( 6 - 10Kg) pwm";
            this.superLoadedPwmRadioButton.UseVisualStyleBackColor = true;
            this.superLoadedPwmRadioButton.CheckedChanged += new System.EventHandler(this.superLoadedPwmRadioButton_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Left motor speed (lines/100ms)";
            // 
            // left_motor_line_speed_textBox
            // 
            this.left_motor_line_speed_textBox.Location = new System.Drawing.Point(339, 256);
            this.left_motor_line_speed_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.left_motor_line_speed_textBox.Name = "left_motor_line_speed_textBox";
            this.left_motor_line_speed_textBox.Size = new System.Drawing.Size(216, 26);
            this.left_motor_line_speed_textBox.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Right motor speed (lines/100ms)";
            // 
            // right_motor_line_speed_textBox
            // 
            this.right_motor_line_speed_textBox.Location = new System.Drawing.Point(339, 221);
            this.right_motor_line_speed_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.right_motor_line_speed_textBox.Name = "right_motor_line_speed_textBox";
            this.right_motor_line_speed_textBox.Size = new System.Drawing.Size(216, 26);
            this.right_motor_line_speed_textBox.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.distance_textBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.left_motor_line_speed_textBox);
            this.groupBox1.Controls.Add(this.xServo_angle_textBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.right_motor_line_speed_textBox);
            this.groupBox1.Controls.Add(this.yServo_angle_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.right_motor_pwm_textBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.left_motor_pwm_textBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(239, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 299);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Robot Sensors Monitor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.new_yServo_angle_numericUpDown);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.new_servo_angles_button);
            this.groupBox2.Controls.Add(this.new_xServo_angle_numericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(449, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 182);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ultrasonic base manual control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.new_wheel_motors_button);
            this.groupBox3.Controls.Add(this.new_right_motor_pwm_numericUpDown);
            this.groupBox3.Controls.Add(this.new_left_motor_pwm_numericUpDown);
            this.groupBox3.Location = new System.Drawing.Point(44, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 182);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motors manual control";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(48, 343);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1346, 383);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manual controls";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.unloadedPwmRadioButton);
            this.groupBox5.Controls.Add(this.loadedPwmRadioButton);
            this.groupBox5.Controls.Add(this.superLoadedPwmRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(30, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 199);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motor PWM modes";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.Controller_toggle);
            this.groupBox6.Location = new System.Drawing.Point(955, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(361, 323);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ASWD manual control";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.collisionPreventionToggle);
            this.groupBox7.Controls.Add(this.scanner_mode);
            this.groupBox7.Location = new System.Drawing.Point(877, 48);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(259, 158);
            this.groupBox7.TabIndex = 44;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Automatic controls";
            // 
            // RCWarehouseRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 768);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RCWarehouseRobot";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.new_xServo_angle_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_yServo_angle_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_left_motor_pwm_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_right_motor_pwm_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox scanner_mode;
        private System.Windows.Forms.CheckBox collisionPreventionToggle;
        private System.Windows.Forms.RadioButton unloadedPwmRadioButton;
        private System.Windows.Forms.RadioButton loadedPwmRadioButton;
        private System.Windows.Forms.RadioButton superLoadedPwmRadioButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox left_motor_line_speed_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox right_motor_line_speed_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

