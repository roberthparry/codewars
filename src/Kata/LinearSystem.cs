namespace LinearSystems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using MathNet.Numerics.LinearAlgebra.Double;

    public class LinearSystem
    {

        public string Solve(string input)
        {
            InputToMatrixAndVector(input, out double[,] m, out double[] y);

            var matrix = DenseMatrix.OfArray(m);
            if (Math.Abs(matrix.Determinant()) < 1.0e-12)
                return "SOLUTION=NONE";

            var vector = DenseVector.OfArray(y);
            var result = matrix.Inverse().Multiply(vector);
            return $"SOLUTION=({string.Join("; ", result.Select(e => $"{e}"))})";
        }

        private static void InputToMatrixAndVector(string input, out double[,] matrix, out double[] vector)
        {
            string[] lines = Regex.Split(input, "\r\n|\r|\n");
            double[][] table = lines.Select(l => Regex.Split(l, @"\s+")
                                                      .Where(s => s != string.Empty)
                                                      .Select(t => double.Parse(t))
                                                      .ToArray()).ToArray();

            var ylist = new List<double>();
            var mlistlist = new List<List<double>>();
            foreach (double[] row in table)
            {
                ylist.Add(row[row.Length - 1]);
                var mlist = new List<double>();
                for (int i = 0; i < row.Length - 1; i++)
                    mlist.Add(row[i]);
                mlistlist.Add(mlist);
            }

            vector = ylist.ToArray();
            matrix = new double[mlistlist.Count, mlistlist[0].Count];
            for (int i = 0; i < mlistlist.Count; i++)
                for (int j = 0; j < mlistlist[i].Count; j++)
                    matrix[i, j] = mlistlist[i][j];
        }
    }
}