namespace Dataplace.Imersao.Presentation.Views.Orcamentos.Messages
{
    public class OrcamentoSetaAzulClick
    {

        public OrcamentoSetaAzulClick(int numOrcamento)
        {
            NumOrcamento = numOrcamento;

        }

        public OrcamentoSetaAzulClick(string cdCliente = null, string cdVendedor = null)
        {
            CdCliente = cdCliente;
            CdCliente = cdVendedor;
        }

        public int NumOrcamento { get; }
        public string CdCliente { get; }
        public string CdVendedor { get; }
    }
}
