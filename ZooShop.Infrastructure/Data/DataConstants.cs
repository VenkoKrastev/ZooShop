﻿namespace ZooShop.Infrastructure.Data
{
    public static class DataConstants
    {
        public const int ProductNameMinLength = 3;
        public const int ProductNameMaxLength = 100;

        public const int ProductDetailsMinLength = 10;
        public const int ProductDetailsMaxLength = 1000;

        public const int ProductImageUrlMinLength = 5;
        public const int ProductImageUrlMaxLength = 1000000000;

        public const string ProductPriceMinValue = "0";
        public const string ProductPriceMaxValue = "100000";

        public const int CustomerNameMinLength = 3;
        public const int CustomerNameMaxLength = 50;

        public const int CustomerPhoneNumberMinLength = 8;
        public const int CustomerPhoneNumberMaxLength = 20;

        public const int CustomerEmailMinLength = 7;
        public const int CustomerEmailMaxLength = 100;

        public const int AnimalNameMinLength = 3;
        public const int AnimalNameMaxLength = 30;

        public const int ProductCategoryMinLength = 3;
        public const int ProductCategoryMaxLength = 50;

        public const string LengthErrorMessage = "{0} must be between {2} and {1} characters long!";
        public const string RangeErrorMessage = "{0} must be a number between {1} and {2}!";

    }
}
