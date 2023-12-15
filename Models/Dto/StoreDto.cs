using BusinessEntity;

namespace SmsPanel.Models.Dto
{
    public class StoreDto
    {
        public long id { get; set; }
        /// <summary>
        /// کد خرید مشتری
        /// </summary>
        public string idStore { get; set; }
        public string idStoreEncriptSMS { get; set; }
        /// <summary>
        /// جمع مبلغ پرداختی
        /// </summary>
        public string PriceFinal { get; set; }
        /// <summary>
        /// نام مشتری
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// نام خانوادگی مشتری
        /// </summary>
        public string Family { get; set; } = "";
        /// <summary>
        /// تلفن مشتری
        /// </summary>
        public string Phone { get; set; } = "";
        /// <summary>
        /// تاریخ
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// ساعت
        /// </summary>
        public string Time { get; set; }
        /// <summary>
        /// کارت
        /// </summary>
        public string Card { get; set; }
        /// <summary>
        /// نقدی
        /// </summary>
        public string Cash { get; set; }
        /// <summary>
        /// حساب
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// جمع کل قبل از تخفیف 
        /// </summary>
        public string Price { get; set; }
        /// <summary>
        /// جمع اقلام
        /// </summary>
        public string SumCount { get; set; }
        /// <summary>
        /// سود شما از خرید
        /// </summary>
        public string Discount { get; set; }
        /// <summary>
        /// مالیات بر ارزش افزوده
        /// </summary>
        public string VAT { get; set; }
        /// <summary>
        /// تخفیف سفارشی
        /// </summary>
        public string DiscountRandom { get; set; }
        /// <summary>
        /// جمع کل قیمت خرید بر تعداد
        /// </summary>
        public string PriceKharidAll { get; set; }
        /// <summary>
        /// کد صندوقدار
        /// </summary>
        public string idCashier { get; set; }
        /// <summary>
        /// بارکد خرید
        /// </summary>
        public string idPay { get; set; }
        /// <summary>
        /// وضعیت پرداخت برگشتی
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// رابطه یک به چند بین خرید و کالا های خرید
        /// </summary>
        public List<StoreListKalaDto> StoreListKala { get; set; } = new List<StoreListKalaDto>();
    }
}
