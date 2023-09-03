using System;

class Rectangle
{
    // 1. Ein Feld mit einem für Felder typischen Zugriffsmodifizierer.
    private int width;

    // 2. Ein Feld, dessen Wert während der Lebensdauer eines Objekts nicht verändert werden kann.
    private readonly int height;

    // 3. Ein Feld, für welches ein Standardwert zugewiesen wird.
    private string name = "DefaultRectangle";

    // 4. Eine selber implementierte, read-only Eigenschaft.
    public int Area
    {
        get { return width * height; }
    }

    // 5. Eine selber implementierte, read-write Eigenschaft.
    public int Width
    {
        get { return width; }
        set { width = value; }
    }

    // 6. Eine selber implementierte, write-only Eigenschaft.
    public string Name
    {
        set { name = value; }
    }

    // 7. Eine automatisch implementierte, read-only Eigenschaft.
    public int Perimeter { get; } // Nur Getter, automatisch initialisiert.

    // 8. Eine automatisch implementierte, read-write Eigenschaft.
    public string Description { get; set; }

    // 10. Zwei verschiedene Eigenschaften mit jeweils unterschiedlicher Anwendung der expression body Schreibweise.

    // Expression Body Schreibweise für eine read-only Eigenschaft.
    public bool IsSquare => width == height;

    // Expression Body Schreibweise für eine read-write Eigenschaft.
    public double ScaledArea
    {
        get => Area * AreaMultiplier;
        set => AreaMultiplier = value;
    }
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
}
