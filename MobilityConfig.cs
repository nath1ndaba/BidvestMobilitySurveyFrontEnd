
namespace BidvestMobilitySurveyFrontEnd
{
    public static class MobilityConfig
    {
        public static string DATABASE_NAME => GetEnv(nameof(DATABASE_NAME));
        public static string API_URL => GetEnv(nameof(API_URL));
        public static string PAYMENT_CHECKOUT_URL => GetEnv(nameof(PAYMENT_CHECKOUT_URL));
        public static string DATABASE_HOST => GetEnv(nameof(DATABASE_HOST));
        public static string DATABASE_AUTH_DB => GetEnv(nameof(DATABASE_AUTH_DB));
        public static string DATABASE_USERNAME => GetEnv(nameof(DATABASE_USERNAME));
        public static string DATABASE_USER_PASSWORD => GetEnv(nameof(DATABASE_USER_PASSWORD));

      
        public static string GetEnv(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }

        public static int GetIntEnv(string key)
        {
            return int.TryParse(GetEnv(key), out int result) ? result : 0;
        }

        public static int GetIntEnv(string key, int @default)
        {
            return int.TryParse(GetEnv(key), out int result) ? result : @default;
        }
    }
}
