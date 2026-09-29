namespace TechFix
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int ClienteId { get; set; }

        public Equipamento(
            int id,
            string tipo,
            string marca,
            string modelo,
            int clienteId)
        {
            Id = id;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            ClienteId = clienteId;
        }

        public void Mostrar()
        {
            Console.WriteLine(
                $"ID: {Id} | Tipo: {Tipo} | Marca: {Marca} | " +
                $"Modelo: {Modelo} | Cliente: {ClienteId}"
            );
        }
    }
}
