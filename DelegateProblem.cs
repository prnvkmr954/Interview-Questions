public class DelegateProblem 
{
    public delegate int MathOperation(int a, int b);

    // Step 2: Define methods matching delegate signature
    public static int Add(int x, int y) => x + y;
    public static int Subtract(int x, int y) => x - y;
    public static int Multiply(int x, int y) => x * y;
    public static int Divide(int x, int y) => y != 0 ? x / y : 0;
}