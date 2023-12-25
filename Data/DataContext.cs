using Microsoft.EntityFrameworkCore;

namespace  TarifApp.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options){
            
        }
        public DbSet<Yemek> yemekler => Set<Yemek>();
        public DbSet<Kullanıcı> Kullanıcılar => Set<Kullanıcı>();
        public DbSet<YemekKayit> YemekKayitlari => Set<YemekKayit>();
        
    }
}
    
            
    
      