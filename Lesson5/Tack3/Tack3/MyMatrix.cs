using System;

namespace Tack3
{
    public class MyMatrix
    {
        private int[][] intMatrix;
   

        public MyMatrix(int rows, int columns)
        {
            intMatrix = new int[Math.Abs(rows)][];

            for (int i = 0; i < Math.Abs(rows); i++)
                intMatrix[i] = new int[Math.Abs(columns)];
            CreateMatrix();
        }

        public void CreateMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < intMatrix.Length; i++)
                for (int j = 0; j < intMatrix[i].Length; j++)
                    intMatrix[i][j] = rand.Next(10, 90);
        }

        public void ShowPartly(int startRow, int startCol, int endRow, int endCol)
        {
            if (startRow < 0 || startCol < 0 || endRow > intMatrix.Length || endCol > intMatrix[0].Length)
            {
                Console.WriteLine("Попытка обращения за пределы массива");
                return;
            }

            if (startRow>endRow||startCol>endCol)
            {
                Console.WriteLine("Неверно заданны координаты конечной точки");
                return;
            }

            for (int i = startRow; i < endRow; i++)
            {
                for (int j = startCol; j < endCol; j++)
                {
                    Console.Write("{0}  ", intMatrix[i][j]);
                }
                Console.Write("\n");
            }
        }

        public void ChangeSize(int row, int col)
        {
            if (row <= 0 || col <= 0)
            {
                Console.WriteLine("Размеры матрицы не могут быть меньше или равны нулю");
                return;
            }
            var mNew = new int[row][];
            for (int i = 0; i < row; i++)
                mNew[i]=new int[col];

            for (int i = 0; i < Math.Min(intMatrix.Length,row); i++)
            {
                for (int j = 0; j < Math.Min(intMatrix[i].Length,col); j++)
                {
                    mNew[i][j] = intMatrix[i][j];
                }
            }
            Random rand =new Random();
            if (row>intMatrix.Length)
            {
                for (int i = intMatrix.Length; i < row; i++)
                    for (int j = 0; j < Math.Min(col, intMatrix[0].Length); j++)
                        mNew[i][j] = rand.Next(10, 90);
            }
            if (col>intMatrix[0].Length)
            {
                for (int i = intMatrix[0].Length; i < col; i++)
                    for (int j = 0; j < row; j++)
                        mNew[j][i] = rand.Next(10, 90);
            }

            intMatrix = mNew;

        }

        public void Show()
        {
            ShowPartly(0, 0, intMatrix.Length, intMatrix[0].Length);
        }

        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 < intMatrix.Length && index2 >= 0 && index2 < intMatrix[0].Length)
                    return intMatrix[index1][index2];
                Console.WriteLine("Попытка обращения за пределы массива.");
                return 0;
            }

            set
            {
                if (index1 >= 0 && index1 < intMatrix.Length && index2 >= 0 && index2 < intMatrix[0].Length)
                    intMatrix[index1][index2] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }
    }
}