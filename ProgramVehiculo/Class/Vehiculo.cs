using System;

namespace ProgramVehiculo.Class;

public class Vehiculo
{
  private string placa {get;set;} =string.Empty;
  private string marca {get;set;}= string.Empty;
  private string modelo {get;set;} = string.Empty;
  public string PrecioAlquiler {get;set;} = string.Empty;

  public string Placa
  {
    get{return value;}
    set
    {
      if (value ==)
    }
  }

  public Vehiculo()
  {
    
  }
  public Vehiculo(string placa, string marca, string modelo, string precio)
  {
    Placa = placa;
    Marca = marca;
    Modelo = modelo;
    PrecioAlquiler = precio;
  }
}