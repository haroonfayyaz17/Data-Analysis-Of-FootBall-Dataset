namespace Prob_Lab_Football_
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.awayteamwinbtn = new System.Windows.Forms.Button();
            this.btnWinningPer = new System.Windows.Forms.Button();
            this.finalistpredictorbtn = new System.Windows.Forms.Button();
            this.groundpredictorbtn = new System.Windows.Forms.Button();
            this.winpredictorbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hometeamwinbtn = new System.Windows.Forms.Button();
            this.projectedbtn = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 94);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 73);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(181, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(828, 62);
            this.label2.TabIndex = 9;
            this.label2.Text = "Football Analysis System\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Calibri Light", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(0, 94);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1459, 590);
            this.listView1.TabIndex = 14;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // awayteamwinbtn
            // 
            this.awayteamwinbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.awayteamwinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.awayteamwinbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayteamwinbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.awayteamwinbtn.Location = new System.Drawing.Point(984, 229);
            this.awayteamwinbtn.Name = "awayteamwinbtn";
            this.awayteamwinbtn.Size = new System.Drawing.Size(396, 48);
            this.awayteamwinbtn.TabIndex = 30;
            this.awayteamwinbtn.Text = "W&inning Probability on Away Ground (Bar Chart)";
            this.awayteamwinbtn.UseVisualStyleBackColor = false;
            this.awayteamwinbtn.Click += new System.EventHandler(this.awayteamwinbtn_Click);
            // 
            // btnWinningPer
            // 
            this.btnWinningPer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnWinningPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWinningPer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWinningPer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWinningPer.Location = new System.Drawing.Point(984, 504);
            this.btnWinningPer.Name = "btnWinningPer";
            this.btnWinningPer.Size = new System.Drawing.Size(396, 51);
            this.btnWinningPer.TabIndex = 28;
            this.btnWinningPer.Text = "&Overall Interpretations";
            this.btnWinningPer.UseVisualStyleBackColor = false;
            this.btnWinningPer.Click += new System.EventHandler(this.btnWinningPer_Click);
            // 
            // finalistpredictorbtn
            // 
            this.finalistpredictorbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.finalistpredictorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finalistpredictorbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalistpredictorbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finalistpredictorbtn.Location = new System.Drawing.Point(61, 506);
            this.finalistpredictorbtn.Name = "finalistpredictorbtn";
            this.finalistpredictorbtn.Size = new System.Drawing.Size(333, 49);
            this.finalistpredictorbtn.TabIndex = 24;
            this.finalistpredictorbtn.Text = "&Yearly Interpretations";
            this.finalistpredictorbtn.UseVisualStyleBackColor = false;
            this.finalistpredictorbtn.Click += new System.EventHandler(this.finalistpredictorbtn_Click);
            // 
            // groundpredictorbtn
            // 
            this.groundpredictorbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groundpredictorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groundpredictorbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundpredictorbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groundpredictorbtn.Location = new System.Drawing.Point(984, 402);
            this.groundpredictorbtn.Name = "groundpredictorbtn";
            this.groundpredictorbtn.Size = new System.Drawing.Size(396, 56);
            this.groundpredictorbtn.TabIndex = 27;
            this.groundpredictorbtn.Text = "&Ground Prediction";
            this.groundpredictorbtn.UseVisualStyleBackColor = false;
            this.groundpredictorbtn.Click += new System.EventHandler(this.groundpredictorbtn_Click);
            // 
            // winpredictorbtn
            // 
            this.winpredictorbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.winpredictorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.winpredictorbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winpredictorbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winpredictorbtn.Location = new System.Drawing.Point(61, 226);
            this.winpredictorbtn.Name = "winpredictorbtn";
            this.winpredictorbtn.Size = new System.Drawing.Size(333, 51);
            this.winpredictorbtn.TabIndex = 26;
            this.winpredictorbtn.Text = "&Win Predictor";
            this.winpredictorbtn.UseVisualStyleBackColor = false;
            this.winpredictorbtn.Click += new System.EventHandler(this.winpredictorbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // hometeamwinbtn
            // 
            this.hometeamwinbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hometeamwinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hometeamwinbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometeamwinbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hometeamwinbtn.Location = new System.Drawing.Point(984, 327);
            this.hometeamwinbtn.Name = "hometeamwinbtn";
            this.hometeamwinbtn.Size = new System.Drawing.Size(396, 53);
            this.hometeamwinbtn.TabIndex = 23;
            this.hometeamwinbtn.Text = "&Hometeam Win%(Bar Graph)";
            this.hometeamwinbtn.UseVisualStyleBackColor = false;
            this.hometeamwinbtn.Click += new System.EventHandler(this.hometeamwinbtn_Click);
            // 
            // projectedbtn
            // 
            this.projectedbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.projectedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectedbtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectedbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projectedbtn.Location = new System.Drawing.Point(61, 350);
            this.projectedbtn.Name = "projectedbtn";
            this.projectedbtn.Size = new System.Drawing.Size(333, 52);
            this.projectedbtn.TabIndex = 22;
            this.projectedbtn.Text = "&Projected Score";
            this.projectedbtn.UseVisualStyleBackColor = false;
            this.projectedbtn.Click += new System.EventHandler(this.projectedbtn_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDateTime.Location = new System.Drawing.Point(515, 547);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 24);
            this.lblDateTime.TabIndex = 31;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(537, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 51);
            this.button1.TabIndex = 32;
            this.button1.Text = "&FIFA World Cup";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1459, 684);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.awayteamwinbtn);
            this.Controls.Add(this.btnWinningPer);
            this.Controls.Add(this.finalistpredictorbtn);
            this.Controls.Add(this.groundpredictorbtn);
            this.Controls.Add(this.winpredictorbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hometeamwinbtn);
            this.Controls.Add(this.projectedbtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calisto MT", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button awayteamwinbtn;
        private System.Windows.Forms.Button btnWinningPer;
        private System.Windows.Forms.Button finalistpredictorbtn;
        private System.Windows.Forms.Button groundpredictorbtn;
        private System.Windows.Forms.Button winpredictorbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hometeamwinbtn;
        private System.Windows.Forms.Button projectedbtn;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;

    }
}