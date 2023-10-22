namespace MyNamespace
{
    public class Spiel
    {
        public Fussballmannschaft Heimmannschaft { get; set; } = new Fussballmannschaft(); //Komposition
        public Fussballmannschaft Gastmannschaft { get; set; } = new Fussballmannschaft(); //Aggregation
        public Resultat SpielResultat { get; set; }
    }
}
