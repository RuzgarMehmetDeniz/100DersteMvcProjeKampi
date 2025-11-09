# 100DersteMvcProjeKampi  
## ASP.NET MVC Eğitim Kampı Uygulaması  
Bu proje, “100 derste MVC” eğitimi sonunda, öğrendiklerinizi uygulamaya dönüştürmeniz için hazırlanmış bir web uygulamasıdır.

### 🎯 Projenin Amacı  
- MVC mimarisiyle gerçek‑dünya tarzı bir uygulama geliştirme becerisi kazandırmak.  
- Ders içerikleri ve proje modülleri ile öğrencilerin öğrendiklerini pekiştirmelerini sağlamak.

### 🌟 Temel Özellikler  
- Ders modülleri listesi ve detay sayfası: Her ders için içerik, video bağlantısı, örnek proje.  
- Kullanıcı rolleri:  Eğitmen, Yönetici gibi farklı roller tanımlıdır ve erişim kontrolü vardır.  
- Yönetici paneli: Ders, içerik, kullanıcı ve proje yönetimi yapılabilir.  
- Responsive ve modern arayüz: Hem mobilde hem masaüstünde uyumlu, kullanıcı dostu tasarım.  
- Katmanlı mimari ve iyi yapılandırılmış kod: MVC yapısı + servis katmanı + repository katmanı vb.

### 🛠 Kullanılan Teknolojiler  
- C#  
- ASP.NET MVC  
- Entity Framework  
- Microsoft SQL Server  
- HTML5 / CSS3 / JavaScript  
- Bootstrap / jQuery  
- Razor View Engine  

### 🏗 Teknik Mimari  
Proje şu mimari yapı üzerine kurulmuştur:  
- Katmanlı mimari (Layers Architecture): “Controller”, “Service”, “Repository” katmanları ile iş mantığı, veri erişimi ve sunum ayrıştırılmıştır.  
- MVC (Model‑View‑Controller) deseni kullanılmıştır.  
- Uygulama katmanları aşağıdaki şekilde organize edilmiştir:  
  - Controller: HTTP isteklerini alır, uygun servis katmanını çağırır.  
  - Service: İş kurallarının uygulandığı katmandır.  
  - Repository: Veritabanı işlemlerinin yapıldığı katmandır.  
- Bu yapı sayesinde kodun okunabilirliği, test edilebilirliği ve bakım kolaylığı artırılmıştır.

### 🗄 Veritabanı Yapısı  
Veritabanı yapılandırması şu şekilde özetlenebilir:  
- Kullanılan sistem: Microsoft SQL Server (ya da LocalDB)  
- Code First yaklaşımıyla Entity Framework aracılığıyla model‑tablo eşlemeleri yapılmıştır.  
- Ana tablolar ve ilişkiler:  
  - **Users** tablosu ( Eğitmen, Yönetici rolleri)  
  - **Courses** tablosu (ders içerikleri)  
  - İlişkiler: Users ↔ Projects (1‑çok), Courses ↔ Projects (1‑çok)

### 🧱 Modüller / Alt Fonksiyonlar  
- Kullanıcı Girişi & Kayıt:  Eğitmen, Yönetici rolleriyle kayıt/giriş işlemleri.  
- Ders Listeleme & Detay: Tüm derslerin listelenmesi, detay sayfası gösterimi.  
- Yönetici Paneli: Ders ekleme/düzenleme, içerik yönetimi, kullanıcı yönetimi.  
- İlerleme Takibi: Öğrencinin tamamladığı derslerin ve yüklediği projelerin durumlarını izlemesi.  

### 📸 Ekran Görüntüleri![SweedAlert](https://github.com/user-attachments/assets/07b8e858-3d6b-4bf7-b303-a8ca4b8e35f9)
![Home](https://github.com/user-attachments/assets/402bef72-df30-4d7e-bcb9-9e28ff0a700c)
![Geliştirme Araçları](https://github.com/user-attachments/assets/05a1eacc-bd37-4c74-bbe2-6e09d73b2ea0)
![Hakkında](https://github.com/user-attachments/assets/b7d2dcc0-5748-46b1-9ffe-84b9fbcb844e)
![Görseller](https://github.com/user-attachments/assets/9004443e-a580-45f8-a71e-2898a8e921ab)
![Projeye Dair](https://github.com/user-attachments/assets/7f8a50b8-8069-49f6-9f66-9b0841d583a1)
![İletişim](https://github.com/user-attachments/assets/4f5e1807-8b17-4dc1-b2ba-0d486a74c283)
![MvcProjeKampı](https://github.com/user-attachments/assets/6f6cf91c-14c5-4b55-a57f-216d3b73726b)
![Tüm Başlıklar](https://github.com/user-attachments/assets/9331a20f-329a-4c1f-8dd5-0782837f310f)
![Yazarlar](https://github.com/user-attachments/assets/7c90a799-2886-4f5d-b7ec-60836e80832f)
![Galeri](https://github.com/user-attachments/assets/08941281-f83e-4dc6-9237-4b05f8868273)
![Error](https://github.com/user-attachments/assets/1e197172-b2ce-459e-b195-e99582bd8da6)
![Admin Giriş Paneli](https://github.com/user-attachments/assets/93a7b3eb-a7ae-4f66-8527-8b3d0a761d25)
![Yazar Giriş Paneli](https://github.com/user-attachments/assets/b71ad2a8-ccf4-49f0-a10a-053764c838c1)
![Yazar Yazılarım](https://github.com/user-attachments/assets/f24ce3b6-da55-438e-b37f-2779683c7079)
![Yazar Profil](https://github.com/user-attachments/assets/11e407d2-9caa-4e07-8da3-2ad4ab3ed630)
![Yazar Başlıklar](https://github.com/user-attachments/assets/1ea4872e-e00f-4f6d-950c-f6fc389b40eb)
![Yazar Tüm Başlıklar](https://github.com/user-attachments/assets/ee686b2c-0349-4ca9-9d6a-5fa4ad59f335)
![Yazar Mesajlar](https://github.com/user-attachments/assets/28ce1516-7fc9-45cf-b127-dca7548cf4e6)
![Yazar Siteye Git](https://github.com/user-attachments/assets/a726896b-e7dc-4161-a2a7-ef7cb9d61539)
![Başlıklar](https://github.com/user-attachments/assets/884e6e08-ab08-42aa-b713-068c9498d29b)
![Grafikler](https://github.com/user-attachments/assets/28f30db1-0697-42fd-8957-0c23412052a3)
![Hakkımızda](https://github.com/user-attachments/assets/062e9422-9da3-4b35-a8fd-331041d9ef4f)
![Harita](https://github.com/user-attachments/assets/0d7be73b-f070-4f8b-8ee5-8bfcd727385f)
![Giriş Yap](https://github.com/user-attachments/assets/f767e440-b6d4-4757-a2d9-f7b27847626c)

![Raporlar](https://github.com/user-attachments/assets/4a0b22bc-4cc8-4bf9-b9a7-8bf0762d49fb)



