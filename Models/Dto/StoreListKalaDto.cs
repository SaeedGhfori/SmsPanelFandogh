using BusinessEntity;

namespace SmsPanel.Models.Dto
{
    public class StoreListKalaDto
    {
        public long id { get; set; }
        /// <summary>
        /// نام و برند کالا
        /// </summary>
        public string GoodNameGoodBrand { get; set; }
        /// <summary>
        /// تعداد کالا
        /// </summary>
        public double tedad { get; set; }
        /// <summary>
        /// قیمت کالا
        /// </summary>
        public string price { get; set; }
        /// <summary>
        /// تخفیف
        /// </summary>
        public string Discount { get; set; }
        /// <summary>
        /// قیمت خرید
        /// </summary>
        public string PriceKharid { get; set; }
        /// <summary>
        /// مبلغ تعداد بر قیمت کالا
        /// </summary>
        public string PriceAll { get; set; }
        /// <summary>
        /// کد خرید رابطه یک یه چند
        /// </summary>
        public long StoreID { get; set; }
        /// <summary>
        /// رابطه یک به چند بین خرید و لیست کالا های هر خرید
        /// </summary>
        public StoreDto Store { get; set; }
    }
}
