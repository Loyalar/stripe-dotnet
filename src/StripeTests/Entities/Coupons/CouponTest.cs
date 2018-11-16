namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class CouponTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/coupons/co_123");
            var coupon = JsonConvert.DeserializeObject<Coupon>(json);
            Assert.NotNull(coupon);
            Assert.IsType<Coupon>(coupon);
            Assert.NotNull(coupon.Id);
            Assert.Equal("coupon", coupon.Object);
        }
    }
}
