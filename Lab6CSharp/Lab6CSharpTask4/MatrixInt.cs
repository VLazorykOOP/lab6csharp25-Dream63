using System.Diagnostics.Contracts;
using System.Drawing;
using System.Numerics;
using System;
using System.Collections;

namespace Lab6CSharp.Lab6CSharpTask4
{
    internal class MatrixInt : IEnumerable<int>
    {

        // Fields
        private int[,] IntMatrix;
        private List<int> IntMatrixList = new();
        
        private uint n, m;
        private int codeError;
        private static uint num_mat;

        // Properties
        public uint N { get { return n; } }
        public uint M { get { return m; } }
        public int CodeError { get { return codeError; } set { codeError = value; } }


        // Indexator
        public int this[int index1, int index2]
        {
            get
            {
                if (index1 >= 0 && index1 < n && index2 >= 0 && index2 < n) return IntMatrix[index1, index2];
                codeError = -1; return 0;
            }
            set { codeError = value; }
        }
                public int this[int index]
        {
            get
            {
                if (index >= 0 && index < n * m) return IntMatrix[index / M, index % M];
                codeError = -1; return 0;
            }
            set { codeError = value; }
        }
        // Operators
        public static MatrixInt operator ++(MatrixInt obj)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] + 1;
                }
            return new(array);
        }
        public static MatrixInt operator --(MatrixInt obj)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] - 1;
                }
            return new(array);
        }
        public static bool operator true(MatrixInt obj)
        {
            if (obj.n == 0 && obj.m == 0) return false;
            foreach (int i in obj.IntMatrix)
                if (i != 0) return true;

            return false;
        }
        public static bool operator false(MatrixInt obj)
        {
            return obj ? false : true;
        }
        public static bool operator !(MatrixInt obj)
        {
            return obj.N == 0;
        }
        public static MatrixInt operator ~(MatrixInt obj)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = ~obj[i, j];
                }
            return new(array);
        }
        public static MatrixInt operator +(MatrixInt obj, MatrixInt other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] + other[i, j];
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator +(MatrixInt obj, int other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] + other;
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator -(MatrixInt obj, MatrixInt other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] - other[i, j];
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator -(MatrixInt obj, int other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] - other;
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator *(MatrixInt obj, MatrixInt other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] * other[i, j];
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator *(MatrixInt obj, int other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] * other;
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator /(MatrixInt obj, MatrixInt other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = (int)Math.Round((double)obj[i,j] / (double)other[i,j]);
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator /(MatrixInt obj, int other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = (int)Math.Round((double)obj[i,j] / (double)other);
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator %(MatrixInt obj, MatrixInt other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] % other[i, j];
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator %(MatrixInt obj, int other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] % other;
            }
            return new MatrixInt(obj.n, obj.m, array);
        }        
        public static MatrixInt operator |(MatrixInt obj, MatrixInt other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] | other[i, j];
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator |(MatrixInt obj, int other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] | other;
            }
            return new MatrixInt(obj.n, obj.m, array);
        }        
        public static MatrixInt operator ^(MatrixInt obj, MatrixInt other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] ^ other[i, j];
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static MatrixInt operator ^(MatrixInt obj, int other)
        {
            int[,] array = new int[obj.N, obj.m];
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)            
                {
                    array[i,j] = obj[i, j] ^ other;
            }
            return new MatrixInt(obj.n, obj.m, array);
        }
        public static bool operator ==(MatrixInt obj, MatrixInt other)
        {
            if(obj.n != other.n || obj.m != other.m) return false;
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)
                    if(obj[i, j] != other[i, j]) return false;

            return true;
        }
        public static bool operator !=(MatrixInt obj, MatrixInt other)
        {
            if(obj.n != other.n || obj.m != other.m) return true;
            for (int i = 0; i < obj.n; i++)
                for (int j = 0; j < obj.m; j++)
                    if(obj[i,j] != other[i,j]) return true;
                
            return false;
        }
        public static bool operator >(MatrixInt obj, MatrixInt other)
        {
            if(obj.n == other.n) return obj.m > other.m;
            return obj.n > other.n;
        }
        public static bool operator >=(MatrixInt obj, MatrixInt other)
        {
            if(obj.n == other.n) return obj.m >= other.m;
            return obj.n >= other.n;
        }
        public static bool operator <(MatrixInt obj, MatrixInt other)
        {
            if(obj.n == other.n) return obj.m < other.m;
            return obj.n < other.n;
        }
        public static bool operator <=(MatrixInt obj, MatrixInt other)
        {
            if(obj.n == other.n) return obj.m <= other.m;
            return obj.n >= other.n;
        }

        public override bool Equals(object? obj) { return Equals(obj as MatrixInt); }
        public override int GetHashCode() { return base.GetHashCode(); }

        // Constructors
        public MatrixInt() : this(1, 1) { }
        public MatrixInt(int[,] array) : this((uint)array.GetLength(1), (uint)array.GetLength(1) , array) { }
        public MatrixInt(uint size1, uint size2) : this(size1, size2, new int[size1, size2]) { }
        public MatrixInt(uint size1, uint size2, int[,] value) {
            this.n = size1;
            this.m = size2;
            this.IntMatrix = new int[size1, size2];

            for (int i = 0; i < size1 && i < value.GetLength(0); i++)
                for (int j = 0; j < size2 && j < value.GetLength(1); j++) {
                    IntMatrix[i, j] = value[i, j];
                    IntMatrixList.Add(IntMatrix[i,j]);
                }
            num_mat++;
        }
        // Destructor
        ~MatrixInt(){
            num_mat--;
            Console.WriteLine($"MatrixInt object destroyed!");
        }

        // Functions
        public void SetVectorElementsFromKeyboard()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Enter element #({i}, {j})");
                    IntMatrix[i, j] = int.TryParse(Console.ReadLine(), out int val) ? val : 0;
                }
        }
        public void Print()
        {
            Console.WriteLine("[{0}]", string.Join(", ", IntMatrix));
        }
        public void SetArrayToValue(int value)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++) 
                    IntMatrix[i, j] = value;
        }
        public static uint NumberOfTypeObjects()
        {
            return num_mat;
        }
        public void SetArrayElement(int val, uint index1, uint index2)
        {
            IntMatrix[index1, index2] = val;
        }
        public int[,] GetIntMatrix()
        {
            return IntMatrix;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)IntMatrixList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)IntMatrixList).GetEnumerator();
        }
    }
}