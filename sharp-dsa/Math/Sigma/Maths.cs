namespace DSA.Math.Sigma
{
    public class Maths
    {
        public int Sigma(int n)
        {
            return n * (n + 1) / 2;
        }


        public int RecursiveSigma(int n)
        {
            if (n == 0) return 0;

            return n + RecursiveSigma(n - 1);
        }

        public int FullSigmaChad(Func<int, int> f, int initialTerm, int endTerm)
        {
            if (f == null) return 0;

            int res = 0;

            for(int i = initialTerm; i <= endTerm; ++i)
            {
                res += f(i);
            }

            return res;
        }
    }
}