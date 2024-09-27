class Program
{
    static void Main()
    {
        Console.Write("Matn kiriting: ");
        string userInput = Console.ReadLine()!;

        Console.WriteLine("Tanlang:"); 
        Console.WriteLine("1. Matnni formatlash (Format)"); 
        Console.WriteLine("2. Matnni bo'laklarga ajratish (Split)");
        Console.WriteLine("3. Matndan substring olish (Substring)");
        Console.WriteLine("4. Matnlarni taqqoslash (Compare)");
        Console.WriteLine("5. Matnni almashtirish (Replace)");
        Console.WriteLine("6. Matn ichida so'z topish (Contains)");
        Console.WriteLine("7. Matnlarni birlashtirish (Join)");
        Console.WriteLine("8. Bo'sh joylarni olib tashlash (Trim)");
        Console.WriteLine("9. Matn oxirini tekshirish (EndsWith)");
        Console.WriteLine("10. Belgining indeksini aniqlash (IndexOf)");
        Console.WriteLine("11. Matnni o'chirish (Remove)");
        Console.WriteLine("12. Harflarni katta qilish (ToUpper)");
        Console.WriteLine("13. Harflarni kichik qilish (ToLower)");
        Console.WriteLine("14. Matnni chap tomondan to'ldirish (PadLeft)");
        Console.WriteLine("15. Matnni o'ng tomondan to'ldirish (PadRight)");
        Console.WriteLine("16. Matn boshini tekshirish (StartsWith)");
        Console.WriteLine("17. Matnni harflarga ajratish (ToCharArray)");
        Console.WriteLine("18. Oxirgi uchraydigan indeksni aniqlash (LastIndexOf)");
        Console.WriteLine("19. Chiqish");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Format: {string.Format("{0}", userInput)}");
            break;

            case 2:
                Console.WriteLine("Bo'laklarga ajratilgan: ");

                foreach(var item in userInput.Split(' '))
                    Console.WriteLine(item);

                break;

            case 3:
                Console.Write("Qaysi indeksdan substring olishni xohlaysiz? ");
                int startIndex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Substring: {userInput.Substring(startIndex)}");
            break;

            case 4:
                Console.Write("Taqqoslash uchun yangi matn kiriting: ");
                string compareText = Console.ReadLine()!;
                Console.WriteLine($"Taqqoslash natijasi: {string.Compare(userInput, compareText)}");
            break;

            case 5:
                Console.Write("Qaysi so'zni almashtirishni xohlaysiz? ");
                string oldWord = Console.ReadLine()!;
                Console.Write("Qaysi so'z bilan almashtirishni xohlaysiz? ");
                string newWord = Console.ReadLine()!;
                Console.WriteLine($"Natija: {userInput.Replace(oldWord, newWord)}");
            break;

            case 6:
                Console.Write("Qaysi so'zni tekshirmoqchisiz? ");
                string containsWord = Console.ReadLine()!;
                Console.WriteLine(userInput.Contains(containsWord) ? "Topildi!" : "Topilmadi!");
            break;

            case 7:
                Console.Write("Birlashtiriladigan matnlarni kiriting (vergul bilan ajratib): ");
                string[] joinStrings = Console.ReadLine()!.Split(',');
                Console.WriteLine($"Birlashtirilgan: {string.Join(" ", joinStrings)}");
            break;

            case 8:
                Console.WriteLine($"Bo'sh joylardan olib tashlanganda: '{userInput.Trim()}'");
            break;

            case 9:
                Console.Write("Matn oxirini tekshirish uchun so'z kiriting: ");
                string endsWithWord = Console.ReadLine()!;
                Console.WriteLine(userInput.EndsWith(endsWithWord) ? "True" : "False");
            break;

            case 10:
                Console.Write("Harf kiriting: ");
                char userChar = Console.ReadLine()![0];
                Console.WriteLine($"{userChar} oxirgi indeks: {userInput.LastIndexOf(userChar)}");
            break;

            case 11:
                Console.Write("Qaysi indeksdan boshlab o'chirishni xohlaysiz? ");
                int removeIndex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Natija: {userInput.Remove(removeIndex)}");
            break;

            case 12:
                Console.WriteLine($"Katta harflar: {userInput.ToUpper()}");
            break;

            case 13:
                Console.WriteLine($"Kichik harflar: {userInput.ToLower()}");
            break;

            case 14:
                Console.Write("Chap tomondan to'ldirish uchun uzunlik kiriting: ");
                int padLeftLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Natija: '{userInput.PadLeft(padLeftLength)}'");
            break;

            case 15:
                Console.Write("O'ng tomondan to'ldirish uchun uzunlik kiriting: ");
                int padRightLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Natija: '{userInput.PadRight(padRightLength)}'");
            break;

            case 16:
                Console.Write("Matn boshini tekshirish uchun so'z kiriting: ");
                string startsWithWord = Console.ReadLine()!;
                Console.WriteLine(userInput.StartsWith(startsWithWord) ? "True" : "False");
            break;

            case 17:
                char[] charArray = userInput.ToCharArray();
                Console.WriteLine("Harflarga ajratilgan:");
                foreach(var c in charArray)
                    Console.WriteLine(c);
            break;

            case 18:
                Console.Write("Qaysi belgi oxirgi uchraydigan indeksini aniqlamoqchisiz? ");
                char lastIndexChar = Console.ReadLine()![0];
                Console.WriteLine($"{lastIndexChar} oxirgi indeks: {userInput.LastIndexOf(lastIndexChar)}");
            break;

            default:
                Console.WriteLine("Noto'g'ri tanlov! Qaytadan urinib ko'ring.");
            break;
        }
    }
}