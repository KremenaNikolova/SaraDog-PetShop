namespace PetShop.Common
{
    public static class ValidationConstants
    {
        public static class ItemValidationConstants
        {
            public const int TitleMinLength = 5;
            public const int TitleMaxLength = 20;

            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 150;

            public const string PriceMinValue = "0";
            public const string PriceMaxValue = "500";

            public const double RatingMinValue = 0;
            public const double RatingMaxValue = 5;

            public const int ImageMaxLength = 2048;

        }

        public static class CategoryValidationConstants
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 20;
        }

        public static class CommentValidationConstants
        {
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 500;
        }
    }
}
