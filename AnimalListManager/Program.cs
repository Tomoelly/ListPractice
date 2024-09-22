namespace AnimalListManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 創建一個 List<string> 來儲存動物名字
            List<string> animals = new List<string>();

            // 2. 新增動物名字 Dog, Cat, Elephant, Tiger, Lion 到 List 中
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Elephant");
            animals.Add("Tiger");
            animals.Add("Lion");

            // 1+2. 更簡潔的產生List法:
            List<string> animals2 = new List<string>() { "Dog", "Cat", "Elephant", "Tiger", "Lion" };

            // 3. 使用迴圈列印 List 中的所有動物名字
            // 提示：使用 foreach 迴圈
            Console.WriteLine("List 中的所有動物名字");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            // 4. 從 List 中移除動物名字 Elephant
            Console.WriteLine("\n*從 List 中移除動物名字 Elephant");
            animals.Remove("Elephant");

            // 5. 再次使用迴圈列印剩下的動物名字
            Console.WriteLine("\n*移除 Elephant 後，動物剩下: ");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            // 6. 修改 List 中的 Tiger 名字為 Panther
            // 提示：使用索引查找並更新元素
            // 先找尋 Tiger 的 Index值
            var indexOfTiger = animals.IndexOf("Tiger");

            // 如果有找到，則 IndexOf() 返回索引值，而非 -1
            if (indexOfTiger != -1)
            {
                animals[indexOfTiger] = "Panther";
                Console.WriteLine("\n*修改 Tiger 為 Panther");
            }

            // 7. 列印最終的動物名字列表
            Console.WriteLine("\n*修改Tiger 後的動物清單: ");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
