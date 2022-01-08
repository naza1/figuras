namespace CodingChallenge.Data.Classes
{
    public class LanguageFactory
    {
        public ILanguage GetLanguage(int lang)
        {
            switch (lang)
            {
                case 1: return new SpanishLang();
                case 2: return new EnglishLang();
                case 3: return new PortugesLang();
            }

            return new EnglishLang();
        }
    }
}
