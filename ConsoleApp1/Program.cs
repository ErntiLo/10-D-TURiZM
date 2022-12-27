using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("10/D Uygulamasına Hoş Geldiniz...");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Uygulamalar...");
            Console.WriteLine("Taksi ugulaması İçin 1 e tıklayınız");
            Console.WriteLine("Otobüs uygulaması için 3'e tıklayınız");
            string uygulamabilgisi = Console.ReadLine();
            if (uygulamabilgisi == "1")
            {
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Uygulamaya Giriş İçin 1'ye Tıklayınız");
                Console.WriteLine("Uygulama Daha Beta aşamasında olduğu için geçici kullanıcı adı ve şifre kullanmak isterseniz seçeneklerden seçebilirsiniz.");
                Console.WriteLine("--------------------------------------------");
                string secenekbilgi = Console.ReadLine();
                Console.Clear();
                if (secenekbilgi == "1")
                {
                    Console.Clear();
                bas2:

                    Console.WriteLine("**************************************************************************************");
                    Console.WriteLine("*     Giriş Yapmak İçin 1'e tıklayınız                                               *");
                    Console.WriteLine("*      Kullanıcı Adı ve şifreyi Görmek İçin 2'e Tıklayınız;                          *");
                    Console.WriteLine("**************************************************************************************");
                    string secenekbilgi2 = Console.ReadLine();
                    if (secenekbilgi2 == "1")
                    {
                        Console.Clear();
                    bas1:
                        Console.WriteLine("Kullanıcı Adı Giriniz ; ");
                        string kullanicibilgi = Console.ReadLine();
                        if (kullanicibilgi == "turizm")
                        {
                            Console.WriteLine("Şifre Giriniz");
                            if (Console.ReadLine() == "1234")
                            {

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Lütfen Doğru Şifre Giriniz.");
                                goto bas1;
                            }
                            Console.WriteLine("Giriş Başarılı Yönlendiriliyorsunuz");
                            Console.Clear();
                            Console.WriteLine("*****************************************************************************************************************");
                            Console.WriteLine("Uygulamaya Hoş Geldiniz Kullanmak İstediğiniz Taşıtı Seçiniz");
                            Console.WriteLine("*****************************************************************************************************************");
                            Console.WriteLine("Taksi için 1 'e Tıklayınız.");

                            string ulasimbilgi = Console.ReadLine();
                            if (ulasimbilgi == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("*****************************************************************");
                                Console.WriteLine("Müsait Olan Taksiler");
                                Console.WriteLine("Eren Bağ Hadımköy Civarı ");
                                Console.WriteLine("Ahmet Ateş Arnavutköy Merkez Civari");
                                Console.WriteLine("Sudenaz Eskici Hadımköy PTT Civarı");
                                Console.WriteLine("*****************************************************************");
                                Console.WriteLine("Müsait Olmayan Taksiler");
                                Console.WriteLine("İbrahim Can Gülşen Esenkent Opet Civarında Yolcu Taşıyor");
                                Console.WriteLine("*******************************************************************");
                                Console.WriteLine("Müsait Olan taksicilere Ulaşmak için 1'e tıklayınız.");
                                if (Console.ReadLine() == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Eren Taksi İçin 1'e ");
                                    Console.WriteLine("Ahmet Taksi İçin 2'ye");
                                    Console.WriteLine("Sudenaz Taksi İçin 3'e");
                                    string taksicin = Console.ReadLine();
                                    if (taksicin == "1")
                                    {
                                        Console.WriteLine("Lütfen Konumunuzu giriniz: ");
                                        string konum = Console.ReadLine();
                                        Console.WriteLine("Lütfen İsim Ve Soy isim giriniz: ");
                                        string isim = Console.ReadLine();
                                    bas34:


                                        Console.WriteLine("Eren taksiye " + konum + " bilgisi ulaşmıştır ");
                                        Console.WriteLine("*******************************************************************");
                                    bas345:

                                        Console.WriteLine("Eren Taksi Hakkında görüşleri görüntülemek için 1'e tıklayınız");
                                        Console.WriteLine("Eren Taksinin Nerede olduğunu görüntülemek için 5'ye tıklayınız");


                                        string gorus = Console.ReadLine();
                                        Console.WriteLine("*******************************************************************");
                                        if (gorus == "1")
                                        {

                                            Console.WriteLine("E*** T***: hayatımda gördüğüm en kötü taksici ");
                                            Console.WriteLine("A*** G*******: Aşşırı hızlı sürüyor ");
                                            Console.WriteLine("Ç**** Ş****: Muhabbeti sarıyor");
                                            Console.WriteLine("Geri Dönmek İçin Enter'a basın.");


                                            if (Console.ReadLine() == "")
                                            {
                                                Console.Clear();
                                                goto bas34;
                                            }
                                            if (gorus == "5")
                                            {

                                                Console.WriteLine("Eren taksi " + konum + " civarında");

                                                goto bas345;
                                            }
                                        }

                                    }
                                    if (taksicin == "2")
                                    {
                                        Console.WriteLine("Lütfen Konumunuzu giriniz: ");
                                        string konum = Console.ReadLine();
                                        Console.WriteLine("Lütfen İsim Ve Soy isim giriniz: ");
                                        string isim = Console.ReadLine();
                                    bas34:


                                        Console.WriteLine("Ahmet taksiye " + konum + " bilgisi ulaşmıştır ");
                                        Console.WriteLine("*******************************************************************");
                                    bas345:
                                        Console.WriteLine("Ahmet Taksi Hakkında görüşleri görüntülemek için 1'e tıklayınız");
                                        Console.WriteLine("ahmnet Taksinin Nerede olduğunu görüntülemek için 5'ye tıklayınız");
                                        string gorus = Console.ReadLine();
                                        Console.WriteLine("*******************************************************************");
                                        if (gorus == "1")
                                        {

                                            Console.WriteLine("E*** T***: çok samimi ");
                                            Console.WriteLine("Geri Dönmek İçin Enter'a basın.");

                                            if (Console.ReadLine() == "")
                                            {
                                                Console.Clear();
                                                goto bas34;
                                            }
                                        }
                                        if (gorus == "5")
                                        {
                                            Console.WriteLine("sude taksi " + konum + " civarında");
                                            goto bas345;
                                        }




                                    }
                                    if (taksicin == "3")
                                    {
                                        Console.WriteLine("Lütfen Konumunuzu giriniz: ");
                                        string konum = Console.ReadLine();
                                        Console.WriteLine("Lütfen İsim Ve Soy isim giriniz: ");
                                        string isim = Console.ReadLine();
                                    bas34:


                                        Console.WriteLine("sude taksiye " + konum + " bilgisi ulaşmıştır ");
                                        Console.WriteLine("*******************************************************************");
                                    bas345:
                                        Console.WriteLine("sude Taksi Hakkında görüşleri görüntülemek için 1'e tıklayınız");
                                        Console.WriteLine("sude Taksinin Nerede olduğunu görüntülemek için 5'ye tıklayınız");

                                        string gorus = Console.ReadLine();
                                        Console.WriteLine("*******************************************************************");
                                        if (gorus == "1")
                                        {

                                            Console.WriteLine("E*** T***: çok susuyor ");
                                            Console.WriteLine("A*** G*******: çok utangaç ");
                                            Console.WriteLine("Ç**** Ş****: çok yavaş sürüyor ");
                                            Console.WriteLine("Geri Dönmek İçin Enter'a basın.");

                                            if (Console.ReadLine() == "")
                                            {
                                                Console.Clear();
                                                goto bas34;
                                            }
                                            if (gorus == "5")
                                            {
                                                Console.WriteLine("Sude " + konum + " civarında");
                                                goto bas345;
                                            }
                                        }
                                    }
                                }
                                else if (kullanicibilgi == "")
                                {
                                    Console.WriteLine("Lütfen Kullanıcı Adını doğru girin");
                                    goto bas1;



                                }

                            }
                            if (secenekbilgi2 == "2")
                            {
                                Console.WriteLine("Kullanıcı Adı:turizm --------- Şifre: 1234");

                                goto bas2;


                            }
                        }

                    }
                }
            }


            else if (uygulamabilgisi == "3")
            {
                double odenecekTutar = 0;
                int biletParası = 0; 
                 int aracTipi = 0;
                Console.WriteLine("      - 10-D Turizm'e Hoşgeldiniz -      ");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000); // 1 Saniye Bekle
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine("|                                                                                  |");
                Console.WriteLine("| Giriş Yapmak İçin 1'e tıklayınız                                                 |");
                Console.WriteLine("| Şirketimiz'in Kayıt Bölümü Arızalı Olduğu İçin Seçeneklerden Düzenleyebilirsiniz |");
                Console.WriteLine("|                                                                                  |");
                Console.WriteLine("------------------------------------------------------------------------------------");

                if (Console.ReadLine() == "1")
                {
                    Console.Clear();
                bas1:
                    Console.WriteLine("Kullanıcı Adı Giriniz ; ");
                    if (Console.ReadLine() == "turizm")
                        Console.WriteLine("");
                    {
                        Console.WriteLine("Şifre Giriniz");
                        if (Console.ReadLine() == "1234")
                            Console.WriteLine("");
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Lütfen Doğru Şifre Giriniz.");
                            goto bas1;
                        }
                        Console.WriteLine("Giriş Başarılı Yönlendiriliyorsunuz");
                        Console.WriteLine("");
                        Console.WriteLine("         | Yolculuk Yapmak İstediğiniz Aracı Seçiniz |          ");
                        Console.WriteLine("");
                        Console.WriteLine("Yolculuk Yapacağınız Toplu Taşıma Araçlarımız Aşağıdaki Seçeneklerde Mevcuttur :  ");
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("|                       |");
                        Console.WriteLine("|     1 - Otobüs        |");
                        Console.WriteLine("|     2 - Hızlı Tren    |");
                        Console.WriteLine("|                       |");
                        Console.WriteLine("-------------------------");
                        Console.Write(" Lütfen Kaç Numaralı Toplu Taşıma İle Yolculuk Yapmak İstediğinizi Seçiniz : ");
                        int aracTipi2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("|                                            |");
                        Console.WriteLine("|        1 - Arnavutköy Merkez Mahallesi.    |");
                        Console.WriteLine("|        2 - Atatürk Mahallesi.              |");
                        Console.WriteLine("|        3 - Baklalı Mahallesi.              |");
                        Console.WriteLine("|        4 - Bolluca Mahallesi.              |");
                        Console.WriteLine("|        5 - Hadımköy                        |");
                        Console.WriteLine("|                                            |");
                        Console.WriteLine("----------------------------------------------");

                        Console.Write(" Lütfen Kaç Numaralı Mahalleye Yolculuk Yapmak İstediğinizi Seçiniz : ");
                        aracTipi = Convert.ToInt32(Console.ReadLine());
                        Console.Write(" Lütfen Bu Mahalleye Yolculuk Yapmak İçin Kaç Tane Bilet Almak İstediğinizi Giriniz ? : ");
                        biletParası = Convert.ToInt32(Console.ReadLine());
                        if (aracTipi2 == 1)
                        {
                            odenecekTutar = biletParası * 500;
                        }
                        else if (aracTipi2 == 2)

                        {
                            odenecekTutar = biletParası * 400;
                        }
                        
                        }
                       
                        Console.WriteLine(" Ödenecek Tutar : {0} TL'dir 10-D Turizm'e Hoşgeldiniz  Kafe İyi Günler Diler... ", odenecekTutar);
                        Console.ReadKey();
                    }
                    Console.ReadKey();
                }
            }
        }
    }

