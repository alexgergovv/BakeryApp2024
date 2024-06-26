﻿namespace BakeryApp2024.Infrastructure.Constants
{
	public static class DataConstants
    {
        public const int CategoryNameMaxLength = 50;

        public const int ProductNameMinLength = 5;
        public const int ProductNameMaxLength = 50;
        public const int ProductDescriptionMinLength = 20;
        public const int ProductDescriptionMaxLength = 250;
        public const string ProductPriceMaxValue = "1000";
        public const string ProductPriceMinValue = "0";

        public const int BakerNameMinLength = 5;
        public const int BakerNameMaxLength = 50;
        public const int BakerPhoneNumberMinLength = 7;
        public const int BakerPhoneNumberMaxLength = 15;

        public const int BlogTitleMinLength = 10;
        public const int BlogTitleMaxLength = 100;
        public const int BlogContentMinLength = 25;
        public const int BlogContentMaxLength = 1000;
        public const int BlogAuthorNameMinLength = 5;
        public const int BlogAuthorNameMaxLength = 50;

        public const int OrderCustomerNameMinLength = 5;
        public const int OrderCustomerNameMaxLength = 50;
        public const int OrderCustomerAddressMinLength = 10;
        public const int OrderCustomerAddressMaxLength = 120;
        public const int OrderCustomerEmailMinLength = 5;
        public const int OrderCustomerEmailMaxLength = 64;
        public const int OrderQuantityMinValue = 0;
        public const int OrderQuantityMaxValue = 50;
        public const int OrderStatusMinLength = 5;
        public const int OrderStatusMaxLength = 30;

        public const int CityMaxLength = 50;
        public const int CityMinLength = 3;
        public const int CountryMaxLength = 50;
        public const int CountryMinLength = 2;
        public const int ZipCodeMaxValue = 99950;
        public const int ZipCodeMinValue = 501;

        public const int UserFirstNameMaxLength = 15;
        public const int UserFirstNameMinLength = 3;
		public const int UserLastNameMaxLength = 20;
		public const int UserLastNameMinLength = 4;
		public const int ReviewDescriptionMaxLength = 200;
		public const int ReviewDescriptionMinLength = 5;

        public const int ReviewerNameMaxLength = 40;
        public const int ReviewerNameMinLength = 4;

        public const int NameOnCardMaxLength = 25;
        public const int NameOnCardMinLength = 3;
		public const int CardNumberMaxLength = 19;
		public const int CardNumberMinLength = 19;
		public const int CardExpirationMonthMaxValue = 12;
		public const int CardExpirationMonthMinValue = 1;
		public const int CardExpirationYearMaxValue = 2100;
		public const int CardExpirationYearMinValue = 2024;
		public const int CardCVVMaxLength = 3;
		public const int CardCVVMinLength = 3;
	}
}
