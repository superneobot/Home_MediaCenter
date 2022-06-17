namespace Project_X
{
    partial class mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.mainform_table = new System.Windows.Forms.TabControl();
            this.mc_page = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.library_list = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lib_page = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.load_list = new System.Windows.Forms.Button();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.save_list = new System.Windows.Forms.Button();
            this.film_caption = new System.Windows.Forms.Label();
            this.film_poster = new System.Windows.Forms.PictureBox();
            this.menu_poster = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_poster_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_poster_load = new System.Windows.Forms.ToolStripMenuItem();
            this.add_film = new System.Windows.Forms.Button();
            this.add_films = new System.Windows.Forms.Button();
            this.film_list = new System.Windows.Forms.ListBox();
            this.server_settings = new System.Windows.Forms.TabPage();
            this.server_exec_param = new System.Windows.Forms.CheckBox();
            this.server_status_tip = new System.Windows.Forms.Label();
            this.open_server_path = new System.Windows.Forms.LinkLabel();
            this.server_path = new System.Windows.Forms.TextBox();
            this.select_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.server_port = new System.Windows.Forms.NumericUpDown();
            this.ip4 = new System.Windows.Forms.NumericUpDown();
            this.ip3 = new System.Windows.Forms.NumericUpDown();
            this.ip2 = new System.Windows.Forms.NumericUpDown();
            this.ip1 = new System.Windows.Forms.NumericUpDown();
            this.mainform_table.SuspendLayout();
            this.mc_page.SuspendLayout();
            this.lib_page.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.film_poster)).BeginInit();
            this.menu_poster.SuspendLayout();
            this.server_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.server_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainform_table
            // 
            this.mainform_table.Controls.Add(this.mc_page);
            this.mainform_table.Controls.Add(this.lib_page);
            this.mainform_table.Controls.Add(this.server_settings);
            this.mainform_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainform_table.ImageList = this.images;
            this.mainform_table.Location = new System.Drawing.Point(0, 0);
            this.mainform_table.Name = "mainform_table";
            this.mainform_table.SelectedIndex = 0;
            this.mainform_table.Size = new System.Drawing.Size(436, 508);
            this.mainform_table.TabIndex = 1;
            this.mainform_table.SelectedIndexChanged += new System.EventHandler(this.mainform_table_SelectedIndexChanged);
            this.mainform_table.TabIndexChanged += new System.EventHandler(this.mainform_table_TabIndexChanged);
            // 
            // mc_page
            // 
            this.mc_page.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mc_page.Controls.Add(this.button3);
            this.mc_page.Controls.Add(this.library_list);
            this.mc_page.Controls.Add(this.comboBox1);
            this.mc_page.Controls.Add(this.button2);
            this.mc_page.Controls.Add(this.button1);
            this.mc_page.ImageIndex = 1;
            this.mc_page.Location = new System.Drawing.Point(4, 23);
            this.mc_page.Name = "mc_page";
            this.mc_page.Padding = new System.Windows.Forms.Padding(3);
            this.mc_page.Size = new System.Drawing.Size(428, 481);
            this.mc_page.TabIndex = 0;
            this.mc_page.Text = "Медиацентр";
            this.mc_page.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // library_list
            // 
            this.library_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.library_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.library_list.FormattingEnabled = true;
            this.library_list.Location = new System.Drawing.Point(88, 6);
            this.library_list.Name = "library_list";
            this.library_list.Size = new System.Drawing.Size(121, 22);
            this.library_list.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "720p",
            "1080p",
            "2K",
            "4K"});
            this.comboBox1.Location = new System.Drawing.Point(88, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(7, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lib_page
            // 
            this.lib_page.Controls.Add(this.statusStrip1);
            this.lib_page.Controls.Add(this.load_list);
            this.lib_page.Controls.Add(this.save_list);
            this.lib_page.Controls.Add(this.film_caption);
            this.lib_page.Controls.Add(this.film_poster);
            this.lib_page.Controls.Add(this.add_film);
            this.lib_page.Controls.Add(this.add_films);
            this.lib_page.Controls.Add(this.film_list);
            this.lib_page.ImageIndex = 2;
            this.lib_page.Location = new System.Drawing.Point(4, 23);
            this.lib_page.Name = "lib_page";
            this.lib_page.Padding = new System.Windows.Forms.Padding(3);
            this.lib_page.Size = new System.Drawing.Size(428, 481);
            this.lib_page.TabIndex = 2;
            this.lib_page.Text = "Библиотека";
            this.lib_page.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(3, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(422, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(13, 17);
            this.status.Text = "0";
            // 
            // load_list
            // 
            this.load_list.BackColor = System.Drawing.Color.Transparent;
            this.load_list.FlatAppearance.BorderSize = 0;
            this.load_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.load_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.load_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_list.ImageIndex = 4;
            this.load_list.ImageList = this.images;
            this.load_list.Location = new System.Drawing.Point(373, 6);
            this.load_list.Name = "load_list";
            this.load_list.Size = new System.Drawing.Size(23, 23);
            this.load_list.TabIndex = 4;
            this.load_list.UseVisualStyleBackColor = false;
            this.load_list.Click += new System.EventHandler(this.load_list_Click);
            this.load_list.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            this.load_list.MouseHover += new System.EventHandler(this.load_list_MouseHover);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "globe.ico");
            this.images.Images.SetKeyName(1, "two displays.png");
            this.images.Images.SetKeyName(2, "two pictures.png");
            this.images.Images.SetKeyName(3, "save.png");
            this.images.Images.SetKeyName(4, "open.png");
            this.images.Images.SetKeyName(5, "import.png");
            // 
            // save_list
            // 
            this.save_list.BackColor = System.Drawing.Color.Transparent;
            this.save_list.FlatAppearance.BorderSize = 0;
            this.save_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.save_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.save_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_list.ImageIndex = 3;
            this.save_list.ImageList = this.images;
            this.save_list.Location = new System.Drawing.Point(397, 6);
            this.save_list.Name = "save_list";
            this.save_list.Size = new System.Drawing.Size(23, 23);
            this.save_list.TabIndex = 4;
            this.save_list.UseVisualStyleBackColor = false;
            this.save_list.Click += new System.EventHandler(this.save_list_Click);
            this.save_list.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            this.save_list.MouseHover += new System.EventHandler(this.save_list_MouseHover);
            // 
            // film_caption
            // 
            this.film_caption.AutoSize = true;
            this.film_caption.Location = new System.Drawing.Point(194, 189);
            this.film_caption.Name = "film_caption";
            this.film_caption.Size = new System.Drawing.Size(16, 14);
            this.film_caption.TabIndex = 3;
            this.film_caption.Text = "...";
            // 
            // film_poster
            // 
            this.film_poster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.film_poster.ContextMenuStrip = this.menu_poster;
            this.film_poster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.film_poster.Location = new System.Drawing.Point(8, 189);
            this.film_poster.Name = "film_poster";
            this.film_poster.Size = new System.Drawing.Size(180, 260);
            this.film_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.film_poster.TabIndex = 2;
            this.film_poster.TabStop = false;
            this.film_poster.Click += new System.EventHandler(this.film_poster_Click);
            // 
            // menu_poster
            // 
            this.menu_poster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_poster_open,
            this.menu_poster_load});
            this.menu_poster.Name = "menu_poster";
            this.menu_poster.Size = new System.Drawing.Size(104, 48);
            // 
            // menu_poster_open
            // 
            this.menu_poster_open.Name = "menu_poster_open";
            this.menu_poster_open.Size = new System.Drawing.Size(103, 22);
            this.menu_poster_open.Text = "Open";
            this.menu_poster_open.Click += new System.EventHandler(this.menu_poster_open_Click);
            // 
            // menu_poster_load
            // 
            this.menu_poster_load.Name = "menu_poster_load";
            this.menu_poster_load.Size = new System.Drawing.Size(103, 22);
            this.menu_poster_load.Text = "Load";
            this.menu_poster_load.Click += new System.EventHandler(this.menu_poster_load_Click);
            // 
            // add_film
            // 
            this.add_film.BackColor = System.Drawing.Color.Transparent;
            this.add_film.FlatAppearance.BorderSize = 0;
            this.add_film.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.add_film.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.add_film.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_film.ImageIndex = 5;
            this.add_film.ImageList = this.images;
            this.add_film.Location = new System.Drawing.Point(8, 6);
            this.add_film.Name = "add_film";
            this.add_film.Size = new System.Drawing.Size(23, 23);
            this.add_film.TabIndex = 1;
            this.add_film.UseVisualStyleBackColor = false;
            this.add_film.Click += new System.EventHandler(this.add_film_Click);
            this.add_film.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            this.add_film.MouseHover += new System.EventHandler(this.add_film_MouseHover);
            // 
            // add_films
            // 
            this.add_films.BackColor = System.Drawing.Color.Transparent;
            this.add_films.FlatAppearance.BorderSize = 0;
            this.add_films.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.add_films.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.add_films.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_films.Location = new System.Drawing.Point(33, 6);
            this.add_films.Name = "add_films";
            this.add_films.Size = new System.Drawing.Size(23, 23);
            this.add_films.TabIndex = 1;
            this.add_films.Text = "...";
            this.add_films.UseVisualStyleBackColor = false;
            this.add_films.Click += new System.EventHandler(this.add_films_Click);
            this.add_films.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            this.add_films.MouseHover += new System.EventHandler(this.add_films_MouseHover);
            // 
            // film_list
            // 
            this.film_list.Font = new System.Drawing.Font("Motiva Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.film_list.FormattingEnabled = true;
            this.film_list.ItemHeight = 16;
            this.film_list.Location = new System.Drawing.Point(8, 35);
            this.film_list.Name = "film_list";
            this.film_list.Size = new System.Drawing.Size(412, 148);
            this.film_list.TabIndex = 0;
            this.film_list.Click += new System.EventHandler(this.film_list_Click);
            // 
            // server_settings
            // 
            this.server_settings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server_settings.Controls.Add(this.server_exec_param);
            this.server_settings.Controls.Add(this.server_status_tip);
            this.server_settings.Controls.Add(this.open_server_path);
            this.server_settings.Controls.Add(this.server_path);
            this.server_settings.Controls.Add(this.select_btn);
            this.server_settings.Controls.Add(this.label2);
            this.server_settings.Controls.Add(this.label1);
            this.server_settings.Controls.Add(this.start_btn);
            this.server_settings.Controls.Add(this.server_port);
            this.server_settings.Controls.Add(this.ip4);
            this.server_settings.Controls.Add(this.ip3);
            this.server_settings.Controls.Add(this.ip2);
            this.server_settings.Controls.Add(this.ip1);
            this.server_settings.ImageKey = "globe.ico";
            this.server_settings.Location = new System.Drawing.Point(4, 23);
            this.server_settings.Name = "server_settings";
            this.server_settings.Padding = new System.Windows.Forms.Padding(3);
            this.server_settings.Size = new System.Drawing.Size(428, 481);
            this.server_settings.TabIndex = 1;
            this.server_settings.Text = "Веб-сервер";
            this.server_settings.UseVisualStyleBackColor = true;
            // 
            // server_exec_param
            // 
            this.server_exec_param.AutoSize = true;
            this.server_exec_param.Location = new System.Drawing.Point(10, 101);
            this.server_exec_param.Name = "server_exec_param";
            this.server_exec_param.Size = new System.Drawing.Size(258, 18);
            this.server_exec_param.TabIndex = 12;
            this.server_exec_param.Text = "Автозапуск сервера при старте приложения";
            this.server_exec_param.UseVisualStyleBackColor = true;
            this.server_exec_param.CheckedChanged += new System.EventHandler(this.server_exec_param_CheckedChanged);
            // 
            // server_status_tip
            // 
            this.server_status_tip.AutoSize = true;
            this.server_status_tip.Location = new System.Drawing.Point(7, 84);
            this.server_status_tip.Name = "server_status_tip";
            this.server_status_tip.Size = new System.Drawing.Size(109, 14);
            this.server_status_tip.TabIndex = 11;
            this.server_status_tip.Text = "Сервер остановлен";
            // 
            // open_server_path
            // 
            this.open_server_path.AutoSize = true;
            this.open_server_path.Location = new System.Drawing.Point(231, 61);
            this.open_server_path.Name = "open_server_path";
            this.open_server_path.Size = new System.Drawing.Size(61, 14);
            this.open_server_path.TabIndex = 10;
            this.open_server_path.TabStop = true;
            this.open_server_path.Text = "Открыть...";
            this.open_server_path.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.open_server_path_LinkClicked);
            // 
            // server_path
            // 
            this.server_path.Location = new System.Drawing.Point(73, 58);
            this.server_path.Name = "server_path";
            this.server_path.Size = new System.Drawing.Size(152, 21);
            this.server_path.TabIndex = 9;
            // 
            // select_btn
            // 
            this.select_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.select_btn.FlatAppearance.BorderSize = 0;
            this.select_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.select_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.select_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_btn.Location = new System.Drawing.Point(6, 56);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(61, 25);
            this.select_btn.TabIndex = 8;
            this.select_btn.Text = "Выбрать";
            this.select_btn.UseVisualStyleBackColor = false;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP address";
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.start_btn.FlatAppearance.BorderSize = 0;
            this.start_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.start_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Motiva Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_btn.Location = new System.Drawing.Point(287, 28);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 22);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "Старт";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // server_port
            // 
            this.server_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server_port.Location = new System.Drawing.Point(231, 28);
            this.server_port.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.server_port.Name = "server_port";
            this.server_port.Size = new System.Drawing.Size(50, 21);
            this.server_port.TabIndex = 4;
            this.server_port.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.server_port.ValueChanged += new System.EventHandler(this.Selected_ip_address);
            // 
            // ip4
            // 
            this.ip4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ip4.Location = new System.Drawing.Point(175, 28);
            this.ip4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(50, 21);
            this.ip4.TabIndex = 3;
            this.ip4.Value = new decimal(new int[] {
            103,
            0,
            0,
            0});
            this.ip4.ValueChanged += new System.EventHandler(this.Selected_ip_address);
            // 
            // ip3
            // 
            this.ip3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ip3.Location = new System.Drawing.Point(119, 28);
            this.ip3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(50, 21);
            this.ip3.TabIndex = 2;
            this.ip3.ValueChanged += new System.EventHandler(this.Selected_ip_address);
            // 
            // ip2
            // 
            this.ip2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ip2.Location = new System.Drawing.Point(63, 28);
            this.ip2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(50, 21);
            this.ip2.TabIndex = 1;
            this.ip2.Value = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.ip2.ValueChanged += new System.EventHandler(this.Selected_ip_address);
            // 
            // ip1
            // 
            this.ip1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ip1.Location = new System.Drawing.Point(7, 28);
            this.ip1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(50, 21);
            this.ip1.TabIndex = 0;
            this.ip1.Value = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.ip1.ValueChanged += new System.EventHandler(this.Selected_ip_address);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(436, 508);
            this.Controls.Add(this.mainform_table);
            this.Font = new System.Drawing.Font("Motiva Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.mainform_table.ResumeLayout(false);
            this.mc_page.ResumeLayout(false);
            this.lib_page.ResumeLayout(false);
            this.lib_page.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.film_poster)).EndInit();
            this.menu_poster.ResumeLayout(false);
            this.server_settings.ResumeLayout(false);
            this.server_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.server_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainform_table;
        private System.Windows.Forms.TabPage mc_page;
        private System.Windows.Forms.TabPage server_settings;
        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.NumericUpDown ip4;
        private System.Windows.Forms.NumericUpDown ip3;
        private System.Windows.Forms.NumericUpDown ip2;
        private System.Windows.Forms.NumericUpDown ip1;
        private System.Windows.Forms.NumericUpDown server_port;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox server_path;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel open_server_path;
        private System.Windows.Forms.Label server_status_tip;
        private System.Windows.Forms.CheckBox server_exec_param;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage lib_page;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button add_films;
        private System.Windows.Forms.ListBox film_list;
        private System.Windows.Forms.Label film_caption;
        private System.Windows.Forms.PictureBox film_poster;
        private System.Windows.Forms.ContextMenuStrip menu_poster;
        private System.Windows.Forms.ToolStripMenuItem menu_poster_open;
        private System.Windows.Forms.ToolStripMenuItem menu_poster_load;
        private System.Windows.Forms.Button add_film;
        private System.Windows.Forms.Button save_list;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox library_list;
        private System.Windows.Forms.Button load_list;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
    }
}

