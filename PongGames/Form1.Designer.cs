namespace PongGames
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
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Paddle1 = new System.Windows.Forms.PictureBox();
            this.Paddle2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.Pong = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = global::PongGames.Properties.Resources.bonbon;
            this.Ball.Location = new System.Drawing.Point(489, 269);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(37, 37);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // Paddle1
            // 
            this.Paddle1.BackColor = System.Drawing.Color.Red;
            this.Paddle1.Location = new System.Drawing.Point(30, 194);
            this.Paddle1.Name = "Paddle1";
            this.Paddle1.Size = new System.Drawing.Size(16, 170);
            this.Paddle1.TabIndex = 1;
            this.Paddle1.TabStop = false;
            // 
            // Paddle2
            // 
            this.Paddle2.BackColor = System.Drawing.Color.Red;
            this.Paddle2.Location = new System.Drawing.Point(970, 194);
            this.Paddle2.Name = "Paddle2";
            this.Paddle2.Size = new System.Drawing.Size(16, 170);
            this.Paddle2.TabIndex = 3;
            this.Paddle2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBox.Image = global::PongGames.Properties.Resources.cancel;
            this.CloseBox.Location = new System.Drawing.Point(984, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(32, 32);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseBox.TabIndex = 0;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            this.CloseBox.MouseLeave += new System.EventHandler(this.CloseBox_MouseLeave);
            this.CloseBox.MouseHover += new System.EventHandler(this.CloseBox_MouseHover);
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(5, 0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(32, 32);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            // 
            // Pong
            // 
            this.Pong.AutoSize = true;
            this.Pong.BackColor = System.Drawing.Color.Transparent;
            this.Pong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Pong.ForeColor = System.Drawing.Color.White;
            this.Pong.Location = new System.Drawing.Point(42, 6);
            this.Pong.Name = "Pong";
            this.Pong.Size = new System.Drawing.Size(50, 20);
            this.Pong.TabIndex = 2;
            this.Pong.Text = "Pong";
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(101)))), ((int)(((byte)(123)))));
            this.Panel.Controls.Add(this.label3);
            this.Panel.Controls.Add(this.score2);
            this.Panel.Controls.Add(this.score1);
            this.Panel.Controls.Add(this.Pong);
            this.Panel.Controls.Add(this.LogoBox);
            this.Panel.Controls.Add(this.CloseBox);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1016, 32);
            this.Panel.TabIndex = 0;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.element_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(483, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.element_MouseDown);
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.Color.Transparent;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score2.ForeColor = System.Drawing.Color.White;
            this.score2.Location = new System.Drawing.Point(503, 4);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(21, 24);
            this.score2.TabIndex = 4;
            this.score2.Text = "0";
            this.score2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.element_MouseDown);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score1.ForeColor = System.Drawing.Color.White;
            this.score1.Location = new System.Drawing.Point(466, 4);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(21, 24);
            this.score1.TabIndex = 3;
            this.score1.Text = "0";
            this.score1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.element_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1016, 538);
            this.Controls.Add(this.Paddle2);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Paddle1);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Paddle1;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Paddle2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label Pong;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score1;
    }
}

