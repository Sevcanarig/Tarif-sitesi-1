using System.ComponentModel.DataAnnotations;

namespace TarifApp.Data{
    public class Kullanıcı{
        [Key]
        public int KullanıcıId { get; set; }
        public string? KullanıcıAd { get; set; }
        public string? KullanıcıSoyad { get; set; }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }

        public ICollection<YemekKayit> YemekKayit { get; set; } = new List<YemekKayit>();
    }
    }
