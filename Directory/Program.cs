const string rootDir = @"C:\Temp\ManagerFolder";

Dictionary<int, string> students = new Dictionary<int, string>();
students.Add(123, "John Doe");
students.Add(124, "Mary Lee");
students.Add(125, "Jack Jones");
students.Add(126, "Jimmy Jones");

// var dirs = Directory.GetFiles(rootDir, "*.txt", SearchOption.AllDirectories);
// foreach (var dir in dirs)
// {
//     Console.WriteLine(dir);
// }

//File.WriteAllText(dirs[0], $"{students[123]} {students[126]}");
//File.AppendAllText(dirs[0], $" {students[124]} {students[125]}");
//File.AppendAllText(@"C:\Temp\ManagerFolder\AnotherFile.txt", $" {students[126]} {students[125]}");
foreach (string value in students.Values)
{
    File.AppendAllText(rootDir + "\\DataBase.txt", $"{value}\n");
}
var storage = File.ReadAllLines(rootDir + "\\DataBase.txt");
Console.WriteLine(storage.Length);