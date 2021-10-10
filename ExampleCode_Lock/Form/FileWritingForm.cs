using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExampleCode_Lock.Class;

namespace ExampleCode_Lock
{
    public partial class Form1 : Form
    {
        FileManager fm;

        public Form1()
        {
            InitializeComponent();
            fm = new FileManager();
        }

        private async void btn_Write_Click(object sender, EventArgs e)
        {
            int num = 10;
            Task[] tasks = new Task[num];

            Parallel.For(0, num, i =>
           {
               WriteText($"{txt_WriteText.Text}{i}");
           });
            /*
            for (int i = 0; i < num; i++)
            {
                string str = txt_WriteText.Text + i.ToString();
                tasks[i] = Task.Run(() =>
                {
                    WriteText(str);
                });
            }
            await Task.WhenAll(tasks);
            */
            WriteText("完了");
        }

        private void WriteText(string text)
        {
            string tmp = text;
            fm.Write(tmp);
        }
    }
}
