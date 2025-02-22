﻿using System;
using System.Text;
using MatrixDotNet.Extensions;
using MatrixDotNet.Extensions.Builder;
using MatrixDotNet.Extensions.Decompositions;

namespace Samples.Samples.MatrixSamples
{
    public class LUSample : SampleTest
    {
        public static string Run()
        {
            var builder = new StringBuilder();

            // initialize matrix with random values.
            var matrix = BuildMatrix.RandomDouble(5, 5, -10, 10);

            builder.AppendLine(matrix.ToString());

            // LU decomposition.
            matrix.GetLowerUpper(out var lower, out var upper);

            Console.WriteLine("lower-triangular matrix");
            lower.Pretty();

            Console.WriteLine("upper-triangular matrix");
            upper.Pretty();

            Console.WriteLine("A = LU");
            Console.WriteLine(lower * upper);

            return builder.ToString();
        }
    }
}