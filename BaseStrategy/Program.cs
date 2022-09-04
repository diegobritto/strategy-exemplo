using BaseStrategy.model;

Pedido pedidoA = new(new EmpresaA());
Pedido pedidoB = new(new EmpresaB());
Pedido pedidoC = new(new EmpresaC());
Console.WriteLine("Frete empresa A: " + pedidoA.CalculaFrete());
Console.WriteLine("Frete empresa B: " + pedidoB.CalculaFrete());
Console.WriteLine("Frete empresa C: " + pedidoC.CalculaFrete());