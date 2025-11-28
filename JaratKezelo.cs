namespace JaratKezeloProject
{
    public class JaratKezelo
    {
        private List<Jarat> jaratok;

        public void ujJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            Jarat jarat = new(jaratSzam, repterHonnan, repterHova, indulas, 0);
            foreach (var item in jaratok)
            {
                if (item.JaratSzam == jarat.JaratSzam)
                {
                    throw new ArgumentException("A járatszámnak egyedinek kell lennie!");
                }
            }
            jaratok.Add(jarat);
        }
        public void Keses(string jaratSzam, int keses)
        {
            foreach (var item in jaratok)
            {
                if (item.JaratSzam == jaratSzam)
                {
                    if (item.Keses-keses < 0)
                    {
                        throw new NegativKesesException(item.Keses - keses);
                    }
                    item.Keses += keses;
                }
            }
        }
    }
    class NegativKesesException : Exception
    {
        public NegativKesesException(int osszKeses) : base("Nem lehet negatív késés érték: " + osszKeses)
        {
        }
    }
}
