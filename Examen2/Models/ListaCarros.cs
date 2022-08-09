namespace Examen2.Models
{
    public class ListaCarros
    {
       public List<Carros> Carros { get; set; }
       public static ListaCarros listcar = new ListaCarros();
       private ListaCarros()
        {
            Carros = new List<Carros>();
            AgregarCarro("Tesla","Model X",250,420,116000);
            AgregarCarro("BMW", "ix", 200, 566, 110000);
            AgregarCarro("Mercedes", "EQC", 280, 432, 87000);
            AgregarCarro("Renault", "E-Tech", 170, 260, 50000);
            AgregarCarro("VolksWagan", "ID.4", 180, 496, 58000);
            AgregarCarro("Mustang", "Mach-E", 200, 510, 75000);
        }
        public void AgregarCarro(string a,string b, int c,int d, int e)
        {
            Carros car = new Carros();
            car.Marca = a;
            car.Model = b;
            car.VelocidadMaxina = c;
            car.Kilometrosderecorido = d;
            car.Precio = e;
            car.Id = 0;
            var c1 = Carros.OrderByDescending(x => x.Id).FirstOrDefault();
            car.Id = c1?.Id + 1 ?? 0;
            Carros.Add(car);
        }
    }
}
