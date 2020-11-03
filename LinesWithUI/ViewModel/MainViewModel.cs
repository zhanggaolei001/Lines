using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using GalaSoft.MvvmLight;

namespace LinesWithUI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            var testLines = new List<Line>();
            int index = 0;
            testLines.Add(new Line(87.2663998172368, 396.791658773067, index++));
            testLines.Add(new Line(145.278979365401, 270.337590433886, index++));
            testLines.Add(new Line(48.0455060913066, 125.805512696578, index++));
            testLines.Add(new Line(78.6448937707756, 77.8412344453802, index++));
            testLines.Add(new Line(85.9307009467527, 385.098432017364, index++));
            testLines.Add(new Line(41.9558565617663, 62.3246113805568, index++));
            testLines.Add(new Line(326.999653016979, 128.530702111495, index++));
            testLines.Add(new Line(3.36222612384489, 11.0351768328456, index++));
            testLines.Add(new Line(514.660194142994, 94.8645069025684, index++));
            testLines.Add(new Line(28.1905502087742, 129.641798663686, index++));
            testLines.Add(new Line(186.077456220517, 144.965831175441, index++));
            testLines.Add(new Line(19.0440173768603, 83.891506402609, index++));
            testLines.Add(new Line(53.5030272689541, 125.760294591507, index++));
            testLines.Add(new Line(413.756982525824, 57.2265556288133, index++));
            testLines.Add(new Line(307.185244162015, 12.7208634814449, index++));
            testLines.Add(new Line(66.4058144151739, 193.959998118151, index++));
            testLines.Add(new Line(27.8151875306698, 45.2858761923853, index++));
            testLines.Add(new Line(86.6654752005038, 45.8048729549784, index++));
            testLines.Add(new Line(966.989420636938, 42.8143183790003, index++));
            testLines.Add(new Line(62.236806788027, 235.551219995479, index++));
            testLines.Add(new Line(2.34583181668218, 7.48485846948364, index++));
            testLines.Add(new Line(25.2903294401913, 90.1992655294331, index++));
            testLines.Add(new Line(110.651950336645, 40.0971813943061, index++));
            testLines.Add(new Line(32.9669847248059, 12.7527616251376, index++));
            testLines.Add(new Line(139.93205644179, 342.115583397273, index++));
            testLines.Add(new Line(12.8594211052552, 34.6442414288428, index++));
            testLines.Add(new Line(111.04853561905, 218.784377445579, index++));
            testLines.Add(new Line(379.278491386832, 44.4451951496811, index++));
            testLines.Add(new Line(643.859550258895, 25.180211422972, index++));
            testLines.Add(new Line(133.557957759627, 261.467049730445, index++));
            testLines.Add(new Line(147.670839496517, 71.6411085676797, index++));
            testLines.Add(new Line(65.9730740596389, 301.790618575681, index++));
            Lines = testLines;
            Starts = Lines.Select(l => l.Start).ToList();
            Ends = Lines.Select(l => l.End).ToList();
        }

        public List<Line> Lines { get; set; }
        public List<double> Starts { get; set; }
        public List<double> Ends { get; set; }
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
            return $"第{Index}条直线:{Start.ToString().PadLeft(10, ' ')}\t{End.ToString().PadLeft(10, ' ')}";
        }
    }
}