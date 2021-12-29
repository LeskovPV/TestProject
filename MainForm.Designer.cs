namespace TestProject
{
    partial class МainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(МainForm));
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.checkGroupBox = new System.Windows.Forms.GroupBox();
            this.checkLabel = new System.Windows.Forms.Label();
            this.checkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.checkButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.sourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.solutionButton = new System.Windows.Forms.Button();
            this.taskButton = new System.Windows.Forms.Button();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.inputDataGridView = new System.Windows.Forms.DataGridView();
            this.statisticsPanel = new System.Windows.Forms.Panel();
            this.statisticsLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.matchGroupBox = new System.Windows.Forms.GroupBox();
            this.goalsLabel = new System.Windows.Forms.Label();
            this.goalsTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.intervalGroupBox = new System.Windows.Forms.GroupBox();
            this.beginLabel = new System.Windows.Forms.Label();
            this.beginNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endLabel = new System.Windows.Forms.Label();
            this.endNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.calcButton = new System.Windows.Forms.Button();
            this.outputGroupBox.SuspendLayout();
            this.checkGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkNumericUpDown)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.statisticsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            this.statisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).BeginInit();
            this.matchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
            this.intervalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beginNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.resultTextBox);
            this.outputGroupBox.Controls.Add(this.outputTextBox);
            this.outputGroupBox.Controls.Add(this.checkGroupBox);
            this.outputGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputGroupBox.Location = new System.Drawing.Point(7, 448);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Padding = new System.Windows.Forms.Padding(7);
            this.outputGroupBox.Size = new System.Drawing.Size(875, 153);
            this.outputGroupBox.TabIndex = 2;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Результат";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTextBox.Location = new System.Drawing.Point(284, 20);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(365, 126);
            this.resultTextBox.TabIndex = 6;
            this.resultTextBox.Text = "\tРасчётные значения\tРезультат проверки\r\n\r\n\tPx\t\t\tQx\r\n\r\n\tPy\t\t\tQy\r\n\r\n\tPn\t\t\tQn\r\n\r\n\tPz" +
    "\t\t\tQz";
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.outputTextBox.Enabled = false;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.Location = new System.Drawing.Point(7, 20);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(277, 126);
            this.outputTextBox.TabIndex = 3;
            this.outputTextBox.Text = "\r\n\r\nВероятность победы команды \"Хозяева\":\r\n\r\nВероятность победы команды \"Гости\":\r" +
    "\n\r\nВероятность ничьи:\r\n\r\nВероятность что интервал не будет закрыт:";
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkGroupBox
            // 
            this.checkGroupBox.Controls.Add(this.checkLabel);
            this.checkGroupBox.Controls.Add(this.checkNumericUpDown);
            this.checkGroupBox.Controls.Add(this.checkButton);
            this.checkGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkGroupBox.Enabled = false;
            this.checkGroupBox.Location = new System.Drawing.Point(649, 20);
            this.checkGroupBox.Name = "checkGroupBox";
            this.checkGroupBox.Padding = new System.Windows.Forms.Padding(7);
            this.checkGroupBox.Size = new System.Drawing.Size(219, 126);
            this.checkGroupBox.TabIndex = 0;
            this.checkGroupBox.TabStop = false;
            this.checkGroupBox.Text = "Верефикация";
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Location = new System.Drawing.Point(112, 30);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(97, 13);
            this.checkLabel.TabIndex = 4;
            this.checkLabel.Text = "Число испытаний";
            // 
            // checkNumericUpDown
            // 
            this.checkNumericUpDown.Location = new System.Drawing.Point(10, 28);
            this.checkNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.checkNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.checkNumericUpDown.Name = "checkNumericUpDown";
            this.checkNumericUpDown.Size = new System.Drawing.Size(96, 20);
            this.checkNumericUpDown.TabIndex = 3;
            this.checkNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.checkNumericUpDown.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(8, 93);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(203, 23);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Проверить методом Монте-Карло";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.sourceLinkLabel);
            this.titlePanel.Controls.Add(this.solutionButton);
            this.titlePanel.Controls.Add(this.taskButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(7, 7);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(875, 51);
            this.titlePanel.TabIndex = 3;
            // 
            // sourceLinkLabel
            // 
            this.sourceLinkLabel.AutoSize = true;
            this.sourceLinkLabel.Location = new System.Drawing.Point(709, 17);
            this.sourceLinkLabel.Name = "sourceLinkLabel";
            this.sourceLinkLabel.Size = new System.Drawing.Size(149, 13);
            this.sourceLinkLabel.TabIndex = 2;
            this.sourceLinkLabel.TabStop = true;
            this.sourceLinkLabel.Text = "Исходный код на github.com";
            this.sourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceLinkLabel_LinkClicked);
            // 
            // solutionButton
            // 
            this.solutionButton.Location = new System.Drawing.Point(553, 12);
            this.solutionButton.Name = "solutionButton";
            this.solutionButton.Size = new System.Drawing.Size(136, 23);
            this.solutionButton.TabIndex = 1;
            this.solutionButton.Text = "Посмотреть решение";
            this.solutionButton.UseVisualStyleBackColor = true;
            this.solutionButton.Click += new System.EventHandler(this.solutionButton_Click);
            // 
            // taskButton
            // 
            this.taskButton.Location = new System.Drawing.Point(404, 12);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(138, 23);
            this.taskButton.TabIndex = 0;
            this.taskButton.Text = "Посмотреть задание";
            this.taskButton.UseVisualStyleBackColor = true;
            this.taskButton.Click += new System.EventHandler(this.taskButton_Click);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.statisticsGroupBox);
            this.inputGroupBox.Controls.Add(this.matchGroupBox);
            this.inputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputGroupBox.Location = new System.Drawing.Point(7, 58);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Padding = new System.Windows.Forms.Padding(7);
            this.inputGroupBox.Size = new System.Drawing.Size(875, 390);
            this.inputGroupBox.TabIndex = 4;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Входные данные";
            // 
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.Controls.Add(this.inputDataGridView);
            this.statisticsGroupBox.Controls.Add(this.statisticsPanel);
            this.statisticsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsGroupBox.Location = new System.Drawing.Point(319, 20);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Padding = new System.Windows.Forms.Padding(7);
            this.statisticsGroupBox.Size = new System.Drawing.Size(549, 363);
            this.statisticsGroupBox.TabIndex = 7;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Статистика сыгранных матчей";
            // 
            // inputDataGridView
            // 
            this.inputDataGridView.AllowUserToAddRows = false;
            this.inputDataGridView.AllowUserToDeleteRows = false;
            this.inputDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.inputDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N5";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inputDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.inputDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDataGridView.Location = new System.Drawing.Point(7, 122);
            this.inputDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.inputDataGridView.Name = "inputDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inputDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.inputDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.inputDataGridView.Size = new System.Drawing.Size(535, 234);
            this.inputDataGridView.TabIndex = 6;
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.Controls.Add(this.statisticsLabel);
            this.statisticsPanel.Controls.Add(this.yLabel);
            this.statisticsPanel.Controls.Add(this.xLabel);
            this.statisticsPanel.Controls.Add(this.yNumericUpDown);
            this.statisticsPanel.Controls.Add(this.xNumericUpDown);
            this.statisticsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statisticsPanel.Location = new System.Drawing.Point(7, 20);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(535, 102);
            this.statisticsPanel.TabIndex = 4;
            // 
            // statisticsLabel
            // 
            this.statisticsLabel.AutoSize = true;
            this.statisticsLabel.Location = new System.Drawing.Point(21, 82);
            this.statisticsLabel.Name = "statisticsLabel";
            this.statisticsLabel.Size = new System.Drawing.Size(383, 13);
            this.statisticsLabel.TabIndex = 4;
            this.statisticsLabel.Text = "Статистика предыдущих встреч (вероятности возможных исходов матча):";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(75, 50);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(396, 13);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "Максимальное количество голов, забитое командой \"Гости\" (по вертикали)";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(75, 16);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(421, 13);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "Максимальное количество голов, забитое командой \"Хозяева\" (по горизонтали)";
            // 
            // yNumericUpDown
            // 
            this.yNumericUpDown.Location = new System.Drawing.Point(19, 48);
            this.yNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.yNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yNumericUpDown.Name = "yNumericUpDown";
            this.yNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.yNumericUpDown.TabIndex = 1;
            this.yNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.yNumericUpDown.ValueChanged += new System.EventHandler(this.gridNumericUpDown_ValueChanged);
            // 
            // xNumericUpDown
            // 
            this.xNumericUpDown.Location = new System.Drawing.Point(19, 14);
            this.xNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.xNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xNumericUpDown.Name = "xNumericUpDown";
            this.xNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.xNumericUpDown.TabIndex = 0;
            this.xNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.xNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.xNumericUpDown.ValueChanged += new System.EventHandler(this.gridNumericUpDown_ValueChanged);
            // 
            // matchGroupBox
            // 
            this.matchGroupBox.Controls.Add(this.goalsLabel);
            this.matchGroupBox.Controls.Add(this.goalsTextBox);
            this.matchGroupBox.Controls.Add(this.timeLabel);
            this.matchGroupBox.Controls.Add(this.timeNumericUpDown);
            this.matchGroupBox.Controls.Add(this.intervalGroupBox);
            this.matchGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.matchGroupBox.Location = new System.Drawing.Point(7, 20);
            this.matchGroupBox.Name = "matchGroupBox";
            this.matchGroupBox.Padding = new System.Windows.Forms.Padding(7);
            this.matchGroupBox.Size = new System.Drawing.Size(312, 363);
            this.matchGroupBox.TabIndex = 6;
            this.matchGroupBox.TabStop = false;
            this.matchGroupBox.Text = "Текущий матч";
            // 
            // goalsLabel
            // 
            this.goalsLabel.AutoSize = true;
            this.goalsLabel.Location = new System.Drawing.Point(142, 65);
            this.goalsLabel.Name = "goalsLabel";
            this.goalsLabel.Size = new System.Drawing.Size(121, 13);
            this.goalsLabel.TabIndex = 10;
            this.goalsLabel.Text = "Список забитых голов";
            // 
            // goalsTextBox
            // 
            this.goalsTextBox.Location = new System.Drawing.Point(20, 59);
            this.goalsTextBox.Name = "goalsTextBox";
            this.goalsTextBox.Size = new System.Drawing.Size(115, 20);
            this.goalsTextBox.TabIndex = 9;
            this.goalsTextBox.Text = "ХХГ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(76, 34);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(119, 13);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Минут до конца матча";
            // 
            // timeNumericUpDown
            // 
            this.timeNumericUpDown.Location = new System.Drawing.Point(20, 32);
            this.timeNumericUpDown.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.timeNumericUpDown.Name = "timeNumericUpDown";
            this.timeNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.timeNumericUpDown.TabIndex = 7;
            this.timeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // intervalGroupBox
            // 
            this.intervalGroupBox.Controls.Add(this.beginLabel);
            this.intervalGroupBox.Controls.Add(this.beginNumericUpDown);
            this.intervalGroupBox.Controls.Add(this.endLabel);
            this.intervalGroupBox.Controls.Add(this.endNumericUpDown);
            this.intervalGroupBox.Controls.Add(this.calcButton);
            this.intervalGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.intervalGroupBox.Location = new System.Drawing.Point(7, 86);
            this.intervalGroupBox.Name = "intervalGroupBox";
            this.intervalGroupBox.Padding = new System.Windows.Forms.Padding(7);
            this.intervalGroupBox.Size = new System.Drawing.Size(298, 270);
            this.intervalGroupBox.TabIndex = 2;
            this.intervalGroupBox.TabStop = false;
            this.intervalGroupBox.Text = "Интервал";
            // 
            // beginLabel
            // 
            this.beginLabel.AutoSize = true;
            this.beginLabel.Location = new System.Drawing.Point(78, 23);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(111, 13);
            this.beginLabel.TabIndex = 8;
            this.beginLabel.Text = "Номер первого гола";
            // 
            // beginNumericUpDown
            // 
            this.beginNumericUpDown.Location = new System.Drawing.Point(22, 21);
            this.beginNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.beginNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beginNumericUpDown.Name = "beginNumericUpDown";
            this.beginNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.beginNumericUpDown.TabIndex = 7;
            this.beginNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.beginNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(78, 49);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(129, 13);
            this.endLabel.TabIndex = 6;
            this.endLabel.Text = "Номер последнего гола";
            // 
            // endNumericUpDown
            // 
            this.endNumericUpDown.Location = new System.Drawing.Point(22, 47);
            this.endNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.endNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNumericUpDown.Name = "endNumericUpDown";
            this.endNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.endNumericUpDown.TabIndex = 5;
            this.endNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.endNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(22, 237);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(261, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Рассчитть вероятности исходов на интервале";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // МainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 608);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.outputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "МainForm";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестовое задание";
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.checkGroupBox.ResumeLayout(false);
            this.checkGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkNumericUpDown)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            this.statisticsPanel.ResumeLayout(false);
            this.statisticsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).EndInit();
            this.matchGroupBox.ResumeLayout(false);
            this.matchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
            this.intervalGroupBox.ResumeLayout(false);
            this.intervalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beginNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox checkGroupBox;
        private System.Windows.Forms.Label checkLabel;
        private System.Windows.Forms.NumericUpDown checkNumericUpDown;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button solutionButton;
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        protected System.Windows.Forms.DataGridView inputDataGridView;
        private System.Windows.Forms.Panel statisticsPanel;
        private System.Windows.Forms.Label statisticsLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.NumericUpDown yNumericUpDown;
        private System.Windows.Forms.NumericUpDown xNumericUpDown;
        private System.Windows.Forms.GroupBox matchGroupBox;
        private System.Windows.Forms.Label goalsLabel;
        private System.Windows.Forms.TextBox goalsTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.NumericUpDown timeNumericUpDown;
        private System.Windows.Forms.GroupBox intervalGroupBox;
        private System.Windows.Forms.Label beginLabel;
        private System.Windows.Forms.NumericUpDown beginNumericUpDown;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.NumericUpDown endNumericUpDown;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.LinkLabel sourceLinkLabel;
    }
}

