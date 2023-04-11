using System;

namespace mandalina //binder gibi
{
    internal class bte110 //şeffaf dosyalar gibi
    {
        static void Main(string[] args) //fonksiyonlar, kağıtlar gibi düşünebiliriz
        {
            // == Konsola yazdırma ==
            //Console.Write(argüman): satır içerisine yazdır
            //Console.WriteLine(argüman): yeni satıra yazdır

            Console.Write("Bu yazı ilk satırda olacak"); //";"leri unutma!
            Console.WriteLine(" ve bu kısım ilk satırdan devam edip alt satır yapacak");
            Console.Write("bu ise ikinci satırda devam edecek.");
            Console.WriteLine();

            //Konsola istediğin şeyi yazdırabilirsin, türü doğruysa
            Console.WriteLine("zart"); // çift tırnak içindeki değerler string, kelimeler, cümleler, her boku içerir
            Console.WriteLine();       // Console.WriteLine(zart); // tırnak kullanılmazsa zart bir değişken olarak tanınır.
                                       // değişkenleri bir aşağıda açıklıyorum.

            // == Değişkenler ==
            // var = genel geçer değişken adı, içeriğine göre türü şekillenir, hoca bunu göstermedi ama
            // sayısal veri türleri için detaylıca bakacağın kaynak: https://learn.microsoft.com/tr-tr/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

            int a = 12; //32 bit (2^32) işaretli (+-li) tam sayıları atayabileceğin veri türü (integer = int = tam sayı)
            byte b = 255; //8 bit (2^8) işaretsiz (yalnızca pozitif) sayısal değerler, 0-255 arası

            // kayan nokta (ondalıklı) veri türleri: https://learn.microsoft.com/tr-tr/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

            float c = 1.2345f; //yanına f koyduğumuzda bu ondalıklının float olduğunu belirtiriz
            double d = 3.4567891234561; //ondalıklı sayılar için double zaten standart, gerekirse yanına d koyabilirsin
            decimal e = 5.67895645645645654656m; //float ile aynı mantık

            //bu kadar veri türü niye var? çünkü her biri bellekte farklı alan kaplıyor
            s
            string f = "ce-eee merhaba lalalala!"; //string yazı atayabileceğimiz bir veri türü, çift tırnak içinde belirtiriz
            char g = 'a'; //char yalnızca bir karakter atayabileceğimiz veri türü, tek tırnak içinde belirtiriz, sayısal bir karşılığı da vardır stringe göre

            //bu arada bunların hepsini de çıktı alırken kullanabilirsin

            Console.WriteLine(a); //çıktısı 12
            Console.WriteLine(b); //çıktısı 255
            Console.WriteLine(c); //çıktısı 1,2345
            Console.WriteLine(d); //çıktısı 3,456
            Console.WriteLine(e); //çıktısı 5,6789
            Console.WriteLine(f); //çıktısı ce-eee merhaba lalalala!
            Console.WriteLine(g); //çıktısı a (özel vaka, 58. satıra bak)

            //+ nominatörü hem toplama, hem de yan yana yazdırma eylemlerinde kullanılır.
            //sayı veri türlerinde (int, byte vs.) toplama
            //eğer string varsa yan yana yazdırma yapar

            Console.WriteLine(); //boş satır da yazdırabilirsin, boşluk yapmak için
            Console.WriteLine(a + a); //a değişkeni integer, toplam yazacak
            Console.WriteLine(f + a); //f değişkeni string olduğundan yan yana yazdıracak
            Console.WriteLine(g + a); //g değişkeni char sayısal bir değere de sahip, bu yüzden toplama yapar, çıktı a12 olmaz

            // = Dönüşümler ==

            //türler birbirine dönüştürülebilir ve dönüşümleri her birinin farklıdır
            //bir önceki kısımda çeşitli sayısal veri türlerinin hafızada farklı alan kaplaması dönüşümlerde hiyerarşi yaratır
            //sayısal veri türlerinde küçük alan kaplayanların büyüğe dönüştürülmesi örtük de gerçekleşebilir

            byte h = 10;
            int i = h; //bu yaptığımız örtük dönüşüm direkt byte'taki 10 değerini int olarak kullanır

            //büyük alan kaplayanların daha küçüğe dönüştürülmesi için açık dönüşümler gerekir

            int j = 256; //byte'ın tutabileceği 255'ten büyük bir veri atıyoruz...
            byte k = (byte)j; //parantez içi belirtimi *cast* açık dönüşümüdür
            // byte l = Convert.ToByte(j); //Convert sınıfı ile açık dönüşüm

            //Convert sınıfı hataları görmek için kullanışlıdır, overflow exception verir çünkü
            //cast dönüşümleri hata vermez, ama veri kaybına yol açar. k değişkeni çıktı olarak 0 verir (bilgisayarlar 0dan saymaya başlar)

            //bazı veri türlerinin ayrıca özel dönüşüm fonksiyonları da bulunur

            string m = "123456"; //burada sayısal bir değer var
            int n = int.Parse(m); //int.Parse() fonksiyonu stringte sadece sayısal değer varsa çalışır, yoksa hata verir
            Console.WriteLine(n);

            int o = 6969;
            string p = o.ToString(); //arg.ToString() = Convert.ToString(arg) kullanarak da
                                     //herhangi bir sayısal değeri stringe çevirmek mümkün   

            //dönüşümler için daha fazlası: https://learn.microsoft.com/tr-tr/dotnet/csharp/programming-guide/types/casting-and-type-conversions

            // == Kaçış karakterleri ==

            //Programlama dilinde yazdığımız karakterleri bir fonksiyon içinde de belirtmek için farklı formatlar kullanıyoruz
            Console.WriteLine("{0}", "merhaba"); //çıktı olarak 0 konumundaki merhabayı verir
            Console.WriteLine("{{0}}", "merhaba"); //çıktı olarak {0} verir, süslü parantezde çift kullanım olarak gözükür
            Console.WriteLine("\\"); //çıktı olarak \ verir

            // \n, \0 gibi farklı kaçış dizileri farklı çıktılara sebep olur

            Console.WriteLine("Hey\nmerhaba"); //Hey üst satırda, merhaba alt satırda gözükecektir
            Console.WriteLine("Hey\0merhaba"); //Heymerhaba

            //Kaçış karakterlerini genelde böyle tek satırlı stringlerden ziyade çok satırlı form verilerinde kullanırız
            //daha fazlası için https://learn.microsoft.com/tr-tr/dotnet/csharp/programming-guide/strings/#string-escape-sequences
        }
    }
}