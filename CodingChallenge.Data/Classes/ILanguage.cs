namespace CodingChallenge.Data.Classes
{
    public interface ILanguage
    {
        string GetEmptyListText();
        string GetHeaderText();
        string GetLineText(int cantidad, decimal area, decimal perimetro, int tipo);

        string GetShapeText();

        string GetPerimeterText();
    }
}
