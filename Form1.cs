using System;
using System.Windows.Forms;

namespace BeginerLearnProjrct {
    public partial class FormSort : Form {
        public FormSort() {
            InitializeComponent();
        }
        int[] arr = new int[32];
        char mode = '1';
        private void buttonGenerate_Click(object sender, EventArgs e) {
            Random rnd = new Random();
            if(richTextBox1.Text != "") {
                richTextBox1.Text += "\n\n";
            }
            richTextBox1.Text += "Исходный массив";
            for(int i = 0;i < arr.Length; i++) {
                arr[i] = rnd.Next(-2056, 2056);
                richTextBox1.Text += arr[i].ToString() + " ";
            }
        }
        private void buttonSort_Click(object sender, EventArgs e) {
            switch(mode) {
                case '1':
                    Sort<int>.BubbleSort(arr);
                    break;
                case '2':
                    Sort<int>.InsertSort(arr);
                    break;
                default:
                    Sort<int>.BubbleSort(arr);
                    break;
            }
            richTextBox1.Text += "\n\nОтсортированный массив";
            for(int i = 0; i < arr.Length; i++) {
                richTextBox1.Text += arr[i].ToString() + " ";
            }
        }
        private void radioButtonBubble_CheckedChanged(object sender, EventArgs e) {
            mode = '1';
        }
        private void radioButtonInsert_CheckedChanged(object sender, EventArgs e) {
            mode = '2';
        }
    }
}
