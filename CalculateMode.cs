using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private int NumberA, NumberB, NumberC, NumberD;//牌面大小对应的数字大小
        private int topCard = 0;//显示在窗体四张牌中扑克牌的编号(1-41)

        #region 一副牌的生成
        //结构： 值得一提的是，在C++中，struct的功能得到了强化，struct不仅可以添加成员变量，
        //还可以添加成员函数，和class类似。
        struct card
        {
            public int face;//牌面大小，数字大小
            public int suit;//牌面花色，如梅花、黑桃、红心、方块，只能有四张
            public int count;//牌面点数，牌面上的的图案点数
            public bool faceup;//牌面是否向上
        }
        private card[] PlayingCards;//一副牌

        //生成一副牌
        private void GetPlayingCareds()
        {
            PlayingCards = new card[41];
            int i;//牌面大小
            int j;//牌面花色
            for (i = 0; i < 10; i++)
            {
                for (j = 1; j <= 4; j++)
                {
                    PlayingCards[j + i * 4].face = i + 1;//PlayingCards[j + i * 4]:指的是：j + i * 4  =>获取文件图片扑克牌的序号
                    PlayingCards[j + i * 4].suit = j;//牌面花色，如梅花、黑桃、红心、方块，只能有四张
                    if (i < 10)
                    {
                        PlayingCards[j + i * 4].count = i + 1;//牌面点数，牌面上的的图案点数
                    }
                    else
                    {
                        PlayingCards[j + i * 4].count = 10;
                    }
                    PlayingCards[j + i * 4].faceup = false;
                }
            }
        }
        //洗牌 :Shuffle
        private void Shuffle()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            card middleCard;//作为临时交换牌顺序的变量
            int j, k;
            for (int i = 0; i < 1000; i++)
            {
                j = (int)random.Next(1, 41);
                k = (int)random.Next(1, 41);
                //打乱牌的顺序(随机交换牌的顺序)
                middleCard = PlayingCards[j];
                PlayingCards[j] = PlayingCards[k];
                PlayingCards[k] = middleCard;
            }
        }
        #endregion


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
            #region 首先：(ABCD位置)24种情况的遍历，然后：计算24点的方法，接着：把字符表达式转为数值表达式
            txtAnswer.Text = "";//清空答案栏 
            for (int i = 1; i <= 24; i++)
            {
                ChangeOfPosition24(i);//24种情况的位置转换的方法
                ArrayList first = new ArrayList();//数字集合对象
                ArrayList firstStr = new ArrayList();//字符集合对象
                first.Add(A.ToString());
                firstStr.Add("A");
                //此方法的核心思路：本来一开始是有ABCD四张牌，第一次对A、B进行加减乘除，再把得到的结果result返回去，第二次调用对result、C重复第一次操作
                //第三次也是重复，不过这次返回去的结果就是计算出来的结果
                cal(ref first, ref firstStr, B, 'B');
                cal(ref first, ref firstStr, C, 'C');
                cal(ref first, ref firstStr, D, 'D');

                for (int j = 0; j < first.Count; j++)
                {
                    if (Convert.ToInt32(Convert.ToDouble(first[j].ToString())) == 24)
                    {
                        //replaceString参数（字符表达式，'字符'，数值）,此方法的核心思想是，一个一个字符替换为对应的数值
                        firstStr[j] = replaceString(firstStr[j].ToString(), 'A', A);
                        firstStr[j] = replaceString(firstStr[j].ToString(), 'B', B);
                        firstStr[j] = replaceString(firstStr[j].ToString(), 'C', C);
                        firstStr[j] = replaceString(firstStr[j].ToString(), 'D', D);
                        //追加文本答案
                        txtAnswer.AppendText("答案" + index + "： " + firstStr[j].ToString() + "=24；" + "\r\n");
                        index++;
                    }
                }
            }
            if (txtAnswer.Text.Trim() == "")
            {
                txtAnswer.Text = "此题无解";
            }
            #endregion

        }

        #region 点击查看答案按钮要做的一系列处理计算
        //1、（ABCD）24种情况的位置转换
        public void ChangeOfPosition24(int i)
        {
            //24种位置转换 
            //此方法的核心思想:要让A/B/C/D四个数两两算一次，如：+加号运算符
            //(A+B) (A+C) (A+D) (B+C) (B+D) (C+D)一共有6种情况，以此类推减号也有6种情况，
            //加减乘除四种运算符加起来总共就有24种情况
            //补充：上面的意思是A在第一个位置有6种情况，同理
            //B在第一个位置也有6种情况，C在第一个位置也有6种情况,D在第一个位置也有6种情况
            switch (i)
            {
                case 1:
                    A = NumberA; B = NumberB; C = NumberC; D = NumberD;
                    break;
                case 2:
                    A = NumberA; B = NumberB; D = NumberC; C = NumberD;
                    break;
                case 3:
                    A = NumberA; C = NumberB; B = NumberC; D = NumberD;
                    break;
                case 4:
                    A = NumberA; C = NumberB; D = NumberC; B = NumberD;
                    break;
                case 5:
                    A = NumberA; D = NumberB; B = NumberC; C = NumberD;
                    break;
                case 6:
                    A = NumberA; D = NumberB; C = NumberC; B = NumberD;
                    break;
                case 7:
                    B = NumberA; A = NumberB; C = NumberC; D = NumberD;
                    break;
                case 8:
                    B = NumberA; A = NumberB; D = NumberC; C = NumberD;
                    break;
                case 9:
                    B = NumberA; C = NumberB; A = NumberC; D = NumberD;
                    break;
                case 10:
                    B = NumberA; C = NumberB; D = NumberC; A = NumberD;
                    break;
                case 11:
                    B = NumberA; D = NumberB; A = NumberC; C = NumberD;
                    break;
                case 12:
                    B = NumberA; D = NumberB; C = NumberC; A = NumberD;
                    break;
                case 13:
                    C = NumberA; A = NumberB; B = NumberC; D = NumberD;
                    break;
                case 14:
                    C = NumberA; A = NumberB; D = NumberC; B = NumberD;
                    break;
                case 15:
                    C = NumberA; B = NumberB; A = NumberC; D = NumberD;
                    break;
                case 16:
                    C = NumberA; B = NumberB; D = NumberC; A = NumberD;
                    break;
                case 17:
                    C = NumberA; D = NumberB; A = NumberC; B = NumberD;
                    break;
                case 18:
                    C = NumberA; D = NumberB; B = NumberC; A = NumberD;
                    break;
                case 19:
                    D = NumberA; A = NumberB; B = NumberC; C = NumberD;
                    break;
                case 20:
                    D = NumberA; A = NumberB; C = NumberC; B = NumberD;
                    break;
                case 21:
                    D = NumberA; B = NumberB; A = NumberC; C = NumberD;
                    break;
                case 22:
                    D = NumberA; B = NumberB; C = NumberC; A = NumberD;
                    break;
                case 23:
                    D = NumberA; C = NumberB; A = NumberC; B = NumberD;
                    break;
                case 24:
                    D = NumberA; C = NumberB; B = NumberC; A = NumberD;
                    break;
            }
        }

        //2、24点计算方法（加减乘除）
        //注意：ref:传入传出，out:传出
        //此方法的核心思路：本来一开始是有ABCD四张牌，第一次对A、B进行加减乘除，再把得到的结果result返回去，第二次调用对result、C重复第一次操作
        //第三次也是重复，不过这次返回去的结果就是计算出来的结果
        private void cal(ref ArrayList num, ref ArrayList numStr, int num2, char num2Str)//传入参数A=6,"A",B=4,"B"
        {
            ArrayList newNum = new ArrayList();//数值集合对象
            ArrayList newNumStr = new ArrayList();//字符集合对象
            int temp;
            for (int i = 0; i < num.Count; i++)
            {
                int num1 = Convert.ToInt32(num[i].ToString());

                #region 加法的情况
                temp = num1 + num2;
                newNum.Add(temp.ToString());//数字：6+4
                newNumStr.Add(numStr[i].ToString() + "+" + num2Str);//字符A+B
                #endregion

                #region 减法的情况
                if (num1 > num2)
                {
                    temp = num1 - num2;
                    newNum.Add(temp.ToString());//数字：6-4
                    newNumStr.Add(numStr[i].ToString() + "-" + num2Str);//字符A-B
                }
                else
                {
                    temp = num2 - num1;
                    newNum.Add(temp.ToString());
                    //检查是否存在+-运算符，若查找返回索引的结果不等于-1，表示存在+-运算符
                    if (numStr[i].ToString().IndexOf('+') != -1 || numStr[i].ToString().IndexOf('-') != -1)
                    {
                        newNumStr.Add(num2Str + "-" + "(" + numStr[i].ToString() + ")");//B-(A)
                    }
                    else
                    {
                        newNumStr.Add(num2Str + "-" + numStr[i].ToString());//B-A
                    }
                }
                #endregion

                #region 乘法的情况
                temp = num1 * num2;
                newNum.Add(temp.ToString());
                if (numStr[i].ToString().IndexOf("+") == -1 && numStr[i].ToString().IndexOf("-") == -1)//利用IndexOf()检查是否有+-运算符-1：指的是没有
                {
                    newNumStr.Add(numStr[i].ToString() + "*" + num2Str);//A*B
                }
                else
                {
                    newNumStr.Add("(" + numStr[i].ToString() + ")" + "*" + num2Str);//(A+B)*C
                }
                #endregion

                #region 除法的情况
                if (num1 > num2)
                {
                    if (num2 != 0 && num1 % num2 == 0)//除数不为0，而且两数相除余数要为0，也就是要能整除
                    {
                        temp = num1 / num2;
                        newNum.Add(temp.ToString());
                        if (numStr[i].ToString().IndexOf("+") == -1 && numStr[i].ToString().IndexOf("-") == -1)
                        {
                            newNumStr.Add(numStr[i].ToString() + "/" + num2Str);//A/B
                        }
                        else
                        {
                            newNumStr.Add("(" + numStr[i].ToString() + ")" + "/" + num2Str);//(A+B)/C
                        }
                    }
                }
                else
                {
                    if (num1 != 0 && num2 % num1 == 0)
                    {
                        temp = num2 / num1;
                        newNum.Add(temp.ToString());
                        if (numStr[i].ToString().IndexOf("+") == -1 && numStr[i].ToString().IndexOf("-") == -1)
                        {
                            newNumStr.Add(num2Str + "/" + numStr[i].ToString());
                        }
                        else
                        {
                            newNumStr.Add(num2Str + "/" + "(" + numStr[i].ToString() + ")");
                        }
                    }
                }
                #endregion
            }
            //要返回的集合结果
            num = newNum;
            numStr = newNumStr;
        }

        //3、用数值表达式替换字符串表达式的方法，此方法的核心思想是，一个一个字符替换为对应的数值
        private object replaceString(string ExpressionStr, char NumStr, int Num)
        {
            //参数（字符表达式=(A-B)*C+D，'字符'=A，数值=5）=>数值表达式=(13-12)*8+3
            int loc = ExpressionStr.IndexOf(NumStr);
            string first = ExpressionStr.Substring(0, loc);
            ExpressionStr = first + Convert.ToInt16(Num) + ExpressionStr.Substring(loc + 1);
            return ExpressionStr;
        }

        #endregion


        private void CalculateMode_Load(object sender, EventArgs e)
        {
            GetPlayingCareds();//生成一副牌
            Shuffle();//洗牌
        }
    }
}
