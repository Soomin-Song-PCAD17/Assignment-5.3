char selection = '1';
while(selection!='q')
{
    Console.WriteLine("1: Flowerbed (Leetcode 605)\n2: Staircase (Leetcode 70)\nq: quit");
    Console.Write("Selection: ");
    selection=Console.ReadKey().KeyChar;
    Console.Clear();
    switch (selection)
    {
        case '1':
            Console.WriteLine("1. You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.\n\nGiven an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.\n\nExample 1:\n\nInput: flowerbed = [1,0,0,0,1], n = 1\n\nOutput: true\n\nExample 2:\n\nInput: flowerbed = [1,0,0,0,1], n = 2\n\nOutput: false\n\n");

            flowerbedDemo([1, 0, 0, 0, 1], 1); //should return true
            flowerbedDemo([1, 0, 0, 0, 1], 2); //should return true
            flowerbedDemo([0], 1); //should return true
            flowerbedDemo([0, 0], 1); //should return true
            flowerbedDemo([0, 0, 0], 2); //should return true
            flowerbedDemo([1], 0); //should return true

            break;
        case '2':
            Console.WriteLine("2. You are climbing a staircase. It takes n steps to reach the top.\n\nEach time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?\nExample 1:\n\nInput: n = 2\n\nOutput: 2\n\nExplanation: There are two ways to climb to the top.\n\n1. 1 step + 1 step\n\n2. 2 steps\n\n\nExample 2:\n\nInput: n = 3\n\nOutput: 3\n\nExplanation: There are three ways to climb to the top.\n\n1. 1 step + 1 step + 1 step\n\n2. 1 step + 2 steps\n\n3. 2 steps + 1 step\n\n");
            //staircaseConstantTimeDemo(2);
            //staircaseConstantTimeDemo(3);
            //staircaseConstantTimeDemo(4);
            //staircaseConstantTimeDemo(42);
            //staircaseConstantTimeDemo(45);
            var staircase = new Staircase();
            staircase.Demo([2,3,10,45]);
            break;
    }
}

#region flowerbed
void flowerbedDemo(int[] flowerbed, int n)
{
    Console.WriteLine($"flowerbed = [{string.Join(", ", flowerbed)}]");
    Console.WriteLine($"n = {n}");
    Console.WriteLine($"Output: {flowerbedFunction(flowerbed,n)}\n");
}

bool flowerbedFunction(int[] flowerbed, int n)
{
    int numSpots = 0;
    for(int i=0;i<flowerbed.Length;i++)
    {
        //handle edge case: spot is left edge
        int leftSpot = (i - 1 < 0) ? 0 : flowerbed[i - 1];
        //handle edge case: spot is right edge
        int rightSpot = (i + 1 >= flowerbed.Length) ? 0 : flowerbed[i + 1];
        if (leftSpot + flowerbed[i] + rightSpot==0) { flowerbed[i] = 2; numSpots++; }
    }

    // remove markers
    for (int i = 0; i < flowerbed.Length; i++)
    {
        if (flowerbed[i]==2) { flowerbed[i] = 0; }
    }
    return numSpots>=n;
}
#endregion

#region staircase
    #region constant time solution
void staircaseConstantTimeDemo(int n)
{
    var staircase = new Staircase();
    Console.WriteLine($"Input: n = {n}");
    Console.WriteLine($"Output: {staircaseFunctionConstantTime(n)}\n");
}
int staircaseFunctionConstantTime(int n)
{
    // follows fibonacci sequence
    // starting at n=3, there are two cases: first step is 1, or first step is 2
    // number of solutions when first step is 1 == staircaseFunction(n-1)
    // number of solutions when first step is 2 == staircaseFunction(n-2)
    // therefore, staircaseFunction(n)=staircaseFunction(n-1)=staircaseFunction(n-2)
    // since we know the value to be fibonacci sequence, we can just do a simple lookup
    // of known fibonacci values within the given constraints of 1<=n<=45
    int[] fibonacciValues = [1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578, 5702887, 9227465, 14930352, 24157817, 39088169, 63245986, 102334155, 165580141, 267914296, 433494437, 701408733, 1134903170, 1836311903];
    return fibonacciValues[n];
}
#endregion
    #region dynamic programming solution
public class Staircase
{
    private int[] solutions = new int[46];
    public void Demo(int[] inputs)
    {
        foreach (int n in inputs) {
            Console.WriteLine($"Input: n = {n}");
            Console.WriteLine($"Output: {staircaseFunction(n)}\n");
        }
    }
    public int staircaseFunction(int n)
    {
        if(n==0||n==1) { solutions[n] = 1; return 1; }
        if(solutions[n] == 0 || solutions[n]==null)
        {
            solutions[n] = staircaseFunction(n-1) + staircaseFunction(n-2);
        }
        return solutions[n];
    }
}
#endregion
#endregion