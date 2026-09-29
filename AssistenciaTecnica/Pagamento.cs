namespace TechFix
{
    public class PagamentoPix : IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine(
                $"Pagamento de R$ {valor:F2} realizado por PIX."
            );
        }
    }

    public class PagamentoCartao : IPagamento
    {
        public void Pagar(double valor)
        {
            Console.WriteLine(
                $"Pagamento de R$ {valor:F2} realizado no cartão."
            );
        }
    }
}
