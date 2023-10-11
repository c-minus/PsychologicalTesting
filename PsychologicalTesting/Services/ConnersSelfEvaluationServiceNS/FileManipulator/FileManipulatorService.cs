using Microsoft.AspNetCore.Components.Forms;
using NPOI.XSSF.UserModel;

namespace PsychologicalTesting.Services.ConnersSelfEvaluationServiceNS.FileManipulator;

public class FileManipulatorService : IFileManipulatorService
{
    public IEnumerable<Question> ReadFromStream(IBrowserFile file)
    {
        try
        {
            // using var stream = file.OpenReadStream();
             // using FileStream fs = new(@"\Users\catalin.lupea\Projects\PsychologicalTesting\PsychologicalTesting\Temp.xlsx", FileMode.Create);
             File.WriteAllText(@"/Users/catalin.lupea/Downloads/FromCSharp.txt", "test");
             // string contents = File.ReadAllText(@"\Users\catalin.lupea\Downloads\TestText.txt");
             // using FileStream fs2 = new FileStream(@"\Users\catalin.lupea\Downloads\TestExcel.xlsx", FileMode.Open, FileAccess.Read, FileShare.Read);
            //  file.OpenReadStream().CopyToAsync(fs);
            //
            // fs.Position = 0;
            // var rows = (await stream.QueryAsync()).ToList();
            // FileStream fs =
            //     new FileStream(Server.MapPath(@"\Content\NPOITemplate.xls"), FileMode.Open, FileAccess.Read);

            // Getting the complete workbook...
            // var templateWorkbook = new XSSFWorkbook(fs2)

            // Getting the worksheet by its name...
            // var sheet = templateWorkbook.GetSheet("Sheet1");

            // Getting the row... 0 is the first row.
            // var dataRow = sheet.GetRow(2);

            // Setting the value 77 at row 5 column 1
            // var cellValue = dataRow.GetCell(0);

            return Enumerable.Empty<Question>();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}