using _5HO_Me_Fab.Models;
using Microsoft.AspNetCore.Mvc;
using ClosedXML.Excel;
using System.IO;

namespace _5HO_Me_Fab.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserInputModel());
            //return View("~/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Index(UserInputModel model)
        {
            model.TankOptions = new UserInputModel().TankOptions;
            model.TankLookup = new UserInputModel().TankLookup;
            model.TankPrices = new UserInputModel().TankPrices;

            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            decimal individual = 0m;

            if (!string.IsNullOrEmpty(model.TankCust1) && model.TankPrices.TryGetValue(model.TankCust1, out var p1))
                individual += p1;
            if (!string.IsNullOrEmpty(model.TankCust2) && model.TankPrices.TryGetValue(model.TankCust2, out var p2))
                individual += p2;
            if (!string.IsNullOrEmpty(model.TankCust3) && model.TankPrices.TryGetValue(model.TankCust3, out var p3))
                individual += p3;
            if (!string.IsNullOrEmpty(model.TankCust4) && model.TankPrices.TryGetValue(model.TankCust4, out var p4))
                individual += p4;
            if (!string.IsNullOrEmpty(model.TankCust5) && model.TankPrices.TryGetValue(model.TankCust5, out var p5))
                individual += p5;
            if (!string.IsNullOrEmpty(model.TankCust6) && model.TankPrices.TryGetValue(model.TankCust6, out var p6))
                individual += p6;

            model.IndividualPrice = individual;

            var labor = model.LaborHours ?? 0m;
            var subtotal = individual + labor;
            var tax = subtotal * 0.08m;
            model.Tax = tax;
            model.Total = subtotal + tax;

            return View("Index", model);
        }

        [HttpPost]
        public IActionResult ExportToExcel(UserInputModel model)
        {
            model.TankPrices = new UserInputModel().TankPrices;

            decimal individual = 0m;

            if (!string.IsNullOrEmpty(model.TankCust1) && model.TankPrices.TryGetValue(model.TankCust1, out var p1))
                individual += p1;
            if (!string.IsNullOrEmpty(model.TankCust2) && model.TankPrices.TryGetValue(model.TankCust2, out var p2))
                individual += p2;
            if (!string.IsNullOrEmpty(model.TankCust3) && model.TankPrices.TryGetValue(model.TankCust3, out var p3))
                individual += p3;
            if (!string.IsNullOrEmpty(model.TankCust4) && model.TankPrices.TryGetValue(model.TankCust4, out var p4))
                individual += p4;
            if (!string.IsNullOrEmpty(model.TankCust5) && model.TankPrices.TryGetValue(model.TankCust5, out var p5))
                individual += p5;
            if (!string.IsNullOrEmpty(model.TankCust6) && model.TankPrices.TryGetValue(model.TankCust6, out var p6))
                individual += p6;

            model.IndividualPrice = individual;

            var labor = model.LaborHours ?? 0m;
            var subtotal = individual + labor;
            var tax = subtotal * 0.08m;
            model.Tax = tax;
            model.Total = subtotal + tax;

            using var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Quote");

            ws.Cell("A1").Value = "Tank Customization 1";
            ws.Cell("B1").Value = model.TankCust1;
            ws.Cell("C1").Value = model.TankCust1Notes;

            ws.Cell("A2").Value = "Tank Customization 2";
            ws.Cell("B2").Value = model.TankCust2;
            ws.Cell("C2").Value = model.TankCust2Notes;

            ws.Cell("A3").Value = "Tank Customization 3";
            ws.Cell("B3").Value = model.TankCust3;
            ws.Cell("C3").Value = model.TankCust3Notes;

            ws.Cell("A4").Value = "Tank Customization 4";
            ws.Cell("B4").Value = model.TankCust4;
            ws.Cell("C4").Value = model.TankCust4Notes;

            ws.Cell("A5").Value = "Tank Customization 5";
            ws.Cell("B5").Value = model.TankCust5;
            ws.Cell("C5").Value = model.TankCust5Notes;

            ws.Cell("A6").Value = "Tank Customization 6";
            ws.Cell("B6").Value = model.TankCust6;
            ws.Cell("C6").Value = model.TankCust6Notes;

            ws.Cell("A10").Value = "Individual Price";
            ws.Cell("B10").Value = model.IndividualPrice;

            ws.Cell("A11").Value = "Labor Hours";
            ws.Cell("B11").Value = model.LaborHours;

            ws.Cell("A12").Value = "Tax";
            ws.Cell("B12").Value = model.Tax;

            ws.Cell("A13").Value = "Total";
            ws.Cell("B13").Value = model.Total;

            ws.Range("C1:C6").Style.Alignment.WrapText = true;
            ws.Columns().AdjustToContents();
            ws.Rows().AdjustToContents();

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            var content = stream.ToArray();

            return File(
                content,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "TankQuote.xlsx"
            );
        }

        public IActionResult NextPage(int id)
        {
            return View($"StaticView{id}");
        }



    }
}
