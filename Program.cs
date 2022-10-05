using IntroEntityFramework.Models;

Console.WriteLine("Hello, World!");

SystemContext context = new SystemContext();

//A titulo de testes, vamos utilizar migrations no projeto ASP.NET CORE
context.Database.EnsureCreated(); 
// Create ('C'RUD)
// Computer c1 = new Computer(1, "2gb", "i3");
// context.Computers.Add(c1);
// context.SaveChanges();

// Computer c2 = new Computer(2, "4gb", "i5");
// context.Computers.Add(c2);
// context.SaveChanges();

// Computer c3 = new Computer(3, "6gb", "i9");
// context.Computers.Add(c3);
// context.SaveChanges();

//Ler (C'R'UD)
IEnumerable<Computer> computers = context.Computers.ToList();

foreach (var computer in computers)
{
    Console.WriteLine($"{computer.Id}, {computer.Ram}, {computer.Processor}");
}

//Ler (C'R'UD)
Computer encontrado = context.Computers.Find(5);
Console.WriteLine($"Encontrando com Id 5: {encontrado.Ram}, {encontrado.Processor}");

//Atualizar (CR'U'D)
encontrado.Ram = "12GB";
encontrado.Processor = "amd";
context.Computers.Update(encontrado);
context.SaveChanges();

Computer atualizado = context.Computers.Find(5);
Console.WriteLine($"Atualizado com Id 5: {atualizado.Ram}, {atualizado.Processor}");

//Remover (CRU'D')
context.Computers.Remove(atualizado);
context.SaveChanges();
