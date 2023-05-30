string[] names = { "Wario", "Armstrong", "Arthas", "Anti-Mage" };

var selectedNames = from p in names
                    where p.StartsWith("")
                    orderby p
                    select p;

foreach (var item in selectedNames)
{
    Console.WriteLine(item);
}