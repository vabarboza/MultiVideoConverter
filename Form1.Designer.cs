namespace MultiVideoConverter
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tbControl = new TabControl();
            tabPage1 = new TabPage();
            pbDownloadVideo = new ProgressBar();
            labelStatusVideo = new Label();
            btnLocationVideo = new Button();
            tbLocationVideo = new TextBox();
            label3 = new Label();
            btnAddVideo = new Button();
            btnCleanVideos = new Button();
            btnDownloadVideos = new Button();
            listBoxLinksVideos = new ListBox();
            label2 = new Label();
            tbVideoLink = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            pbDownloadMusic = new ProgressBar();
            labelStatusMusic = new Label();
            btnLocationMusic = new Button();
            tbLocationMusic = new TextBox();
            label6 = new Label();
            btnAddMusic = new Button();
            btnCleanMusic = new Button();
            btnDownloadMusic = new Button();
            listBoxLinksMusic = new ListBox();
            label7 = new Label();
            tbMusicLink = new TextBox();
            label8 = new Label();
            tabPage3 = new TabPage();
            button3 = new Button();
            progressBar1 = new ProgressBar();
            label11 = new Label();
            cbPower = new CheckBox();
            listBox1 = new ListBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            tbControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tbControl
            // 
            tbControl.Controls.Add(tabPage1);
            tbControl.Controls.Add(tabPage2);
            tbControl.Controls.Add(tabPage3);
            tbControl.Dock = DockStyle.Fill;
            tbControl.ItemSize = new Size(50, 23);
            tbControl.Location = new Point(0, 0);
            tbControl.Multiline = true;
            tbControl.Name = "tbControl";
            tbControl.SelectedIndex = 0;
            tbControl.Size = new Size(684, 491);
            tbControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.MenuBar;
            tabPage1.Controls.Add(pbDownloadVideo);
            tabPage1.Controls.Add(labelStatusVideo);
            tabPage1.Controls.Add(btnLocationVideo);
            tabPage1.Controls.Add(tbLocationVideo);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(btnAddVideo);
            tabPage1.Controls.Add(btnCleanVideos);
            tabPage1.Controls.Add(btnDownloadVideos);
            tabPage1.Controls.Add(listBoxLinksVideos);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(tbVideoLink);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.RightToLeft = RightToLeft.No;
            tabPage1.Size = new Size(676, 460);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Youtube Downloader";
            // 
            // pbDownloadVideo
            // 
            pbDownloadVideo.BackColor = Color.White;
            pbDownloadVideo.Location = new Point(8, 421);
            pbDownloadVideo.Name = "pbDownloadVideo";
            pbDownloadVideo.Size = new Size(657, 23);
            pbDownloadVideo.TabIndex = 12;
            // 
            // labelStatusVideo
            // 
            labelStatusVideo.AutoSize = true;
            labelStatusVideo.Location = new Point(8, 403);
            labelStatusVideo.Name = "labelStatusVideo";
            labelStatusVideo.Size = new Size(83, 15);
            labelStatusVideo.TabIndex = 11;
            labelStatusVideo.Text = "Aguardando...";
            // 
            // btnLocationVideo
            // 
            btnLocationVideo.FlatStyle = FlatStyle.Flat;
            btnLocationVideo.Location = new Point(554, 357);
            btnLocationVideo.Name = "btnLocationVideo";
            btnLocationVideo.Size = new Size(111, 23);
            btnLocationVideo.TabIndex = 10;
            btnLocationVideo.Text = "Selecionar";
            btnLocationVideo.UseVisualStyleBackColor = true;
            btnLocationVideo.Click += btnLocationVideo_Click;
            // 
            // tbLocationVideo
            // 
            tbLocationVideo.Font = new Font("Segoe UI", 9F);
            tbLocationVideo.Location = new Point(8, 357);
            tbLocationVideo.Name = "tbLocationVideo";
            tbLocationVideo.Size = new Size(540, 23);
            tbLocationVideo.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 339);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 8;
            label3.Text = "Local de saida";
            // 
            // btnAddVideo
            // 
            btnAddVideo.FlatStyle = FlatStyle.Flat;
            btnAddVideo.Location = new Point(554, 30);
            btnAddVideo.Name = "btnAddVideo";
            btnAddVideo.Size = new Size(111, 23);
            btnAddVideo.TabIndex = 7;
            btnAddVideo.Text = "Adicionar a fila";
            btnAddVideo.UseVisualStyleBackColor = true;
            btnAddVideo.Click += btnAddVideo_Click;
            // 
            // btnCleanVideos
            // 
            btnCleanVideos.FlatStyle = FlatStyle.Flat;
            btnCleanVideos.Location = new Point(554, 294);
            btnCleanVideos.Name = "btnCleanVideos";
            btnCleanVideos.Size = new Size(111, 23);
            btnCleanVideos.TabIndex = 6;
            btnCleanVideos.Text = "Limpar lista";
            btnCleanVideos.UseVisualStyleBackColor = true;
            btnCleanVideos.Click += btnCleanVideos_Click;
            // 
            // btnDownloadVideos
            // 
            btnDownloadVideos.FlatStyle = FlatStyle.Flat;
            btnDownloadVideos.Location = new Point(8, 294);
            btnDownloadVideos.Name = "btnDownloadVideos";
            btnDownloadVideos.Size = new Size(111, 23);
            btnDownloadVideos.TabIndex = 5;
            btnDownloadVideos.Text = "Baixar videos";
            btnDownloadVideos.UseVisualStyleBackColor = true;
            btnDownloadVideos.Click += btnDownloadVideos_Click;
            // 
            // listBoxLinksVideos
            // 
            listBoxLinksVideos.Font = new Font("Segoe UI", 9F);
            listBoxLinksVideos.FormattingEnabled = true;
            listBoxLinksVideos.ItemHeight = 15;
            listBoxLinksVideos.Location = new Point(8, 89);
            listBoxLinksVideos.Name = "listBoxLinksVideos";
            listBoxLinksVideos.Size = new Size(660, 199);
            listBoxLinksVideos.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 71);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 3;
            label2.Text = "Lista de downloads";
            // 
            // tbVideoLink
            // 
            tbVideoLink.Font = new Font("Segoe UI", 9F);
            tbVideoLink.Location = new Point(8, 30);
            tbVideoLink.Name = "tbVideoLink";
            tbVideoLink.Size = new Size(540, 23);
            tbVideoLink.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 12);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Link do video";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.MenuBar;
            tabPage2.Controls.Add(pbDownloadMusic);
            tabPage2.Controls.Add(labelStatusMusic);
            tabPage2.Controls.Add(btnLocationMusic);
            tabPage2.Controls.Add(tbLocationMusic);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btnAddMusic);
            tabPage2.Controls.Add(btnCleanMusic);
            tabPage2.Controls.Add(btnDownloadMusic);
            tabPage2.Controls.Add(listBoxLinksMusic);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(tbMusicLink);
            tabPage2.Controls.Add(label8);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(676, 460);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Youtube Music";
            // 
            // pbDownloadMusic
            // 
            pbDownloadMusic.BackColor = Color.White;
            pbDownloadMusic.Location = new Point(8, 421);
            pbDownloadMusic.Name = "pbDownloadMusic";
            pbDownloadMusic.Size = new Size(657, 23);
            pbDownloadMusic.TabIndex = 24;
            // 
            // labelStatusMusic
            // 
            labelStatusMusic.AutoSize = true;
            labelStatusMusic.Location = new Point(8, 403);
            labelStatusMusic.Name = "labelStatusMusic";
            labelStatusMusic.Size = new Size(83, 15);
            labelStatusMusic.TabIndex = 23;
            labelStatusMusic.Text = "Aguardando...";
            // 
            // btnLocationMusic
            // 
            btnLocationMusic.FlatStyle = FlatStyle.Flat;
            btnLocationMusic.Location = new Point(554, 357);
            btnLocationMusic.Name = "btnLocationMusic";
            btnLocationMusic.Size = new Size(111, 23);
            btnLocationMusic.TabIndex = 22;
            btnLocationMusic.Text = "Selecionar";
            btnLocationMusic.UseVisualStyleBackColor = true;
            btnLocationMusic.Click += btnLocationMusic_Click;
            // 
            // tbLocationMusic
            // 
            tbLocationMusic.Font = new Font("Segoe UI", 9F);
            tbLocationMusic.Location = new Point(8, 357);
            tbLocationMusic.Name = "tbLocationMusic";
            tbLocationMusic.Size = new Size(540, 23);
            tbLocationMusic.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 339);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 20;
            label6.Text = "Local de saida";
            // 
            // btnAddMusic
            // 
            btnAddMusic.FlatStyle = FlatStyle.Flat;
            btnAddMusic.Location = new Point(554, 30);
            btnAddMusic.Name = "btnAddMusic";
            btnAddMusic.Size = new Size(111, 23);
            btnAddMusic.TabIndex = 19;
            btnAddMusic.Text = "Adicionar a fila";
            btnAddMusic.UseVisualStyleBackColor = true;
            btnAddMusic.Click += btnAddMusic_Click;
            // 
            // btnCleanMusic
            // 
            btnCleanMusic.FlatStyle = FlatStyle.Flat;
            btnCleanMusic.Location = new Point(554, 294);
            btnCleanMusic.Name = "btnCleanMusic";
            btnCleanMusic.Size = new Size(111, 23);
            btnCleanMusic.TabIndex = 18;
            btnCleanMusic.Text = "Limpar lista";
            btnCleanMusic.UseVisualStyleBackColor = true;
            btnCleanMusic.Click += btnCleanMusic_Click;
            // 
            // btnDownloadMusic
            // 
            btnDownloadMusic.FlatStyle = FlatStyle.Flat;
            btnDownloadMusic.Location = new Point(8, 294);
            btnDownloadMusic.Name = "btnDownloadMusic";
            btnDownloadMusic.Size = new Size(111, 23);
            btnDownloadMusic.TabIndex = 17;
            btnDownloadMusic.Text = "Baixar musicas";
            btnDownloadMusic.UseVisualStyleBackColor = true;
            btnDownloadMusic.Click += btnDownloadMusic_Click;
            // 
            // listBoxLinksMusic
            // 
            listBoxLinksMusic.Font = new Font("Segoe UI", 9F);
            listBoxLinksMusic.FormattingEnabled = true;
            listBoxLinksMusic.ItemHeight = 15;
            listBoxLinksMusic.Location = new Point(8, 89);
            listBoxLinksMusic.Name = "listBoxLinksMusic";
            listBoxLinksMusic.Size = new Size(660, 199);
            listBoxLinksMusic.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 71);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 15;
            label7.Text = "Lista de downloads";
            // 
            // tbMusicLink
            // 
            tbMusicLink.Font = new Font("Segoe UI", 9F);
            tbMusicLink.Location = new Point(8, 30);
            tbMusicLink.Name = "tbMusicLink";
            tbMusicLink.Size = new Size(540, 23);
            tbMusicLink.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 12);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 13;
            label8.Text = "Link do video";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.MenuBar;
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(progressBar1);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(cbPower);
            tabPage3.Controls.Add(listBox1);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label4);
            tabPage3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(676, 460);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Video Converter";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(409, 80);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 33;
            button3.Text = "Selecionar";
            button3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.Location = new Point(8, 428);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(657, 23);
            progressBar1.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 410);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 31;
            label11.Text = "Aguardando...";
            // 
            // cbPower
            // 
            cbPower.AutoSize = true;
            cbPower.Location = new Point(171, 377);
            cbPower.Name = "cbPower";
            cbPower.Size = new Size(205, 19);
            cbPower.TabIndex = 30;
            cbPower.Text = "Desligar computador ao finalizar";
            cbPower.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(8, 142);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(660, 214);
            listBox1.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 124);
            label10.Name = "label10";
            label10.Size = new Size(186, 15);
            label10.TabIndex = 28;
            label10.Text = "Lista de arquivos para conversão";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Processador", "Placa de video Nvidia", "Placa de video AMD" });
            comboBox1.Location = new Point(508, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(160, 23);
            comboBox1.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(508, 62);
            label9.Name = "label9";
            label9.Size = new Size(145, 15);
            label9.TabIndex = 26;
            label9.Text = "Dispositivo de conversão";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(8, 374);
            button2.Name = "button2";
            button2.Size = new Size(157, 23);
            button2.TabIndex = 25;
            button2.Text = "Converter Arquivos";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F);
            textBox2.Location = new Point(8, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(395, 23);
            textBox2.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 62);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 23;
            label5.Text = "Local de saida";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(557, 31);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 21;
            button1.Text = "Adicionar a fila";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(8, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(540, 23);
            textBox1.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 13);
            label4.Name = "label4";
            label4.Size = new Size(217, 15);
            label4.TabIndex = 1;
            label4.Text = "Selecione local com arquivos de video";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(684, 491);
            Controls.Add(tbControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multi Video Converter";
            tbControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tbControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox tbVideoLink;
        private Label label1;
        private ListBox listBoxLinksVideos;
        private Label label2;
        private ProgressBar pbDownloadVideo;
        private Label labelStatusVideo;
        private Button btnLocationVideo;
        private TextBox tbLocationVideo;
        private Label label3;
        private Button btnAddVideo;
        private Button btnCleanVideos;
        private Button btnDownloadVideos;
        private ProgressBar pbDownloadMusic;
        private Label labelStatusMusic;
        private Button btnLocationMusic;
        private TextBox tbLocationMusic;
        private Label label6;
        private Button btnAddMusic;
        private Button btnCleanMusic;
        private Button btnDownloadMusic;
        private ListBox listBoxLinksMusic;
        private Label label7;
        private TextBox tbMusicLink;
        private Label label8;
        private Label label4;
        private ComboBox comboBox1;
        private Label label9;
        private Button button2;
        private TextBox textBox2;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private Label label11;
        private CheckBox cbPower;
        private ListBox listBox1;
        private Label label10;
        private Button button3;
    }
}
