namespace TarifApp.Models{

public class Repository{

    private static readonly List<Tarif> _Tarif = new();

    static Repository(){

        _Tarif = new List<Tarif>(){
        new Tarif { Id = 1, Title = "Panna Cotta", Image = "4.jpg", Description="İtalyan Tatlıları Denildiğinde Ilk Akla Gelen Lezzet Panna Cottadır." , Tags = new string[] {"Panna Cotta","tatlı"},isActive =true, isHome=true },
        new Tarif { Id = 2, Title = "Calzone", Image = "5.jpg", Description="Katlanmış Pizza Anlamına Gelen Calzone, Bizdeki Kapalı Pide Ile Benzerlik Gösterir.", Tags = new string[] {"Calzone",},isActive =true, isHome=true },
        new Tarif { Id = 3, Title = "Minestrone Çorbası", Image = "6.jpg", Description="Havuç, Kereviz, Lahana, Meksika Fasulyesi Ve Baharatlarla Hazırlanan Bu Çorba, Sebze Bakımından Çok Zengindir." , Tags = new string[] {"Minestrone Çorbası"},isActive =false, isHome=true },
        new Tarif { Id = 4, Title = "Somon Carpaccio", Image = "7.jpg", Description="Çiğ Etin Çok Ince Bir Şekilde Dilimlenmesiyle Hazırlanır. Venedik Ile Özdeşleşen Carpaccio Sığır Eti, Somon Ve Sebzelerle Hazırlanabilir." , Tags = new string[] {"Carpaccio"},isActive =true, isHome=true },
        new Tarif { Id = 5, Title = "pizza", Image = "1.jpg", Description="Pizza, domates, peynir ve genellikle çeşitli diğer malzemelerle yenen bir yemektir." , Tags = new string[] {"Pizza"},isActive =true, isHome=false },
        new Tarif { Id = 6, Title = "Ravioli", Image = "8.jpg", Description="İtalyan Mantısı Olarak Bilinen Ravioli, Etli Veya Peynirli Olarak Hazırlanır. Genellikle Pesto Sos Eşliğinde Sunulan Bu Yemek, Hem Doyurucu, Hem De Lezzetlidir." , Tags = new string[] {"Ravioli"},isActive =true, isHome=false },
        new Tarif { Id = 7, Title = "Lazanya", Image = "9.jpg", Description="Genellikle Kıymalı Ve Sade Bir Şekilde Sunulur. Lazanya, Ismini İtalya'nın Güzelliğiyle Ünlü Bolonya Şehrinden Alır" , Tags = new string[] {"Lazanya"},isActive =true, isHome=false },
        new Tarif { Id = 7, Title = "Tiramisu", Image = "3.jpg", Description="Kedidili Bisküvi, Mascarpone Peyniri Ve Espresso Ile Hazırlanan Tiramisuyu, Roberto Şef'in Videolu Anlatımıyla Kolayca Hazırlayabilirsiniz." , Tags = new string[] {"Tiramisu"},isActive =true, isHome=true }
            };

    }
        public static List<Tarif> Tarifler{
            get{
                return _Tarif;
            }
        }
            public static Tarif? GetById(int? id){
                return _Tarif.FirstOrDefault(t=> t.Id ==id);
            }
            }
        }
    

