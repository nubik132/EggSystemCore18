Dictionary<string, string> months = new();
months.Add("December", "Декабрь");
months.Add("January", "Январь");
months.Add("February", "Февраль");
months.Add("March", "Март");
months.Add("April", "Апрель");
months.Add("May", "Май");
months.Add("June", "Июнь");
months.Add("July", "Июль");
months.Add("August", "Август");
months.Add("September", "Сентябрь");
months.Add("October", "Октябрь");
months.Add("November", "Ноябрь");

Console.WriteLine("Англо-русский словарь месяцев");

while (true)
    Console.WriteLine(months[Console.ReadLine()]);
