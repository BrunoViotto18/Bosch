using EX003;

for (int i = 0; i < 5; i++)
{
    Animal animal = new Animal();

    Console.WriteLine($"Digite o tipo do {i+1}º animal (Cachorro/Gato/Peixe): ");
    animal.Tipo = Console.ReadLine();

    Console.WriteLine($"\nDigite o nome do {animal.Tipo}");
    animal.Nome = Console.ReadLine();

    Console.Clear();
}

Console.WriteLine($"Foram informados: \n");
Console.WriteLine($"{Animal.Cachorros} cachorros");
Console.WriteLine($"{Animal.Gatos} gatos");
Console.WriteLine($"{Animal.Peixes} peixes");
