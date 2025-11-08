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

### 📸 Ekran Görüntüleri
![Yazarlar](https://github.com/user-attachments/assets/70a896a3-9a18-4d4c-83cf-eb568683130a)
![Grafikler](https://github.com/user-attachments/assets/9d5bc139-61ef-4a0f-a962-6840a886cd20)
![Hakkımızda](https://github.com/user-attachments/assets/bc24a287-c997-4c2c-b2f8-55f4734e5c36)
![Raporlar](https://github.com/user-attachments/assets/50376aa0-c815-4c05-b62b-9fd0b4e10bf0)
![Galeri](https://github.com/user-attachments/assets/cbf7aed2-be5a-41de-b45c-10e6346c798c)
![SweedAlert](https://github.com/user-attachments/assets/8b17dd88-78b5-4861-b11c-5d684a53f328)
![Error](https://github.com/user-attachments/assets/ce8d60d7-746a-40b7-a1ce-da58f52a6ea8)
![Home](https://github.com/user-attachments/assets/df9b053b-840c-43f6-bb52-7aff4e61134b)
![Geliştirme Araçları](https://github.com/user-attachments/assets/2fc63c21-7d11-4644-afd1-0f60a88d2c03)
![Hakkında](https://github.com/user-attachments/assets/2c87fcb4-8b20-494a-be72-c422572af089)
![Görseller](https://github.com/user-attachments/assets/a900ae80-a0cb-4a8f-aa26-c970dc68a3d4)
![Projeye Dair](https://github.com/user-attachments/assets/9253752c-6932-4f7e-b95a-0ee1de97f02b)
![İletişim](https://github.com/user-attachments/assets/3377ca5f-36b5-4a0c-8c8b-5f57325fe38f)
![MvcProjeKampı](https://github.com/user-attachments/assets/8fc8021e-8bad-4cf6-8ddd-670ead8160f5)
![Harita](https://github.com/user-attachments/assets/4baa4728-6b63-4f16-b9f2-93d7a7861ff0)
![Admin Giriş Paneli](https://github.com/user-attachments/assets/dc0d4132-f027-4e25-b214-f5d0e8ccfca6)
![Yazar Giriş Paneli](https://github.com/user-attachments/assets/c05e60ac-c1e3-41ec-8e8f-7d29665590f9)
![Yazar Yazılarım](https://github.com/user-attachments/assets/c5b972bd-4e75-4d1a-8335-cd147cb7fbbc)
![Yazar Profil](https://github.com/user-attachments/assets/d876e6e2-5556-41f8-86e1-d2f414cbce70)
![Yazar Başlıklar](https://github.com/user-attachments/assets/28f48904-8b56-498d-a6ac-3f4a8958da66)
![Yazar Tüm Başlıklar](https://github.com/user-attachments/assets/9e5cc4a7-7660-42c6-9991-73e1c73fab48)
![Yazar Mesajlar](https://github.com/user-attachments/assets/b76ddd14-29b6-4f5b-a37e-05193c3b30c8)
![Yazar Siteye Git](https://github.com/user-attachments/assets/94a7a4ce-d456-4577-ae72-35cef1305859)
![Başlıklar](https://github.com/user-attachments/assets/15cd9024-5ea9-4754-933f-e8b863243c8e)
![Yazılar](https://github.com/user-attachments/assets/7010528a-c9d2-4c91-972c-23ba0d9b1a3a)

