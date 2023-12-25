using System.ComponentModel.DataAnnotations;

namespace TarifApp.Data
{
    public class YemekKayit
    {
        [Key]
        public int KayitId { get; set; }

        public int KullanıcıId { get; set; }
        public Kullanıcı Kullanıcı { get; set; }  = null!;
        
        public int YemekId { get; set; }
        public Yemek Yemek { get; set; } = null!;

        public DateTime KayitTarihi { get; set; }
        
    }
}