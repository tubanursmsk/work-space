/* --1  bir kullanıcının name surname password email değerlerini ekle 
INSERT into  users(name, surname, [password], email, phone)
VALUES(
'ali',
'bil',
'12345',
'ali@mail.com',
'5453910522') */



/* --2   tek sorguda birden fazla kullanıcının name surname password email değerlerini ekle
INSERT into users(name, surname, [password],email,phone)
VALUES('ali','bil','12345','aliiii@mail.com', 5453910500),
('alya','bilmem','12345','alya@mail.com', 5453910522) */


/* -- 3 user  tablosuna eklene son 50 kişiyi getiren sorgu
SELECT top(50) * FROM users ORDER BY uid DESC */



/* -- 4 user tablosunun değerlerini sayfalamaya uygun şekilde getiren sorgu
SELECT * from users 
ORDER BY uid ASC 
OFFSET 0 ROWS
FETCH NEXT 10 ROWS ONLY
 */

/* 
 -- 5 users tablosu içinde name surname  bilgileri içinde arama yapan ve değerin bulunması durumunda veri getiren sorgu
 SELECT * FROM users WHERE [name] LIKE '%all%' or [surname] LIKE '%all%' */
  

  /* -- 6 arama sonuçlarını sayfalama yapacak şekilde olan sorgu
  SELECT * FROM users WHERE [name] LIKE '%all%' or [surname] LIKE '%all%' 
  order BY name ASC
  offset 0 ROWS
  FETCH NEXT 10 ROWS ONLY */

  /* SELECT * count
  FROM users 
  WHERE [name] LIKE '%all%' or [surname] LIKE '%all%' 
  order BY name ASC
  offset 0 ROWS
  FETCH NEXT 10 ROWS ONLY */


-- 7 users tablosu içinde uid değeri 10,14,605,401 olan kullanıcı değerlerini getir
 --SELECT * FROM users WHERE uid IN(10, 14, 401, 605)


--8 users tablosu içindeki son bir aylık kullanıcı kayıtlarını getiren sorgu
--SELECT * FROM users WHERE savedate BETWEEN GETDATE() - 30 and GETDATE()


--9 users tablosu içinde email= 'ali@mail.com' ve şifresi '12345' ve status değeri 1 olan kullanıcıyı getiren sorgu
-- SELECT * FROM users WHERE [email] = 'ali@mail.com' and [password] = '12345' and [status] = 1
-- SELECT * FROM users WHERE [email] = 'mehmet@mail.com' and [password] = '12345' and [status] is NULL



/* INSERT into  users(name, surname, [password], email, phone)
VALUES(
'veli',
'bilir',
'12345',
'veli@mail.com',
'5453910572') 
 */


/* 
 -- 10 age değeri 50 den büyük olanların adedini getir
SELECT COUNT(*) AS ageCount
FROM users
WHERE age > 50;


SELECT COUNT(*) as ageCount, age  FROM users GROUP BY age  */