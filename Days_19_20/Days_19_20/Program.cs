/*------------------------------------------- SQL Notları ---------------------------------------*/
/*

*** SQL: Structured Query Language (Yapısal sorgu dili) veritabanlarını yönetmek ve
bu veritabanları üzerinde işlemler yapmak için kullanılan dildir. SQL, veritabanlarında veri
ekleme, silme, güncelleme, sorgulama gibi işlemleri gerçekleştirmek için kullanılır.
Bir sistemde verilerin tutulduğu yer veri tabanıdır ve bu verileri yönetip işleyecek dış 
dünya ile ietşimini sağlayacak araca yani veri tabanı yönetim sistemlerine ihtiyac vardır. 

*** VTYS (DTMS: Database Managament System): Eğer veritabanından veri almak veya veri eklemek
istiyorsanız önce uygun şekilde VTYS’ye müracaat etmeniz gerekiyor. Bu müracaat VTYS’nin 
anladığı dilden olmalı. Yani sorgu dili ile tam olarak ne istediğimizi ifade edebilmeliyiz ki 
doğru veriyi elde edebilelim.

VTYS TÜRLERİ; Access,Oracle, MySQL, PostgreSQL, Microsoft SQL Server, SQLite vs.

*** Oracle, ticari olarak piyasaya sürülen ilk VTYS oldu ve SQL dilini kullandı (1979).


**** SQL SERVER İÇERİSİNDE KULLANILAN VERİ TÜRLERİ:

**SAYISAL VERİ TÜRLERİ
1-INT: 32 bitlik değerler için
2-BIGINT: 64 bitlik değerler için
3-SMALLINT: 16 bitlik değerler için
4-TINYINT: 8(1 byte) bitlik değerler için  

5-DECIMAL(P,S): hassas satısal değerler için kullanılır. p: tam s: ondalık kısmı ifade eder
6-NUMERİC(P,S): Decimal ile aynı

7-FLOAT(n): 32-64 bit kayan ondalıklı yası(Bilgisayarlarda reel sayılar, floating point sistemi ile ifade
edilir.)
8-REAL: 32 bit kayan ondalıklı sayı. REAL, FLOAT’un daha düşük hassasiyetli halidir. 

**KARAKTER VERİ TÜRLERİ
9-CHAR(n): 8.000 sabit uzunluklu karakterler
10-VARCHAR(n):8.000 değişken uzunulukta karakterler
11-VARCHAR(MAX): uzun metinler için kullanılır. en fazla 2 gb uzunuluğundaki karakter dizisini destekler.
12-TEXT: 2gb kadar büyük metin verisi (kullanımdan kalkıyor!)

**UNİCODE KARAKTER TÜRLERİ
13-NCHAR(n): 4.000 sabit uzunlukta unuicode karakterler
14-NVARCHAR(n): 4.000 değişken uzunlukta unuicode karakterler



CHAR ve VARCHAR FARKI:
CHAR: Sabit uzunluklu. Örneğin, CHAR(10) her zaman 10 karakter uzunluğundadır. Eksik karakterler boşluklarla 
doldurulur. CHAR, sabit uzunluktadır ve boşluklarla tamamlanır.
VARCHAR: Değişken uzunluklu. Örneğin, VARCHAR(10) en fazla 10 karakter uzunluğunda olabilir, 
ancak daha kısa veriler için sadece gereken kadar yer kaplar.
VARCHAR, değişken uzunluktadır.


NCHAR ve NVARCHAR FARKI:
Unicode karakterler (çok dil desteği) için kullanılır. Bu yüzden 2 bayt yer kaplar.
TEXT, SQL Server’ın eski tiplerinden biridir ve artık önerilmez; yerine VARCHAR(MAX) veya NVARCHAR(MAX) 
tercih edilir.
NCHAR: Sabit uzunluklu Unicode karakter dizileri için.
NVARCHAR: Değişken uzunluklu Unicode karakter dizileri için.

TEXT vs VARCHAR(MAX) farkı:
TEXT: Büyük metin verileri için eski bir veri türü.
VARCHAR(MAX): Büyük metin verileri için modern ve daha esnek bir veri türü.



**TARİH VE SAAT VERİ TÜRLERİ
15-DATE: Yıl, ay, gün (3 byte)
16-TIME: Saat, dakika, saniye (3-5 byte)
17-DATETIME: Tarih ve saat	(8 byte)
18-DATATIME2: Genişletilmiş tarih/saat (6-8 byte)
19-SMALLDATATIME: Daha az hassasiyet (4 byte)
20-DATATIMEOFFSET: Zaman dilimi bilgisi	(8-10 byte)



DATETIME vs DATETIME2 FARKI:
DATETIME: 3.33 milisaniye hassasiyetinde ve daha küçük tarih aralığı.
DATETIME2: 100 nanosaniye hassasiyetinde ve daha geniş tarih aralığı.
DATETIME2, daha geniş aralık ve daha yüksek hassasiyet sunar.
SMALLDATETIME, daha az yer kaplar ama hassasiyeti dakikadır (saniye kısmını yuvarlar).
DATETIMEOFFSET, zaman dilimi bilgisi içerir (örn: UTC+3).


**İKİLİ VERİ TÜRLERİ
21-BINARY: Sabit uzunluklu ikili veriler için kullanılır. En fazla 8.000 bayt.
22-VARBINARY(n): Değişken uzunluklu ikili veriler için kullanılır. En fazla 8.000
23-VARBINARY(MAX):
24-IMAGE: Büyük ikili veriler için kullanılır. VARBINARY(MAX) tercih edilir çünkü IMAGE eski bir veri türüdür.


IMAGE vs VARBINARY(MAX) farkı:
IMAGE: Büyük ikili veriler için eski bir veri türü.
VARBINARY(MAX): Büyük ikili veriler için modern ve daha esnek bir veri türü.


**DİĞER VERİ TÜRLERİ
25-BIT: Mantıksal veri	1 bit 1-0 değerlerini kapsar
26-UNIQUEIDENTIFIER: 16 baytlık GUID (Global Unique Identifier) değerleri için kullanılır.
27-XML: (Extensible Markup Language ya da Türkçesiyle Genişletilebilir İşaretleme Dili) XML verileri için 
kullanılır. 
28-JSON: SQL Server 2016 ve sonrasında JSON verileri için kullanılır. JSON verileri VARCHAR veya NVARCHAR 
türünde saklanır.


29-ROWVERSION: 8 bayt uzunluğund bir binary veri tipidir. tablodaki satırların değişikliklerini izlemek için
kullanılan otomatik olarak artan, benzersiz bir ikili sayıdır. Bir satır her güncellendiğinde, ROWVERSION 
sütunundaki değer otomatik olarak değişir.
Kullanım Senaryosu:
Eşzamanlı işlemleri yönetmek (concurrency control) için.
Satırların değişip değişmediğini tespit etmek için.

30-MONEY: 8 byte.para birimi değerlerini saklamak için kullanılır. Ondalık basamakları olan sayıları, 
finansal işlemler ve parasal veriler için yüksek doğrulukla saklar.
31-SMALLMONEY: 4 byte


32-VECTOR: vektör verilerini depolamak ve özellikle benzerlik aramaları ile makine öğrenimi uygulamalarını
optimize etmek için tasarlanmış yeni bir veri tipidir. Bu veri tipi, vektörleri optimize edilmiş ikili 
formatta saklar ve kullanım kolaylığı için JSON dizileri olarak sunar. Her bir vektör elemanı, tek hassasiyetli 
(4 bayt) kayan nokta değeri olarak depolanır. 



33-sys.GEOGRAPHY: Coğrafi verileri (enlem, boylam gibi) saklamak için kullanılır. (GPS) tabanlıdır.
33-sys.GEOMETRY:İki boyutlu düzlemdeki geometrik verileri saklar (nokta, çizgi, çokgen vb.). Düzlem 
(flat-earth) modeli kullanır.
34-sys.HİERARCHYID:Hiyerarşik verileri (örneğin ağaç yapıları) verimli bir şekilde saklamak için kullanılır. 
Parent-child ilişkileri için idealdir.
35-sys.SYSNAME:NVARCHAR(128) eşdeğeridir. Tablo, sütun, şema adları gibi nesne adlarını saklamak için 
kullanılır.


 */