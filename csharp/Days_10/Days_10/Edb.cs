using System;
namespace Days_10
{
    public enum Edb
    {
        MYSQL, MSSQL, SQLITE
    }
}

// enum db yaparak projede neyi hayata geçirdik:
// 1. Veritabanı türlerini tek bir yerde tanımlayarak kodun okunabilirliğini artırdık.
// 2. Veritabanı türlerini sınırlayarak hatalı değerlerin kullanılmasını önledik.

// program.c'in 16. kod satırı --> DB db = new DB(Edb.SQLITE);  bu kısımda görüldüğü
// üzere EDb. yazıldığında 3 tanae db türünü seçebilirsin sadece