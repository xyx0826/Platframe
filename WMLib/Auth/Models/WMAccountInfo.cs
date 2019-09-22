using Newtonsoft.Json;

namespace WMLib.Auth.Models
{
    public class WMAccountInfo
    {
        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("linked_accounts")]
        public WMAccountLinks LinkedAccounts { get; set; }

        [JsonProperty("background")]
        public object Background { get; set; }

        [JsonProperty("written_reviews")]
        public long WrittenReviews { get; set; }

        [JsonProperty("check_code")]
        public string CheckCode { get; set; }

        [JsonProperty("patreon_profile")]
        public object PatreonProfile { get; set; }

        [JsonProperty("verification")]
        public bool IsVerified { get; set; }

        [JsonProperty("banned")]
        public bool IsBanned { get; set; }

        [JsonProperty("ban_until")]
        public object BanUntil { get; set; }

        [JsonProperty("ingame_name")]
        public string IngameName { get; set; }

        [JsonProperty("ban_reason")]
        public object BanReason { get; set; }

        [JsonProperty("avatar")]
        public object Avatar { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("unread_messages")]
        public long UnreadMessages { get; set; }

        [JsonProperty("has_mail")]
        public bool HasMail { get; set; }

        [JsonProperty("reputation")]
        public long Reputation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("anonymous")]
        public bool IsAnonymous { get; set; }

        public class WMAccountLinks
        {
            [JsonProperty("steam_profile")]
            public bool HasSteamProfile { get; set; }

            [JsonProperty("patreon_profile")]
            public bool HasPatreonProfile { get; set; }

            [JsonProperty("xbox_profile")]
            public bool HasXboxProfile { get; set; }
        }
    }
}
