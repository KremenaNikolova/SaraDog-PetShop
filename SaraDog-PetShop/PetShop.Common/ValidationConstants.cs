namespace PetShop.Common
{
    public static class ValidationConstants
    {
        public static class ItemValidation
        {
            public const int TitleMinLength = 5;
            public const int TitleMaxLength = 30;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 1500;

            public const string PriceMinValue = "0";
            public const string PriceMaxValue = "500";

            public const double RatingMinValue = 0;
            public const double RatingMaxValue = 5;

            public const int ImageMaxLength = 2048;

        }

        public static class CategoryValidation
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            public const int ImageMaxLength = 2048;
        }

        public static class CartValidations
        {
            public const string TotalPriceMinValue = "0";
            public const string TotalPriceMaxValue = "2147483647";

            public const string QuantityMinValue = "0";
            public const string QuantityMaxValue = "100";
        }

        public static class UserValidations
        {
            public const int UsernameMinLength = 1;
            public const int UsernameMaxLength = 50;

            public const int FirstNameMinLength = 1;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 1;
            public const int LastNameMaxLength = 50;

            public const int CountryMinLength = 4;
            public const int CountryMaxLength = 56;

            public const int CityMinLength = 2;
            public const int CityMaxLength = 49;

            public const int AddressMinLength = 4;
            public const int AddressMaxLength = 150;

            public const int PostCodeMinLength = 4;
            public const int PostCodeMaxLength = 12;

            public const int DescriptionMaxLength = 1500;
        }


    }
}
