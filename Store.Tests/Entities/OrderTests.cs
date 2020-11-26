namespace Store.Tests.Entities
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        [TestCategory("Domain")]
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroComOitoCaracteres()
        {
            var customer = new Customer("Igor Dutra", "igor@igor.io");
            var order = new Order(customer, 0, null);
            Assert.AreEqual(8, order.Number.Length);
        }
        public void DadoUmNovoPedidoSeuStatusDeveSerAguardandoPagamento()
        {
            Assert.Fail();
        }
        public void DadoUmNovoPagamentoDoPedidoSeuStatusDeveSerAguardandoEntrega()
        {
            Assert.Fail();
        }
        public void DadoUmPedidoCanceladoSeuStatusDeveSerCancelado()
        {
            Assert.Fail();
        }
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroComOitoCaracteres()
        {
            Assert.Fail();
        }
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroComOitoCaracteres()
        {
            Assert.Fail();
        }
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroComOitoCaracteres()
        {
            Assert.Fail();
        }
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroComOitoCaracteres()
        {
            Assert.Fail();
        }
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroComOitoCaracteres()
        {
            Assert.Fail();
        }
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroComOitoCaracteres()
        {
            Assert.Fail();
        }
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroComOitoCaracteres()
        {
            Assert.Fail();
        }
        public void DadoUmNovoPedidoValidoEleDeveGerarUmNumeroComOitoCaracteres()
        {
            Assert.Fail();
        }

    }
}