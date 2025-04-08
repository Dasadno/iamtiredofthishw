namespace iamtiredofthishw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Money num1 = 100;
                Money num2 = 50;


                try
                {
                    CheckResult(num2 - num1);
                    CheckResult(num1 / 2);
                    CheckResult(num1--);
                    CheckResult(num2--);
                }
                catch (ApplicationException ex)
                {
                    throw new ApplicationException("oh no, you're bankrupt");
                }
            }

            static void CheckResult(Money result)
            {
                if (result.Sum < 0)
                {
                    throw new ApplicationException("bankrupt");
                }
            }
        }

    }
}
