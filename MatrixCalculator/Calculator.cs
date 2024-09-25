namespace MatrixCalculator
{
    public static class Calculator
    {
        public static float[,] MultiplyMatrixOnNumber(float[,] matrix, float number) //Перемножение матрицы на число
        {
            int rows = matrix.GetLength(0); //Кол-во строк в матрице
            int columns = matrix.GetLength(1); //Кол-во столбцов в матрице

            float[,] result = new float[rows, columns]; //Итоговая матрица

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix[i, j] * number; //Перемножаем каждый элемет матрицы на указанное число
                }
            }

            return result;
        }

        public static float[,] GetMatrixSum(float[,] matrix1, float[,] matrix2) //Сумма двух матриц
        {
            int rows1 = matrix1.GetLength(0); //Кол-во строк в 1й матрице
            int columns1 = matrix1.GetLength(1); //Кол-во столбцов в 1й матрице

            int rows2 = matrix2.GetLength(0); //Кол-во строк во 2й матрице
            int columns2 = matrix2.GetLength(1); //Кол-во столбцов во 2й матрице

            if (rows1 == rows2 && columns1 == columns2) //Для суммирования кол-во строк и столбцов в матрицах должно совпадать
            {
                float[,] result = new float[rows1, columns1]; //Итоговая матрица

                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < columns1; j++)
                    {
                        result[i, j] = matrix1[i, j] + matrix2[i, j];  //Суммируем каждый элемет 1й и 2й матриц
                    }
                }

                return result;
            }

            return null;
        }

        public static float[,] GetMatrixProduct(float[,] matrix1, float[,] matrix2) //Перемножение двух матриц
        {
            int rows1 = matrix1.GetLength(0); //Кол-во строк в 1й матрице
            int columns1 = matrix1.GetLength(1); //Кол-во столбцов в 1й матрице

            int rows2 = matrix2.GetLength(0); //Кол-во строк во 2й матрице
            int columns2 = matrix2.GetLength(1); //Кол-во столбцов во 2й матрице

            if (columns1 != rows2) return null; //Для перемножения матриц кол-во столбцов 1й матрицы должно равняться кол-ву строк 2й

            float[,] result = new float[rows1, columns2];  //Итоговая матрица
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    result[i, j] = 0;

                    for (int k = 0; k < columns1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                        //Каждый элемент итоговой матрицы равен сумме произведений элементов iй строки 1й матрицы на элементы jго столбца 2й
                    }
                }
            }

            return result;
        }

        public static float[,] MatrixTranspon(float[,] matrix) //Транспонирование матрицы
        {
            int rows = matrix.GetLength(0); //Кол-во строк в матрице
            int columns = matrix.GetLength(1); //Кол-во столбцов в матрице

            float[,] result = new float [columns, rows]; //Итоговая матрица

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[j, i] = matrix[i, j]; //Каждый срока матрицы становится столбцом
                }
            }

            return result;
        }

        public static bool IsMatrixZero(float[,] matrix) //Проверка на нудевую матрицу
        {
            bool flag = true;

            int rows = matrix.GetLength(0); //Кол-во строк в матрице
            int columns = matrix.GetLength(1); //Кол-во столбцов в матрице

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0) //Матрица является нулевой только тогда, когда все ее элементы равны 0
                    {
                        flag = false;
                        break;
                    }
                }
            }

            return flag;
        }
    }
}
