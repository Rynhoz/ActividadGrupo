public class Vehiculo
{
  private string placa {get;set;} =string.Empty;
  private string marca {get;set;}= string.Empty;
  private string modelo {get;set;} = string.Empty;
  private decimal precioAlquiler {get;set;}

  public string Placa
  {
    get{return placa;}
    set
    {
      if (value.Length == 8)
      {
        placa = value;
      }
      else
      {
        Console.WriteLine("La placa debe tener 8 caracteres.");
      }
    }
  }
  public string Marca
  {
    get{return marca;}
    set{marca = value;}
  }
  public string Modelo
  {
    get{return modelo;}
    set{modelo = value;}
  }

  public decimal PrecioAlquiler
  {
    get{return precioAlquiler;}
    set
    {
      if (value > 0)
      {
        precioAlquiler = value;
      }
      else
      {
        Console.WriteLine("El precio de alquiler debe ser mayor a cero.");
      }
    }
  }

  public Vehiculo()
  {
    Placa = "QWERTY";
    Marca = "SIN MARCA";
    Modelo = "SIN MODELO";
    PrecioAlquiler = 1;
  }
  public Vehiculo(string placa, string marca, string modelo, decimal precio)
  {
    Placa = placa;
    Marca = marca;
    Modelo = modelo;
    PrecioAlquiler = precio;
  }
}