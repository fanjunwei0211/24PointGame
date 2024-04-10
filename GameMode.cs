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

namespace _24PointGame
{
    public partial class GameMode : Form
    {
        DateTime beginTime;//记录开始时间
        private int[] btnDowm = { 0, 0, 0, 0 };
        private string lastInput;
        private bool isCorrect = false;//判断答案是否正确
        private int A, B, C, D;//牌面大小对应的数字大小也用于交换数字的位置
        private int NumberA, NumberB, NumberC, NumberD;//牌面大小对应的数字大
        private int gameLevel = 1, gameCorrect = 0, gameError = 0;//游戏等级，正确次数，错误次数
        public GameMode()
        {
            InitializeComponent();
        }

        private void GameMode_Load(object sender, EventArgs e)
        {
            lblResult.Text = "欢迎游戏";
            //时钟开启并计时
            timer1.Enabled = true;
            beginTime = DateTime.Now;
            //可用时间
            int timeAll = 180 - (gameLevel - 1) * 10;
            label_gameTimeUse.Text = "所用时间:" + timeAll / 60 + "分" + timeAll % 60 + "秒";

            lblInput.Text = "";
            gameLevel = 1; gameCorrect = 0; gameError = 0;
            //初始化游戏等级            
            label_gameLevel.Text = "当前关卡：" + gameLevel.ToString();
            //初始化游戏正确次数
            label_gameCorrect.Text = "正确次数：" + gameCorrect.ToString();
            //初始化游戏错误次数
            label_gameError.Text = "错误次数：" + gameError.ToString();


            //初始化游戏
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
            btnNumber1.Text = NumberA.ToString();

            //画第二张牌
            num_j = (int)random.Next(1, 11);
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox2.Image = Image.FromFile(path);
            NumberB = num_j;
            btnNumber2.Text = NumberB.ToString();

            //画第三张牌
            num_j = (int)random.Next(1, 11);
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox3.Image = Image.FromFile(path);
            NumberC = num_j;
            btnNumber3.Text = NumberC.ToString();

            //画第四张牌
            num_j = (int)random.Next(1, 11);
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox4.Image = Image.FromFile(path);
            NumberD = num_j;
            btnNumber4.Text = NumberD.ToString();


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


        #region 键盘按钮时事件
        private void btnNumber1_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnNumber1.Text.Trim();
            //lastInput = btnNumber1.Text.Trim();
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnNumber2.Text.Trim();
            //lastInput = btnNumber2.Text.Trim();
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnNumber3.Text.Trim();
            //lastInput = btnNumber3.Text.Trim();
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnNumber4.Text.Trim();
            //lastInput = btnNumber4.Text.Trim();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnAdd.Text.Trim();
            //lastInput = btnAdd.Text.Trim();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnMinus.Text.Trim();
            //lastInput = btnMinus.Text.Trim();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnMulti.Text.Trim();
            //lastInput = btnMulti.Text.Trim();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnDivide.Text.Trim();
            //lastInput = btnDivide.Text.Trim();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnLeft.Text.Trim();
            //lastInput = btnLeft.Text.Trim();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            lblInput.Text = lblInput.Text + btnRight.Text.Trim();
            //lastInput = btnRight.Text.Trim();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string input = lblInput.Text.Trim();
            lblInput.Text = input.Substring(0, input.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInput.Text = "";
        }
        #endregion


        private void btnNext_Click(object sender, EventArgs e)
        {
            #region 点击下一轮按钮更新初始化数据
            btnAdd.Enabled = true;
            btnMinus.Enabled = true;
            btnDivide.Enabled = true;
            btnMulti.Enabled = true;
            btnNumber1.Enabled = true;
            btnNumber2.Enabled = true;
            btnNumber3.Enabled = true;
            btnNumber4.Enabled = true;
            btnDelete.Enabled = true;
            btnClear.Enabled = true;
            btnLeft.Enabled = true;
            btnRight.Enabled = true;
            btnEnter.Enabled = true;
            lblInput.Text = "";
            txtAnswer.Text = "";
            timer1.Enabled = true;
            beginTime = DateTime.Now;
            //数字按键是否按下
            btnDowm[0] = 0;
            btnDowm[1] = 0;
            btnDowm[2] = 0;
            btnDowm[3] = 0;
            #endregion
            lblResult.Text = "欢迎游戏";
            if(isCorrect == true)
            {
                gameCorrect++;
            }
            else
            {
                gameError++;
            }
            
            isCorrect = false;


            //可用时间
            int timeAll = 180 - (gameLevel - 1) * 10;
            label_gameTimeUse.Text = "所用时间:" + timeAll/60+ "分" + timeAll%60 + "秒";

            //初始化游戏等级
            gameLevel = gameLevel+ 1;   
            label_gameLevel.Text = "当前关卡：" + gameLevel.ToString();
            //初始化游戏正确次数
            
            label_gameCorrect.Text = "正确次数：" + gameCorrect.ToString();
            //初始化游戏错误次数
            
            label_gameError.Text = "错误次数：" + gameError.ToString();

            if (gameError >= 10)
            {
                MessageBox.Show("错误超过10次\r\n游戏结束");
                this.Close();
            }
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
            btnNumber1.Text = NumberA.ToString();

            //画第二张牌
            num_j = (int)random.Next(1, 11);
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox2.Image = Image.FromFile(path);
            NumberB = num_j;
            btnNumber2.Text = NumberB.ToString();

            //画第三张牌
            num_j = (int)random.Next(1, 11);
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox3.Image = Image.FromFile(path);
            NumberC = num_j;
            btnNumber3.Text = NumberC.ToString();

            //画第四张牌
            num_j = (int)random.Next(1, 11);
            num_k = (int)random.Next(1, 5);
            imageNum = num_k + (num_j - 1) * 4;
            path = Directory.GetCurrentDirectory() + @"\images\" + imageNum.ToString() + ".bmp";
            pictureBox4.Image = Image.FromFile(path);
            NumberD = num_j;
            btnNumber4.Text = NumberD.ToString();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            #region 点击查看答案按钮，输入按钮禁用，时钟停止，清空答案栏
            btnAdd.Enabled = false;
            btnMinus.Enabled = false;
            btnDivide.Enabled = false;
            btnMulti.Enabled = false;
            btnNumber1.Enabled = false;
            btnNumber2.Enabled = false;
            btnNumber3.Enabled = false;
            btnNumber4.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            btnEnter.Enabled = false;
            timer1.Enabled = false;//停止时钟
            txtAnswer.Text = "";//清空答案栏
            #endregion
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

        #region 验证确定按钮包含的一系列方法：检查计算用户输入表达式结果是否正确
        //处理Deal谓词表达式中的括号
        private int Deal(string InputExp)
        {
            int result = 0;
            while (InputExp.IndexOf(')') != -1)//判断是否存在括号 input.IndexOf(')') !=-1，表明存在括号
            {
                //3*8÷(9-8)=24、（10+2）*（3-1）=24
                int rightLoc = InputExp.IndexOf(')');//右括号的位置
                string temp = InputExp.Substring(0, rightLoc);//从0（开始位置）到右括号的位置,不包括右括号（10+2
                int leftLoc = temp.LastIndexOf('(');//左括号的位置0
                string first = InputExp.Substring(0, leftLoc);//从0到左括号的位置，空
                string middle = InputExp.Substring(leftLoc + 1, rightLoc - leftLoc - 1);//括号中间的部分10+2
                string last = InputExp.Substring(rightLoc + 1);//右括号后面的部分*（3-1）
                //计算表达式的结果第二层
                InputExp = first + Formula(middle) + last; //""+10+2+*（3-1）注意：+表示连接，连接两个字符串
            }
            //计算表达式的结果第二层
            result = Formula(InputExp);//调用用户输入表达式检查、计算方法，返回用户输入表达式的结果Formula:公式
            return result;
        }

        //最简式运算 Formula：公式
        private int Formula(string InputExp)
        {
            int length = InputExp.Length;//验证表达式的长度
            ArrayList OpeLoc = new ArrayList();//记录运算操作符位置   
            ArrayList Ope = new ArrayList();//记录运算操作符 
            ArrayList Value = new ArrayList();//记录数值内容 ，也就是记录输入表达式的数字的值
            int i;//全局变量i,运用于方法体内每个循环
            for (i = 0; i < length; i++)
            {
                if (IsOperator(InputExp[i]))//检查获判断一个符号是否是基本算符 
                {
                    OpeLoc.Add(i);//记录并添加运算操作符位置x
                    Ope.Add(InputExp[i]);//记录并添加运算操作符  
                }
            }
            if (OpeLoc.Count == 0)
            {
                return int.Parse(InputExp);//处理无运算符的情况
            }
            //计算表达式的结果第三层
            RebuildOperator(ref OpeLoc, ref Ope);//对运算符进行重新组合，把负号和减号区分开来
            if (!CheckFunction(OpeLoc, length))
            {
                return 0;//检查功能，判断运算符组是否合法  ，也就是运算符位置是否正确
            }
            int j = 0;
            for (i = 0; i < OpeLoc.Count; i++)
            {
                Value.Add(int.Parse(InputExp.Substring(j, Convert.ToInt32(OpeLoc[i]) - j)));
                j = Convert.ToInt32(OpeLoc[i]) + 1;//最后一个数值的索引
            }
            //substring(开始索引，字符长度)
            Value.Add(int.Parse(InputExp.Substring(j, length - j)));//处理最后一个数值的添加
            //计算表达式的结果第四层`
            return Calculate(Ope, Value);//调用用户输入表达式的计算方法，参数1：运算符,参数2：数值
        }

        //处理四则混合运算等基础运算(+-*/)
        private int Calculate(ArrayList Ope, ArrayList Values)
        {
            int i;//全局变量i,运用于方法体内每个循环
            for (i = 0; i < Ope.Count; i++)//处理乘法、除法 
            {
                switch (Convert.ToChar(Ope[i]))
                {
                    case '*':
                        Values[i] = Convert.ToInt32(Values[i]) * Convert.ToInt32(Values[i + 1]);
                        Values.RemoveAt(i + 1);
                        Ope.RemoveAt(i);
                        i--;
                        break;
                    case '/':
                        Values[i] = Convert.ToInt32(Values[i]) * Convert.ToInt32(Values[i + 1]);
                        Values.RemoveAt(i + 1);
                        Ope.RemoveAt(i);
                        i--;
                        break;
                }
            }
            for (i = 0; i < Ope.Count; i++)//处理加法和减法 
            {
                switch ((char)Ope[i])
                {
                    case '+':
                        Values[i] = Convert.ToInt32(Values[i]) + Convert.ToInt32(Values[i + 1]);
                        Values.RemoveAt(i + 1);
                        Ope.RemoveAt(i);
                        i--;
                        break;
                    case '-':
                        Values[i] = Convert.ToInt32(Values[i]) - Convert.ToInt32(Values[i + 1]); ;
                        Values.RemoveAt(i + 1);
                        Ope.RemoveAt(i);
                        i--;
                        break;
                }
            }
            return Convert.ToInt32(Values[0].ToString());
        }

        //判断运算符组是否合法
        private bool CheckFunction(ArrayList OpeLoc, int length)
        {
            if (Convert.ToInt32(OpeLoc[0]) == 0)//判断第一个运算符的的索引是否为0，也就是运算符排在表达式第一个
                return false;
            int i;
            for (i = 1; i < OpeLoc.Count; i++)
            {
                if (Convert.ToInt32(OpeLoc[i]) - Convert.ToInt32(OpeLoc[i - 1]) == 1)//检查判断两个运算符是否连续
                    return false;
            }
            if (Convert.ToInt32(OpeLoc[OpeLoc.Count - 1]) == length - 1)//判断最后一个运算符的的索引是否等于表达式索引的，也就是该运算符排在表达式末尾
                return false;
            return true;
        }
        //对负号的处理和重构
        private void RebuildOperator(ref ArrayList OpeLoc, ref ArrayList Ope)
        {
            ArrayList DelItem = new ArrayList();
            if (Convert.ToInt32(OpeLoc[0].ToString()) == 0 && Convert.ToChar(Ope[0]) == '-')//判断第一个符号是否是负号  ，索引为0的符号
            {
                DelItem.Add(0);
            }
            int i;
            for (i = 1; i < OpeLoc.Count; i++)
            {
                //判断是否有相邻的算符且后一个是负号，且后一个运算符-前一个运算符==1
                if (Convert.ToChar(Ope[i]) == '-' && Convert.ToChar(Ope[i - 1]) != '-' && (Convert.ToInt32(OpeLoc[i]) - Convert.ToInt32(OpeLoc[i - 1])) != 1)
                {
                    DelItem.Add(i);
                }
            }
            for (i = DelItem.Count - 1; i > 0; i--)//将负号和减号分开处理  
            {
                //移除运算符和所在运算符所在位置
                Ope.RemoveAt(Convert.ToInt32(DelItem[i]));
                OpeLoc.RemoveAt(Convert.ToInt32(DelItem[i]));
            }
        }
        //判断一个符号是否是基本算符 
        private bool IsOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/')
                return true;//判断是否是四则混合运算算符
            else
                return false;
        }
        //检查输入的计算公式是否有错误，牌是否有重复或则输入有误或输入的牌超过四张
        private bool CheckForNumber(string InputExp)//InputExp：用户输入的表达式如：（6*2）*(6/3)
        {
            bool result = true;
            //先找出分隔符，再返回用户输入以这些分隔符分隔的的string类型数字数组
            string[] str = InputExp.Split(new char[] { '+', '-', '*', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            if (str.Length != 4)
            {
                MessageBox.Show("抱歉，输入有误！请重新输入");
                result = false;
                return result;
            }
            int[] InputNums = new int[4];//用户输入计算表达式的数字
            int[] CreatNums = { NumberA, NumberB, NumberC, NumberD };//生成的四张牌对应的数字，在生成牌时已经赋值
            Array.Sort(CreatNums);//排序：升序
            for (int i = 0; i < 4; i++)
            {
                InputNums[i] = Convert.ToInt32(str[i]);//用户输入的数字
            }
            Array.Sort(InputNums);//排序：升序
            for (int i = 0; i < 4; i++)
            {
                if (InputNums[i] != CreatNums[i])//判断生成的牌对应的数字与用户输入的数字是否一一匹配，如果不匹配则表明牌有重复
                {
                    result = false;
                    MessageBox.Show("抱歉，每张牌只能使用一次！");
                    return result;
                }
            }
            return result;
        }

        #endregion

        private void btnEnter_Click(object sender, EventArgs e)
        {

            if (lblInput.Text.Trim() == "")
            {
                MessageBox.Show("计算表达式不能为空！");
                return;
            }
            if (CheckForNumber(lblInput.Text.Trim()))//检查输入表达式中输入的数字是否匹配
            {
                #region 点击查看答案按钮，输入按钮禁用，时钟停止，清空答案栏
                btnAdd.Enabled = false;
                btnMinus.Enabled = false;
                btnDivide.Enabled = false;
                btnMulti.Enabled = false;
                btnNumber1.Enabled = false;
                btnNumber2.Enabled = false;
                btnNumber3.Enabled = false;
                btnNumber4.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnLeft.Enabled = false;
                btnRight.Enabled = false;
                btnEnter.Enabled = false;
                timer1.Enabled = false;//停止时钟
                txtAnswer.Text = "";//清空答案栏
                #endregion

                //计算表达式的结果第一层
                int result = Deal(lblInput.Text.Trim());//调用Deal()处理方法，对用户输入的表达式做一
                                                        //系列判断计算，返回最终的结果
                if (result == 24)
                {
                    lblResult.Text = "恭喜！您答对了，请进入下一关！";
                    isCorrect = true;
                    timer1.Enabled = false;//暂停时钟
                }
                else
                {
                    isCorrect = false;
                    lblResult.Text = "很遗憾！您答错了，请进入下一关！";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - beginTime;
            label_gameTime.Text = "所用时间:" + ts.Minutes + "分" + ts.Seconds.ToString() + "秒";
            if (ts.Seconds  == 180- (gameLevel - 1) * 10)
            {
                MessageBox.Show("时间到！！！", "时间警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label_gameTime.ForeColor = Color.Red;
            }
        }
    }
}
