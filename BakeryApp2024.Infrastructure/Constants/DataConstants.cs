using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp2024.Infrastructure.Constants
{
    public static class DataConstants
    {
        public const int CategoryNameMaxLength = 50;

        public const int ProductNameMinLength = 5;
        public const int ProductNameMaxLength = 50;
        public const int ProductDescriptionMinLength = 20;
        public const int ProductDescriptionMaxLength = 250;

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
    }
}
