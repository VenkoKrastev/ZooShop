namespace ZooShop.Infrastructure.Data
{
    public static class DataConstants
    {
        public const int ProductNameMinLength = 3;
        public const int ProductNameMaxLength = 100;

        public const int ProductDescriptionMinLength = 10;
        public const int ProductDescriptionMaxLength = 1000;

        public const int ProductImageUrlMinLength = 5;
        public const int ProductImageUrlMaxLength = 1000000000;

        public const string ProductPriceMinValue = "0";
        public const string ProductPriceMaxValue = "10000";

        public const int CategoryMinLength = 3;
        public const int CategoryMaxLength = 20;

        public const int ApplicationUserFirstNameMinLength = 1;
        public const int ApplicationUserFirstNameMaxLength = 30;

        public const int ApplicationUserLastNameMinLength = 1;
        public const int ApplicationUserLastNameMaxLength = 30;

        public const int AccessoriesMinLength = 3;
        public const int AccessoriesMaxLength = 20;


        public const string LengthErrorMessage = "{0} must be between {2} and {1} characters long!";
        public const string RangeErrorMessage = "{0} must be a number between {1} and {2}!";

    }
}
