using System;
using System.Configuration;
using System.IO;
using HW_3_3;

namespace HW_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose, what you want to do:");
            Console.WriteLine("Multiply matrixes (type 1) or solve equation (type 2)");
            string matrixOrEquation;
            do
            {
                Console.WriteLine("Make correct choice");
                matrixOrEquation = Console.ReadLine();
            } while (matrixOrEquation != "1" && matrixOrEquation != "2");
            if (matrixOrEquation == "2")
            {
                Console.WriteLine("Choose, what equation you want to solve.");
                Console.WriteLine("For linear type 1, for quadratic type 2.");
                string type;
                string path = ResourceData.path;
                do
                {
                    Console.WriteLine("Make correct choice");
                    type = Console.ReadLine();
                } while (type != "1" && type != "2");
                if (type == "1")
                {
                    Linear linear = CreateLinear(path);
                    linear.FindSolution();
                    Logger logger = new Logger(path);
                    logger.Log(linear);
                }
                if (type == "2")
                {
                    Quadratic quadratic = CreateQuadratic(path);
                    quadratic.FindSolution();
                    Logger logger = new Logger(path);
                    logger.Log(quadratic);
                }
                Console.WriteLine("Check log file. Press any key to exit.");
            }
            if (matrixOrEquation == "1")
            {
                string path = ConfigurationManager.AppSettings["pathToMatrix"];
                Matrix matrix = readMatrix(path);
                matrix.MultiplyMatrix();
                matrix.PrintMatrix();
                Console.WriteLine("Press any key to exit.");
            }
            Console.ReadKey();
        }
        public static Linear CreateLinear(string path)
        {
            Linear l;
            Console.WriteLine("You chose linear equation (ax + b = 0).");
            double tempA;
            string a;
            Console.WriteLine("Enter a.");
            a = Console.ReadLine();
            while (!double.TryParse(a, out tempA))
            {
                Console.WriteLine("Please enter valid a.");
                Logger logger = new Logger(path);
                logger.LogWrong(a, "-");
                a = Console.ReadLine();
            }
            double tempB;
            string b;
            Console.WriteLine("Enter b.");
            b = Console.ReadLine();
            while (!double.TryParse(b, out tempB))
            {
                Console.WriteLine("Please enter valid b.");
                Logger logger = new Logger(path);
                logger.LogWrong(a, b);
                b = Console.ReadLine();
            }
            l = new Linear(tempA, tempB);
            return l;
        }
        public static Quadratic CreateQuadratic(string path)
        {
            Quadratic q;
            Console.WriteLine("You chose quadratic equation (ax^2 + bx + c = 0).");
            double tempA;
            string a;
            Console.WriteLine("Enter a");
            a = Console.ReadLine();
            while (!double.TryParse(a, out tempA))
            {
                Console.WriteLine("Please enter valid a.");
                Logger logger = new Logger(path);
                logger.LogWrong(a, "-", "-");
                a = Console.ReadLine();
            } 
            double tempB;
            string b;
            Console.WriteLine("Enter b");
            b = Console.ReadLine();
            while (!double.TryParse(b, out tempB))
            {
                Console.WriteLine("Please enter valid b.");
                Logger logger = new Logger(path);
                logger.LogWrong(a, b, "-");
                b = Console.ReadLine();
            }
            double tempC;
            string c;
            Console.WriteLine("Enter c");
            c = Console.ReadLine();
            while (!double.TryParse(c, out tempC))
            {
                Console.WriteLine("Please enter valid c.");
                Logger logger = new Logger(path);
                logger.LogWrong(a, b, c);
                c = Console.ReadLine();
            }
            q = new Quadratic(tempA, tempB, tempC);
            return q;
        }
        public static Matrix readMatrix(string path)
        {
            Matrix m;
            int n1 = 0;
            int m1 = 0;
            int n2 = 0;
            int m2 = 0;
            double[,] matrix1 = new double [0, 0];
            double[,] matrix2 = new double [0, 0];
            double[,] matrix3 = new double[0, 0];
            using (StreamReader sr = new StreamReader(path))
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine("No such file!");
                    m = null;
                    Environment.Exit(-1);
                }
                else
                {
                    for (int i = 0; i < 2; i++)
                    {
                        string s = sr.ReadLine();
                        string[] data = s.Split(new char[] { ' ' });
                        if (i == 0)
                        {
                            n1 = Int32.Parse(data[0]);
                            m1 = Int32.Parse(data[1]);
                            matrix1 = new double[n1, m1];
                            for (int j = 0; j < n1; j++)
                            {
                                s = sr.ReadLine();
                                data = s.Split(new char[] { ' ' });
                                for (int k = 0; k < m1; k++)
                                {
                                    matrix1[j, k] = Double.Parse(data[k]);
                                }
                            }
                        }
                        else
                        {
                            n2 = Int32.Parse(data[0]);
                            m2 = Int32.Parse(data[1]);
                            matrix2 = new double[n2, m2];
                            for (int j = 0; j < n2; j++)
                            {
                                s = sr.ReadLine();
                                data = s.Split(new char[] { ' ' });
                                for (int k = 0; k < m2; k++)
                                {
                                    matrix2[j, k] = Double.Parse(data[k]);
                                }
                            }
                        }
                    }
                    matrix3 = new double[n1, m2];
                    for (int i = 0; i < n1; i++)
                        for (int j = 0; j < m2; j++)
                            matrix3[i,j] = 0;
                    m = new Matrix(n1, m1, n2, m2, matrix1, matrix2, matrix3);
                    if (m1 != n2)
                    {
                        Console.WriteLine("This matrixes can't be multiplied!");
                        m = null;
                        Environment.Exit(-1);
                    }
                }
            }
            return m;
        }
    }
}
