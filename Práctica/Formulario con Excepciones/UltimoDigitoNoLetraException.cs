using System;

public class UltimoDigitoNoLetraException : Exception
{
    public UltimoDigitoNoLetraException() 
        : base("El último carácter del DNI no es una letra.") { }
}