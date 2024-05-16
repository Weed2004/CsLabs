namespace WinFormsApp1
{
    partial class Form1
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
            LogsBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ClassNameStrParamsTextBox = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            ClassNameInvokeMethodTextBox = new TextBox();
            MethodNameTextBox = new TextBox();
            button3 = new Button();
            ClassNameAllMembersToFileTextBox = new TextBox();
            label5 = new Label();
            button4 = new Button();
            ClassNameGenerateFileTextBox = new TextBox();
            label6 = new Label();
            CommandTextBox = new TextBox();
            ClassNameConsoleParserTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // LogsBox
            // 
            LogsBox.Location = new Point(12, 37);
            LogsBox.Multiline = true;
            LogsBox.Name = "LogsBox";
            LogsBox.Size = new Size(410, 566);
            LogsBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "LOGS";
            // 
            // button1
            // 
            button1.Location = new Point(446, 37);
            button1.Name = "button1";
            button1.Size = new Size(194, 85);
            button1.TabIndex = 2;
            button1.Text = "Вывести методы со строковыми параметрами";
            button1.UseVisualStyleBackColor = true;
            // 
            // ClassNameStrParamsTextBox
            // 
            ClassNameStrParamsTextBox.Location = new Point(454, 142);
            ClassNameStrParamsTextBox.Name = "ClassNameStrParamsTextBox";
            ClassNameStrParamsTextBox.Size = new Size(186, 23);
            ClassNameStrParamsTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 124);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Класс:";
            // 
            // button2
            // 
            button2.Location = new Point(655, 37);
            button2.Name = "button2";
            button2.Size = new Size(186, 85);
            button2.TabIndex = 5;
            button2.Text = "Вызвать метод с параметрами из файла";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(655, 125);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 6;
            label3.Text = "Класс:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 169);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Метод:";
            // 
            // ClassNameInvokeMethodTextBox
            // 
            ClassNameInvokeMethodTextBox.Location = new Point(655, 143);
            ClassNameInvokeMethodTextBox.Name = "ClassNameInvokeMethodTextBox";
            ClassNameInvokeMethodTextBox.Size = new Size(186, 23);
            ClassNameInvokeMethodTextBox.TabIndex = 8;
            // 
            // MethodNameTextBox
            // 
            MethodNameTextBox.Location = new Point(655, 187);
            MethodNameTextBox.Name = "MethodNameTextBox";
            MethodNameTextBox.Size = new Size(186, 23);
            MethodNameTextBox.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(872, 37);
            button3.Name = "button3";
            button3.Size = new Size(160, 85);
            button3.TabIndex = 10;
            button3.Text = "Вывести содержимое класса в файл";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ClassNameAllMembersToFileTextBox
            // 
            ClassNameAllMembersToFileTextBox.Location = new Point(872, 143);
            ClassNameAllMembersToFileTextBox.Name = "ClassNameAllMembersToFileTextBox";
            ClassNameAllMembersToFileTextBox.Size = new Size(186, 23);
            ClassNameAllMembersToFileTextBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(872, 125);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Класс:";
            // 
            // button4
            // 
            button4.Location = new Point(446, 274);
            button4.Name = "button4";
            button4.Size = new Size(194, 57);
            button4.TabIndex = 13;
            button4.Text = "Генерация файла класса";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ClassNameGenerateFileTextBox
            // 
            ClassNameGenerateFileTextBox.Location = new Point(454, 352);
            ClassNameGenerateFileTextBox.Name = "ClassNameGenerateFileTextBox";
            ClassNameGenerateFileTextBox.Size = new Size(186, 23);
            ClassNameGenerateFileTextBox.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(454, 334);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 14;
            label6.Text = "Класс:";
            // 
            // CommandTextBox
            // 
            CommandTextBox.Location = new Point(655, 396);
            CommandTextBox.Name = "CommandTextBox";
            CommandTextBox.Size = new Size(186, 23);
            CommandTextBox.TabIndex = 20;
            // 
            // ClassNameConsoleParserTextBox
            // 
            ClassNameConsoleParserTextBox.Location = new Point(655, 352);
            ClassNameConsoleParserTextBox.Name = "ClassNameConsoleParserTextBox";
            ClassNameConsoleParserTextBox.Size = new Size(186, 23);
            ClassNameConsoleParserTextBox.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(655, 378);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 18;
            label7.Text = "Команда:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(655, 334);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 17;
            label8.Text = "Класс:";
            // 
            // button5
            // 
            button5.Location = new Point(655, 246);
            button5.Name = "button5";
            button5.Size = new Size(186, 85);
            button5.TabIndex = 16;
            button5.Text = "Задать значения через атрибут";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 615);
            Controls.Add(CommandTextBox);
            Controls.Add(ClassNameConsoleParserTextBox);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button5);
            Controls.Add(ClassNameGenerateFileTextBox);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(ClassNameAllMembersToFileTextBox);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(MethodNameTextBox);
            Controls.Add(ClassNameInvokeMethodTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(ClassNameStrParamsTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(LogsBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox LogsBox;
        private Label label1;
        private Button button1;
        private TextBox ClassNameStrParamsTextBox;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox ClassNameInvokeMethodTextBox;
        private TextBox MethodNameTextBox;
        private Button button3;
        private TextBox ClassNameAllMembersToFileTextBox;
        private Label label5;
        private Button button4;
        private TextBox ClassNameGenerateFileTextBox;
        private Label label6;
        private TextBox CommandTextBox;
        private TextBox ClassNameConsoleParserTextBox;
        private Label label7;
        private Label label8;
        private Button button5;
    }
}