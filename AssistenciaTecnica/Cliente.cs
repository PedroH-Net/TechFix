namespace TechFix
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Cliente(int id, string nome, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
        }

        public void Mostrar()
        {
            Console.WriteLine(
                $"ID: {Id} | Nome: {Nome} | Telefone: {Telefone}"
            );
        }
    }
}
