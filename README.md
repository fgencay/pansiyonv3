# Pansiyon Yönetim Sistemi

Küçük bir pansiyonun resepsiyon ve kasa işlemleri için geliştirilmiş bir Windows masaüstü uygulaması. Resepsiyon görevlisi, **101–109 numaralı dokuz odanın** doluluk durumunu görebilir, misafire oda seçebilir ve konaklama ücretini giriş-çıkış tarihlerine göre hesaplayabilir.

**Teknolojiler:** C# · Windows Forms · .NET Framework 4.8 · Microsoft SQL Server · ADO.NET

## Bir konaklama kaydının akışı

1. **Oda seçimi:** Yeni müşteri ekranında dolu ve boş odalar ayırt edilir.
2. **Kayıt ve ücret:** Misafirin bilgileri, oda numarası ve konaklama tarihleri kaydedilir. Ücret, gece sayısının koddaki sabit **1.500** birimlik gecelik tarifeyle çarpılmasıyla hesaplanır.
3. **Takip:** Müşteri ekranında kayıtlar listelenebilir, aranabilir ve güncellenebilir. Kaydedilen konaklama ücretleri gelir-gider hesabına dahil edilir.

## Diğer ekranlar

| Ekran | Ne yapar? |
| --- | --- |
| [Odalar](pansiyonv3/frmOdalar.cs) | Her odanın kaydını okuyarak doluluğu ve odaya atanmış misafiri gösterir. |
| [Stoklar ve faturalar](pansiyonv3/frmStoklar.cs) | Gıda, içecek ve atıştırmalık alım tutarlarını; elektrik, su ve internet giderlerini kaydeder. |
| [Gelir-gider](pansiyonv3/frmGelirGider.cs) | Konaklama ücretlerinin toplamından ürün alımları, faturalar ve personel giderini çıkararak kalan tutarı hesaplar. |
| [Mesajlar](pansiyonv3/frmMesajlar.cs) | İsimle birlikte mesaj kaydeder ve önceki mesajları listeler. |

## Yerel ortamda çalıştırma

**Gereksinimler:** Windows, Visual Studio’da **.NET masaüstü geliştirme** iş yükü, .NET Framework 4.8 hedefleme paketi ve erişilebilir bir SQL Server örneği.

1. Depoyu klonlayıp [pansiyonv3.sln](pansiyonv3.sln) dosyasını Visual Studio ile açın.
2. SQL Server’da uygulamanın beklediği şemayı hazırlayın. Örneğin müşteri kayıtları için `MusteriEkle`, oda kayıtları için `Oda101`–`Oda109`, diğer ekranlar için `Stoklar`, `Faturalar` ve `Mesajlar` tabloları kullanılır. Beklenen sütunları ilgili formun SQL sorgularında görebilirsiniz.
3. Formlarda tanımlanan `SqlConnection` bağlantı dizelerini kendi SQL Server örneğinize ve veritabanınıza göre düzenleyin. Ardından çözümü derleyip **F5** ile başlatın.

**Kurulum notu:** Depoda veritabanını oluşturan bir SQL betiği veya örnek veritabanı yedeği yoktur. Projeyi klonlamak tek başına veritabanına bağlı ekranları çalıştırmak için yeterli değildir. Deneme kayıtlarında gerçek misafir bilgileri yerine kurgu veri kullanın.
