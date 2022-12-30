# MVC.NET Framework ile Core Arasındaki Farklar
* Core Multi Platform
* Core da global.asax yok
	Global.asax içerisinde 5 tane metod vardır.
	Bir web uygulamasında yapılması gereken kodlar yazılır.
	Uygulama başlatığında, sonlandığında ya da isteklerde çalışır.
	Bunun yerini Middleware almıştır.
* Ayar dosyası json tabanlı
* Program.cs içerisindeki gerekli nesneler ve ayarları belirtilmelidir.
* wwwroot klasorunde herkese açık olan veriler tutulur.
* Core da gelen requestlere uygulanmak üzere kullanılan teknoloji Middleware
* Tamamen askenkron programlama desteği ile birlikte gelir, bunun sonucunda eskisine göre 4x
  daha hızlı çalışır.
* Core uygulamaları server üzerinde .exe dosyası olarak tutulur.
* Core içerisinde varsayılan olarak DI kullanımı vardır.
* Core ile birlikte TAG Helper kullanımı gelmiştir.
* Core 6.0 ile Console uygulaması gelmiştir.
<br>
Note: Web uygulamaları dağıtık mimaridir. Client - server uygulamasıdır.
