namespace Robot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConnectArduino = new System.Windows.Forms.Button();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.SerCOM = new System.IO.Ports.SerialPort(this.components);
            this.trackBarTheta2 = new System.Windows.Forms.TrackBar();
            this.trackBarTheta3 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FKbutton = new System.Windows.Forms.Button();
            this.labeltheta3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labeltheta2 = new System.Windows.Forms.Label();
            this.labeltheta1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PosFKpz = new System.Windows.Forms.TextBox();
            this.PosFKpy = new System.Windows.Forms.TextBox();
            this.PosFKpx = new System.Windows.Forms.TextBox();
            this.FKtheta3 = new System.Windows.Forms.TextBox();
            this.FKtheta2 = new System.Windows.Forms.TextBox();
            this.FKtheta1 = new System.Windows.Forms.TextBox();
            this.SendForward = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarTheta1 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SendFirstSol = new System.Windows.Forms.Button();
            this.SendSecondSol = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Sol2theta3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Sol2theta2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Sol2theta1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Sol1theta3 = new System.Windows.Forms.TextBox();
            this.Sol1theta2 = new System.Windows.Forms.TextBox();
            this.Sol1theta1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.SendInverse = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AngIKtheta3 = new System.Windows.Forms.TextBox();
            this.AngIKtheta2 = new System.Windows.Forms.TextBox();
            this.AngIKtheta1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IKPz = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IKPy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IKPx = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IntroBtn = new System.Windows.Forms.Button();
            this.ServoText = new System.Windows.Forms.TextBox();
            this.ServoBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.trackBarServo = new System.Windows.Forms.TrackBar();
            this.SvSlideText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheta3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheta1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectArduino
            // 
            this.ConnectArduino.Location = new System.Drawing.Point(124, 81);
            this.ConnectArduino.Name = "ConnectArduino";
            this.ConnectArduino.Size = new System.Drawing.Size(104, 30);
            this.ConnectArduino.TabIndex = 2;
            this.ConnectArduino.Text = "Connect";
            this.ConnectArduino.UseVisualStyleBackColor = true;
            this.ConnectArduino.Click += new System.EventHandler(this.ConnectArduino_Click);
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(239, 40);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(82, 27);
            this.PortBox.TabIndex = 3;
            this.PortBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            // 
            // trackBarTheta2
            // 
            this.trackBarTheta2.Location = new System.Drawing.Point(82, 81);
            this.trackBarTheta2.Maximum = 90;
            this.trackBarTheta2.Minimum = -45;
            this.trackBarTheta2.Name = "trackBarTheta2";
            this.trackBarTheta2.Size = new System.Drawing.Size(261, 45);
            this.trackBarTheta2.TabIndex = 4;
            this.trackBarTheta2.TickFrequency = 10;
            this.trackBarTheta2.Scroll += new System.EventHandler(this.trackBarTheta2_Scroll);
            // 
            // trackBarTheta3
            // 
            this.trackBarTheta3.Location = new System.Drawing.Point(82, 132);
            this.trackBarTheta3.Maximum = 90;
            this.trackBarTheta3.Minimum = -90;
            this.trackBarTheta3.Name = "trackBarTheta3";
            this.trackBarTheta3.Size = new System.Drawing.Size(261, 45);
            this.trackBarTheta3.TabIndex = 4;
            this.trackBarTheta3.TickFrequency = 10;
            this.trackBarTheta3.Scroll += new System.EventHandler(this.trackBarTheta3_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.FKbutton);
            this.groupBox1.Controls.Add(this.labeltheta3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labeltheta2);
            this.groupBox1.Controls.Add(this.labeltheta1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.FKtheta3);
            this.groupBox1.Controls.Add(this.FKtheta2);
            this.groupBox1.Controls.Add(this.FKtheta1);
            this.groupBox1.Controls.Add(this.SendForward);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBarTheta3);
            this.groupBox1.Controls.Add(this.trackBarTheta1);
            this.groupBox1.Controls.Add(this.trackBarTheta2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 337);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forward kinematics";
            // 
            // FKbutton
            // 
            this.FKbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FKbutton.Location = new System.Drawing.Point(375, 243);
            this.FKbutton.Name = "FKbutton";
            this.FKbutton.Size = new System.Drawing.Size(137, 34);
            this.FKbutton.TabIndex = 15;
            this.FKbutton.Text = "Send from text";
            this.FKbutton.UseVisualStyleBackColor = false;
            this.FKbutton.Click += new System.EventHandler(this.FKbutton_Click);
            // 
            // labeltheta3
            // 
            this.labeltheta3.AutoSize = true;
            this.labeltheta3.Cursor = System.Windows.Forms.Cursors.Default;
            this.labeltheta3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltheta3.Location = new System.Drawing.Point(349, 142);
            this.labeltheta3.Name = "labeltheta3";
            this.labeltheta3.Size = new System.Drawing.Size(23, 26);
            this.labeltheta3.TabIndex = 14;
            this.labeltheta3.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(375, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeltheta2
            // 
            this.labeltheta2.AutoSize = true;
            this.labeltheta2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labeltheta2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltheta2.Location = new System.Drawing.Point(349, 91);
            this.labeltheta2.Name = "labeltheta2";
            this.labeltheta2.Size = new System.Drawing.Size(23, 26);
            this.labeltheta2.TabIndex = 14;
            this.labeltheta2.Text = "0";
            // 
            // labeltheta1
            // 
            this.labeltheta1.AutoSize = true;
            this.labeltheta1.Cursor = System.Windows.Forms.Cursors.Default;
            this.labeltheta1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltheta1.Location = new System.Drawing.Point(349, 40);
            this.labeltheta1.Name = "labeltheta1";
            this.labeltheta1.Size = new System.Drawing.Size(23, 26);
            this.labeltheta1.TabIndex = 14;
            this.labeltheta1.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.PosFKpz);
            this.groupBox3.Controls.Add(this.PosFKpy);
            this.groupBox3.Controls.Add(this.PosFKpx);
            this.groupBox3.Location = new System.Drawing.Point(6, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 135);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Positions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pz:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Py:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Px:";
            // 
            // PosFKpz
            // 
            this.PosFKpz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PosFKpz.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PosFKpz.Location = new System.Drawing.Point(233, 85);
            this.PosFKpz.Name = "PosFKpz";
            this.PosFKpz.Size = new System.Drawing.Size(104, 27);
            this.PosFKpz.TabIndex = 12;
            // 
            // PosFKpy
            // 
            this.PosFKpy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PosFKpy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PosFKpy.Location = new System.Drawing.Point(123, 85);
            this.PosFKpy.Name = "PosFKpy";
            this.PosFKpy.Size = new System.Drawing.Size(104, 27);
            this.PosFKpy.TabIndex = 12;
            // 
            // PosFKpx
            // 
            this.PosFKpx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PosFKpx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PosFKpx.Location = new System.Drawing.Point(13, 85);
            this.PosFKpx.Name = "PosFKpx";
            this.PosFKpx.Size = new System.Drawing.Size(104, 27);
            this.PosFKpx.TabIndex = 12;
            // 
            // FKtheta3
            // 
            this.FKtheta3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FKtheta3.Location = new System.Drawing.Point(412, 139);
            this.FKtheta3.Name = "FKtheta3";
            this.FKtheta3.Size = new System.Drawing.Size(100, 27);
            this.FKtheta3.TabIndex = 10;
            this.FKtheta3.TextChanged += new System.EventHandler(this.FKtheta3_TextChanged);
            // 
            // FKtheta2
            // 
            this.FKtheta2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FKtheta2.Location = new System.Drawing.Point(412, 88);
            this.FKtheta2.Name = "FKtheta2";
            this.FKtheta2.Size = new System.Drawing.Size(100, 27);
            this.FKtheta2.TabIndex = 10;
            this.FKtheta2.TextChanged += new System.EventHandler(this.FKtheta2_TextChanged);
            // 
            // FKtheta1
            // 
            this.FKtheta1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FKtheta1.Location = new System.Drawing.Point(412, 37);
            this.FKtheta1.Name = "FKtheta1";
            this.FKtheta1.Size = new System.Drawing.Size(100, 27);
            this.FKtheta1.TabIndex = 10;
            this.FKtheta1.TextChanged += new System.EventHandler(this.FKtheta1_TextChanged);
            // 
            // SendForward
            // 
            this.SendForward.BackColor = System.Drawing.Color.Lime;
            this.SendForward.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendForward.Location = new System.Drawing.Point(375, 193);
            this.SendForward.Name = "SendForward";
            this.SendForward.Size = new System.Drawing.Size(137, 34);
            this.SendForward.TabIndex = 9;
            this.SendForward.Text = "Send from slide";
            this.SendForward.UseVisualStyleBackColor = false;
            this.SendForward.Click += new System.EventHandler(this.SendManToArduino_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Theta3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Theta2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Theta1";
            // 
            // trackBarTheta1
            // 
            this.trackBarTheta1.Location = new System.Drawing.Point(82, 30);
            this.trackBarTheta1.Maximum = 90;
            this.trackBarTheta1.Minimum = -90;
            this.trackBarTheta1.Name = "trackBarTheta1";
            this.trackBarTheta1.Size = new System.Drawing.Size(261, 45);
            this.trackBarTheta1.TabIndex = 4;
            this.trackBarTheta1.TickFrequency = 10;
            this.trackBarTheta1.Scroll += new System.EventHandler(this.trackBarTheta1_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.ExitBtn);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.PortBox);
            this.groupBox2.Controls.Add(this.ConnectArduino);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(212, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 129);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(14, 81);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(104, 30);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(78, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 19);
            this.label19.TabIndex = 4;
            this.label19.Text = "Choose COM Port:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox4.Controls.Add(this.SendFirstSol);
            this.groupBox4.Controls.Add(this.SendSecondSol);
            this.groupBox4.Controls.Add(this.groupBox8);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.SendInverse);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.IKPz);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.IKPy);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.IKPx);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(551, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 588);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inverse kinematics";
            // 
            // SendFirstSol
            // 
            this.SendFirstSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SendFirstSol.Location = new System.Drawing.Point(25, 519);
            this.SendFirstSol.Name = "SendFirstSol";
            this.SendFirstSol.Size = new System.Drawing.Size(170, 34);
            this.SendFirstSol.TabIndex = 18;
            this.SendFirstSol.Text = "Send first solution";
            this.SendFirstSol.UseVisualStyleBackColor = false;
            this.SendFirstSol.Click += new System.EventHandler(this.SendFirstSol_Click);
            // 
            // SendSecondSol
            // 
            this.SendSecondSol.BackColor = System.Drawing.Color.Yellow;
            this.SendSecondSol.Location = new System.Drawing.Point(229, 522);
            this.SendSecondSol.Name = "SendSecondSol";
            this.SendSecondSol.Size = new System.Drawing.Size(170, 34);
            this.SendSecondSol.TabIndex = 18;
            this.SendSecondSol.Text = "Send second solution";
            this.SendSecondSol.UseVisualStyleBackColor = false;
            this.SendSecondSol.Click += new System.EventHandler(this.SendSecondSol_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox8.Controls.Add(this.Sol2theta3);
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.Sol2theta2);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.Sol2theta1);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Location = new System.Drawing.Point(215, 267);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(192, 228);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Solution2";
            // 
            // Sol2theta3
            // 
            this.Sol2theta3.Location = new System.Drawing.Point(84, 170);
            this.Sol2theta3.Name = "Sol2theta3";
            this.Sol2theta3.Size = new System.Drawing.Size(100, 27);
            this.Sol2theta3.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(9, 170);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 24);
            this.label24.TabIndex = 8;
            this.label24.Text = "Theta3";
            // 
            // Sol2theta2
            // 
            this.Sol2theta2.Location = new System.Drawing.Point(85, 108);
            this.Sol2theta2.Name = "Sol2theta2";
            this.Sol2theta2.Size = new System.Drawing.Size(100, 27);
            this.Sol2theta2.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(9, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 24);
            this.label22.TabIndex = 8;
            this.label22.Text = "Theta2";
            // 
            // Sol2theta1
            // 
            this.Sol2theta1.Location = new System.Drawing.Point(85, 46);
            this.Sol2theta1.Name = "Sol2theta1";
            this.Sol2theta1.Size = new System.Drawing.Size(100, 27);
            this.Sol2theta1.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(9, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 24);
            this.label23.TabIndex = 8;
            this.label23.Text = "Theta1";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox7.Controls.Add(this.Sol1theta3);
            this.groupBox7.Controls.Add(this.Sol1theta2);
            this.groupBox7.Controls.Add(this.Sol1theta1);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Location = new System.Drawing.Point(11, 267);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(198, 228);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Solution1";
            // 
            // Sol1theta3
            // 
            this.Sol1theta3.Location = new System.Drawing.Point(84, 170);
            this.Sol1theta3.Name = "Sol1theta3";
            this.Sol1theta3.Size = new System.Drawing.Size(100, 27);
            this.Sol1theta3.TabIndex = 9;
            // 
            // Sol1theta2
            // 
            this.Sol1theta2.Location = new System.Drawing.Point(85, 108);
            this.Sol1theta2.Name = "Sol1theta2";
            this.Sol1theta2.Size = new System.Drawing.Size(100, 27);
            this.Sol1theta2.TabIndex = 9;
            // 
            // Sol1theta1
            // 
            this.Sol1theta1.Location = new System.Drawing.Point(85, 46);
            this.Sol1theta1.Name = "Sol1theta1";
            this.Sol1theta1.Size = new System.Drawing.Size(100, 27);
            this.Sol1theta1.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 170);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 24);
            this.label21.TabIndex = 8;
            this.label21.Text = "Theta3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Theta1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 24);
            this.label20.TabIndex = 8;
            this.label20.Text = "Theta2";
            // 
            // SendInverse
            // 
            this.SendInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SendInverse.Location = new System.Drawing.Point(40, 196);
            this.SendInverse.Name = "SendInverse";
            this.SendInverse.Size = new System.Drawing.Size(137, 34);
            this.SendInverse.TabIndex = 15;
            this.SendInverse.Text = "Inverse";
            this.SendInverse.UseVisualStyleBackColor = false;
            this.SendInverse.Click += new System.EventHandler(this.SendInverse_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Lavender;
            this.groupBox5.Controls.Add(this.AngIKtheta3);
            this.groupBox5.Controls.Add(this.AngIKtheta2);
            this.groupBox5.Controls.Add(this.AngIKtheta1);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(202, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 198);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Angles";
            // 
            // AngIKtheta3
            // 
            this.AngIKtheta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AngIKtheta3.Location = new System.Drawing.Point(94, 144);
            this.AngIKtheta3.Name = "AngIKtheta3";
            this.AngIKtheta3.Size = new System.Drawing.Size(100, 27);
            this.AngIKtheta3.TabIndex = 9;
            // 
            // AngIKtheta2
            // 
            this.AngIKtheta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AngIKtheta2.Location = new System.Drawing.Point(94, 92);
            this.AngIKtheta2.Name = "AngIKtheta2";
            this.AngIKtheta2.Size = new System.Drawing.Size(100, 27);
            this.AngIKtheta2.TabIndex = 9;
            // 
            // AngIKtheta1
            // 
            this.AngIKtheta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AngIKtheta1.Location = new System.Drawing.Point(94, 37);
            this.AngIKtheta1.Name = "AngIKtheta1";
            this.AngIKtheta1.Size = new System.Drawing.Size(100, 27);
            this.AngIKtheta1.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "Theta2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "Theta1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 24);
            this.label14.TabIndex = 8;
            this.label14.Text = "Theta3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 26);
            this.label11.TabIndex = 13;
            this.label11.Text = "Pz:";
            // 
            // IKPz
            // 
            this.IKPz.Location = new System.Drawing.Point(78, 144);
            this.IKPz.Name = "IKPz";
            this.IKPz.Size = new System.Drawing.Size(92, 27);
            this.IKPz.TabIndex = 10;
            this.IKPz.TextChanged += new System.EventHandler(this.FKtheta3_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 26);
            this.label10.TabIndex = 13;
            this.label10.Text = "Py:";
            // 
            // IKPy
            // 
            this.IKPy.Location = new System.Drawing.Point(78, 96);
            this.IKPy.Name = "IKPy";
            this.IKPy.Size = new System.Drawing.Size(92, 27);
            this.IKPy.TabIndex = 10;
            this.IKPy.TextChanged += new System.EventHandler(this.FKtheta2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Px:";
            // 
            // IKPx
            // 
            this.IKPx.Location = new System.Drawing.Point(78, 48);
            this.IKPx.Name = "IKPx";
            this.IKPx.Size = new System.Drawing.Size(92, 27);
            this.IKPx.TabIndex = 10;
            this.IKPx.TextChanged += new System.EventHandler(this.FKtheta1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // IntroBtn
            // 
            this.IntroBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.IntroBtn.Font = new System.Drawing.Font("Arial", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntroBtn.Location = new System.Drawing.Point(212, 12);
            this.IntroBtn.Name = "IntroBtn";
            this.IntroBtn.Size = new System.Drawing.Size(760, 53);
            this.IntroBtn.TabIndex = 10;
            this.IntroBtn.Text = "HUMAN-MACHINE INTERFACE";
            this.IntroBtn.UseVisualStyleBackColor = false;
            this.IntroBtn.Click += new System.EventHandler(this.IntroBtn_Click);
            // 
            // ServoText
            // 
            this.ServoText.Location = new System.Drawing.Point(313, 51);
            this.ServoText.Name = "ServoText";
            this.ServoText.Size = new System.Drawing.Size(87, 27);
            this.ServoText.TabIndex = 11;
            // 
            // ServoBtn
            // 
            this.ServoBtn.Location = new System.Drawing.Point(416, 49);
            this.ServoBtn.Name = "ServoBtn";
            this.ServoBtn.Size = new System.Drawing.Size(96, 29);
            this.ServoBtn.TabIndex = 12;
            this.ServoBtn.Text = "Send";
            this.ServoBtn.UseVisualStyleBackColor = true;
            this.ServoBtn.Click += new System.EventHandler(this.ServoBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox6.Controls.Add(this.SvSlideText);
            this.groupBox6.Controls.Add(this.trackBarServo);
            this.groupBox6.Controls.Add(this.ServoBtn);
            this.groupBox6.Controls.Add(this.ServoText);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(13, 549);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(532, 110);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gripper control";
            // 
            // trackBarServo
            // 
            this.trackBarServo.BackColor = System.Drawing.Color.DarkSalmon;
            this.trackBarServo.Location = new System.Drawing.Point(30, 48);
            this.trackBarServo.Maximum = 60;
            this.trackBarServo.Name = "trackBarServo";
            this.trackBarServo.Size = new System.Drawing.Size(203, 45);
            this.trackBarServo.TabIndex = 13;
            this.trackBarServo.TickFrequency = 5;
            this.trackBarServo.Scroll += new System.EventHandler(this.trackBarServo_Scroll);
            // 
            // SvSlideText
            // 
            this.SvSlideText.AutoSize = true;
            this.SvSlideText.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SvSlideText.Location = new System.Drawing.Point(258, 49);
            this.SvSlideText.Name = "SvSlideText";
            this.SvSlideText.Size = new System.Drawing.Size(23, 26);
            this.SvSlideText.TabIndex = 14;
            this.SvSlideText.Text = "0";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(983, 671);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.IntroBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheta3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTheta1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarServo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectArduino;
        private System.Windows.Forms.ComboBox PortBox;
        private System.IO.Ports.SerialPort SerCOM;
        private System.Windows.Forms.TrackBar trackBarTheta2;
        private System.Windows.Forms.TrackBar trackBarTheta3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SendForward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarTheta1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FKtheta1;
        private System.Windows.Forms.TextBox FKtheta3;
        private System.Windows.Forms.TextBox FKtheta2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PosFKpz;
        private System.Windows.Forms.TextBox PosFKpy;
        private System.Windows.Forms.TextBox PosFKpx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IKPz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox IKPy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IKPx;
        private System.Windows.Forms.Button SendInverse;
        private System.Windows.Forms.Label labeltheta3;
        private System.Windows.Forms.Label labeltheta2;
        private System.Windows.Forms.Label labeltheta1;
        private System.Windows.Forms.Button FKbutton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox Sol2theta3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox Sol2theta2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Sol2theta1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox Sol1theta3;
        private System.Windows.Forms.TextBox Sol1theta2;
        private System.Windows.Forms.TextBox Sol1theta1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox AngIKtheta3;
        private System.Windows.Forms.TextBox AngIKtheta2;
        private System.Windows.Forms.TextBox AngIKtheta1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button SendFirstSol;
        private System.Windows.Forms.Button SendSecondSol;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button IntroBtn;
        private System.Windows.Forms.TextBox ServoText;
        private System.Windows.Forms.Button ServoBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label SvSlideText;
        private System.Windows.Forms.TrackBar trackBarServo;
    }
}

