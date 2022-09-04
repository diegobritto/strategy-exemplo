using BaseStrategy.model.Interfaces;

namespace BaseStrategy.model
{
    public class Pedido : IFrete
    {
        private readonly IFrete _frete;
        private List<ItemPedido> _itensPedido;
        public Pedido(IFrete frete)
        {
            _frete=frete;
        }
        public double CalculaFrete()
        {
            return _frete.CalculaFrete();
        }

        public void addPedido(ItemPedido pPedido)
        {
            if(pPedido != null)
                _itensPedido.Add(pPedido);
        }

        public void delPedido(ItemPedido pPedido)
        {
            if (pPedido != null)
                _itensPedido.Add(pPedido);
        }
    }
}
