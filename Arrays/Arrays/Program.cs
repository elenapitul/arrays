using System;
//using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayArrays(); //1.
            //ReverseOrder(); //2.
            //CountOccurrences(); //3.
            //InsertElement(); //4.
            //RemoveElement(); //5.
            //SumArray(); //6.
            //UniqueItem(); //7.
            //MergeArrayOrdered(); //8.
            //MinMax(); //9.
            //OddEven(); //10.
            //OrderArrayAscend(); //11.
            //OrderArrayDescend(); //12.
            //SecondLargest(); //13.
            //SecondSmallest(); //14.
            //Matrice(); //15.
            AdditionMatrices(); //16.

        }

        //1. Write a method to create an array of 5 integers and display the array items.
        //Access individual elements and display them through indexes.
        public static void DisplayArrays()
        {
            int n = 5;
            int[] arr = new int[n];
            Console.WriteLine("Create an array of 5 integers. ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Option 1.");
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.WriteLine("Option 2.");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"element[{i}] = {arr[i]}");
            }
        }

        //2. Write a method to reverse the order of the items in the array.
        public static void ReverseOrder()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is: ");
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            int[] rvrs = new int[n];
            int aux = 0;
            for (int i = 0; i < n; i++)
            {
                aux = arr[i];
                arr[i] = rvrs[n - i - 1];
                rvrs[n - i - 1] = aux;

            }
            Console.WriteLine("The reverse array is: ");
            foreach (int element in rvrs)
            {
                Console.WriteLine(element);
            }
        }

        //3. Write a method to get the number of occurrences of a specified element in an array.
        public static void CountOccurrences()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("What element you want to count? ");
            int x = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine($"There are no occurrences of the element {x}.");
            }
            else
            {
                Console.WriteLine($"There are {count} occurrences of the element {x}.");
            }
        }

        //4. Write a method to insert a new item before the second element in an existing array.
        public static void InsertElement()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n + 1];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("What item you want to add? ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("In which place you want to add it? ");
            int place = int.Parse(Console.ReadLine());
            //n = n + 1;
            for (int i = n; i >= place; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[place - 1] = x;
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine($"element[{i}] = {arr[i]}");
            }
        }

        //5. Write a method to remove a specified item using the index from an array.
        public static void RemoveElement()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Index of the element to be removed: ");
            int index = int.Parse(Console.ReadLine());
            while (!(index >= 0 && index < n))
            {
                Console.WriteLine("Please write a correct index.");
                index = int.Parse(Console.ReadLine());
            }
            //Easier option: arr = arr.Where(RemoveElement => RemoveElement != arr[index]).ToArray();
            for (int i = index; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine($"Element[{i}] = {arr[i]}");
            }
        }

        //6. Write a program to find the sum of all elements of the array.
        public static void SumArray()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Sum = {sum}");
        }

        //7. Write a program to print all unique elements in an array.
        public static void UniqueItem()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                int unique = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        n--;
                        j--;
                        unique = 0;
                    }
                }

                if (unique != 1)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    unique--;
                    i--;
                }

            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element[{i}] = {arr[i]}");
            }

        }

        //8. Write a program to merge two arrays of same size sorted in ascending order.
        public static void MergeArrayOrdered()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrA = new int[n];
            int[] arrB = new int[n];
            Console.WriteLine($"Create an array A of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arrA[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Create an array B of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arrB[i] = int.Parse(Console.ReadLine());
            }

            int[] newArr = new int[arrA.Length + arrB.Length];
            //Easier option: int[] newArr = arrA.Concat(arrB).ToArray();
            for (int i = 0; i < arrA.Length; i++)
            {
                newArr[i] = arrA[i];
            }
            int j = 0;
            for (int i = n; i < newArr.Length; i++)
            {
                newArr[i] = arrB[j];
                j++;
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                for (int k = 0; k < newArr.Length - 1; k++)
                {
                    if (newArr[k] >= newArr[k + 1])
                    {
                        int aux = newArr[k + 1];
                        newArr[k + 1] = newArr[k];
                        newArr[k] = aux;
                    }
                }

            }

            Console.WriteLine("The new array is: ");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine($"Element[{i}] = {newArr[i]}");
            }

        }

        //9. Write a program to find maximum and minimum element in an array.
        public static void MinMax()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine(arr.Min());
            //Console.WriteLine(arr.Max());
            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }

            }

            Console.WriteLine(min);
            Console.WriteLine(max);
        }

        //10. Write a program to separate odd and even integers in separate arrays.
        public static void OddEven()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] odd = new int[arr.Length];
            int[] even = new int[arr.Length];
            int o = 0;
            int e = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    odd[o] = arr[i];
                    o++;
                }
                else
                {
                    even[e] = arr[i];
                    e++;
                }
            }

            Array.Resize(ref odd, o);
            Array.Resize(ref even, e);

            Console.WriteLine();
            Console.WriteLine("The array with odd integers is: ");
            for (int i = 0; i < odd.Length; i++)
            {
                Console.WriteLine($"Element[{i}] = {odd[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("The array with even integers is: ");
            for (int i = 0; i < even.Length; i++)
            {
                Console.WriteLine($"Element[{i}] = {even[i]}");
            }
        }

        //11. Write a program to sort elements of array in ascending order.
        public static void OrderArrayAscend()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] >= arr[j])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }

            Console.WriteLine("The ascending array is: ");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }

        }

        //12. Write a program to sort elements of the array in descending order.
        public static void OrderArrayDescend()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("The descending array is: ");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
        }

        //13. Write a program to find the second largest element in an array.
        public static void SecondLargest()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }

            Console.WriteLine($"The second largest element is {arr[1]}");
        }

        //14. Write a program to find the second smallest element in an array.
        public static void SecondSmallest()
        {
            Console.WriteLine("Number of elements of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Create an array of {n} elements.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);
            Console.WriteLine($"The second smallest element is {arr[1]}");
        }


        //15. Write a program for a 2D array of size 3x3 and print the matrix.
        public static void Matrice()
        {
            Console.WriteLine("The size of each dimension of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[,] intMatrix = new int[n, n];
            Console.WriteLine("Write each element of the matrix. ");
            for (int row = 0; row < intMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < intMatrix.GetLength(1); col++)
                {
                    var inputNumber = Console.ReadLine();
                    intMatrix[row, col] = int.Parse(inputNumber);
                }
            }
            for (int row = 0; row < intMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < intMatrix.GetLength(1); col++)
                {
                    Console.Write($"{intMatrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        //16. Write a program for addition of two matrices of same size.
        public static void AdditionMatrices()
        {
            Console.WriteLine("The size of each dimension of both matrices: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[n, n];
            int[,] matrix2 = new int[n, n];

            Console.WriteLine("Write each element of 1st matrix. ");
            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    var inputNumber = Console.ReadLine();
                    matrix1[row, col] = int.Parse(inputNumber);
                }
            }
            Console.WriteLine("Write each element of 2nd matrix. ");
            for (int row = 0; row < matrix2.GetLength(0); row++)
            {
                for (int col = 0; col < matrix2.GetLength(1); col++)
                {
                    var inputNumber = Console.ReadLine();
                    matrix2[row, col] = int.Parse(inputNumber);
                }
            }
            Console.WriteLine("Matrix 1: ");
            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    Console.Write($"{matrix1[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Matrix 2: ");
            for (int row = 0; row < matrix2.GetLength(0); row++)
            {
                for (int col = 0; col < matrix2.GetLength(1); col++)
                {
                    Console.Write($"{matrix2[row, col]} ");
                }
                Console.WriteLine();
            }

            int[,] addmatrix = new int[n, n];
            for (int row = 0; row < addmatrix.GetLength(0); row++)
            {
                for (int col = 0; col < addmatrix.GetLength(1); col++)
                {
                    addmatrix[row, col] = matrix1[row, col] + matrix2[row, col];
                }
            }
            Console.WriteLine($"The new matrix is: ");
            for (int row = 0; row < addmatrix.GetLength(0); row++)
            {
                for (int col = 0; col < addmatrix.GetLength(1); col++)
                {
                    Console.Write($"{addmatrix[row,col]} ");
                }
                Console.WriteLine();
            }            
        }
    }
}
