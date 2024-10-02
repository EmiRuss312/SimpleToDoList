namespace ToDoList
{
    partial class ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.TaskName_label = new System.Windows.Forms.Label();
            this.TaskDescription_label = new System.Windows.Forms.Label();
            this.TaskTime_label = new System.Windows.Forms.Label();
            this.TaskName_TextBox = new System.Windows.Forms.TextBox();
            this.TaskDescription_TextBox = new System.Windows.Forms.TextBox();
            this.TaskTime_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Tasks_DataGridView = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddTask_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.ClearSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskName_label
            // 
            this.TaskName_label.AutoSize = true;
            this.TaskName_label.Location = new System.Drawing.Point(12, 20);
            this.TaskName_label.Name = "TaskName_label";
            this.TaskName_label.Size = new System.Drawing.Size(95, 13);
            this.TaskName_label.TabIndex = 2;
            this.TaskName_label.Text = "Название задачи";
            this.TaskName_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskDescription_label
            // 
            this.TaskDescription_label.AutoSize = true;
            this.TaskDescription_label.Location = new System.Drawing.Point(12, 50);
            this.TaskDescription_label.Name = "TaskDescription_label";
            this.TaskDescription_label.Size = new System.Drawing.Size(95, 13);
            this.TaskDescription_label.TabIndex = 3;
            this.TaskDescription_label.Text = "Описание задачи";
            this.TaskDescription_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskTime_label
            // 
            this.TaskTime_label.AutoSize = true;
            this.TaskTime_label.Location = new System.Drawing.Point(12, 80);
            this.TaskTime_label.Name = "TaskTime_label";
            this.TaskTime_label.Size = new System.Drawing.Size(99, 13);
            this.TaskTime_label.TabIndex = 4;
            this.TaskTime_label.Text = "Время для задачи";
            this.TaskTime_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaskName_TextBox
            // 
            this.TaskName_TextBox.Location = new System.Drawing.Point(114, 20);
            this.TaskName_TextBox.MaxLength = 48;
            this.TaskName_TextBox.Name = "TaskName_TextBox";
            this.TaskName_TextBox.Size = new System.Drawing.Size(272, 20);
            this.TaskName_TextBox.TabIndex = 5;
            // 
            // TaskDescription_TextBox
            // 
            this.TaskDescription_TextBox.Location = new System.Drawing.Point(114, 50);
            this.TaskDescription_TextBox.MaxLength = 48;
            this.TaskDescription_TextBox.Name = "TaskDescription_TextBox";
            this.TaskDescription_TextBox.Size = new System.Drawing.Size(272, 20);
            this.TaskDescription_TextBox.TabIndex = 6;
            // 
            // TaskTime_DateTimePicker
            // 
            this.TaskTime_DateTimePicker.Location = new System.Drawing.Point(114, 80);
            this.TaskTime_DateTimePicker.Name = "TaskTime_DateTimePicker";
            this.TaskTime_DateTimePicker.Size = new System.Drawing.Size(272, 20);
            this.TaskTime_DateTimePicker.TabIndex = 7;
            // 
            // Tasks_DataGridView
            // 
            this.Tasks_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tasks_DataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Tasks_DataGridView.ColumnHeadersVisible = false;
            this.Tasks_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.Description,
            this.TaskTime});
            this.Tasks_DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tasks_DataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.Tasks_DataGridView.Location = new System.Drawing.Point(0, 192);
            this.Tasks_DataGridView.Name = "Tasks_DataGridView";
            this.Tasks_DataGridView.ReadOnly = true;
            this.Tasks_DataGridView.Size = new System.Drawing.Size(405, 271);
            this.Tasks_DataGridView.TabIndex = 8;
            // 
            // TaskName
            // 
            this.TaskName.FillWeight = 58.66167F;
            this.TaskName.HeaderText = "Задача";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 165.1962F;
            this.Description.HeaderText = "Описание";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // TaskTime
            // 
            this.TaskTime.FillWeight = 76.14212F;
            this.TaskTime.HeaderText = "Время";
            this.TaskTime.Name = "TaskTime";
            this.TaskTime.ReadOnly = true;
            // 
            // AddTask_btn
            // 
            this.AddTask_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddTask_btn.Image = ((System.Drawing.Image)(resources.GetObject("AddTask_btn.Image")));
            this.AddTask_btn.Location = new System.Drawing.Point(12, 106);
            this.AddTask_btn.Name = "AddTask_btn";
            this.AddTask_btn.Size = new System.Drawing.Size(80, 80);
            this.AddTask_btn.TabIndex = 9;
            this.AddTask_btn.UseVisualStyleBackColor = false;
            this.AddTask_btn.Click += new System.EventHandler(this.AddTask_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Clear_btn.Image = ((System.Drawing.Image)(resources.GetObject("Clear_btn.Image")));
            this.Clear_btn.Location = new System.Drawing.Point(313, 106);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(80, 80);
            this.Clear_btn.TabIndex = 10;
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // ClearSelected
            // 
            this.ClearSelected.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClearSelected.Image = ((System.Drawing.Image)(resources.GetObject("ClearSelected.Image")));
            this.ClearSelected.Location = new System.Drawing.Point(227, 106);
            this.ClearSelected.Name = "ClearSelected";
            this.ClearSelected.Size = new System.Drawing.Size(80, 80);
            this.ClearSelected.TabIndex = 11;
            this.ClearSelected.UseVisualStyleBackColor = false;
            this.ClearSelected.Click += new System.EventHandler(this.ClearSelected_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(405, 463);
            this.Controls.Add(this.ClearSelected);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.AddTask_btn);
            this.Controls.Add(this.Tasks_DataGridView);
            this.Controls.Add(this.TaskTime_DateTimePicker);
            this.Controls.Add(this.TaskDescription_TextBox);
            this.Controls.Add(this.TaskName_TextBox);
            this.Controls.Add(this.TaskTime_label);
            this.Controls.Add(this.TaskDescription_label);
            this.Controls.Add(this.TaskName_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TaskName_label;
        private System.Windows.Forms.Label TaskDescription_label;
        private System.Windows.Forms.Label TaskTime_label;
        private System.Windows.Forms.TextBox TaskName_TextBox;
        private System.Windows.Forms.TextBox TaskDescription_TextBox;
        private System.Windows.Forms.DateTimePicker TaskTime_DateTimePicker;
        private System.Windows.Forms.DataGridView Tasks_DataGridView;
        private System.Windows.Forms.Button AddTask_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button ClearSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskTime;
    }
}

