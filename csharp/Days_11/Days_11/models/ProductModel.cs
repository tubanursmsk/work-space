using System;
namespace Days_11.models
{
	public struct ProductModel
	{

		public int? pid;
		public string title;
		public string detail;
		public int price;
		public bool? status;

		public ProductModel(int? pid, string title, string detail, int price, bool? status)
		{
			this.pid = pid;
			this.title = title;
			this.detail = detail;
			this.price = price;
			this.status = status;
		}

        public override string ToString() // toString metodu, bir nesnenin string temsili için kullanılır.
                                          // Bu metodu override ederek, nesnenin istediğimiz şekilde
                                          // string olarak temsil edilmesini sağlayabiliriz.
                                          // bu metodu kullanmadan önce kod çıktısı şu şekildeydi:
                                          // Days_11.models.ProductModel
                                          //toString metodunu override ettikten sonra kod çıktısı şu
                                          //şekilde oldu: 553-Samsung-Samsung Detail-30000-
        {
            return $"{pid}-{title}-{detail}-{price}-{status}";
        }

    }
}

