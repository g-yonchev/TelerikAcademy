namespace Matrix
{
    using System;

    class MatrixTest
    {
        static void Main()
        {
            Matrix<double> a = new Matrix<double>(3, 3);
            Matrix<double> b = new Matrix<double>(3, 3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = i + j + 0.1;
                    b[i, j] = i + j + 0.1;
                }
            }

            Matrix<double> c = a * b;

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}
