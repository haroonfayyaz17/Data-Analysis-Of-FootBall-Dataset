namespace Prob_Lab_Football_
{
    partial class ProjectedScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectedScore));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SingleTeamTab = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.cmbGoals = new System.Windows.Forms.ComboBox();
            this.cmbTeamB = new System.Windows.Forms.ComboBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.cmbTeamA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AllTeamsTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.cmbGoals1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridGoals = new System.Windows.Forms.DataGridView();
            this.ColOpponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SingleTeamGoals = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.lblGoals = new System.Windows.Forms.Label();
            this.cmbTeamBPG = new System.Windows.Forms.ComboBox();
            this.btnGetPG = new System.Windows.Forms.Button();
            this.cmbTeamAPG = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AllTeamGoals = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDisplayPG = new System.Windows.Forms.Button();
            this.GridPG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTeamPG = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SingleTeamTab.SuspendLayout();
            this.AllTeamsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoals)).BeginInit();
            this.SingleTeamGoals.SuspendLayout();
            this.AllTeamGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPG)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SingleTeamTab);
            this.tabControl1.Controls.Add(this.AllTeamsTab);
            this.tabControl1.Controls.Add(this.SingleTeamGoals);
            this.tabControl1.Controls.Add(this.AllTeamGoals);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Gabriola", 13.824F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1305, 723);
            this.tabControl1.TabIndex = 9;
            // 
            // SingleTeamTab
            // 
            this.SingleTeamTab.BackColor = System.Drawing.SystemColors.Info;
            this.SingleTeamTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SingleTeamTab.BackgroundImage")));
            this.SingleTeamTab.Controls.Add(this.btnBack);
            this.SingleTeamTab.Controls.Add(this.label8);
            this.SingleTeamTab.Controls.Add(this.lblValue);
            this.SingleTeamTab.Controls.Add(this.cmbGoals);
            this.SingleTeamTab.Controls.Add(this.cmbTeamB);
            this.SingleTeamTab.Controls.Add(this.btnGet);
            this.SingleTeamTab.Controls.Add(this.cmbTeamA);
            this.SingleTeamTab.Controls.Add(this.label5);
            this.SingleTeamTab.Controls.Add(this.label6);
            this.SingleTeamTab.Controls.Add(this.label7);
            this.SingleTeamTab.Font = new System.Drawing.Font("Calisto MT", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleTeamTab.Location = new System.Drawing.Point(4, 54);
            this.SingleTeamTab.Name = "SingleTeamTab";
            this.SingleTeamTab.Padding = new System.Windows.Forms.Padding(3);
            this.SingleTeamTab.Size = new System.Drawing.Size(1297, 665);
            this.SingleTeamTab.TabIndex = 0;
            this.SingleTeamTab.Text = "Probabiltiy of Goals Against Any Team";
            this.SingleTeamTab.Click += new System.EventHandler(this.SingleTeamTab_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(1098, 521);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 52);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Gabriola", 26F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1291, 80);
            this.label8.TabIndex = 12;
            this.label8.Text = "Probabiltiy of Goals Against Any Team";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(346, 381);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 24);
            this.lblValue.TabIndex = 8;
            // 
            // cmbGoals
            // 
            this.cmbGoals.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGoals.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGoals.Font = new System.Drawing.Font("Perpetua Titling MT", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGoals.FormattingEnabled = true;
            this.cmbGoals.Location = new System.Drawing.Point(372, 409);
            this.cmbGoals.Name = "cmbGoals";
            this.cmbGoals.Size = new System.Drawing.Size(383, 27);
            this.cmbGoals.TabIndex = 11;
            this.cmbGoals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGoals_KeyPress);
            // 
            // cmbTeamB
            // 
            this.cmbTeamB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTeamB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamB.Font = new System.Drawing.Font("Perpetua Titling MT", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeamB.FormattingEnabled = true;
            this.cmbTeamB.Location = new System.Drawing.Point(372, 294);
            this.cmbTeamB.Name = "cmbTeamB";
            this.cmbTeamB.Size = new System.Drawing.Size(383, 27);
            this.cmbTeamB.TabIndex = 10;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.Green;
            this.btnGet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGet.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnGet.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGet.Location = new System.Drawing.Point(1098, 433);
            this.btnGet.Margin = new System.Windows.Forms.Padding(4);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(129, 50);
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "&Get";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // cmbTeamA
            // 
            this.cmbTeamA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTeamA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamA.Font = new System.Drawing.Font("Perpetua Titling MT", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeamA.FormattingEnabled = true;
            this.cmbTeamA.Location = new System.Drawing.Point(372, 198);
            this.cmbTeamA.Name = "cmbTeamA";
            this.cmbTeamA.Size = new System.Drawing.Size(383, 27);
            this.cmbTeamA.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(84, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of Goals";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(209, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "Team B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(207, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Team A";
            // 
            // AllTeamsTab
            // 
            this.AllTeamsTab.BackColor = System.Drawing.SystemColors.Info;
            this.AllTeamsTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllTeamsTab.BackgroundImage")));
            this.AllTeamsTab.Controls.Add(this.button1);
            this.AllTeamsTab.Controls.Add(this.btnDisplay);
            this.AllTeamsTab.Controls.Add(this.cmbGoals1);
            this.AllTeamsTab.Controls.Add(this.label3);
            this.AllTeamsTab.Controls.Add(this.gridGoals);
            this.AllTeamsTab.Controls.Add(this.label2);
            this.AllTeamsTab.Controls.Add(this.cmbTeams);
            this.AllTeamsTab.Controls.Add(this.label1);
            this.AllTeamsTab.Font = new System.Drawing.Font("Calisto MT", 12.096F);
            this.AllTeamsTab.Location = new System.Drawing.Point(4, 54);
            this.AllTeamsTab.Name = "AllTeamsTab";
            this.AllTeamsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AllTeamsTab.Size = new System.Drawing.Size(1297, 665);
            this.AllTeamsTab.TabIndex = 1;
            this.AllTeamsTab.Text = "Probability of Goals Against All Teams";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1108, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "&Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Green;
            this.btnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplay.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisplay.Location = new System.Drawing.Point(1108, 192);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(144, 50);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // cmbGoals1
            // 
            this.cmbGoals1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGoals1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGoals1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGoals1.FormattingEnabled = true;
            this.cmbGoals1.Location = new System.Drawing.Point(478, 239);
            this.cmbGoals1.Name = "cmbGoals1";
            this.cmbGoals1.Size = new System.Drawing.Size(383, 27);
            this.cmbGoals1.TabIndex = 2;
            this.cmbGoals1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGoals_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(209, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Number of Goals";
            // 
            // gridGoals
            // 
            this.gridGoals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridGoals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridGoals.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.gridGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGoals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColOpponent,
            this.ColProbability});
            this.gridGoals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridGoals.Location = new System.Drawing.Point(3, 331);
            this.gridGoals.MultiSelect = false;
            this.gridGoals.Name = "gridGoals";
            this.gridGoals.ReadOnly = true;
            this.gridGoals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridGoals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridGoals.RowTemplate.Height = 24;
            this.gridGoals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridGoals.Size = new System.Drawing.Size(1291, 331);
            this.gridGoals.TabIndex = 14;
            this.gridGoals.TabStop = false;
            this.gridGoals.Visible = false;
            // 
            // ColOpponent
            // 
            this.ColOpponent.HeaderText = "Opponent";
            this.ColOpponent.Name = "ColOpponent";
            this.ColOpponent.ReadOnly = true;
            // 
            // ColProbability
            // 
            this.ColProbability.HeaderText = "Probability";
            this.ColProbability.Name = "ColProbability";
            this.ColProbability.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Gabriola", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1291, 84);
            this.label2.TabIndex = 13;
            this.label2.Text = "Probabiltiy of Goals Against All Teams";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTeams
            // 
            this.cmbTeams.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTeams.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeams.Font = new System.Drawing.Font("Perpetua Titling MT", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeams.FormattingEnabled = true;
            this.cmbTeams.Location = new System.Drawing.Point(478, 169);
            this.cmbTeams.Name = "cmbTeams";
            this.cmbTeams.Size = new System.Drawing.Size(383, 27);
            this.cmbTeams.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(360, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Team";
            // 
            // SingleTeamGoals
            // 
            this.SingleTeamGoals.BackColor = System.Drawing.SystemColors.Info;
            this.SingleTeamGoals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SingleTeamGoals.BackgroundImage")));
            this.SingleTeamGoals.Controls.Add(this.button2);
            this.SingleTeamGoals.Controls.Add(this.lblGoals);
            this.SingleTeamGoals.Controls.Add(this.cmbTeamBPG);
            this.SingleTeamGoals.Controls.Add(this.btnGetPG);
            this.SingleTeamGoals.Controls.Add(this.cmbTeamAPG);
            this.SingleTeamGoals.Controls.Add(this.label12);
            this.SingleTeamGoals.Controls.Add(this.label13);
            this.SingleTeamGoals.Controls.Add(this.label4);
            this.SingleTeamGoals.Font = new System.Drawing.Font("Calisto MT", 12.096F);
            this.SingleTeamGoals.Location = new System.Drawing.Point(4, 54);
            this.SingleTeamGoals.Name = "SingleTeamGoals";
            this.SingleTeamGoals.Size = new System.Drawing.Size(1297, 665);
            this.SingleTeamGoals.TabIndex = 2;
            this.SingleTeamGoals.Text = "Projected Goals Against Any Team";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(34, 387);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 52);
            this.button2.TabIndex = 21;
            this.button2.Text = "&Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.Location = new System.Drawing.Point(443, 389);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(0, 24);
            this.lblGoals.TabIndex = 17;
            // 
            // cmbTeamBPG
            // 
            this.cmbTeamBPG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTeamBPG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamBPG.Font = new System.Drawing.Font("Perpetua Titling MT", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeamBPG.FormattingEnabled = true;
            this.cmbTeamBPG.Location = new System.Drawing.Point(448, 247);
            this.cmbTeamBPG.Name = "cmbTeamBPG";
            this.cmbTeamBPG.Size = new System.Drawing.Size(383, 27);
            this.cmbTeamBPG.TabIndex = 20;
            // 
            // btnGetPG
            // 
            this.btnGetPG.BackColor = System.Drawing.Color.Green;
            this.btnGetPG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetPG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetPG.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnGetPG.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnGetPG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetPG.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetPG.Location = new System.Drawing.Point(1079, 389);
            this.btnGetPG.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetPG.Name = "btnGetPG";
            this.btnGetPG.Size = new System.Drawing.Size(129, 50);
            this.btnGetPG.TabIndex = 15;
            this.btnGetPG.Text = "&Get";
            this.btnGetPG.UseVisualStyleBackColor = false;
            this.btnGetPG.Click += new System.EventHandler(this.btnGetPG_Click);
            // 
            // cmbTeamAPG
            // 
            this.cmbTeamAPG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTeamAPG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamAPG.Font = new System.Drawing.Font("Perpetua Titling MT", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeamAPG.FormattingEnabled = true;
            this.cmbTeamAPG.Location = new System.Drawing.Point(448, 167);
            this.cmbTeamAPG.Name = "cmbTeamAPG";
            this.cmbTeamAPG.Size = new System.Drawing.Size(383, 27);
            this.cmbTeamAPG.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(257, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Team B";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(257, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 26);
            this.label13.TabIndex = 14;
            this.label13.Text = "Team A";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Gabriola", 26F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1297, 88);
            this.label4.TabIndex = 13;
            this.label4.Text = "Projected Goals Against Any Team";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AllTeamGoals
            // 
            this.AllTeamGoals.BackColor = System.Drawing.SystemColors.Info;
            this.AllTeamGoals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllTeamGoals.BackgroundImage")));
            this.AllTeamGoals.Controls.Add(this.button3);
            this.AllTeamGoals.Controls.Add(this.btnDisplayPG);
            this.AllTeamGoals.Controls.Add(this.GridPG);
            this.AllTeamGoals.Controls.Add(this.cmbTeamPG);
            this.AllTeamGoals.Controls.Add(this.label11);
            this.AllTeamGoals.Controls.Add(this.label9);
            this.AllTeamGoals.Font = new System.Drawing.Font("Calisto MT", 12.096F);
            this.AllTeamGoals.Location = new System.Drawing.Point(4, 54);
            this.AllTeamGoals.Name = "AllTeamGoals";
            this.AllTeamGoals.Size = new System.Drawing.Size(1297, 665);
            this.AllTeamGoals.TabIndex = 3;
            this.AllTeamGoals.Text = "Projected Goals Against All Teams";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1045, 266);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 45);
            this.button3.TabIndex = 21;
            this.button3.Text = "&Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDisplayPG
            // 
            this.btnDisplayPG.BackColor = System.Drawing.Color.Green;
            this.btnDisplayPG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplayPG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayPG.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnDisplayPG.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDisplayPG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplayPG.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayPG.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDisplayPG.Location = new System.Drawing.Point(1045, 163);
            this.btnDisplayPG.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayPG.Name = "btnDisplayPG";
            this.btnDisplayPG.Size = new System.Drawing.Size(159, 50);
            this.btnDisplayPG.TabIndex = 18;
            this.btnDisplayPG.Text = "&Display";
            this.btnDisplayPG.UseVisualStyleBackColor = false;
            this.btnDisplayPG.Click += new System.EventHandler(this.btnDisplayPG_Click);
            // 
            // GridPG
            // 
            this.GridPG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridPG.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.GridPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.GridPG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridPG.Location = new System.Drawing.Point(0, 338);
            this.GridPG.MultiSelect = false;
            this.GridPG.Name = "GridPG";
            this.GridPG.ReadOnly = true;
            this.GridPG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.GridPG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.GridPG.RowTemplate.Height = 24;
            this.GridPG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPG.Size = new System.Drawing.Size(1297, 327);
            this.GridPG.TabIndex = 20;
            this.GridPG.TabStop = false;
            this.GridPG.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Opponent";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Projected Goals";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cmbTeamPG
            // 
            this.cmbTeamPG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTeamPG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamPG.Font = new System.Drawing.Font("Perpetua Titling MT", 9.216F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeamPG.FormattingEnabled = true;
            this.cmbTeamPG.Location = new System.Drawing.Point(463, 175);
            this.cmbTeamPG.Name = "cmbTeamPG";
            this.cmbTeamPG.Size = new System.Drawing.Size(383, 27);
            this.cmbTeamPG.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(334, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "Team";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Gabriola", 26F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1297, 81);
            this.label9.TabIndex = 13;
            this.label9.Text = "Projected Goals Against All Teams";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProjectedScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1305, 723);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calisto MT", 12.096F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ProjectedScore";
            this.Text = "ProjectedScore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.SingleTeamTab.ResumeLayout(false);
            this.SingleTeamTab.PerformLayout();
            this.AllTeamsTab.ResumeLayout(false);
            this.AllTeamsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGoals)).EndInit();
            this.SingleTeamGoals.ResumeLayout(false);
            this.SingleTeamGoals.PerformLayout();
            this.AllTeamGoals.ResumeLayout(false);
            this.AllTeamGoals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SingleTeamTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.ComboBox cmbGoals;
        private System.Windows.Forms.ComboBox cmbTeamB;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.ComboBox cmbTeamA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage AllTeamsTab;
        private System.Windows.Forms.ComboBox cmbTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOpponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProbability;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ComboBox cmbGoals1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage SingleTeamGoals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage AllTeamGoals;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGoals;
        private System.Windows.Forms.ComboBox cmbTeamBPG;
        private System.Windows.Forms.Button btnGetPG;
        private System.Windows.Forms.ComboBox cmbTeamAPG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDisplayPG;
        private System.Windows.Forms.DataGridView GridPG;
        private System.Windows.Forms.ComboBox cmbTeamPG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}