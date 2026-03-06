using System;
namespace Days_11
{
	public enum EStatus
	{
		USER, ADMIN, CUSTOMER, MODERATOR
	}
}

// enum typlerının yazılımdaki etkisi: 
// 1- Kodun okunabilirliğini artırır. Örneğin, EStatus enum'ı sayesinde kullanıcıların
// rollerini daha anlaşılır bir şekilde ifade edebiliriz.

// 2- Hata yapma olasılığını azaltır. Enum'lar, belirli bir küme içindeki değerleri
// temsil eder, bu da yanlış değerlerin kullanılmasını önler.

// 3- Kodun bakımını kolaylaştırır. Enum'lar, belirli bir küme içindeki değerleri
// temsil eder, bu da kodun daha düzenli ve anlaşılır olmasını sağlar.
