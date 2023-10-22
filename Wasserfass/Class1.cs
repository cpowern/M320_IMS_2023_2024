public class Wassertank
{
    private double wasserStand;

    public void befüllen(double wasserMenge)
    {
        wasserStand += wasserMenge;
    }

    public void entnehmen(double wasserMenge)
    {
        wasserStand -= wasserMenge;
    }

    public void entleeren()
    {
        wasserStand = 0;
    }
}
