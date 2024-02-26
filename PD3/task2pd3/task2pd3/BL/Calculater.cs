using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace task2pd3.BL
{
    internal class Calculater
    {
        public double num1;
        public double num2;
        public Calculater()
        {
            this.num1 = 10;
            this.num2 = 10;
            
        }
        public Calculater(double num1,double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void setValue(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;

        }
        public double Mod()
        {
            if (num2 != 0)
            {
                return num1 % num2;
            }
            else
            {
                Console.WriteLine("Division by zero is not possible");
                return 0;
            }
        }
        public double Add()
        {
            return num1 + num2;
        }
        public double Sub()
        {
            return num1 - num2;
        }
        public double Mul()
        {
            return num1 * num2;
        }
        public double Div()
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Division by zero is not possible");
                return 0;
            }
        }
        public double squareRoot()
        {
            return Math.Sqrt(num1);
        }
        public double exponential()
        {
            return Math.Exp(num1);
        }
         public double naturalLogarithm()
        {
            return Math.Log(num1);
        }
       public double trigonometricSin()
        {
            return Math.Sin(num1);
        }
        public double trigonometricCos()
        {
            return Math.Cos(num1);
        }
        public double trigonometricTan()
        {
            return Math.Tan(num1);
        }
        }

    }

