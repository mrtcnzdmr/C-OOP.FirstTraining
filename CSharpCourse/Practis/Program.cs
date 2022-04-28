using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis
{
    class Program
    {
        static void Main(string[] args)
        {
            //int s1, s2;
            //Console.WriteLine("Bir sayı giriniz: ");
            //s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayıyı giriniz: ");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("AND :" + (s1 & s2));
            //Console.WriteLine("OR: " + (s1 | s2));
            //Console.WriteLine("XOR: " + (s1 ^ s2));
            //Console.ReadLine();

            //int s1, s2, toplam;
            //Console.WriteLine("Bir sayı giriniz:");
            //s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir sayı giriniz:");
            //s2 = Convert.ToInt32(Console.ReadLine());
            //toplam = s1 + s2;
            //Console.WriteLine("Sağa 3 bit kaydırınca toplam değer : {0}", (toplam >> 3));
            //Console.WriteLine("Sola 4 bit kaydırınca toplam değer : {0}", (toplam << 4));
            //Console.ReadLine();

            //int sayi;
            //Console.WriteLine("Bir sayı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi < 10)
            //{
            //    Console.WriteLine("Sayı 10'dan küçük");
            //}
            //else if (sayi > 10)
            //{
            //    Console.WriteLine("Sayı 10dan büyük ");
            //}
            //else if (sayi == 10)
            //{
            //    Console.WriteLine("Sayı 10");
            //}
            //Console.ReadLine();

            //char secim;
            //Console.WriteLine("Bir tuşa basınız");
            //secim = Convert.ToChar(Console.ReadLine());
            //if (secim >= 'A' && secim <= 'Z' || secim >= 'a' && secim <= 'z')
            //{
            //    Console.WriteLine("Harf tuşuna basıldı");
            //}
            //else if (secim >= '0' && secim <= '9')
            //{
            //    Console.WriteLine("Rakam tuşuna basıldı");
            //}
            //else
            //{
            //    Console.WriteLine("Özel karakter tuşuna basıldı");
            //}
            //Console.ReadLine();

            //int a, b, c;
            //Console.WriteLine("Bir sayı giriniz");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir sayı giriniz");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bir sayı giriniz");
            //c = Convert.ToInt32(Console.ReadLine());
            //if (a > b && a > c)
            //{
            //    Console.WriteLine("{0} en büyük sayı", a);
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine("{0} en büyük sayı", b);
            //}
            //else
            //{
            //    Console.WriteLine("{0} en büyük sayı", c);
            //}
            //Console.ReadLine();

            //char character;
            //Console.WriteLine("Gel bir oyun oynayalım :))))))) ");
            //Console.ReadKey();
            //Console.WriteLine("Büyük ya da küçük bir harf yaz :)))");
            //character = Convert.ToChar(Console.ReadLine());
            //if (character >= 'a' && character <= 'z')
            //{
            //    Console.WriteLine("Küçük harfle yazdın AHAHAHAHHA");
            //}
            //else
            //{
            //    Console.WriteLine("Büyük harfle yazdın AHAHHAHAHAH");
            //}
            //Console.ReadLine();

            //int ciftSayıToplam = 0; int tekSayıToplam = 0;
            //int limit;

            //Console.WriteLine("Limit gitiniz:");
            //limit = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("\nTek sayılar");
            //for (int i = 1; i <= limit; i += 2) //tek sayılar
            //{
            //    Console.Write(i + " ");
            //    tekSayıToplam += i;
            //}

            //Console.Write(" => Tek sayıların toplamı : " + tekSayıToplam);

            //Console.WriteLine("\nÇift sayılar");
            //for (int i = 2; i < limit; i += 2)
            //{
            //    Console.Write(i + " ");
            //    ciftSayıToplam += i;
            //}
            //Console.Write(" => Çift sayıların toplamı : " + ciftSayıToplam);
            //Console.ReadLine();


            //int sayac = 1;
            //for (int i = 1000; i > 0; i--)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //        sayac++;
            //    }

            //}
            //Console.WriteLine("5'in katı olan sayı adedi:" + sayac);
            //Console.ReadKey();

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine(i + "x" + j + "=" + i * j);
            //    }
            //    Console.WriteLine("******************");
            //}
            //Console.ReadKey();


            //char cinsiyet, as_du;
            //int yas;

            //Console.WriteLine("Cinsiyetiniz nedir? (e/k)");
            //cinsiyet = Convert.ToChar(Console.ReadLine());
            //if (cinsiyet == 'e' || cinsiyet == 'E')
            //{
            //    Console.WriteLine("Askerliğinizi yaptıysanız(e) yapmadıysanız(h)");
            //    as_du = Convert.ToChar(Console.ReadLine());
            //    if (as_du == 'e' || as_du == 'E')
            //    {
            //        Console.WriteLine("Yaşınız");
            //        yas = Convert.ToInt32(Console.ReadLine());

            //        if (yas <= 30)
            //        {
            //            Console.WriteLine("İşe alındınız");
            //        }
            //        else
            //        {
            //            Console.WriteLine("İşe sadece 31 yaşından küçükler alınacaktır");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Askerliğini yapmamış personel işe alınmayacaktır");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("İşe sadece erkekler alınacaktır");
            //}

            //Console.ReadLine();


            //Console.WriteLine("Lütfen 10 dan küçük bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //string sonuc = sayi < 10 ? "Sayı girişi kabul edildi" : "Sayı girişi kabul edilmedi";
            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            //Console.WriteLine("DİLLER");
            //Console.WriteLine("1-TÜRKÇE");
            //Console.WriteLine("2-ENGLİSH");
            //Console.WriteLine("3-DEUTSCHLAND");
            //Console.WriteLine("4-LA FRANCE");
            //Console.WriteLine("Bir dil seçin");
            //int secim = Convert.ToInt32(Console.ReadLine());
            //switch (secim)
            //{
            //    case 1: Console.WriteLine("Seni seviyorum"); break;
            //    case 2: Console.WriteLine("I love you"); break;
            //    case 3: Console.WriteLine("Ich liebe dich"); break;
            //    case 4: Console.WriteLine("Je t'aime"); break;
            //    default: Console.WriteLine("Yanlış giriş yapıtınız"); break;
            //}
            //Console.ReadLine();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Mert");
            //}


            //int ciftSayılarToplam = 0, tekSayılarToplam = 0;
            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftSayılarToplam += i;
            //    }
            //    else
            //    {
            //        tekSayılarToplam += i;
            //    }
            //}

            //Console.WriteLine("Tek sayılar toplamı:{0}", tekSayılarToplam);
            //Console.WriteLine("Çift sayılar toplamı:{0}", ciftSayılarToplam);


            //int toplam=0, ortalama=0;
            //int i;

            //for (i = 1; i <= 16; i++)
            //{
            //    Console.Write(" {0}. sayıyı giriniz => ",i);
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    toplam += number;
            //}
            //ortalama = toplam / (i - 1);
            //Console.WriteLine("Sayıların toplamı {0}",toplam);
            //Console.WriteLine("Sayıların ortalaması {0}",ortalama);

            //Random rdm = new Random();
            //for (int i = 1; i <=10; i++)
            //{
            //    int number=rdm.Next(1, 101);
            //    Console.WriteLine(i + ". sayı = " + number);
            //}

            //Random rdm = new Random();
            //int s;
            //double s1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    s = rdm.Next(1000, 2001);
            //    s1 = s / 100.0;
            //    Console.WriteLine("{0}.sayi : {1}",i,s1);
            //}


            //char[] d ={ 'a', '?', '_', 'p', '#', '%', '<','!','9','*','/','3','2'};

            //Random rdm = new Random();
            //for (int i = 1; i <=7 ; i++)
            //{
            //    int s = rdm.Next(0, 13);
            //    Console.Write("{0}",d[s]);
            //}






            Console.ReadLine();










        }
    }
}
