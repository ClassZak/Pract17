namespace Pract17
{
    partial class PortScanForm
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
            this.buttonScan = new System.Windows.Forms.Button();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPortBegin = new System.Windows.Forms.Label();
            this.labelPortEnd = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.numericUpDownPortBegin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPortEnd = new System.Windows.Forms.NumericUpDown();
            this.progressBarScan = new System.Windows.Forms.ProgressBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(683, 12);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(105, 23);
            this.buttonScan.TabIndex = 0;
            this.buttonScan.Text = "Сканировать";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 17);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(53, 13);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "IP адрес:";
            // 
            // labelPortBegin
            // 
            this.labelPortBegin.AutoSize = true;
            this.labelPortBegin.Location = new System.Drawing.Point(234, 17);
            this.labelPortBegin.Name = "labelPortBegin";
            this.labelPortBegin.Size = new System.Drawing.Size(52, 13);
            this.labelPortBegin.TabIndex = 2;
            this.labelPortBegin.Text = "Порты с ";
            // 
            // labelPortEnd
            // 
            this.labelPortEnd.AutoSize = true;
            this.labelPortEnd.Location = new System.Drawing.Point(418, 17);
            this.labelPortEnd.Name = "labelPortEnd";
            this.labelPortEnd.Size = new System.Drawing.Size(19, 13);
            this.labelPortEnd.TabIndex = 3;
            this.labelPortEnd.Text = "по";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(71, 14);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 4;
            this.textBoxIP.Text = "127.0.0.1";
            // 
            // numericUpDownPortBegin
            // 
            this.numericUpDownPortBegin.Location = new System.Drawing.Point(292, 14);
            this.numericUpDownPortBegin.Maximum = new decimal(new int[] {
            4999,
            0,
            0,
            0});
            this.numericUpDownPortBegin.Name = "numericUpDownPortBegin";
            this.numericUpDownPortBegin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPortBegin.TabIndex = 5;
            this.numericUpDownPortBegin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownPortEnd
            // 
            this.numericUpDownPortEnd.Location = new System.Drawing.Point(443, 14);
            this.numericUpDownPortEnd.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownPortEnd.Name = "numericUpDownPortEnd";
            this.numericUpDownPortEnd.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPortEnd.TabIndex = 6;
            this.numericUpDownPortEnd.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // progressBarScan
            // 
            this.progressBarScan.Location = new System.Drawing.Point(12, 415);
            this.progressBarScan.Name = "progressBarScan";
            this.progressBarScan.Size = new System.Drawing.Size(776, 23);
            this.progressBarScan.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 369);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Порт";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Открыт";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Закрыт";
            // 
            // PortScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.progressBarScan);
            this.Controls.Add(this.numericUpDownPortEnd);
            this.Controls.Add(this.numericUpDownPortBegin);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelPortEnd);
            this.Controls.Add(this.labelPortBegin);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.buttonScan);
            this.Name = "PortScanForm";
            this.Text = "PortScan";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPortEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPortBegin;
        private System.Windows.Forms.Label labelPortEnd;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.NumericUpDown numericUpDownPortBegin;
        private System.Windows.Forms.NumericUpDown numericUpDownPortEnd;
        private System.Windows.Forms.ProgressBar progressBarScan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

