namespace WeatherAppClient
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FullInformation = new System.Windows.Forms.TabPage();
            this.resultInformation = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetAllWeatherButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ChosenCity = new System.Windows.Forms.TabPage();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChoseCityName = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.Map = new System.Windows.Forms.TabPage();
            this.WarszawaValue = new System.Windows.Forms.Label();
            this.Warszawa = new System.Windows.Forms.Label();
            this.ZakopaneValue = new System.Windows.Forms.Label();
            this.Zakopane = new System.Windows.Forms.Label();
            this.Poznan = new System.Windows.Forms.Label();
            this.PoznańValue = new System.Windows.Forms.Label();
            this.Szczecin = new System.Windows.Forms.Label();
            this.SzczecinValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DateInfo = new System.Windows.Forms.Label();
            this.HumidityButton = new System.Windows.Forms.Button();
            this.PressureButton = new System.Windows.Forms.Button();
            this.TemperatureButton = new System.Windows.Forms.Button();
            this.TimeLoadedLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LoadCurrentDataLabel = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.Olsztyn = new System.Windows.Forms.Label();
            this.OlsztynValue = new System.Windows.Forms.Label();
            this.Lublin = new System.Windows.Forms.Label();
            this.LublinValue = new System.Windows.Forms.Label();
            this.GdańskValue = new System.Windows.Forms.Label();
            this.Gdańsk = new System.Windows.Forms.Label();
            this.WrocławValue = new System.Windows.Forms.Label();
            this.Wrocław = new System.Windows.Forms.Label();
            this.KrakówValue = new System.Windows.Forms.Label();
            this.Kraków = new System.Windows.Forms.Label();
            this.SuwałkiValue = new System.Windows.Forms.Label();
            this.Suwałki = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.FullInformation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ChosenCity.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Map.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            this.actionToolStripMenuItem.Click += new System.EventHandler(this.actionToolStripMenuItem_Click);
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FullInformation);
            this.tabControl1.Controls.Add(this.ChosenCity);
            this.tabControl1.Controls.Add(this.Map);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // FullInformation
            // 
            this.FullInformation.Controls.Add(this.resultInformation);
            this.FullInformation.Controls.Add(this.panel1);
            this.FullInformation.Controls.Add(this.statusStrip1);
            this.FullInformation.Location = new System.Drawing.Point(4, 22);
            this.FullInformation.Name = "FullInformation";
            this.FullInformation.Size = new System.Drawing.Size(792, 400);
            this.FullInformation.TabIndex = 0;
            this.FullInformation.Text = "tabPage4";
            this.FullInformation.UseVisualStyleBackColor = true;
            // 
            // resultInformation
            // 
            this.resultInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultInformation.Location = new System.Drawing.Point(0, 42);
            this.resultInformation.Multiline = true;
            this.resultInformation.Name = "resultInformation";
            this.resultInformation.ReadOnly = true;
            this.resultInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultInformation.Size = new System.Drawing.Size(792, 336);
            this.resultInformation.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GetAllWeatherButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 42);
            this.panel1.TabIndex = 1;
            // 
            // GetAllWeatherButton
            // 
            this.GetAllWeatherButton.Location = new System.Drawing.Point(77, 3);
            this.GetAllWeatherButton.Name = "GetAllWeatherButton";
            this.GetAllWeatherButton.Size = new System.Drawing.Size(200, 36);
            this.GetAllWeatherButton.TabIndex = 0;
            this.GetAllWeatherButton.Text = "button1";
            this.GetAllWeatherButton.UseVisualStyleBackColor = true;
            this.GetAllWeatherButton.Click += new System.EventHandler(this.GetAllWeatherButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ChosenCity
            // 
            this.ChosenCity.Controls.Add(this.textBoxCity);
            this.ChosenCity.Controls.Add(this.panel2);
            this.ChosenCity.Location = new System.Drawing.Point(4, 22);
            this.ChosenCity.Name = "ChosenCity";
            this.ChosenCity.Size = new System.Drawing.Size(792, 400);
            this.ChosenCity.TabIndex = 1;
            this.ChosenCity.Text = "tabPage4";
            this.ChosenCity.UseVisualStyleBackColor = true;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCity.Location = new System.Drawing.Point(0, 71);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.Size = new System.Drawing.Size(792, 329);
            this.textBoxCity.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ChoseCityName);
            this.panel2.Controls.Add(this.cityComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 71);
            this.panel2.TabIndex = 0;
            // 
            // ChoseCityName
            // 
            this.ChoseCityName.AutoSize = true;
            this.ChoseCityName.Location = new System.Drawing.Point(26, 17);
            this.ChoseCityName.Name = "ChoseCityName";
            this.ChoseCityName.Size = new System.Drawing.Size(35, 13);
            this.ChoseCityName.TabIndex = 1;
            this.ChoseCityName.Text = "label1";
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(26, 36);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(128, 21);
            this.cityComboBox.TabIndex = 0;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // Map
            // 
            this.Map.Controls.Add(this.Suwałki);
            this.Map.Controls.Add(this.SuwałkiValue);
            this.Map.Controls.Add(this.Kraków);
            this.Map.Controls.Add(this.KrakówValue);
            this.Map.Controls.Add(this.Wrocław);
            this.Map.Controls.Add(this.WrocławValue);
            this.Map.Controls.Add(this.Gdańsk);
            this.Map.Controls.Add(this.GdańskValue);
            this.Map.Controls.Add(this.LublinValue);
            this.Map.Controls.Add(this.Lublin);
            this.Map.Controls.Add(this.OlsztynValue);
            this.Map.Controls.Add(this.Olsztyn);
            this.Map.Controls.Add(this.WarszawaValue);
            this.Map.Controls.Add(this.Warszawa);
            this.Map.Controls.Add(this.ZakopaneValue);
            this.Map.Controls.Add(this.Zakopane);
            this.Map.Controls.Add(this.Poznan);
            this.Map.Controls.Add(this.PoznańValue);
            this.Map.Controls.Add(this.Szczecin);
            this.Map.Controls.Add(this.SzczecinValue);
            this.Map.Controls.Add(this.panel3);
            this.Map.Controls.Add(this.statusStrip2);
            this.Map.Controls.Add(this.pictureBox1);
            this.Map.Location = new System.Drawing.Point(4, 22);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(792, 400);
            this.Map.TabIndex = 2;
            this.Map.Text = "tabPage1";
            this.Map.UseVisualStyleBackColor = true;
            // 
            // WarszawaValue
            // 
            this.WarszawaValue.AutoSize = true;
            this.WarszawaValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.WarszawaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WarszawaValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WarszawaValue.Location = new System.Drawing.Point(310, 155);
            this.WarszawaValue.Name = "WarszawaValue";
            this.WarszawaValue.Size = new System.Drawing.Size(16, 16);
            this.WarszawaValue.TabIndex = 10;
            this.WarszawaValue.Text = "   ";
            // 
            // Warszawa
            // 
            this.Warszawa.AutoSize = true;
            this.Warszawa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Warszawa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Warszawa.Location = new System.Drawing.Point(310, 182);
            this.Warszawa.Name = "Warszawa";
            this.Warszawa.Size = new System.Drawing.Size(73, 17);
            this.Warszawa.TabIndex = 9;
            this.Warszawa.Text = "Warszawa";
            // 
            // ZakopaneValue
            // 
            this.ZakopaneValue.AutoSize = true;
            this.ZakopaneValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ZakopaneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakopaneValue.Location = new System.Drawing.Point(274, 293);
            this.ZakopaneValue.Name = "ZakopaneValue";
            this.ZakopaneValue.Size = new System.Drawing.Size(16, 16);
            this.ZakopaneValue.TabIndex = 8;
            this.ZakopaneValue.Text = "   ";
            // 
            // Zakopane
            // 
            this.Zakopane.AutoSize = true;
            this.Zakopane.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Zakopane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zakopane.Location = new System.Drawing.Point(274, 318);
            this.Zakopane.Name = "Zakopane";
            this.Zakopane.Size = new System.Drawing.Size(72, 17);
            this.Zakopane.TabIndex = 7;
            this.Zakopane.Text = "Zakopane";
            this.Zakopane.Click += new System.EventHandler(this.WrocławLabel_Click);
            // 
            // Poznan
            // 
            this.Poznan.AutoSize = true;
            this.Poznan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Poznan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Poznan.Location = new System.Drawing.Point(161, 167);
            this.Poznan.Name = "Poznan";
            this.Poznan.Size = new System.Drawing.Size(56, 17);
            this.Poznan.TabIndex = 6;
            this.Poznan.Text = "Poznań";
            // 
            // PoznańValue
            // 
            this.PoznańValue.AutoSize = true;
            this.PoznańValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PoznańValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PoznańValue.Location = new System.Drawing.Point(161, 141);
            this.PoznańValue.Name = "PoznańValue";
            this.PoznańValue.Size = new System.Drawing.Size(16, 16);
            this.PoznańValue.TabIndex = 5;
            this.PoznańValue.Text = "   ";
            // 
            // Szczecin
            // 
            this.Szczecin.AutoSize = true;
            this.Szczecin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Szczecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szczecin.Location = new System.Drawing.Point(60, 98);
            this.Szczecin.Name = "Szczecin";
            this.Szczecin.Size = new System.Drawing.Size(64, 17);
            this.Szczecin.TabIndex = 4;
            this.Szczecin.Text = "Szczecin";
            // 
            // SzczecinValue
            // 
            this.SzczecinValue.AutoSize = true;
            this.SzczecinValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SzczecinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SzczecinValue.Location = new System.Drawing.Point(60, 72);
            this.SzczecinValue.Name = "SzczecinValue";
            this.SzczecinValue.Size = new System.Drawing.Size(20, 17);
            this.SzczecinValue.TabIndex = 3;
            this.SzczecinValue.Text = "   ";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.DateInfo);
            this.panel3.Controls.Add(this.HumidityButton);
            this.panel3.Controls.Add(this.PressureButton);
            this.panel3.Controls.Add(this.TemperatureButton);
            this.panel3.Controls.Add(this.TimeLoadedLabel);
            this.panel3.Controls.Add(this.StatusLabel);
            this.panel3.Controls.Add(this.LoadCurrentDataLabel);
            this.panel3.Location = new System.Drawing.Point(477, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 378);
            this.panel3.TabIndex = 2;
            // 
            // DateInfo
            // 
            this.DateInfo.AutoSize = true;
            this.DateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateInfo.Location = new System.Drawing.Point(48, 269);
            this.DateInfo.Name = "DateInfo";
            this.DateInfo.Size = new System.Drawing.Size(0, 17);
            this.DateInfo.TabIndex = 5;
            // 
            // HumidityButton
            // 
            this.HumidityButton.Location = new System.Drawing.Point(48, 155);
            this.HumidityButton.Name = "HumidityButton";
            this.HumidityButton.Size = new System.Drawing.Size(139, 41);
            this.HumidityButton.TabIndex = 4;
            this.HumidityButton.Text = "button1";
            this.HumidityButton.UseVisualStyleBackColor = true;
            this.HumidityButton.Click += new System.EventHandler(this.HumidityButton_Click);
            // 
            // PressureButton
            // 
            this.PressureButton.Location = new System.Drawing.Point(48, 108);
            this.PressureButton.Name = "PressureButton";
            this.PressureButton.Size = new System.Drawing.Size(139, 41);
            this.PressureButton.TabIndex = 3;
            this.PressureButton.Text = "button1";
            this.PressureButton.UseVisualStyleBackColor = true;
            this.PressureButton.Click += new System.EventHandler(this.PressureButton_Click);
            // 
            // TemperatureButton
            // 
            this.TemperatureButton.Location = new System.Drawing.Point(48, 61);
            this.TemperatureButton.Name = "TemperatureButton";
            this.TemperatureButton.Size = new System.Drawing.Size(139, 41);
            this.TemperatureButton.TabIndex = 3;
            this.TemperatureButton.Text = "button1";
            this.TemperatureButton.UseVisualStyleBackColor = true;
            this.TemperatureButton.Click += new System.EventHandler(this.TemperatureButton_Click);
            // 
            // TimeLoadedLabel
            // 
            this.TimeLoadedLabel.AutoSize = true;
            this.TimeLoadedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeLoadedLabel.Location = new System.Drawing.Point(48, 269);
            this.TimeLoadedLabel.Name = "TimeLoadedLabel";
            this.TimeLoadedLabel.Size = new System.Drawing.Size(0, 17);
            this.TimeLoadedLabel.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.Location = new System.Drawing.Point(48, 235);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(46, 17);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "label2";
            // 
            // LoadCurrentDataLabel
            // 
            this.LoadCurrentDataLabel.AutoSize = true;
            this.LoadCurrentDataLabel.Location = new System.Drawing.Point(45, 30);
            this.LoadCurrentDataLabel.Name = "LoadCurrentDataLabel";
            this.LoadCurrentDataLabel.Size = new System.Drawing.Size(35, 13);
            this.LoadCurrentDataLabel.TabIndex = 0;
            this.LoadCurrentDataLabel.Text = "label1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 378);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(792, 22);
            this.statusStrip2.TabIndex = 1;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // statusStrip3
            // 
            this.statusStrip3.Location = new System.Drawing.Point(0, 428);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(800, 22);
            this.statusStrip3.TabIndex = 2;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // Olsztyn
            // 
            this.Olsztyn.AutoSize = true;
            this.Olsztyn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Olsztyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Olsztyn.Location = new System.Drawing.Point(255, 89);
            this.Olsztyn.Name = "Olsztyn";
            this.Olsztyn.Size = new System.Drawing.Size(50, 16);
            this.Olsztyn.TabIndex = 11;
            this.Olsztyn.Text = "Olsztyn";
            // 
            // OlsztynValue
            // 
            this.OlsztynValue.AutoSize = true;
            this.OlsztynValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OlsztynValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OlsztynValue.Location = new System.Drawing.Point(255, 61);
            this.OlsztynValue.Name = "OlsztynValue";
            this.OlsztynValue.Size = new System.Drawing.Size(16, 16);
            this.OlsztynValue.TabIndex = 12;
            this.OlsztynValue.Text = "   ";
            // 
            // Lublin
            // 
            this.Lublin.AutoSize = true;
            this.Lublin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Lublin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lublin.Location = new System.Drawing.Point(347, 245);
            this.Lublin.Name = "Lublin";
            this.Lublin.Size = new System.Drawing.Size(42, 16);
            this.Lublin.TabIndex = 13;
            this.Lublin.Text = "Lublin";
            // 
            // LublinValue
            // 
            this.LublinValue.AutoSize = true;
            this.LublinValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LublinValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LublinValue.Location = new System.Drawing.Point(347, 216);
            this.LublinValue.Name = "LublinValue";
            this.LublinValue.Size = new System.Drawing.Size(16, 16);
            this.LublinValue.TabIndex = 14;
            this.LublinValue.Text = "   ";
            // 
            // GdańskValue
            // 
            this.GdańskValue.AutoSize = true;
            this.GdańskValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GdańskValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GdańskValue.Location = new System.Drawing.Point(184, 63);
            this.GdańskValue.Name = "GdańskValue";
            this.GdańskValue.Size = new System.Drawing.Size(16, 16);
            this.GdańskValue.TabIndex = 15;
            this.GdańskValue.Text = "   ";
            // 
            // Gdańsk
            // 
            this.Gdańsk.AutoSize = true;
            this.Gdańsk.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Gdańsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gdańsk.Location = new System.Drawing.Point(187, 91);
            this.Gdańsk.Name = "Gdańsk";
            this.Gdańsk.Size = new System.Drawing.Size(54, 16);
            this.Gdańsk.TabIndex = 16;
            this.Gdańsk.Text = "Gdańsk";
            // 
            // WrocławValue
            // 
            this.WrocławValue.AutoSize = true;
            this.WrocławValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.WrocławValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WrocławValue.Location = new System.Drawing.Point(136, 218);
            this.WrocławValue.Name = "WrocławValue";
            this.WrocławValue.Size = new System.Drawing.Size(16, 16);
            this.WrocławValue.TabIndex = 17;
            this.WrocławValue.Text = "   ";
            // 
            // Wrocław
            // 
            this.Wrocław.AutoSize = true;
            this.Wrocław.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Wrocław.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wrocław.Location = new System.Drawing.Point(136, 245);
            this.Wrocław.Name = "Wrocław";
            this.Wrocław.Size = new System.Drawing.Size(62, 16);
            this.Wrocław.TabIndex = 18;
            this.Wrocław.Text = "Wrocław";
            // 
            // KrakówValue
            // 
            this.KrakówValue.AutoSize = true;
            this.KrakówValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.KrakówValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KrakówValue.Location = new System.Drawing.Point(241, 245);
            this.KrakówValue.Name = "KrakówValue";
            this.KrakówValue.Size = new System.Drawing.Size(16, 16);
            this.KrakówValue.TabIndex = 19;
            this.KrakówValue.Text = "   ";
            // 
            // Kraków
            // 
            this.Kraków.AutoSize = true;
            this.Kraków.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Kraków.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kraków.Location = new System.Drawing.Point(241, 269);
            this.Kraków.Name = "Kraków";
            this.Kraków.Size = new System.Drawing.Size(51, 16);
            this.Kraków.TabIndex = 20;
            this.Kraków.Text = "Kraków";
            // 
            // SuwałkiValue
            // 
            this.SuwałkiValue.AutoSize = true;
            this.SuwałkiValue.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SuwałkiValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SuwałkiValue.Location = new System.Drawing.Point(377, 86);
            this.SuwałkiValue.Name = "SuwałkiValue";
            this.SuwałkiValue.Size = new System.Drawing.Size(16, 16);
            this.SuwałkiValue.TabIndex = 21;
            this.SuwałkiValue.Text = "   ";
            // 
            // Suwałki
            // 
            this.Suwałki.AutoSize = true;
            this.Suwałki.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Suwałki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Suwałki.Location = new System.Drawing.Point(377, 108);
            this.Suwałki.Name = "Suwałki";
            this.Suwałki.Size = new System.Drawing.Size(56, 16);
            this.Suwałki.TabIndex = 22;
            this.Suwałki.Text = "Suwałki";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WeatherAppClient.Properties.Resources.Mapa;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 361);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.FullInformation.ResumeLayout(false);
            this.FullInformation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ChosenCity.ResumeLayout(false);
            this.ChosenCity.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Map.ResumeLayout(false);
            this.Map.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FullInformation;
        private System.Windows.Forms.TabPage ChosenCity;
        private System.Windows.Forms.TabPage Map;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GetAllWeatherButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ChoseCityName;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label TimeLoadedLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label LoadCurrentDataLabel;
        private System.Windows.Forms.Button TemperatureButton;
        private System.Windows.Forms.Button PressureButton;
        private System.Windows.Forms.Button HumidityButton;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.Label Szczecin;
        private System.Windows.Forms.Label SzczecinValue;
        private System.Windows.Forms.Label Poznan;
        private System.Windows.Forms.Label PoznańValue;
        private System.Windows.Forms.Label Zakopane;
        private System.Windows.Forms.TextBox resultInformation;
        private System.Windows.Forms.Label DateInfo;
        private System.Windows.Forms.Label ZakopaneValue;
        private System.Windows.Forms.Label WarszawaValue;
        private System.Windows.Forms.Label Warszawa;
        private System.Windows.Forms.Label Wrocław;
        private System.Windows.Forms.Label WrocławValue;
        private System.Windows.Forms.Label Gdańsk;
        private System.Windows.Forms.Label GdańskValue;
        private System.Windows.Forms.Label LublinValue;
        private System.Windows.Forms.Label Lublin;
        private System.Windows.Forms.Label OlsztynValue;
        private System.Windows.Forms.Label Olsztyn;
        private System.Windows.Forms.Label Suwałki;
        private System.Windows.Forms.Label SuwałkiValue;
        private System.Windows.Forms.Label Kraków;
        private System.Windows.Forms.Label KrakówValue;
    }
}