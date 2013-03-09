using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixLibrary;

namespace TestMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix<int> mat = new Matrix<int>(2, 2);
            if (mat)
            {
                foreach (var item in mat)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Matrix is empty!");
            }
            Console.WriteLine();
            mat[0, 0] = 1;
            mat[0, 1] = 2;
            mat[1, 0] = 3;
            mat[1, 1] = 4;
            Console.WriteLine(mat[0, 0]);
            Console.WriteLine();

            Matrix<int> mat2 = new Matrix<int>(2, 2);
            mat2[0, 0] = 4;
            mat2[0, 1] = 3;
            mat2[1, 0] = 2;
            mat2[1, 1] = 1;

            Matrix<int> addedMatrix = mat + mat2;
            if (addedMatrix)
            {
                foreach (var item in addedMatrix)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();

            Matrix<int> subtractedMatrix = mat2 - mat;
            foreach (var item in subtractedMatrix)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Matrix<int> multipliedMatrix = mat * mat2;
            foreach (var item in multipliedMatrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
