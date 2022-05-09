using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Domain.Entities
{
    public class Order:BaseEntity
    {
        //kendimiz yonetmek istersek buraya customerid ekleriz fakat eklemesekte entityframework tool u kendisi iliskiyi kurup ekleme yapicaktir.Biz ekledigimiz zaman ise isminden algilayip baglantiyi kuracaktir arkaplanda
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        //Bire cok veya cok a cok iliski icin kullandigimiz bir yapi icollection
        public ICollection<Product> Products { get; set; }
        //bir musterinin birden fazla siparisi olabilir fakat bir siparisin birden fazla musterisi olamaz. Bunun icin bire cok bir iliski kuruyoruz.
        public Customer Customer { get; set; }
    }
}
