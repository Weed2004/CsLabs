namespace Lab3
{
    partial class Form1
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
            this.logsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.createNodeButton = new System.Windows.Forms.Button();
            this.createNodeNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addConnectionNode1Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addConnectionNode2Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addConnectionWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.removeConnectionNode2Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.removeConnectionNode1Name = new System.Windows.Forms.TextBox();
            this.removeConnectionButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.removeNodeName = new System.Windows.Forms.TextBox();
            this.removeNodeButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pathFindNode2Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pathFindNode1Name = new System.Windows.Forms.TextBox();
            this.pathFindButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveGrapgButton = new System.Windows.Forms.Button();
            this.loadGrapghButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logsTextBox
            // 
            this.logsTextBox.Location = new System.Drawing.Point(12, 624);
            this.logsTextBox.Multiline = true;
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.Size = new System.Drawing.Size(460, 172);
            this.logsTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 608);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.graphPanel.Location = new System.Drawing.Point(478, 25);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(668, 771);
            this.graphPanel.TabIndex = 2;
            // 
            // createNodeButton
            // 
            this.createNodeButton.Location = new System.Drawing.Point(12, 25);
            this.createNodeButton.Name = "createNodeButton";
            this.createNodeButton.Size = new System.Drawing.Size(100, 37);
            this.createNodeButton.TabIndex = 3;
            this.createNodeButton.Text = "Создать узел";
            this.createNodeButton.UseVisualStyleBackColor = true;
            this.createNodeButton.Click += new System.EventHandler(this.createNodeButton_Click);
            // 
            // createNodeNameTextBox
            // 
            this.createNodeNameTextBox.Location = new System.Drawing.Point(12, 81);
            this.createNodeNameTextBox.Name = "createNodeNameTextBox";
            this.createNodeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.createNodeNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя узла:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя узла 1:";
            // 
            // addConnectionNode1Name
            // 
            this.addConnectionNode1Name.Location = new System.Drawing.Point(226, 81);
            this.addConnectionNode1Name.Name = "addConnectionNode1Name";
            this.addConnectionNode1Name.Size = new System.Drawing.Size(100, 20);
            this.addConnectionNode1Name.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Создать связь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Имя узла 2:";
            // 
            // addConnectionNode2Name
            // 
            this.addConnectionNode2Name.Location = new System.Drawing.Point(226, 120);
            this.addConnectionNode2Name.Name = "addConnectionNode2Name";
            this.addConnectionNode2Name.Size = new System.Drawing.Size(100, 20);
            this.addConnectionNode2Name.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Вес:";
            // 
            // addConnectionWeight
            // 
            this.addConnectionWeight.Location = new System.Drawing.Point(226, 159);
            this.addConnectionWeight.Name = "addConnectionWeight";
            this.addConnectionWeight.Size = new System.Drawing.Size(100, 20);
            this.addConnectionWeight.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Имя узла 2:";
            // 
            // removeConnectionNode2Name
            // 
            this.removeConnectionNode2Name.Location = new System.Drawing.Point(337, 120);
            this.removeConnectionNode2Name.Name = "removeConnectionNode2Name";
            this.removeConnectionNode2Name.Size = new System.Drawing.Size(100, 20);
            this.removeConnectionNode2Name.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Имя узла 1:";
            // 
            // removeConnectionNode1Name
            // 
            this.removeConnectionNode1Name.Location = new System.Drawing.Point(337, 81);
            this.removeConnectionNode1Name.Name = "removeConnectionNode1Name";
            this.removeConnectionNode1Name.Size = new System.Drawing.Size(100, 20);
            this.removeConnectionNode1Name.TabIndex = 14;
            // 
            // removeConnectionButton
            // 
            this.removeConnectionButton.Location = new System.Drawing.Point(337, 25);
            this.removeConnectionButton.Name = "removeConnectionButton";
            this.removeConnectionButton.Size = new System.Drawing.Size(100, 37);
            this.removeConnectionButton.TabIndex = 13;
            this.removeConnectionButton.Text = "Удалить связь";
            this.removeConnectionButton.UseVisualStyleBackColor = true;
            this.removeConnectionButton.Click += new System.EventHandler(this.removeConnectionButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Имя узла:";
            // 
            // removeNodeName
            // 
            this.removeNodeName.Location = new System.Drawing.Point(118, 81);
            this.removeNodeName.Name = "removeNodeName";
            this.removeNodeName.Size = new System.Drawing.Size(100, 20);
            this.removeNodeName.TabIndex = 19;
            // 
            // removeNodeButton
            // 
            this.removeNodeButton.Location = new System.Drawing.Point(118, 25);
            this.removeNodeButton.Name = "removeNodeButton";
            this.removeNodeButton.Size = new System.Drawing.Size(100, 37);
            this.removeNodeButton.TabIndex = 18;
            this.removeNodeButton.Text = "Удалить узел";
            this.removeNodeButton.UseVisualStyleBackColor = true;
            this.removeNodeButton.Click += new System.EventHandler(this.removeNodeButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Имя узла 2:";
            // 
            // pathFindNode2Name
            // 
            this.pathFindNode2Name.Location = new System.Drawing.Point(12, 305);
            this.pathFindNode2Name.Name = "pathFindNode2Name";
            this.pathFindNode2Name.Size = new System.Drawing.Size(100, 20);
            this.pathFindNode2Name.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Имя узла 1:";
            // 
            // pathFindNode1Name
            // 
            this.pathFindNode1Name.Location = new System.Drawing.Point(12, 266);
            this.pathFindNode1Name.Name = "pathFindNode1Name";
            this.pathFindNode1Name.Size = new System.Drawing.Size(100, 20);
            this.pathFindNode1Name.TabIndex = 22;
            // 
            // pathFindButton
            // 
            this.pathFindButton.Location = new System.Drawing.Point(12, 210);
            this.pathFindButton.Name = "pathFindButton";
            this.pathFindButton.Size = new System.Drawing.Size(100, 37);
            this.pathFindButton.TabIndex = 21;
            this.pathFindButton.Text = "Найти путь";
            this.pathFindButton.UseVisualStyleBackColor = true;
            this.pathFindButton.Click += new System.EventHandler(this.pathFindButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveGrapgButton
            // 
            this.saveGrapgButton.Location = new System.Drawing.Point(140, 582);
            this.saveGrapgButton.Name = "saveGrapgButton";
            this.saveGrapgButton.Size = new System.Drawing.Size(100, 23);
            this.saveGrapgButton.TabIndex = 27;
            this.saveGrapgButton.Text = "Сохранить граф";
            this.saveGrapgButton.UseVisualStyleBackColor = true;
            this.saveGrapgButton.Click += new System.EventHandler(this.saveGrapgButton_Click);
            // 
            // loadGrapghButton
            // 
            this.loadGrapghButton.Location = new System.Drawing.Point(246, 582);
            this.loadGrapghButton.Name = "loadGrapghButton";
            this.loadGrapghButton.Size = new System.Drawing.Size(110, 23);
            this.loadGrapghButton.TabIndex = 28;
            this.loadGrapghButton.Text = "Загурзить граф";
            this.loadGrapghButton.UseVisualStyleBackColor = true;
            this.loadGrapghButton.Click += new System.EventHandler(this.loadGrapghButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 808);
            this.Controls.Add(this.loadGrapghButton);
            this.Controls.Add(this.saveGrapgButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pathFindNode2Name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pathFindNode1Name);
            this.Controls.Add(this.pathFindButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.removeNodeName);
            this.Controls.Add(this.removeNodeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.removeConnectionNode2Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.removeConnectionNode1Name);
            this.Controls.Add(this.removeConnectionButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addConnectionWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addConnectionNode2Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addConnectionNode1Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createNodeNameTextBox);
            this.Controls.Add(this.createNodeButton);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logsTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox logsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Button createNodeButton;
        private System.Windows.Forms.TextBox createNodeNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addConnectionNode1Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addConnectionNode2Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addConnectionWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox removeConnectionNode2Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox removeConnectionNode1Name;
        private System.Windows.Forms.Button removeConnectionButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox removeNodeName;
        private System.Windows.Forms.Button removeNodeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pathFindNode2Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pathFindNode1Name;
        private System.Windows.Forms.Button pathFindButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveGrapgButton;
        private System.Windows.Forms.Button loadGrapghButton;
    }
}

