using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapilari_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Giriş Yapınız.\nKullanıcı adını giriniz: ");
            string kullanici_adi = Console.ReadLine();
            Console.Write("Şifreyi giriniz: ");
            string sifre = Console.ReadLine();
            if (kullanici_adi == "Negan" && sifre == "lucille")
            {
                Console.Write("\nBaşarıyla giriş yaptınız.");
            }
            else
            {
                Console.Write("\nGiriş yapılamadı.");
            }
            Console.ReadKey();
        }
    }
}
/* Kod kısmında iki değişken tanımlayıp bir kullanıcı adı ve şifre belirleyiniz. Kullanıcıya mesaj olarak giriş yapınız  diyerek kullanıcı adı ve şifre bilgilerini ayrı ayrı isteyiniz. Ekrandan gelen kullanıcı adı ve sizin değişkeninizdeki değer ile birebir aynı ise başarılı giriş yaptın mesajı verin. Değilse başarısız giriş yaptınız mesajı verin.
*/