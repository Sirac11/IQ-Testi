Console.WriteLine("Adınızı girin");
string ad = Console.ReadLine();


if (ad == "Hepsinin doğru olması için adınız")
{
    
    int TopSkor = 0;


    for (int i = 0; i < 5; i++)
    {
        SoruHavuzu havuz = new SoruHavuzu();
        Soru rastgeleSoru = havuz.RastgeleSoruGetir();
        Console.WriteLine(rastgeleSoru.Metin);
        Console.WriteLine(string.Join("\n", rastgeleSoru.Secenekler));
        
        Console.ReadLine();

        havuz.SoruCikar(rastgeleSoru);

        if (ad == "")
        {
            Console.WriteLine("Tebrikler hanenize 10 puan eklendi");
            TopSkor += 10;
        }
        else
        {
            Console.WriteLine("Yanlış cevap");
        }
    }


    Console.WriteLine("\r\nTestiniz bitti" + " " + ad + ": " + TopSkor + " Puan aldınız");

    Console.WriteLine("\r\nEğer toplam skorunuzun neye tekabül ettiğini göremek istiyorsanız 1'e basın, çıkmak istiyorsanız 2'ye basın");
    int bas = Convert.ToInt32(Console.ReadLine());

    if (bas == 1)
    {
        Console.WriteLine("\r\nTebrikler My Master tam anlamıyla 'MÜKEMMEL'\r\n");
    }
}


else
{
    int TopSkor = 0;

    for (int i = 0; i < 5; i++)
    {
        SoruHavuzu havuz = new SoruHavuzu();
        Soru rastgeleSoru = havuz.RastgeleSoruGetir();
        Console.WriteLine(rastgeleSoru.Metin);
        Console.WriteLine(string.Join("\n", rastgeleSoru.Secenekler));

        havuz.SoruCikar(rastgeleSoru);


        string Cevap = Console.ReadLine();


        if (Cevap == rastgeleSoru.DogruCevap)
        {
            Console.WriteLine("Tebrikler hanenize 10 puan eklendi");
            TopSkor += 10;
        }
        else
        {
            Console.WriteLine("Yanlış cevap");
        }
    }


    Console.WriteLine("\r\nTestiniz bitti" + " " + ad + ": " + TopSkor + " Puan aldınız");

    Console.WriteLine("\r\nEğer toplam skorunuzun neye tekabül ettiğini göremek istiyorsanız 1'e basın, çıkmak istiyorsanız 2'ye basın");
    int bas = Convert.ToInt32(Console.ReadLine());

    if (bas == 1)
    {
        if (TopSkor == 0)
        {
            Console.WriteLine("\r\n!!Zeka belirtisi bulunamadı!!");
        }
        else
        {
            if (TopSkor == 10)
            {
                Console.WriteLine("\r\nİçerde kimse var mı!");
            }
            else
            {
                if (TopSkor == 20)
                {
                    Console.WriteLine("\r\nZeka kırıntıları bulundu!");
                }
                else
                {
                    if (TopSkor == 30)
                    {
                        Console.WriteLine("\r\nİdare eder!");
                    }
                    else
                    {
                        if (TopSkor == 40)
                        {
                            Console.WriteLine("\r\nPerfect👌");
                        }
                        else
                        {
                            if (bas == 2)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
