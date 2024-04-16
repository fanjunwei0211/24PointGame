using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _24PointGame
{
    public partial class CalculateMode : Form
    {
        private int A, B, C, D;//牌面大小对应的数字大小也用于交换数字的位置
        private int NumberA, NumberB, NumberC, NumberD;//牌面大小对应的数字大

        public CalculateMode()
        {
            InitializeComponent();
        }
        //点击随机生成发四张牌
        private void button_Random_Click(object sender, EventArgs e)
        {
            int imageNum;
            string path;
            Random random = new Random((int)DateTime.Now.Ticks);
            //生成牌的序号
            int num_j, num_k;


            //画第一张牌
            num_j = (int)random.Next(1, 11); //数值
            num_k = (int)random.Next(1, 5);  //花色
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox1.Image = Image.FromFile(path);
            NumberA = num_j;

            //画第二张牌
            num_j = (int)random.Next(1, 11);
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox2.Image = Image.FromFile(path);
            NumberB = num_j;

            //画第三张牌
            num_j = (int)random.Next(1, 11);
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox3.Image = Image.FromFile(path);
            NumberC = num_j;

            //画第四张牌
            num_j = (int)random.Next(1, 11);
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox4.Image = Image.FromFile(path);
            NumberD = num_j;

            int index = 1;//记录答案个数 
            txtAnswer.Text = "";//清空答案栏 

            var customerInput = new int[4];
            customerInput[0] = NumberA;
            customerInput[1] = NumberB;
            customerInput[2] = NumberC;
            customerInput[3] = NumberD;

            var task = new Solver();
            var answer = task.Solution(customerInput);
            if (answer.Count == 0)
            {
                txtAnswer.Text = "此题无解";
            }
            else
            {
                foreach (var a in answer)
                {
                    txtAnswer.AppendText("答案" + index + "： " + a + "\r\n");
                    index++;
                }
            }

        }



        private void CalculateMode_Load(object sender, EventArgs e)
        {

        }
        
        static bool AreExpressionsEquivalent(string expression1, string expression2)
        {
            // 使用 DataTable 计算表达式的值
            DataTable table = new DataTable();
            var result1 = table.Compute(expression1, "");
            var result2 = table.Compute(expression2, "");

            // 检查两个结果是否相等
            return result1.Equals(result2);
        }
        private void button_Handin_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] numbers = input.Split(' ');
            if(numbers.Length != 4)
            {
                MessageBox.Show("请输入四个数");
                return;
            }
            if(int.Parse(numbers[0]) < 1 || int.Parse(numbers[0]) > 10)
            {
                MessageBox.Show("请输入1~10之间数");
                return;
            }
            NumberA = int.Parse(numbers[0]);
            
            if(int.Parse(numbers[1]) < 1 || int.Parse(numbers[1]) > 10)
            {
                MessageBox.Show("请输入1~10之间数");
                return;
            }
            NumberB = int.Parse(numbers[1]);
            
            if (int.Parse(numbers[2]) < 1 || int.Parse(numbers[2]) > 10)
            {
                MessageBox.Show("请输入1~10之间数");
                return;
            }
            NumberC = int.Parse(numbers[2]);
            
            
            if (int.Parse(numbers[3]) < 1 || int.Parse(numbers[3]) > 10)
            {
                MessageBox.Show("请输入1~10之间数");
                return;
            }
            NumberD = int.Parse(numbers[3]);

            int imageNum;
            string path;
            Random random = new Random((int)DateTime.Now.Ticks);
            //生成牌的序号
            int num_k;
            //画第一张牌
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (NumberA - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox1.Image = Image.FromFile(path);

            //画第二张牌
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (NumberB - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox2.Image = Image.FromFile(path);

            //画第三张牌
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (NumberC - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox3.Image = Image.FromFile(path);

            //画第四张牌
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (NumberD - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox4.Image = Image.FromFile(path);

            int index = 1;//记录答案个数 
            txtAnswer.Text = "";//清空答案栏 

            var customerInput = new int[4];
            customerInput[0] = NumberA;
            customerInput[1] = NumberB;
            customerInput[2] = NumberC;
            customerInput[3] = NumberD;

            var task = new Solver();
            var answer = task.Solution(customerInput);
            if(answer.Count == 0)
            {
                txtAnswer.Text = "此题无解";
            }
            else
            {
                foreach (var a in answer)
                {
                    txtAnswer.AppendText("答案" + index + "： " + a + "\r\n");
                    index++;
                }
            }
        }
    }
}
