using OfficeOpenXml;

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
Console.WriteLine("Hello World!");
const string root = @"C:\Temp";
Directory.CreateDirectory(root + @"\TaskManagement");
File.Create(root + @"\TaskManagement\Tasks.xlsx").Close();

using var package = new ExcelPackage(new FileInfo(root + @"\TaskManagement\Tasks.xlsx"));

var worksheet = package.Workbook.Worksheets.Add("Tasks");
worksheet.Cells[1, 1].Value = "Name";
worksheet.Cells[1, 2].Value = "Age";
worksheet.Cells[1, 3].Value = "City";

worksheet.Cells[2, 1].Value = "John Doe";
worksheet.Cells[2, 2].Value = 30;
worksheet.Cells[2, 3].Value = "New York";

worksheet.Cells[3, 1].Value = "Jane Smith";
worksheet.Cells[3, 2].Value = 25;
worksheet.Cells[3, 3].Value = "Los Angeles";

File.WriteAllBytes(root + @"\TaskManagement\Tasks.xlsx", package.GetAsByteArray());

Console.WriteLine(worksheet.Cells[1, 2].Value.ToString());