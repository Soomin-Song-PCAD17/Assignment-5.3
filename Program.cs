char selection = '1';
while(selection!='q')
{
    Console.WriteLine("1: Flowerbed\n2: Staircase\nq: quit");
    Console.Write("Selection: ");
    selection=Console.ReadKey().KeyChar;
    Console.Clear();
    switch (selection)
    {
        case '1':
            Console.WriteLine("1. You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.\n\nGiven an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.\n\nExample 1:\n\nInput: flowerbed = [1,0,0,0,1], n = 1\n\nOutput: true\n\nExample 2:\n\nInput: flowerbed = [1,0,0,0,1], n = 2\n\nOutput: false\n\n");

            flowerbedDemo([1, 0, 0, 0, 1], 2);
            flowerbedDemo([1, 0, 0, 0, 1], 2);
            break;
        case '2':
            Console.WriteLine("2. You are climbing a staircase. It takes n steps to reach the top.\n\nEach time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?\nExample 1:\n\nInput: n = 2\n\nOutput: 2\n\nExplanation: There are two ways to climb to the top.\n\n1. 1 step + 1 step\n\n2. 2 steps\n\n\nExample 2:\n\nInput: n = 3\n\nOutput: 3\n\nExplanation: There are three ways to climb to the top.\n\n1. 1 step + 1 step + 1 step\n\n2. 1 step + 2 steps\n\n3. 2 steps + 1 step\n\n");
            break;
    }
}

void flowerbedDemo(int[] flowerbed, int n)
{
    Console.WriteLine($"flowerbed = [{string.Join(", ", flowerbed)}]");
    Console.WriteLine($"n = {n}");
    Console.WriteLine($"Output: {flowerbedFunction(flowerbed,n)}\n");
}

bool flowerbedFunction(int[] flowerbed, int n)
{
    int numSpots = 0;
    for(int i = 2;i<flowerbed.Length;i++)
    {
        if (flowerbed[i - 2] + flowerbed[i - 1] + flowerbed[i]==0)
        {
            flowerbed[i - 1] = 2;
            numSpots++;
        }
    }
    for(int i = 0; i < flowerbed.Length; i++)
    {
        if (flowerbed[i]==2) { flowerbed[i] = 0; }
    }
    return numSpots>=n;
}