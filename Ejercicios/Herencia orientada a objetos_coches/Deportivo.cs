using System;

public class Deportivo : Coche
{
    public int Par { get; set; } // Atributo de aceleración

    // Constructor con todos los datos
    public Deportivo(string marca, string modelo, string matricula, int cv, int cc, double precio, int par)
        : base(marca, modelo, matricula, cv, cc, precio)
    {
        Par = par;
    }

    // Método reprogramarMotor: Incrementa en un 25% los caballos de fuerza
    public override void ReprogramarMotor()
    {
        Cv = (int)(Cv * 1.25);
    }

    // Método toString (sobrescrito)
    public override string ToString()
    {
        return base.ToString() + $", Par: {Par}";
    }
}
