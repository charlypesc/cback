using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndV1.Utils
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var sb = new StringBuilder();
            sb.Append(@"
                     <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1>Prueba PDF!</h1></div>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
