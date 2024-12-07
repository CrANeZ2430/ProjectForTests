IEnumerable<User> users = [
    new User(1362, "Oleksii", 16),
    new User(1363, "John", 17),
    new User(1363, "Jason", 25)
];

Console.WriteLine(users.Dump());
record User(int Id, string Name, byte Age);