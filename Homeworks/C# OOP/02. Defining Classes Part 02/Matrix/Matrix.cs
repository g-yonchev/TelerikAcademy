namespace Matrix
{
    using System;
    using System.Text;

    public class Matrix<T>
        where T : IComparable
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Cols = cols;
            this.Rows = rows;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The matrix must have at leats 1 row");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The matrix must have at leats 1 colum");
                }
                this.cols = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row > this.Rows || col < 0 || col > this.Cols)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.matrix[row, col];
            }
            set
            {
                if (row < 0 || row > this.Rows || col < 0 || col > this.Cols)
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows && firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new Exception("Invalid operation");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    newMatrix[i,j] = (dynamic)firstMatrix[i,j] + secondMatrix[i,j];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows && firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new Exception("Invalid operation");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int i = 0; i < firstMatrix.Rows; i++)
            {
                for (int j = 0; j < firstMatrix.Cols; j++)
                {
                    newMatrix[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Cols && firstMatrix.Cols != secondMatrix.Rows)
            {
                throw new Exception("Invalid operation");
            }

            Matrix<T> newMatrix = new Matrix<T>(firstMatrix.Rows, secondMatrix.Cols);
            T temp;
            for (int i = 0; i < newMatrix.Rows; i++)
            {
                for (int j = 0; j < newMatrix.Cols; j++)
                {

                    temp = default(T);
                    for (int k = 0; k < newMatrix.Cols; k++)
                    {
                        temp += (dynamic)firstMatrix[i, k] * secondMatrix[j, k];
                    }
                    newMatrix[i, j] = (dynamic)temp;
                }
            }
            return newMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i,j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(this.matrix[row, col] + "\t");
                }
                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
