using System;

class UniqueQuiz3 {
    static public void Main(String[] args) {
        while (true) {
            char operation = char.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            float[,] matrixOne = new float[row, column];
            float[,] matrixTwo = new float[row, column];

            if (operation != '+' && operation != '-') {
                break;
            }

            // Input values for matrix one
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < column; j++) {
                    matrixOne[i, j] = float.Parse(Console.ReadLine());
                }
            }

            // Input values for matrix two
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < column; j++) {
                    matrixTwo[i, j] = float.Parse(Console.ReadLine());
                }
            }

            // Perform matrix addition or subtraction
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < column; j++) {
                    if (operation == '+') {
                        matrixOne[i, j] += matrixTwo[i, j];
                    } else {
                        matrixOne[i, j] -= matrixTwo[i, j];
                    }
                }
            }

            // Display the resulting matrix
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < column; j++) {
                    Console.Write("{0} ", matrixOne[i, j]);
                }
                Console.WriteLine("");
            }
        }
    }
}