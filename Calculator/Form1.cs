using System.Numerics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the Form1 class and sets up the form's components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the sum of two integers and returns the result.
        /// </summary>
        /// <param name="a">First addend.</param>
        /// <param name="b">Second addend.</param>
        /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public int test(int a, int b)
        {
            int sum = 0;
            int c, d;
            
            sum = a+b;
            
            if (sum == 0)
            {

            }
            else
            {

            }
            return sum;
        }


        /// <summary>
        /// Adds two integers and returns their sum.
        /// </summary>
        /// <returns>The sum of the two input integers.</returns>
        public int add(int a, int b)
        {
            int sum;
            sum = a + b;
            if(sum >10)
            {

            }
            else 
            {
            
            }
            return sum;
        }


        public int minus(int a, int b)
        {
            int result;
            result = a - b;
            return result;
        }

        public int multiply(int a, int b)
        {
            int result;
            result = a * b;


            //test
            return result;
        }
    }
}