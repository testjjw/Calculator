using System.Numerics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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


        public int add(int a, int b)
        {
            int sum;
            sum = a + b;
            if (sum > 10)
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

        public int add(int a, int b, int c)
        {
            int sum;
            sum = a + b + c;
            return sum;
        }

        public void newadd()
        {
            try 
            { 
                if (!double.TryParse(tbInsert1.Text, out double num1))
                {
                    MessageBox.Show("첫 번째 값이 숫자가 아닙니다.", "입력 오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(tbInsert2.Text, out double num2))
                {
                    MessageBox.Show("두 번째 값이 숫자가 아닙니다.", "입력 오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = num1 + num2;

                //lblResult.Text = $"{num1} + {num2} = {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
}
    }
}
