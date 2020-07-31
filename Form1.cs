using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginerLearnProjrct {
    public partial class FormSort : Form {
        public FormSort() {
            InitializeComponent();
        }
        int[] arr = new int[32];
        private void buttonGenerate_Click(object sender, EventArgs e) {
            Random rnd = new Random();
            richTextBox1.Text += "Исходный массив";
            for(int i = 0;i < arr.Length; i++) {
                arr[i] = rnd.Next(-2056, 2056);
                richTextBox1.Text += arr[i].ToString() + " ";
            }
        }
        private void buttonSort_Click(object sender, EventArgs e) {
            Sort<int>.BubbleSort(arr);
            richTextBox1.Text += "\n\nОтсортированный массив";
            for(int i = 0; i < arr.Length; i++) {
                richTextBox1.Text += arr[i].ToString() + " ";
            }
        }
    }
}
