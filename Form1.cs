using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        public string path = @"Task.txt";
        public List<TaskData> tasks = new List<TaskData>();
        private System.Timers.Timer taskTimer;
        public ToDoList()
        {
            InitializeComponent();
            CheckFile();

            TaskTime_DateTimePicker.Format = DateTimePickerFormat.Custom;
            TaskTime_DateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";

            WhiteTheme_btn.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            taskTimer = new System.Timers.Timer();
            taskTimer.Interval = 60000;
            taskTimer.Elapsed += TaskTimer_Tik;
            taskTimer.Start();
        }

        private void AddTask_btn_Click(object sender, EventArgs e)
        {
            addTask();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            tasks.Clear();
            UpdateDataGridView();
            SaveTasks();
        }

        private void ClearSelected_Click(object sender, EventArgs e)
        {
            DeleteTasks();
        }

        private void DarkTheme_btn_Click(object sender, EventArgs e)
        {
            SetDarkTheme();
        }

        private void WhiteTheme_btn_Click(object sender, EventArgs e)
        {
            SetWhiteTheme();
        }

        private void SetDarkTheme()
        {
            this.BackColor = Color.Black;
            Tasks_DataGridView.BackgroundColor = Color.Gray;
            TaskName_label.ForeColor = Color.Gray;
            TaskDescription_label.ForeColor = Color.Gray;
            TaskTime_label.ForeColor = Color.Gray;

            DarkTheme_btn.Visible = false;
            WhiteTheme_btn.Visible = true;
        }

        private void SetWhiteTheme()
        {
            this.BackColor = Color.White;
            Tasks_DataGridView.BackgroundColor = Color.White;
            TaskName_label.ForeColor = Color.Black;
            TaskDescription_label.ForeColor = Color.Black;
            TaskTime_label.ForeColor = Color.Black;

            WhiteTheme_btn.Visible = false;
            DarkTheme_btn.Visible = true;
        }

        private void CheckFile()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else LoadTasks();
        }

        private void addTask()
        {
            if (string.IsNullOrEmpty(TaskName_TextBox.Text) || string.IsNullOrEmpty(TaskDescription_TextBox.Text))
            {
                MessageBox.Show("Вы не указали данные о задаче!");
            }
            else if (TaskTime_DateTimePicker.Value <= DateTime.Now)
            {
                MessageBox.Show("Укажите актуальное время!");
            }
            else
            {
                tasks.Add(new TaskData
                {
                    Name = TaskName_TextBox.Text,
                    Description = TaskDescription_TextBox.Text,
                    Time = TaskTime_DateTimePicker.Value,
                    isNotifed = false
                });

                UpdateDataGridView();
                SaveTasks();
            }
        }
        private void LoadTasks()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<TaskData>));
                using (StreamReader reader = new StreamReader(path))
                {
                    tasks = (List<TaskData>)serializer.Deserialize(reader);
                }

                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки задач: " + ex.Message);
            }
        }

        private void SaveTasks()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<TaskData>));
                using (StreamWriter writer = new StreamWriter(path))
                {
                    serializer.Serialize(writer, tasks);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения задач: " + ex.Message);
            }
        }

        private void DeleteTasks()
        {
            if (Tasks_DataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in Tasks_DataGridView.SelectedRows)
                {
                    tasks.RemoveAt(row.Index);
                }
                UpdateDataGridView();
                SaveTasks();
            }
            else
            {
                MessageBox.Show("Вы не выбрали задачи!");
            }
        }

        private void UpdateDataGridView()
        {
            Tasks_DataGridView.Rows.Clear();
            foreach (var task in tasks)
            {
                Tasks_DataGridView.Rows.Add(task.Name, task.Description, task.Time.ToString("dd.MM.yyyy HH:mm"));
            }
        }

        private void TaskTimer_Tik(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (var task in tasks)
            {
                if (task.Time <= DateTime.Now && task.isNotifed == false)
                {
                    MessageBox.Show($"Задача '{task.Name}' просрочена!", "Задача просрочена");
                    task.isNotifed = true;
                }
            }
        }
    }
}
