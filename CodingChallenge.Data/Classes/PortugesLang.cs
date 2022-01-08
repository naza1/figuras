using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    internal class PortugesLang : ILanguage
    {
        public string GetEmptyListText()
        {
            return "<h1>lista vazia</h1>";
        }

        public string GetHeaderText()
        {
            throw new NotImplementedException();
        }

        public string GetLineText(int cantidad, decimal area, decimal perimetro, int tipo)
        {
            throw new NotImplementedException();
        }

        public string GetShapeText()
        {
            throw new NotImplementedException();
        }

        public string GetPerimeterText()
        {
            throw new NotImplementedException();
        }
    }
}
