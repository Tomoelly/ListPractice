namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 創建一個List保存待辦事項
            List<string> todos = new List<string>();

            // 2. 新增3個待辦事項到 todos
            todos.Add("學習 C# 的 List基礎");
            todos.Add("紀錄在 chatGPT 上討論的內容");
            todos.Add("對答案");

            // 3. 使用迴圈列出所有待辦事項
            // 提示: 用foreach或for迴圈來遍歷List並使用Console.WriteLine印出每個待辦

            Console.WriteLine("目前的待辦事項: ");
            foreach (string todo in todos)
            {
                Console.WriteLine(todo);
            }

            // 4. 刪除其中一個待辦事項
            // 提示: 使用 .Remove() 方法移除某個待辦事項
            todos.Remove("對答案");
            todos.Remove("測試移除不存在的項目");

            // 5. 再次使用迴圈印出剩下所有待辦事項
            Console.WriteLine("目前的待辦事項: ");
            foreach (var todo in todos)
            {
                Console.WriteLine(todo);
            }

            // 6. 確認所有步驟是否成功並運行code

        }
    }
}
