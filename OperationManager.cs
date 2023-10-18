public static class OperationManager
{
    public static int Compute(string op, int a, int b)
    {
        switch (op)
        {
            case "+":
                return a + b;
                break;
            case "-":
                return a - b;
                break;
            case "*":
                return a * b;
                break;
            case "/":
                return a / b;
                break;
            case "%":
                return a % b;
                break;
            default:
                throw new NotImplementedException();
        }
    }
}
