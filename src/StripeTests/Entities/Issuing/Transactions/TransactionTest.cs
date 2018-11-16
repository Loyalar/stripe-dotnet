namespace StripeTests.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Issuing;
    using Xunit;

    public class TransactionTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/issuing/transactions/ipi_123");
            var transaction = JsonConvert.DeserializeObject<Transaction>(json);
            Assert.NotNull(transaction);
            Assert.IsType<Transaction>(transaction);
            Assert.NotNull(transaction.Id);
            Assert.Equal("issuing.transaction", transaction.Object);
        }
    }
}
