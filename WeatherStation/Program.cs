using Database;

User user1 = new User("alkashka", 999);
User user2 = new User("Ja", 999);
Sensor sensor1 = new Sensor();

Console.WriteLine($"Utworzono użytkownika 1: {user1.Name} (ID: {user1.Id})");
Console.WriteLine($"Utworzono użytkownika 2: {user2.Name} (ID: {user2.Id})");
Console.WriteLine("Utworzono sensor 1");
bool i = user1.Equals( user2 );
Console.WriteLine(i);