using System;
namespace Days_9.models
{
	public struct User
	{
		public string name;
		public string surname;
		public int age;

		public string allData()
		{
			return $"{name} - {surname} - {age}";
		}

        // override
        // defaultta var olan bir fonksiyonun ezilmesi - değiştirilmesi
        public override string ToString() // allData fonksiyonunu override ederek, nesne yazdırıldığında, ekrana allData fonksiyonunun döndürdüğü değerin yazılmasını sağladık.
        {
			return $"{name} - {surname} - {age}";
        }

    }
}

