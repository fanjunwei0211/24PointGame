using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24PointGame
{
    internal class Solver
    {
        // 需要达成的目标结果值
        private const double target = 24;

        // 四则运算符号定义，其中，a -- b = b - a，a // b = b / a
        private readonly List<string> ops = new List<string> { "+", "-", "*", "/", "--", "//" };

        // precise_mode为精准模式，若开启，则减号及除号后开启括号
        private readonly bool preciseMode;

        public Solver(bool preciseMode = false)
        {
            this.preciseMode = preciseMode;
        }

        public List<string> Solution(int[] nums)
        {
            var result = new List<string>();
            // 对输入的数字进行降维处理 例如：[1, 2, 3, 4] -> [[1, 2], [3, 4]]
            var groups = DimensionalityReduction(Format(nums));
            foreach (var group in groups)
            {
                foreach (var op in ops)
                {
                    var exp = Assemble(group[0], group[1], op)["exp"];
                    if (Check(exp, target) && !result.Contains(exp))
                    {
                        result.Add(exp);
                    }
                }
            }
            return result.Select(exp => exp + "=" + target).ToList();
        }

        // 对需要处理的数字或表达式组合进行降维，降低到二维
        private List<List<Dictionary<string, string>>> DimensionalityReduction(List<Dictionary<string, string>> nums)
        {
            var result = new List<List<Dictionary<string, string>>>();

            // 如果维数大于2，则选出两个表达式组合成一个，从而降低一个维度，通过递归降低到二维
            if (nums.Count > 2)
            {
                foreach (var group in Group(nums, 2))
                {
                    foreach (var op in ops)
                    {
                        var newGroup = new List<Dictionary<string, string>> { Assemble(group[0][0], group[0][1], op) }.Concat(group[1]).ToList();
                        result.AddRange(DimensionalityReduction(newGroup));
                    }
                }
            }
            else
            {
                result.Add(nums);
            }
            return result;
        }

        // 将两个表达式组合成一个新表达式
        private Dictionary<string, string> Assemble(Dictionary<string, string> exp1, Dictionary<string, string> exp2, string op)
        {
            // 如果运算符为'--'或者'//'，则交换数字顺序重新计算
            if (op == "--" || op == "//")
            {
                return Assemble(exp2, exp1, op[0].ToString());
            }

            // 如果是乘法，则根据两个表达式的情况加括号
            if (op == "*" || op == "/")
            {
                exp1 = AddParenthesis(exp1);
                exp2 = AddParenthesis(exp2);
            }

            if (preciseMode)
            {
                if (op == "-")
                {
                    exp2 = AddParenthesis(exp2);
                }
                else if (op == "/")
                {
                    exp2 = AddParenthesis(exp2, true);
                }
            }

            var exp = ConvertExpression(exp1["exp"] + op + exp2["exp"], op);
            return new Dictionary<string, string> { { "op", op }, { "exp", exp } };
        }

        // 根据需要为表达式添加相应的括号
        private Dictionary<string, string> AddParenthesis(Dictionary<string, string> exp, bool isNecessary = false)
        {
            // 如果上一计算步骤的运算符号为加号或减号，则需加括号
            if ((isNecessary && !Regex.IsMatch(exp["exp"], @"\d+")) || Regex.IsMatch(exp["op"], @"[\+\-]"))
            {
                return new Dictionary<string, string> { { "exp", "(" + exp["exp"] + ")" }, { "op", exp["op"] } };
            }
            return exp;
        }

        // 检查表达式是否与结果相等，考虑到中间步骤的除法，因此不采用相等判断，而是采用计算值和目标值的绝对值是否符合某个精度
        private bool Check(string exp, double target, double precision = 0.0001)
        {
            try
            {
                return Math.Abs(Calculate(exp) - target) < precision;
            }
            catch (DivideByZeroException)
            {
                return false;
            }
        }

        // 计算表达式的值
        private double Calculate(string exp)
        {
            return Convert.ToDouble(new DataTable().Compute(exp, null));
        }

        // 将表达式各项重新排序成为等价标准表达式
        private string ConvertExpression(string exp, string op)
        {
            string pattern;
            if (op == "+" || op == "-")
            {
                pattern = @"([\+\-]((\(.+\)|\d+)[\*\/](\(.+\)|\d+)|\d+))";
                exp = "+" + exp;
            }
            else
            {
                pattern = @"([\*\/](\(.+?\)|\d+))";
                exp = "*" + exp;
            }
            var tmp1 = Regex.Matches(exp, pattern);
            var tmp2 = tmp1.Select(m => m.Value);
            var tmp3 = tmp2.OrderBy(c => c, StringComparer.Ordinal);
            var result = string.Concat(tmp3);
            if(result.Length != exp.Length)
                result = exp;
            return result.Substring(1);
        }

        // 将输入的数字格式化为字典，数字的运算符号为空格，注意不是空字符
        private List<Dictionary<string, string>> Format(int[] nums)
        {
            return nums.Select(num => new Dictionary<string, string> { { "op", " " }, { "exp", num.ToString() } }).ToList();
        }

        // 对表达式列表进行分组，返回列表，[[[n1, n2], [n3, n4]], [[n1, n3], [n2, n4]], ...]
        private IEnumerable<List<List<Dictionary<string, string>>>> Group(List<Dictionary<string, string>> expList, int counter)
        {
            // 生成以下标号为元素的列表
            var indexList = Enumerable.Range(0, expList.Count).ToList();

            // 以下标号列表取出不重复的组合
            var combinations = GetCombinations(indexList, counter);

            // 使用下标得到原表达式并组成最终的结果数组
            foreach (var group1 in combinations)
            {
                var group2 = indexList.Except(group1).ToList();
                yield return new List<List<Dictionary<string, string>>>
                {
                    group1.Select(g1 => expList[g1]).ToList(),
                    group2.Select(g2 => expList[g2]).ToList()
                };
            }
        }

        // 获取组合
        private IEnumerable<List<int>> GetCombinations(List<int> items, int count)
        {
            if (count == 1)
            {
                return items.Select(item => new List<int> { item });
            }
            return items.SelectMany((item, index) => GetCombinations(items.Skip(index + 1).ToList(), count - 1).Select(result => new List<int> { item }.Concat(result).ToList()));
        }
    }

}
