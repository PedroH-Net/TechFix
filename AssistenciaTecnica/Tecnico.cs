namespace TechFix
{
    public class Tecnico : Cliente
    {
        public string Especialidade { get; set; }

        public Tecnico(
            int id,
            string nome,
            string telefone,
            string especialidade)
            : base(id, nome, telefone)
        {
            Especialidade = especialidade;
        }

        public new void Mostrar()
        {
            Console.WriteLine(
                $"ID: {Id} | Técnico: {Nome} | " +
                $"Especialidade: {Especialidade}"
            );
        }
    }
}
