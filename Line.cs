namespace Lines
{
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
            return $"第{Index}条直线:{Start.ToString().PadLeft(10, ' ')}\t{End.ToString().PadLeft(10, ' ')}";
        }
    }
}