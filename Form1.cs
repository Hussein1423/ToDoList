using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                checkedListBox1.Items.Add(textBox1.Text);
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Add Task";
                notifyIcon1.BalloonTipText = textBox1.Text;
                notifyIcon1.ShowBalloonTip(1000);
                textBox1.Clear();
            }
            else
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipTitle = "Error";
                notifyIcon1.BalloonTipText = "Empty String";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Text != string.Empty)
            {
                for (int i = 0; i <= checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i) == true)
                    {
                        checkedListBox1.Items.RemoveAt(i);
                        notifyIcon1.Icon = SystemIcons.Application;
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.BalloonTipTitle = "Delete Task";
                        notifyIcon1.BalloonTipText = checkedListBox1.GetItemText(i);
                        notifyIcon1.ShowBalloonTip(1000);
                    }

                }
            }
            else
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.BalloonTipTitle = "Error";
                notifyIcon1.BalloonTipText = "Empty String";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }
    }
}
