using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoList : Form
    {
        public string path = @"Task.txt";
        public ToDoList()
        {
            InitializeComponent();
            CheckFile();

            WhiteTheme_btn.Visible = false;
        }

        private void AddTask_btn_Click(object sender, EventArgs e)
        {
            if (TaskTime_DateTimePicker.Value >= DateTime.Now)
            {
                Tasks_DataGridView.Rows.Add(TaskName_TextBox.Text, TaskDescription_TextBox.Text, TaskTime_DateTimePicker.Value.ToString("dd/MM/yy HH:mm"));
            }
            else MessageBox.Show("Выберите актуальное время");
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Tasks_DataGridView.Rows.Clear();
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

        private void LoadTasks()
        {
            int a = 0;
        }

        private void DeleteTasks()
        {
            if (Tasks_DataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in Tasks_DataGridView.SelectedRows)
                {
                    Tasks_DataGridView.Rows.Clear();
                }
            }
            else MessageBox.Show("Вы не выбрали задачи!");
        }
    }
}
