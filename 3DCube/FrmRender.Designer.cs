namespace _DCubeNoGimbalLock
{
    partial class FrmRender
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tX = new System.Windows.Forms.TrackBar();
            this.tY = new System.Windows.Forms.TrackBar();
            this.tZ = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.chFront = new System.Windows.Forms.CheckBox();
            this.gFilling = new System.Windows.Forms.GroupBox();
            this.chWires = new System.Windows.Forms.CheckBox();
            this.chBottom = new System.Windows.Forms.CheckBox();
            this.chTop = new System.Windows.Forms.CheckBox();
            this.chRight = new System.Windows.Forms.CheckBox();
            this.chBack = new System.Windows.Forms.CheckBox();
            this.chLeft = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).BeginInit();
            this.gFilling.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z:";
            // 
            // tX
            // 
            this.tX.AutoSize = false;
            this.tX.Location = new System.Drawing.Point(37, 31);
            this.tX.Maximum = 360;
            this.tX.Minimum = -360;
            this.tX.Name = "tX";
            this.tX.Size = new System.Drawing.Size(165, 19);
            this.tX.TabIndex = 10;
            this.tX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tX.Scroll += new System.EventHandler(this.tX_Scroll);
            // 
            // tY
            // 
            this.tY.AutoSize = false;
            this.tY.Location = new System.Drawing.Point(37, 56);
            this.tY.Maximum = 360;
            this.tY.Minimum = -360;
            this.tY.Name = "tY";
            this.tY.Size = new System.Drawing.Size(165, 19);
            this.tY.TabIndex = 11;
            this.tY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tY.Value = 50;
            this.tY.Scroll += new System.EventHandler(this.tY_Scroll);
            // 
            // tZ
            // 
            this.tZ.AutoSize = false;
            this.tZ.Location = new System.Drawing.Point(37, 81);
            this.tZ.Maximum = 360;
            this.tZ.Minimum = -360;
            this.tZ.Name = "tZ";
            this.tZ.Size = new System.Drawing.Size(165, 19);
            this.tZ.TabIndex = 12;
            this.tZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tZ.Scroll += new System.EventHandler(this.tZ_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(116, 131);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 30);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chFront
            // 
            this.chFront.AutoSize = true;
            this.chFront.Location = new System.Drawing.Point(16, 54);
            this.chFront.Name = "chFront";
            this.chFront.Size = new System.Drawing.Size(53, 17);
            this.chFront.TabIndex = 15;
            this.chFront.Text = "Przód";
            this.chFront.UseVisualStyleBackColor = true;
            this.chFront.CheckedChanged += new System.EventHandler(this.chFront_CheckedChanged);
            // 
            // gFilling
            // 
            this.gFilling.Controls.Add(this.chWires);
            this.gFilling.Controls.Add(this.chBottom);
            this.gFilling.Controls.Add(this.chTop);
            this.gFilling.Controls.Add(this.chRight);
            this.gFilling.Controls.Add(this.chBack);
            this.gFilling.Controls.Add(this.chLeft);
            this.gFilling.Controls.Add(this.chFront);
            this.gFilling.Location = new System.Drawing.Point(233, 19);
            this.gFilling.Name = "gFilling";
            this.gFilling.Size = new System.Drawing.Size(131, 179);
            this.gFilling.TabIndex = 16;
            this.gFilling.TabStop = false;
            this.gFilling.Text = "Wype³nienie";
            // 
            // chWires
            // 
            this.chWires.AutoSize = true;
            this.chWires.Checked = true;
            this.chWires.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chWires.Location = new System.Drawing.Point(16, 16);
            this.chWires.Name = "chWires";
            this.chWires.Size = new System.Drawing.Size(75, 17);
            this.chWires.TabIndex = 21;
            this.chWires.Text = "Krawêdzie";
            this.chWires.UseVisualStyleBackColor = true;
            this.chWires.CheckedChanged += new System.EventHandler(this.chWires_CheckedChanged);
            // 
            // chBottom
            // 
            this.chBottom.AutoSize = true;
            this.chBottom.Location = new System.Drawing.Point(16, 139);
            this.chBottom.Name = "chBottom";
            this.chBottom.Size = new System.Drawing.Size(73, 17);
            this.chBottom.TabIndex = 20;
            this.chBottom.Text = "Podstawa";
            this.chBottom.UseVisualStyleBackColor = true;
            this.chBottom.CheckedChanged += new System.EventHandler(this.chBottom_CheckedChanged);
            // 
            // chTop
            // 
            this.chTop.AutoSize = true;
            this.chTop.Location = new System.Drawing.Point(16, 122);
            this.chTop.Name = "chTop";
            this.chTop.Size = new System.Drawing.Size(49, 17);
            this.chTop.TabIndex = 19;
            this.chTop.Text = "Góra";
            this.chTop.UseVisualStyleBackColor = true;
            this.chTop.CheckedChanged += new System.EventHandler(this.chTop_CheckedChanged);
            // 
            // chRight
            // 
            this.chRight.AutoSize = true;
            this.chRight.Location = new System.Drawing.Point(16, 105);
            this.chRight.Name = "chRight";
            this.chRight.Size = new System.Drawing.Size(56, 17);
            this.chRight.TabIndex = 18;
            this.chRight.Text = "Prawo";
            this.chRight.UseVisualStyleBackColor = true;
            this.chRight.CheckedChanged += new System.EventHandler(this.chRight_CheckedChanged);
            // 
            // chBack
            // 
            this.chBack.AutoSize = true;
            this.chBack.Location = new System.Drawing.Point(16, 71);
            this.chBack.Name = "chBack";
            this.chBack.Size = new System.Drawing.Size(42, 17);
            this.chBack.TabIndex = 16;
            this.chBack.Text = "Ty³";
            this.chBack.UseVisualStyleBackColor = true;
            this.chBack.CheckedChanged += new System.EventHandler(this.chBack_CheckedChanged);
            // 
            // chLeft
            // 
            this.chLeft.AutoSize = true;
            this.chLeft.Location = new System.Drawing.Point(16, 88);
            this.chLeft.Name = "chLeft";
            this.chLeft.Size = new System.Drawing.Size(52, 17);
            this.chLeft.TabIndex = 17;
            this.chLeft.Text = "Lewo";
            this.chLeft.UseVisualStyleBackColor = true;
            this.chLeft.CheckedChanged += new System.EventHandler(this.chLeft_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 179);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bry³a";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rysuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "400";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Szerokoœæ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "200";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Wysokoœæ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "300";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "D³ugoœæ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.gFilling);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(994, 209);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(788, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 179);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "O obiekcie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pole ca³kowite:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Pole podstawy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Objêtoœæ:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Location = new System.Drawing.Point(646, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 179);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zoom";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(67, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(31, 16);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(30, 157);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tX);
            this.groupBox3.Controls.Add(this.tY);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tZ);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Location = new System.Drawing.Point(388, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 179);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orientacja";
            // 
            // FrmRender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(994, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FrmRender";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Visualizacja prosopad³oœcianu. GDI+";
            this.Load += new System.EventHandler(this.FrmRender_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tZ)).EndInit();
            this.gFilling.ResumeLayout(false);
            this.gFilling.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tX;
        private System.Windows.Forms.TrackBar tY;
        private System.Windows.Forms.TrackBar tZ;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox chFront;
        private System.Windows.Forms.GroupBox gFilling;
        private System.Windows.Forms.CheckBox chBottom;
        private System.Windows.Forms.CheckBox chTop;
        private System.Windows.Forms.CheckBox chRight;
        private System.Windows.Forms.CheckBox chBack;
        private System.Windows.Forms.CheckBox chLeft;
        private System.Windows.Forms.CheckBox chWires;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
    }
}

