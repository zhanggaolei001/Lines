using System;
using System.Collections.Generic;
using System.Linq;

namespace Lines
{
    class Program
    {
        private static void Main(string[] args)
        {
            var testLines = new List<Line>();
            int index = 0;
            testLines.Add(new Line(234, 5667.9, index++));
            testLines.Add(new Line(534, 5.967, index++));
            testLines.Add(new Line(660, 565.9, index++));
            testLines.Add(new Line(1.0, 5.9, index++));
            testLines.Add(new Line(3.10, 6545.9, index++));
            testLines.Add(new Line(5.0, 98.9, index++));
            testLines.Add(new Line(554.0, 588.9, index++));
            testLines.Add(new Line(189.0, -5.9, index++));
            testLines.Add(new Line(1345.0, 5.9, index++));
            Console.WriteLine("测试数据:");
            foreach (var line in testLines) Console.WriteLine(line.ToString());
            var starts = testLines.Select(l => l.Start).ToArray();
            var max = 0; //最大相交线数量 
            var resultLines = new List<Line>();
            for (var i = 0; i < starts.Length; i++)
            {
                var tmp = new List<Line>();
                var start = starts[i];
                var count = 0; //start处垂线相交数量.
                foreach (var line in testLines)
                {
                    if (line.Start <= start && line.End >= start)
                    {
                        count++;
                        tmp.Add(line);
                    }
                }
                if (max < count)//如有等值,忽略,仅获取一例,假设题目要求输出一个条件即可.
                {
                    max = count;
                    Console.WriteLine($"更新max值:直线索引:{i}\t当前垂线位置:{starts[i]}\t与垂线相交的直线数量:{count}");
                    resultLines = tmp;
                }
            }

            Console.WriteLine($"最大相交数量为:{max}");
            Console.WriteLine($"实例为:");
            foreach (var line in resultLines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("over");
        }
    }

    public class Line
    {
        public Line(double start, double end, int index)
        {
            if (start > end)
            {
                Start = end;
                End = start;
            }
            else
            {
                Start = start;
                End = end;
            }
            Index = index;
        }

        public int Index { get; }
        public double Start { get; }
        public double End { get; }

        public override string ToString()
        {
            return $"第{Index}条直线:{Start.ToString().PadLeft(10,' ')}\t{End.ToString().PadLeft(10, ' ')}";
        }
    }
}