string [] leksaker = {"Bil", "Pistol", "Såpbubblor", "Stressboll", "Skibidi"};

string [] klasskompisar = {"Leonard", "David", "Rasmus", "Adam", "Eijvan"};

int [] värden = {0, 3, 5, 6, 9};

for (int i = 0; i < klasskompisar.Length; i++)
{
    Console.WriteLine($"{klasskompisar[i]} ger betyget {värden[i]} till {leksaker[i]}");
}

List<string> cities = new List<string>();

while(true)
{
    Console.WriteLine("Skriv en stad.");
    string city = Console.ReadLine();

    if (city == "exit")
    {
        break;
    }
    else
    {
        cities.Add(city);
    }
}

foreach (string stad in cities)
{
    Console.WriteLine(stad);
}

Console.ReadLine();