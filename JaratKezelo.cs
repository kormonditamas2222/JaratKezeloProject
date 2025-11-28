namespace JaratKezeloProject
{
    public class JaratKezelo
    {
        private List<Jarat> jaratok = new List<Jarat>();

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            Jarat jarat = new(jaratSzam, repterHonnan, repterHova, indulas, 0);
            if (jaratok != null) 
            {
                foreach (var item in jaratok)
                {
                    if (item.JaratSzam == jarat.JaratSzam)
                    {
                        throw new ArgumentException("A járatszámnak egyedinek kell lennie!");
                    }
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
        public DateTime MikorIndul(string jaratSzam)
        {
            foreach (var item in jaratok)
            {
                if (item.JaratSzam == jaratSzam)
                {
                    return item.Indulas.AddMinutes(item.Keses);
                }
            }
            throw new ArgumentException("Nincs ehhez a járathoz tartozó időpont.");
        }
        public List<string> JaratokRepuloterrol(string repter)
        {
            List<string> jaratokOnnan = [];
            foreach (var item in jaratok)
            {
                if (item.HonnanRepter == repter)
                {
                    jaratokOnnan.Add(item.JaratSzam);
                }
            }
            return jaratokOnnan;
        }
    }
    class NegativKesesException : Exception
    {
        public NegativKesesException(int osszKeses) : base("Nem lehet negatív késés érték: " + osszKeses)
        {
        }
    }
}
