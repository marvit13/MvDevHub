using System.Collections.Generic;

namespace MvPyramid
{
    class PyramidCalculator
    {
        private Tree _tree;
        public List<List<int>> ResultList { get; private set; }
        public PyramidCalculator()
        {
            _tree = new Tree(GetInputDataSet());
        }

        public List<List<int>> GetInputDataSet()
        {
            var InputValues = new List<List<int>>();
            InputValues.Add(new List<int> { 215 });
            InputValues.Add(new List<int> { 192, 124 });
            InputValues.Add(new List<int> { 117, 269, 442 });
            InputValues.Add(new List<int> { 218, 836, 347, 235 });
            InputValues.Add(new List<int> { 320, 805, 522, 417, 345 });
            InputValues.Add(new List<int> { 229, 601, 728, 835, 133, 124 });
            InputValues.Add(new List<int> { 248, 202, 277, 433, 207, 263, 257 });
            InputValues.Add(new List<int> { 359, 464, 504, 528, 516, 716, 871, 182 });
            InputValues.Add(new List<int> { 461, 441, 426, 656, 863, 560, 380, 171, 923 });
            InputValues.Add(new List<int> { 381, 348, 573, 533, 448, 632, 387, 176, 975, 449 });
            InputValues.Add(new List<int> { 223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444 });
            InputValues.Add(new List<int> { 330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197 });
            InputValues.Add(new List<int> { 131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928 });
            InputValues.Add(new List<int> { 223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121 });
            InputValues.Add(new List<int> { 924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233 });
            return InputValues;
        }

        public void CalculateEvenOddValues()
        {
            ResultList = _tree.GetEvenOddValues();
        }

        public List<int> GetMaxSumResult()
        {
            return ResultList[0];
        }
    }
}
