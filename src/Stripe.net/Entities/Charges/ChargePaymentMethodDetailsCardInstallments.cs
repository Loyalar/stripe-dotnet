namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardInstallments : StripeEntity<ChargePaymentMethodDetailsCardInstallments>
    {
        [JsonProperty("plan")]
        public ChargePaymentMethodDetailsCardInstallmentsPlan Plan { get; set; }
    }
}
