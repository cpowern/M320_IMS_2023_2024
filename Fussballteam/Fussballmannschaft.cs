namespace MyNamespace
{
    public class Fussballmannschaft
    {
        public string ErmittleGewinner(int result)
        {
            if (result > 0)
            {
                return "Team 1 hat gewonnen!";
            }
            else if (result < 0)
            {
                return "Team 2 hat gewonnen!";
            }
            else
            {
                return "Unentschieden!";
            }
        }
    }

}
