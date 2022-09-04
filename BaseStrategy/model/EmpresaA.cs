using BaseStrategy.model.Interfaces;


namespace BaseStrategy.model
{
    public class EmpresaA : IFrete
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public double CalculaFrete()
        {
            return 10;
        }
    }
}
