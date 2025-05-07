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
            Console.WriteLine("1. You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.\r\n\r\nGiven an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.\r\n\r\nExample 1:\r\n\r\nInput: flowerbed = [1,0,0,0,1], n = 1\r\n\r\nOutput: true\r\n\r\nExample 2:\r\n\r\nInput: flowerbed = [1,0,0,0,1], n = 2\r\n\r\nOutput: false\r\n\r\n");
            break;
        case '2':
            Console.WriteLine("2. You are climbing a staircase. It takes n steps to reach the top.\r\n\r\nEach time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?\r\nExample 1:\r\n\r\nInput: n = 2\r\n\r\nOutput: 2\r\n\r\nExplanation: There are two ways to climb to the top.\r\n\r\n1. 1 step + 1 step\r\n\r\n2. 2 steps\r\n\r\n\r\nExample 2:\r\n\r\nInput: n = 3\r\n\r\nOutput: 3\r\n\r\nExplanation: There are three ways to climb to the top.\r\n\r\n1. 1 step + 1 step + 1 step\r\n\r\n2. 1 step + 2 steps\r\n\r\n3. 2 steps + 1 step");
            break;


    }
}