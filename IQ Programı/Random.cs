public class Soru
{
    public string Metin { get; set; }
    public string[] Secenekler { get; set; }
    public string DogruCevap { get; set; }

    public Soru(string metin, string[] secenekler, string dogruCevap)
    {
        Metin = metin;
        Secenekler = secenekler;
        DogruCevap = dogruCevap;
    }
}

public class SoruHavuzu
{
    private List<Soru> _sorular;

    public SoruHavuzu()
    {
        _sorular = new List<Soru>();
        // Burada soruları havuza ekleyebilirsiniz
        _sorular.Add(new Soru("\r\nİnsan vücudundaki en büyük organ hangisidir?\r\n",
                              new string[] { "A) Beyin\r\n", "B) Kalp\r\n", "C) Karaciğer\r\n", "D) Cilt\r\n" },
                              "d"));
        _sorular.Add(new Soru("\r\nKimya'da H2O formülü neyi ifade eder?\r\n",
                              new string[] { "A) Karbon dioksit\r\n", "B) Oksijen\r\n", "C) Su\r\n", "D) Hidrojen gazı\r\n" },
                              "c"));
        _sorular.Add(new Soru("\r\nDünya'nın etrafındaki atmosferin yüzde kaçı nitrojenden oluşur?\r\n",
                              new string[] { "A) %21\r\n", "B) %47\r\n", "C) %63\r\n", "D) %78\r\n" },
                              "a"));
        _sorular.Add(new Soru("\r\nBir köpek yavrusuna ne denir?\r\n",
                              new string[] { "A) Civciv\r\n", "B) Kedi\r\n", "C) Tavşan\r\n", "D) Köpek yavrusu\r\n" },
                              "d"));
        _sorular.Add(new Soru("\r\nİnsanların en sık kullandığı dil hangisidir?\r\n",
                              new string[] { "A) Mandarin\r\n", "B) İngilizce\r\n", "C) İspanyolca\r\n", "D) Arapça\r\n" },
                              "b"));
        _sorular.Add(new Soru("\r\nHangi gezegen güneş sisteminde en büyük boyuta sahiptir?\r\n",
                              new string[] { "A) Jüpiter\r\n", "B) Venüs\r\n", "C) Mars\r\n", "D) Neptün\r\n" },
                              "a"));
        _sorular.Add(new Soru("\r\n20 + 12 x 2 kaçtır?\r\n",
                              new string[] { "A) 44\r\n", "B) 52\r\n", "C) 64\r\n", "D) 54\r\n" },
                              "a"));
        _sorular.Add(new Soru("\r\nİlk cep telefonu hangi yılda piyasaya sürüldü?\r\n",
                              new string[] { "A) 1967\r\n", "B) 1983\r\n", "C) 1996\r\n", "D) 2004\r\n" },
                              "a"));
        _sorular.Add(new Soru("\r\nİnsan beyninde kaç tane lob var?\r\n",
                              new string[] { "A) 2\r\n", "B) 3\r\n", "C) 4\r\n", "D) 5\r\n" },
                              "c"));
        _sorular.Add(new Soru("\r\nHangi ülke Kuzey Amerika kıtasında yer almaz?\r\n",
                              new string[] { "A) Kanada\r\n", "B) ABD\r\n", "C) Meksika\r\n", "D) İspanya\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangi şehir Türkiye'nin en kalabalık şehridir?\r\n",
                      new string[] { "A) İstanbul\r\n", "B) Ankara\r\n", "C) İzmir\r\n", "D) Bursa\r\n" },
                      "a"));

        _sorular.Add(new Soru("\r\nHangi ülke Avrupa'nın en büyük adası olan Büyük Britanya Adası'nın bir parçasıdır?\r\n",
                              new string[] { "A) İrlanda\r\n", "B) İsveç\r\n", "C) İngiltere\r\n", "D) İspanya\r\n" },
                              "c"));

        _sorular.Add(new Soru("\r\nHangisi bir tür kumaştır?\r\n",
                              new string[] { "A) Tülbent\r\n", "B) Salam\r\n", "C) Domates\r\n", "D) Çivili çam\r\n" },
                              "a"));

        _sorular.Add(new Soru("\r\nHangi renk Türkiye bayrağında yer almaz?\r\n",
                              new string[] { "A) Beyaz\r\n", "B) Kırmızı\r\n", "C) Sarı\r\n", "D) Yeşil\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangisi bir tür çikolatadır?\r\n",
                              new string[] { "A) Köpek\r\n", "B) Kedi\r\n", "C) Bitter\r\n", "D) Aslan\r\n" },
                              "c"));

        _sorular.Add(new Soru("\r\nHangi gezegen Güneş Sistemi'mizde 2. sıradadır?\r\n",
                              new string[] { "A) Mars\r\n", "B) Jüpiter\r\n", "C) Dünya\r\n", "D) Venüs\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangisi bir tür yemektir?\r\n",
                              new string[] { "A) Araba\r\n", "B) Köfte\r\n", "C) Uçak\r\n", "D) Gemi\r\n" },
                              "b"));

        _sorular.Add(new Soru("\r\nHangisi bir tür meyvedir?\r\n",
                              new string[] { "A) Lahana\r\n", "B) Havuç\r\n", "C) Salatalık\r\n", "D) Çilek\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangisi bir tür hayvan değildir?\r\n",
                              new string[] { "A) Tavşan\r\n", "B) Sincap\r\n", "C) Gergedan\r\n", "D) Lale\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangi ülke Asya ve Avrupa kıtaları arasında yer alır?\r\n",
                              new string[] { "A) Türkiye\r\n", "B) ABD\r\n", "C) Brezilya\r\n", "D) Japonya\r\n" },
                              "a"));

        _sorular.Add(new Soru("\r\nHangisi bir tür ağaç değildir?\r\n",
                              new string[] { "A) Çam\r\n", "B) Kavak\r\n", "C) Zeytin\r\n", "D) Kayın\r\n" },
                              "c"));

        _sorular.Add(new Soru("\r\nHangisi bir tür balık değildir?\r\n",
                              new string[] { "A) Levrek\r\n", "B) Uskumru\r\n", "C) Palamut\r\n", "D) Keçi\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangi yıl Türkiye Cumhuriyeti'nin kuruluşu yıl dönümü kutlanmıştır?\r\n",
                                new string[] { "A) 1923\r\n", "B) 1933\r\n", "C) 1943\r\n", "D) 1953\r\n" },
                              "a"));
        _sorular.Add(new Soru("\r\nHangisi bir tür kuş değildir?\r\n",
                         new string[] { "A) Karga\r\n", "B) Leylek\r\n", "C) Penguen\r\n", "D) Atmaca\r\n" },
                         "a"));

        _sorular.Add(new Soru("\r\nHangisi bir tür araba markası değildir?\r\n",
                              new string[] { "A) BMW\r\n", "B) Mercedes\r\n", "C) Honda\r\n", "D) Patates\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangi renk trafik ışığında durmak anlamına gelir?\r\n",
                              new string[] { "A) Kırmızı\r\n", "B) Sarı\r\n", "C) Yeşil\r\n", "D) Mavi\r\n" },
                              "a"));

        _sorular.Add(new Soru("\r\nHangi ülke Akdeniz'e kıyısı olan bir ülke değildir?\r\n",
                              new string[] { "A) Türkiye\r\n", "B) İspanya\r\n", "C) Fransa\r\n", "D) Bulgaristan\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangisi bir tür spor değildir?\r\n",
                              new string[] { "A) Futbol\r\n", "B) Basketbol\r\n", "C) Voleybol\r\n", "D) Masa\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangisi bir tür meyve değildir?\r\n",
                         new string[] { "A) Elma\r\n", "B) Muz\r\n", "C) Salatalık\r\n", "D) Portakal\r\n" },
                         "c"));

        _sorular.Add(new Soru("\r\nHangi gezegen Güneş Sistemi'nde üçüncü gezegendir?\r\n",
                              new string[] { "A) Venüs\r\n", "B) Dünya\r\n", "C) Mars\r\n", "D) Jüpiter\r\n" },
                              "b"));

        _sorular.Add(new Soru("\r\nHangi ülkenin başkenti Paris'tir?\r\n",
                              new string[] { "A) Almanya\r\n", "B) İtalya\r\n", "C) Fransa\r\n", "D) İspanya\r\n" },
                              "c"));

        _sorular.Add(new Soru("\r\nHangisi bir tür yazılım dilidir?\r\n",
                              new string[] { "A) HTML\r\n", "B) Excel\r\n", "C) Photoshop\r\n", "D) Powerpoint\r\n" },
                              "a"));

        _sorular.Add(new Soru("\r\nHangisi bir tür müzik aleti değildir?\r\n",
                              new string[] { "A) Keman\r\n", "B) Gitar\r\n", "C) Tef\r\n", "D) Fare\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nHangi takımın renkleri kırmızı-beyazdır?\r\n",
                              new string[] { "A) Galatasaray\r\n", "B) Fenerbahçe\r\n", "C) Beşiktaş\r\n", "D) Trabzonspor\r\n" },
                              "a"));

        _sorular.Add(new Soru("\r\nHangisi bir tür araba modeli değildir?\r\n",
                              new string[] { "A) Ferrari\r\n", "B) Lamborghini\r\n", "C) Boeing\r\n", "D) Bugatti\r\n" },
                              "c"));

        _sorular.Add(new Soru("\r\nHangi yıl İstanbul'un fethi gerçekleşmiştir?\r\n",
                              new string[] { "A) 1453\r\n", "B) 1553\r\n", "C) 1653\r\n", "D) 1753\r\n" },
                              "a"));

        _sorular.Add(new Soru("\r\nHangisi bir tür denizaltı değildir?\r\n",
                              new string[] { "A) Nükleer Denizaltı\r\n", "B) Diesel Denizaltı\r\n", "C) Elektrikli Denizaltı\r\n", "D) Uçaklı Denizaltı\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nDünyanın en büyük okyanusu hangisidir?\r\n",
                              new string[] { "A) Hint Okyanusu\r\n", "B) Atlantik Okyanusu\r\n", "C) Arktik Okyanusu\r\n", "D) Pasifik Okyanusu\r\n" },
                              "d"));

        _sorular.Add(new Soru("\r\nMatematikte, kaç basamaklı sayılara ondalık sayı denir?\r\n",
                                      new string[] { "A) 1 basamaklı ve üzeri\r\n", "B) 2 basamaklı ve üzeri\r\n", "C) 3 basamaklı ve üzeri\r\n", "D) 4 basamaklı ve üzeri\r\n" },
                                      "a"));

        _sorular.Add(new Soru("\r\nHangi gezegen Güneş Sistemi'ndeki en büyük gezegendir?\r\n",
                                      new string[] { "A) Mars\r\n", "B) Jüpiter\r\n", "C) Satürn\r\n", "D) Neptün\r\n" },
                                      "b"));

        _sorular.Add(new Soru("\r\nBir bilgisayarın merkezi işlem birimi (CPU) hangi bileşen tarafından kontrol edilir?\r\n",
                                      new string[] { "A) Anakart\r\n", "B) Hard Disk\r\n", "C) RAM\r\n", "D) BIOS\r\n" },
                                      "d"));

        _sorular.Add(new Soru("\r\nTarihte Türklerin ilk yazılı eseri hangisidir?\r\n",
                              new string[] { "A) Orhun Abideleri\r\n", "B) Yenisey Abideleri\r\n", "C) Göktürk Yazıtları\r\n", "D) İslamiyet öncesi Türk eserleri\r\n" },
                              "a"));

        _sorular.Add(new Soru("\r\nMaddenin en küçük yapı taşı nedir?\r\n",
                                      new string[] { "A) Atom\r\n", "B) Molekül\r\n", "C) İyon\r\n", "D) Elektron\r\n" },
                                      "a"));

        _sorular.Add(new Soru("\r\nHangi ülke Avrupa Birliği'nden çıkış kararı almıştır?\r\n",
                                      new string[] { "A) İtalya\r\n", "B) Yunanistan\r\n", "C) İngiltere\r\n", "D) Almanya\r\n" },
                                      "c"));

        _sorular.Add(new Soru("\r\nİnsan beyninde kaç lob bulunur?\r\n",
                                      new string[] { "A) 2\r\n", "B) 3\r\n", "C) 4\r\n", "D) 5\r\n" },
                                      "c"));

        _sorular.Add(new Soru("\r\nKimya'da 'Fe' sembolü hangi elementi temsil eder?\r\n",
                                      new string[] { "A) Bakır\r\n", "B) Çinko\r\n", "C) Demir\r\n", "D) Altın\r\n" },
                                      "c"));

        _sorular.Add(new Soru("\r\nHangi ülke, 2018 Dünya Kupası'nda şampiyon olmuştur?\r\n",
                                      new string[] { "A) Almanya\r\n", "B) Fransa\r\n", "C) İspanya\r\n", "D) Brezilya\r\n" },
                                      "b"));

        _sorular.Add(new Soru("\r\nTürkiye'de bulunan en yüksek dağ hangisidir?\r\n",
                                      new string[] { "A) Ağrı Dağı\r\n", "B) Uludağ\r\n", "C) Kaçkar Dağları\r\n", "D) Erciyes Dağı\r\n" },
                                      "a"));

        _sorular.Add(new Soru("\r\nHangi matematiksel terim, türevin ters işlemi olarak tanımlanır?\r\n",
                                      new string[] { "A) Türevli Fonksiyon\r\n", "B) İntegral\r\n", "C) Limit\r\n", "D) Diferansiyel Denklem\r\n" },
                                      "b"));

        _sorular.Add(new Soru("\r\nHangi element, Dünya'nın kabuğunda en bol bulunan elementtir?\r\n",
                                      new string[] { "A) Hidrojen\r\n", "B) Karbon\r\n", "C) Oksijen\r\n", "D) Silisyum\r\n" },
                                      "d"));
    }

    public Soru RastgeleSoruGetir()
    {
        Random random = new Random();
        int rastgeleIndex = random.Next(0, _sorular.Count);
        Soru rastgeleSoru = _sorular[rastgeleIndex];
        _sorular.RemoveAt(rastgeleIndex);
        return rastgeleSoru;
    }
    public void SoruCikar(Soru soru)
    {
        _sorular.Remove(soru);
    }
}
