using System;
using System.Collections.Generic;

public class Usuario
{
    public string Correo { get; set; }
    public string Contraseña { get; set; }
    public List<Entrenamiento> Entrenamientos { get; set; }

    public Usuario(string correo, string contraseña)
    {
        Correo = correo;
        Contraseña = contraseña;
        Entrenamientos = new List<Entrenamiento>();
    }
}
