namespace WinFormsApp1
{

    using System;
    using System.Windows.Forms;
    partial class Form1
    {

        private FileManager fileManager;
        private Button buttonStart;
        private Button buttonStop;
        private ListBox listBoxFiles;
        private Timer timer;
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

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            // Запуск таймера
            timer.Start();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            // Остановка таймера
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Выполнение поиска новых файлов
            fileManager.ActiveSearch();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            // Обновление списка файлов
            listBoxFiles.Items.Clear();
            foreach (string file in fileManager.files)
            {
                listBoxFiles.Items.Add(file);
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonStart = new Button();
            buttonStop = new Button();
            listBoxFiles = new ListBox();
            timer = new Timer(components);
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(0, 12);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.Click += ButtonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(0, 41);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(75, 23);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "Stop";
            buttonStop.Click += ButtonStop_Click;
            // 
            // listBoxFiles
            // 
            listBoxFiles.ItemHeight = 15;
            listBoxFiles.Location = new Point(231, 12);
            listBoxFiles.Name = "listBoxFiles";
            listBoxFiles.Size = new Size(571, 484);
            listBoxFiles.TabIndex = 3;
            listBoxFiles.SelectedIndexChanged += listBoxFiles_SelectedIndexChanged;
            // 
            // timer
            // 
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 508);
            Controls.Add(buttonStart);
            Controls.Add(buttonStop);
            Controls.Add(listBoxFiles);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            fileManager = new FileManager();
            ResumeLayout(false);
        }

        #endregion
    }
}