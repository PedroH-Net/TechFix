namespace TechFix
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public int EquipamentoId { get; set; }
        public int TecnicoId { get; set; }

        public string Problema { get; set; }
        public string Servico { get; set; }

        public double Valor { get; set; }

        public string Status { get; set; }

        public OrdemServico(
            int id,
            int equipamentoId,
            int tecnicoId,
            string problema,
            string servico,
            double valor)
        {
            Id = id;
            EquipamentoId = equipamentoId;
            TecnicoId = tecnicoId;
            Problema = problema;
            Servico = servico;
            Valor = valor;

            // Toda OS começa aberta
            Status = "Aberta";
        }

        public void Mostrar()
        {
            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"OS: {Id}");
            Console.WriteLine($"Equipamento: {EquipamentoId}");
            Console.WriteLine($"Técnico: {TecnicoId}");
            Console.WriteLine($"Problema: {Problema}");
            Console.WriteLine($"Serviço: {Servico}");
            Console.WriteLine($"Valor: R$ {Valor:F2}");
            Console.WriteLine($"Status: {Status}");
        }
    }
}
