namespace NumberListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 創建一個 List<int> 來儲存數字
            List<int> numbers = new List<int>();

            // 2. 新增數字 10, 20, 30, 40, 50 到 List 中
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);

            // 3. 使用迴圈列印 List 中的所有數字
            // 提示：使用 foreach 迴圈
            Console.WriteLine("List中的所有數字");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // 4. 從 List 中移除數字 30
            Console.WriteLine("\n從 List 中移除數字 30");
            numbers.Remove(30);

            // 5. 再次使用迴圈列印剩下的所有數字
            Console.WriteLine("\n移除 30 後的數字: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
