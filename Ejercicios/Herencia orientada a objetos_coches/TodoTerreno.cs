using System;

public class TodoTerreno : Coche
{
    public int Traccion { get; set; } // Atributo de tracción

    // Constructor con todos los datos
    public TodoTerreno(string marca, string modelo, string matricula, int cv, int cc, double precio, int traccion)
        : base(marca, modelo, matricula, cv, cc, precio)
    {
        Traccion = traccion;
    }

    // Método reprogramarMotor: Incrementa en un 10% los caballos de fuerza
    public override void ReprogramarMotor()
    {
        Cv = (int)(Cv * 1.10);
    }

    // Método toString (sobrescrito)
    public override string ToString()
    {
        return base.ToString() + $", Tracción: {Traccion}";
    }
}
