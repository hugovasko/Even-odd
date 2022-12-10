namespace Even_odd
{
    internal class Program
    {
        private static void Main()
        {
            // #read a matrix from a text file
            var matrixFromFile = File.ReadAllText(@"C:\Users\hugov\source\repos\Even-odd\Even-odd\resources\matrix.txt");
            // #endregion

            // find the sum of the even-valued elements in the odd-numbered rows
            var sumOfEvenElementsInOddRows = 0;
            var matrix = matrixFromFile.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < matrix.Length; i++)
            {
                var row = matrix[i].Split(' ');
                if (i % 2 != 0) continue;
                foreach (var t in row)
                {
                    var element = int.TryParse(t, out var number) ? number : 0;
                    if (element % 2 == 0)
                    {
                        sumOfEvenElementsInOddRows += element;
                    }
                }
            }

            Console.WriteLine(sumOfEvenElementsInOddRows);
            // #endregion

            // find the sum of the odd-valued elements in the even-numbered columns
            var sumOfOddElementsInEvenColumns = 0;
            foreach (var t in matrix)
            {
                var row = t.Split(' ');
                for (var j = 0; j < row.Length; j++)
                {
                    var element = int.TryParse(row[j], out var number) ? number : 0;
                    if (j % 2 != 0 && element % 2 != 0)
                    {
                        sumOfOddElementsInEvenColumns += element;
                    }
                }
            }

            Console.WriteLine(sumOfOddElementsInEvenColumns);
            // #endregion
        }

    }
}