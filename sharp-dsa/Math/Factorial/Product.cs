namespace DSATraining.sharp_dsa.Math.Factorial
{
    public class Product
    {
        public int Factorial(int n)
        {
            if (n == 0) return 1;

            return n * Factorial(n - 1);
        }
    }
}
