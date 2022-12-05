using System.Collections;

ArrayList mas = new ArrayList { "Летуновский" };
mas.Add("Максим");
mas.Add("Александрович");
foreach (string item in mas)
    Console.Write(item + " ");
