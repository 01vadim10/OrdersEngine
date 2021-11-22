using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class VideoFactory : IProductFactory
    {
        public IPaymentResult CreateProduct(int amount, string details = "")
        {
            if (amount > 0)
                return GenerateProduct(details);

            return null;
        }

        public virtual IPaymentResult GenerateProduct(string details)
        {
            var product = new VideoProductOfPayment();
            product.ExtraVideo = details.Contains("Learning to Ski") ? "First Aid" : null;
            return new PackingSlip<VideoProductOfPayment>(PaymentResultEnum.Video, product);
        }
    }
}
