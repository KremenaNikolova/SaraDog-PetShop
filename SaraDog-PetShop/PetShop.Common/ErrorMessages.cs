namespace PetShop.Common
{
    public static class ErrorMessages
    {
        public static class ItemErrorMessages
        {
            public const string InvalidTitle = "Title must be between {2} and {1} characters.";

            public const string InvalidDescription = "Description must be between {2} and {1} characters.";

            public const string InvalidPrice = "Price must be between ${1} and ${2}.";
        }

        public static class OrderErrorMessages
        {
            public const string InvalidFirstName = "First Name must be between {2} and {1} characters.";

            public const string InvalidLastName = "Last Name must be between {2} and {1} characters.";

            public const string InvalidCountry = "Country must be between {2} and {1} characters.";

            public const string InvalidCity = "Name of the City must be between {2} and {1} characters.";

            public const string InvalidAddress = "Address must be between {2} and {1} characters.";

            public const string InvalidPostCode = "Postal Code must be between {2} and {1} characters.";

            public const string InvalidDescripion = "Description can not be more of {1} characters.";
        }

        public static class CategoryErrorMessages
        {
            public const string InvalidName = "Category Name must be between {2} and {1} characters.";
        }

        public static class UserErrorMessage
        {
            public const string InvalidUsername = "{0} must be between {2} and {1} characters.";
        }

        public static class GeneralError
        {
            public const string GeneralRequiredErrorMessage = "The field is required!";
        }

    }
}
