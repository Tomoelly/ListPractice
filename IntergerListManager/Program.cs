namespace IntergerListManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 創建一個 List<int> 來儲存整數
            List<int> numbers = new List<int>();

            // 2. 新增整數 5, 15, 25, 35, 45, 55 到 List 中
            numbers.Add(5);
            numbers.Add(15);
            numbers.Add(25);
            numbers.Add(35);
            numbers.Add(45);
            numbers.Add(55);

            // 3. 使用迴圈列印 List 中的所有整數
            // 提示：使用 foreach 迴圈
            Console.WriteLine("\nList中的所有整數: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // 4. 找到數字 35 的索引
            // 提示：使用 IndexOf 方法
            int index= numbers.IndexOf(35);

            // 5. 將該整數修改為 100
            // 如果有找到index (index非null)，將該整數修改為100
            // 2024-10-02 這邊忘記 index找不到要怎麼處理，有重新問GPT
            // 重點: IndexOf()沒找到 >> 返回 -1
            if (index != -1)
            {
                // 有找到索引
                numbers[index] = 100;
                Console.WriteLine($"\n已修改索引 {index} 的值為 100");
            }
            else
            {
                Console.WriteLine("List中沒有 35 ");
            }

            // 6. 再次列印所有的整數
            Console.WriteLine("\n再次列印所有的整數: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // 7. 從 List 中移除數字 15
            numbers.Remove(15);
            Console.WriteLine("\n從 List 中移除數字 15");

            // 8. 列印最終的整數列表
            Console.WriteLine("\n列印最終的整數列表");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
