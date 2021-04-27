using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Create an Add method that passes 3 integers
        public int Add(int num1, int num2, int num3, int expected)
        {
            return num1 + num2 + num3;
        }

        // Create a Subtract method that passes 2 integers

        public int Subtract(int minuend, int subtrhend, int expected)
        {
            return minuend - subtrhend;
        }
        // Keep track of which number is getting passed as minuend and subtrahend

        // Create a Multiply method that passes 2 integers
        public int Multiply(int num1, int num2, int expected)
        {
            return num1 * num2;
        }
        // Create a Divide method that passes 2 integers
        public int Divide(int num1, int num2, int expected)
        {
            return num1 / num2;
        }

        
        // Create 2 methods that will utilize the [Fact] tests you wrote
        public void Fact()
        {
            
        }
        
    }
}
