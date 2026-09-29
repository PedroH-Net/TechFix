using TechFix;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TechFix
{
    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();
        static List<Tecnico> tecnicos = new List<Tecnico>();
        static List<Equipamento> equipamentos = new List<Equipamento>();
        static List<OrdemServico> ordens = new List<OrdemServico>();

        static int idCliente = 1;
        static int idTecnico = 1;
        static int idEquipamento = 1;
        static int idOrdem = 1;

        static void Main(string[] args)
        {
            int opcao = -1;

            while (opcao != 0)
            {
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("              TECHFIX");
                Console.WriteLine("       ASSISTÊNCIA TÉCNICA");
                Console.WriteLine("======================================");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Cadastrar técnico");
                Console.WriteLine("3 - Cadastrar equipamento");
                Console.WriteLine("4 - Abrir ordem de serviço");
                Console.WriteLine("5 - Listar clientes");
                Console.WriteLine("6 - Listar técnicos");
                Console.WriteLine("7 - Listar equipamentos");
                Console.WriteLine("8 - Listar ordens de serviço");
                Console.WriteLine("9 - Alterar status da OS");
                Console.WriteLine("10 - Fazer pagamento");
                Console.WriteLine("11 - Salvar dados");
                Console.WriteLine("12 - Carregar dados");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("======================================");

                Console.Write("Escolha uma opção: ");

                try
                {
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            CadastrarCliente();
                            break;

                        case 2:
                            CadastrarTecnico();
                            break;

                        case 3:
                            CadastrarEquipamento();
                            break;

                        case 4:
                            AbrirOrdem();
                            break;

                        case 5:
                            ListarClientes();
                            break;

                        case 6:
                            ListarTecnicos();
                            break;

                        case 7:
                            ListarEquipamentos();
                            break;

                        case 8:
                            ListarOrdens();
                            break;

                        case 9:
                            AlterarStatus();
                            break;

                        case 10:
                            FazerPagamento();
                            break;

                        case 11:
                            SalvarDados();
                            break;

                        case 12:
                            CarregarDados();
                            break;

                        case 0:
                            Console.WriteLine("Sistema encerrado.");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Digite uma opção válida.");
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadLine();
                }
            }
        }

        static void CadastrarCliente()
        {
            Console.Clear();

            Console.WriteLine("=== CADASTRO DE CLIENTE ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(
                idCliente,
                nome,
                telefone
            );

            clientes.Add(cliente);

            idCliente++;

            Console.WriteLine("\nCliente cadastrado com sucesso!");
        }

        static void CadastrarTecnico()
        {
            Console.Clear();

            Console.WriteLine("=== CADASTRO DE TÉCNICO ===");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Especialidade: ");
            string especialidade = Console.ReadLine();

            Tecnico tecnico = new Tecnico(
                idTecnico,
                nome,
                telefone,
                especialidade
            );

            tecnicos.Add(tecnico);

            idTecnico++;

            Console.WriteLine("\nTécnico cadastrado com sucesso!");
        }

        static void CadastrarEquipamento()
        {
            Console.Clear();

            Console.WriteLine("=== CADASTRO DE EQUIPAMENTO ===");

            if (clientes.Count == 0)
            {
                Console.WriteLine("Cadastre um cliente primeiro.");
                return;
            }

            ListarClientes();

            Console.Write("\nID do cliente: ");
            int clienteId = int.Parse(Console.ReadLine());

            Console.Write("Tipo do equipamento: ");
            string tipo = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();

            Equipamento equipamento = new Equipamento(
                idEquipamento,
                tipo,
                marca,
                modelo,
                clienteId
            );

            equipamentos.Add(equipamento);

            idEquipamento++;

            Console.WriteLine("\nEquipamento cadastrado com sucesso!");
        }

        static void AbrirOrdem()
        {
            Console.Clear();

            Console.WriteLine("=== ABRIR ORDEM DE SERVIÇO ===");

            if (equipamentos.Count == 0)
            {
                Console.WriteLine("Cadastre um equipamento primeiro.");
                return;
            }

            if (tecnicos.Count == 0)
            {
                Console.WriteLine("Cadastre um técnico primeiro.");
                return;
            }

            ListarEquipamentos();

            Console.Write("\nID do equipamento: ");
            int equipamentoId = int.Parse(Console.ReadLine());

            ListarTecnicos();

            Console.Write("\nID do técnico responsável: ");
            int tecnicoId = int.Parse(Console.ReadLine());

            Console.Write("Problema apresentado: ");
            string problema = Console.ReadLine();

            Console.Write("Serviço realizado: ");
            string servico = Console.ReadLine();

            Console.Write("Valor do serviço: R$ ");
            double valor = double.Parse(Console.ReadLine());

            OrdemServico ordem = new OrdemServico(
                idOrdem,
                equipamentoId,
                tecnicoId,
                problema,
                servico,
                valor
            );

            ordens.Add(ordem);

            idOrdem++;

            Console.WriteLine("\nOrdem de serviço criada!");
        }

        static void ListarClientes()
        {
            Console.WriteLine("\n=== CLIENTES ===");

            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }

            foreach (Cliente cliente in clientes)
            {
                cliente.Mostrar();
            }
        }

        static void ListarTecnicos()
        {
            Console.WriteLine("\n=== TÉCNICOS ===");

            if (tecnicos.Count == 0)
            {
                Console.WriteLine("Nenhum técnico cadastrado.");
                return;
            }

            foreach (Tecnico tecnico in tecnicos)
            {
                tecnico.Mostrar();
            }
        }

        static void ListarEquipamentos()
        {
            Console.WriteLine("\n=== EQUIPAMENTOS ===");

            if (equipamentos.Count == 0)
            {
                Console.WriteLine("Nenhum equipamento cadastrado.");
                return;
            }

            foreach (Equipamento equipamento in equipamentos)
            {
                equipamento.Mostrar();
            }
        }

        static void ListarOrdens()
        {
            Console.Clear();

            Console.WriteLine("=== ORDENS DE SERVIÇO ===");

            if (ordens.Count == 0)
            {
                Console.WriteLine("Nenhuma ordem cadastrada.");
                return;
            }

            foreach (OrdemServico ordem in ordens)
            {
                ordem.Mostrar();
            }
        }

        static void AlterarStatus()
        {
            ListarOrdens();

            if (ordens.Count == 0)
                return;

            Console.Write("\nDigite o ID da OS: ");
            int id = int.Parse(Console.ReadLine());

            OrdemServico ordem = ordens.Find(x => x.Id == id);

            if (ordem == null)
            {
                Console.WriteLine("OS não encontrada.");
                return;
            }

            Console.WriteLine("\n1 - Em análise");
            Console.WriteLine("2 - Em manutenção");
            Console.WriteLine("3 - Aguardando peça");
            Console.WriteLine("4 - Pronto");
            Console.WriteLine("5 - Entregue");

            Console.Write("Escolha o novo status: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
                ordem.Status = "Em análise";

            else if (opcao == 2)
                ordem.Status = "Em manutenção";

            else if (opcao == 3)
                ordem.Status = "Aguardando peça";

            else if (opcao == 4)
                ordem.Status = "Pronto";

            else if (opcao == 5)
                ordem.Status = "Entregue";

            else
                Console.WriteLine("Status inválido.");

            Console.WriteLine("Status atualizado!");
        }

        static void FazerPagamento()
        {
            ListarOrdens();

            if (ordens.Count == 0)
                return;

            Console.Write("\nID da OS: ");
            int id = int.Parse(Console.ReadLine());

            OrdemServico ordem = ordens.Find(x => x.Id == id);

            if (ordem == null)
            {
                Console.WriteLine("OS não encontrada.");
                return;
            }

            Console.WriteLine("\n1 - PIX");
            Console.WriteLine("2 - Cartão");

            Console.Write("Forma de pagamento: ");
            int opcao = int.Parse(Console.ReadLine());

            IPagamento pagamento;

            if (opcao == 1)
                pagamento = new PagamentoPix();
            else
                pagamento = new PagamentoCartao();

            pagamento.Pagar(ordem.Valor);
        }

        static void SalvarDados()
        {
            try
            {
                string json = JsonSerializer.Serialize(
                    new
                    {
                        clientes,
                        tecnicos,
                        equipamentos,
                        ordens
                    }
                );

                File.WriteAllText("dados.json", json);

                Console.WriteLine("Dados salvos com sucesso!");
            }
            catch
            {
                Console.WriteLine("Erro ao salvar os dados.");
            }
        }

        static void CarregarDados()
        {
            try
            {
                if (!File.Exists("dados.json"))
                {
                    Console.WriteLine("Nenhum arquivo de dados encontrado.");
                    return;
                }

                string json = File.ReadAllText("dados.json");

                Console.WriteLine("Dados encontrados!");
                Console.WriteLine(json);
            }
            catch
            {
                Console.WriteLine("Erro ao carregar os dados.");
            }
        }
    }
}
