
Vehiculo[] vehiculos = new Vehiculo[6];
vehiculos = new Vehiculo[]
{
  null!,
  new Vehiculo("JKL78901", "Chevrolet", "Malibu", 550),
  new Vehiculo("MNO34567", "Nissan", "Sentra", 400),
  new Vehiculo("ABC12345", "Toyota", "Corolla", 500),
  new Vehiculo("DEF67890", "Honda", "Civic", 600),
  new Vehiculo("GHI23456", "Ford", "Focus", 750),
};
Vehiculo vehiculo1 = new Vehiculo("ABC12345", "Toyota", "Corolla", 500);
Vehiculo vehiculo2 = new Vehiculo("DEF67890", "Honda", "Civic", 600);
Vehiculo vehiculo3 = new Vehiculo("GHI23456", "Ford", "Focus", 750);
Vehiculo vehiculo4 = new Vehiculo("GHI23454", "Ford", "Focus", 850);
if (RegistrarVehiculo(vehiculo4, vehiculos))
{
  Console.WriteLine("Vehiculo registrado exitosamente.");
}
else
{
  Console.WriteLine("No se pudo registrar el vehiculo. No hay espacio disponible.");
}

MostrarVehiculos(vehiculos);
Console.WriteLine("Buscar vehiculo:");
string buscar = Console.ReadLine()!;
Console.WriteLine(BuscarPorPlaca(vehiculos, buscar).Modelo);

bool RegistrarVehiculo(Vehiculo vehiculo, Vehiculo[] vehiculos)
{
  for (int i = 0; i < vehiculos.Length; i++)
  {
    if (vehiculos[i] == null)
    {
      vehiculos[i] = vehiculo;
      return true;
    }
  }
  return false;
}

void MostrarVehiculos(Vehiculo[] vehiculos)
{
  foreach (var objVehiculo in vehiculos)
  {
    Console.WriteLine($"Placa: {objVehiculo.Placa}, Marca:{objVehiculo.Marca}, Modelo:{objVehiculo.Modelo}, Precio de alquiler:{objVehiculo.PrecioAlquiler}");
  }
}

Vehiculo BuscarPorPlaca(Vehiculo[] vehiculos, string placa)
{
  var vehiculo = vehiculos.FirstOrDefault(v => v.Placa == placa);
  if (vehiculo == null) return new Vehiculo();

  return vehiculo!;
}

// creacion de nodos

Nodo n1 = new Nodo();
Nodo n2 = new Nodo();
Nodo n3 = new Nodo();

//asignar valores a los nodos
n1.Dato = vehiculo1;
n2.Dato = vehiculo2;
n3.Dato = vehiculo3;

//enlazar los nodos

n1.Siguiente = n2;
n2.Siguiente = n3;

//mostrar todos los nodos usando referencias

Console.WriteLine($"Nodo 1: {n1.Dato.Modelo}");
Console.WriteLine($"Nodo 2: {n1.Siguiente.Dato.Modelo}");
Console.WriteLine($"Nodo 3: {n1.Siguiente.Siguiente.Dato.Modelo}");

Nodo actual = n1;
Console.WriteLine("Recorriendo los nodos enlazados:");
while (actual != null)
{
  Console.Write($"[{actual.Dato}] -> ");
  actual = actual.Siguiente;
}
Console.WriteLine("null");
public class Vehiculo
{
  private string placa { get; set; } = string.Empty;
  private string marca { get; set; } = string.Empty;
  private string modelo { get; set; } = string.Empty;
  private decimal precioAlquiler { get; set; }

  public string Placa
  {
    get { return placa; }
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
    get { return marca; }
    set { marca = value; }
  }
  public string Modelo
  {
    get { return modelo; }
    set { modelo = value; }
  }

  public decimal PrecioAlquiler
  {
    get { return precioAlquiler; }
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

public class Nodo
{
  public Vehiculo Dato { get; set; }
  public Nodo Siguiente { get; set; }

  public Nodo()
  {
    Dato = new Vehiculo();
    Siguiente = null!;
  }
  public Nodo(Vehiculo dato, Nodo siguiente)
  {
    Dato = dato;
    Siguiente = siguiente;
  }
}