PhoneBook book = new PhoneBook();
book.AddGroup("Друзья");
book.AddGroup("Работа");
book.AddNumber("Друзья", "Максик знойный", "+375298249305");
book.AddNumber("Друзья", "Валд ФёрстБлад", "+375298249428");
book.AddNumber("Друзья", "Отец", "+375295047854");
book.AddNumber("Работа", "Начальник", "+75483641875");
book.AddNumber("Работа", "Лёха груз", "+7549862468");
book.AddNumber("Работа", "Маша Секретарша", "+754348568");
book.Print();
class PhoneBook
{
    Dictionary<string, Dictionary<string, string>> book;

    public PhoneBook()
    {
        book = new Dictionary<string, Dictionary<string, string>>();
    }

    public void AddGroup(string group)
    {
        book.Add(group, new Dictionary<string, string>());
    }

    public void AddNumber(string group,string name, string number)
    {
        book[group].Add(name, number);
    }

    public void Print()
    {
        foreach (var item in book)
        {
            Console.WriteLine(item.Key + ":\n");
            foreach (var number in item.Value)
            {
                Console.WriteLine(number.Key + " : " + number.Value);
            }
            Console.WriteLine();
        }
    }
}