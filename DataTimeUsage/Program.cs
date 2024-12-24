var currentTime = DateTime.Now;
var dataOfEmployment = new DateTime(2015, 7, 25);

var c = currentTime - dataOfEmployment;
Console.WriteLine((int)(c.TotalDays / 365));
