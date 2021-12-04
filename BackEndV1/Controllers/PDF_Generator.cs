using BackEndV1.Utils;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PDF_Generator : ControllerBase
    {
        private IConverter _converter;
        public PDF_Generator(IConverter converter)
        {
            _converter = converter;
        }

        [HttpGet]
        public IActionResult CreatePDF()
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.Letter,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "Convivencia Escolar",
                //Out = @"D:\PDFCreator\Employee_Report.pdf"
            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = TemplateGenerator.GetHTMLString(),
                WebSettings = { DefaultEncoding = "utf-8"},
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Convivencia Escolar" }
            };
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            var file = _converter.Convert(pdf);
            return File(file, "application/pdf", "Report.pdf");
        }


        //impresion desde la busqueda de registro
        [HttpPost]
        public IActionResult CreandoPDF([FromBody] DataStorage dataStorage)
        {
            {

                //string Html = dataStorage.FromHtmlToPdf;
                byte[] data = Convert.FromBase64String(dataStorage.FromHtmlToPdf);
                string decodedString = Encoding.UTF8.GetString(data);    
                var fecha = DateTime.Now.ToString("dd_MM_yyyy");
                string usuario = "Julieta";
                var globalSettings = new GlobalSettings
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.Letter,
                    Margins = new MarginSettings { Top = 15 },
                    DocumentTitle = "Convivencia Escolar",
                    //Out = @"D:\PDFCreator\Employee_Report.pdf"
                };
                var objectSettings = new ObjectSettings
                {
                    PagesCount = true,
                    HtmlContent = decodedString,
                    WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "Style.css") },
                    HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Pagina [page] de [toPage]", Line = false },
                    FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Convivencia Escolar" }
                };
                var pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = globalSettings,
                    Objects = { objectSettings }
                };
                var file = _converter.Convert(pdf);
                return File(file, "application/pdf", usuario+fecha+".pdf");
            
            }

        }
        [Route("reg")]
        [HttpPost]
        public IActionResult PdfRegistro([FromBody] DataStorage dataStorage)
        {
            {

                //string Html = dataStorage.FromHtmlToPdf;
                byte[] data = Convert.FromBase64String(dataStorage.FromHtmlToPdf);
                string decodedString = Encoding.UTF8.GetString(data);
                var fecha = DateTime.Now.ToString("dd_MM_yyyy");
                string usuario = "Julieta";
                var globalSettings = new GlobalSettings
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.Letter,
                    Margins = new MarginSettings { Top = 15 },
                    DocumentTitle = "Convivencia Escolar",
                    //Out = @"D:\PDFCreator\Employee_Report.pdf"
                };
                var objectSettings = new ObjectSettings
                {
                    PagesCount = true,
                    HtmlContent = decodedString,
                    WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "registro.css") },
                    HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Pagina [page] de [toPage]", Line = false },
                    FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Convivencia Escolar" }
                };
                var pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = globalSettings,
                    Objects = { objectSettings }
                };
                var file = _converter.Convert(pdf);
                return File(file, "application/pdf", usuario + fecha + ".pdf");

            }
        }
    }
}
