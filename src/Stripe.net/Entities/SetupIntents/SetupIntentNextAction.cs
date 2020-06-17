namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentNextAction : StripeEntity<SetupIntentNextAction>
    {
        [JsonProperty("redirect_to_url")]
        public SetupIntentNextActionRedirectToUrl RedirectToUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("use_stripe_sdk")]
        public SetupIntentNextActionUseStripeSdk UseStripeSdk { get; set; }
    }
}
