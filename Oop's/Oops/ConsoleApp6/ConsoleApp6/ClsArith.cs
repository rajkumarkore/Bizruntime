namespace ConsoleApp6
{
    class ClsArith
    {
        int Num1, Num2, Result;

        public int PNum1
        {
            set { Num1 = value; }
        }
        public int PNum2
        {
            set { Num1 = value; }
        }
        public int PResult
        {
            get { return Result; }
        }
        public void Add()
        {
            Result = Num1 + Num2;
        }
        public void sub()
        {
            Result = Num1 - Num2;
         }
        public void Mul()
        {
            Result = Num1 * Num2;
         }
        public void Div()
        {
            Result = Num1 / Num2;
        }
    }
}
