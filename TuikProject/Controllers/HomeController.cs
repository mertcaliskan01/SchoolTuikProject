using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using TuikProject.Data;
using TuikProject.Models;

namespace TuikProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebHostEnvironment _hostEnvironment;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, ILogger<HomeController> logger, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _hostEnvironment = hostEnvironment;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Titles()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ImportExport()
        {
            return View();
        }

        public ActionResult Import()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                IFormFile file = Request.Form.Files[0];
                string folderName = "UploadExcel";
                string webRootPath = _hostEnvironment.WebRootPath;
                string newPath = Path.Combine(webRootPath, folderName);
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                if (file.Length > 0)
                {
                    string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                    ISheet sheet;
                    string fullPath = Path.Combine(newPath, file.FileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        stream.Position = 0;
                        if (sFileExtension == ".xls")
                        {
                            HSSFWorkbook hssfwb = new HSSFWorkbook(stream); //This will read the Excel 97-2000 formats  
                            sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook  
                        }
                        else
                        {
                            XSSFWorkbook hssfwb = new XSSFWorkbook(stream); //This will read 2007 Excel format  
                            sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook   
                        }
                        IRow headerRow = sheet.GetRow(0); //Get Header Row
                        int cellCount = 25;
                        sb.Append("<table class='table table-bordered'><tr>");
                        for (int j = 0; j < cellCount; j++)
                        {
                            NPOI.SS.UserModel.ICell cell = headerRow.GetCell(j);
                            if (cell == null || string.IsNullOrWhiteSpace(cell.ToString())) continue;
                            sb.Append("<th>" + cell.ToString() + "</th>");
                        }
                        sb.Append("</tr>");
                        sb.AppendLine("<tr>");
                        for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++) //Read Excel File
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null) continue;
                            if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;
                            for (int j = row.FirstCellNum; j < cellCount; j++)
                            {
                                if (row.GetCell(j) != null)
                                    sb.Append("<td>" + row.GetCell(j).ToString() + "</td>");
                            }
                            sb.AppendLine("</tr>");
                        }
                        sb.Append("</table>");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return this.Content(sb.ToString());
        }


        public ActionResult Download(string fileName)
        {
            ActionResult actionResult = null;
            try
            {
                string Files = "wwwroot/UploadExcel/" + fileName + ".xls";
                byte[] fileBytes = System.IO.File.ReadAllBytes(Files);
                System.IO.File.WriteAllBytes(Files, fileBytes);
                MemoryStream ms = new MemoryStream(fileBytes);
                actionResult = File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName + ".xls");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return actionResult;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
