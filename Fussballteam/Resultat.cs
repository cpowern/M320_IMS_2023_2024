namespace MyNamespace
{
    public class Resultat
    {
        public Spiel Spiel { get; set; } = new Spiel(); //Komposition
        public int HeimmannschaftTore { get; set; }
        public int GastmannschaftTore { get; set; }
    }
}
