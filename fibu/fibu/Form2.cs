using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibu
{
    public partial class Form2 : Form
    {
        List<Film> filmler = new List<Film>();
        public Form2()
        {
            InitializeComponent();
            filmler.Add(new Film { Adi = "The Sound of Music", Turu = "Aile", Yönetmen = "Robert Wise", cikisYılı = "1965", imbd = "8,1", süre = "172", konu = "1930'larda, İkinci Dünya Savaşı'nın patlak vermesinden önce, genç bir müzik öğretmeni, Nazi işgali altındaki Avusturya'da bir ailenin yedi çocuğuna bakmak için işe alınır." });
            filmler.Add(new Film { Adi = "Home Alone", Turu = "Aile", Yönetmen = "Chris Columbus", cikisYılı = "1990", imbd = "7,3", süre = "100", konu = " 8 yaşındaki Kevin McCallister, ailesinin Noel tatili için Fransa'ya uçarken yanlışlıkla evde unutulur. Kevin, evde iki hırsızı uzak tutmak için bir plan yapar." });
            filmler.Add(new Film { Adi = "The Lion King", Turu = "Aile", Yönetmen = "Roger Allers, Rob Minkoff", cikisYılı = "1994", imbd = "8,6", süre = "88", konu = " Mufasa ve Sarabi, Simba adında sevimli bir yavru aslan yetiştirirler. Simba, babasının tahtına varis olur, ancak kötü amcası Scar, Simba'yı tahttan indirmek ve krallığı ele geçirmek için bir komplo kurar." });

            filmler.Add(new Film
            {
                Adi = "The Matrix",
                Turu = "Aksiyon",
                Yönetmen = "Lana Wachowski, Lilly Wachowski",
                cikisYılı = "1999",
                imbd = "8,7",
                süre = "136",
                konu = "Neo, bilgisayar programcısı bir adamdır. Bir gün, Morpheus adında gizemli bir adamla tanışır ve Neo'ya gerçek dünyanın aslında bir bilgisayar simülasyonu olduğunu söyler. Neo, Morpheus'un yardımıyla gerçek dünyanın gerçekliğini keşfeder ve insanlığı kurtarmak için bir savaşa girer."
            });

            filmler.Add(new Film
            {
                Adi = "The Raid 2: Berandal",
                Turu = "Aksiyon",
                Yönetmen = "Gareth Evans",
                cikisYılı = "2014",
                imbd = "7,8",
                süre = "150",
                konu = "Rama, Jakarta'nın en tehlikeli çetesinin içine sızan bir polistir. Rama, çete lideri Tama'nın güvenini kazanmayı başarır ve çetenin iç işleyişini öğrenir. Ancak Rama, çetenin bir sonraki planını öğrendikten sonra, çeteden kaçmak zorunda kalır."
            });

            filmler.Add(new Film
            {
                Adi = "The Last Action Hero",
                Turu = "Aksiyon",
                Yönetmen = "John McTiernan",
                cikisYılı = "1993",
                imbd = "5,2",
                süre = "105",
                konu = "Danny, 10 yaşındaki bir çocuktur. Danny, Arnold Schwarzenegger'in oynadığı bir aksiyon filminin büyük bir hayranıdır. Bir gün, Danny'nin oyuncağı onu filmin içine çeker ve Danny, filmin kahramanı Jack Slater ile tanışır. Danny ve Jack, kötü adam Benedict'e karşı birlikte savaşmak zorunda kalırlar."
            });
            filmler.Add(new Film
            {
                Adi = "The Cat in the Hat",
                Turu = "Animasyon",
                Yönetmen = "Bo Welch",
                cikisYılı = "2003",
                imbd = "4,9",
                süre = "87",
                konu = "Conrad ve Sally Walden, annesinin işe gitmesi ve babasının da geç saatte eve gelmesi nedeniyle evde yalnız kalırlar. Kapı çaldığında, Conrad ve Sally, eğlenceli ve yaramaz bir kedi olan The Cat in the Hat ile tanışırlar. The Cat in the Hat, Conrad ve Sally'nin evini alt üst eder ve iki kardeşin başlarına birçok sorun açar."
            });

            filmler.Add(new Film
            {
                Adi = "Horton Hears a Who!",
                Turu = "Animasyon",
                Yönetmen = "Jimmy Hayward, Steve Martino",
                cikisYılı = "2008",
                imbd = "5,2",
                süre = "92",
                konu = "Horton, küçük bir fildir. Bir gün, Horton, küçük bir çiçeğin içinde yaşayan bir şehir olan Whoville'in varlığını keşfeder. Horton, Whoville'i korumak için elinden geleni yapar."
            });

            filmler.Add(new Film
            {
                Adi = "The Lorax",
                Turu = "Animasyon",
                Yönetmen = "Chris Renaud, Kyle Balda",
                cikisYılı = "2012",
                imbd = "5,3",
                süre = "88",
                konu = "Ted, bir kıza aşık olur ve kıza bir Truffula ağacı hediye etmek ister. Ted, Truffula ağaçlarının olduğu bir orman bulmak için yola çıkar. Ted, ormanda The Lorax ile tanışır. The Lorax, Truffula ağaçlarının koruyucusudur."
            });

            filmler.Add(new Film
            {
                Adi = "Blackfish",
                Turu = "Belgesel",
                Yönetmen = "Gabriela Cowperthwaite",
                cikisYılı = "2013",
                imbd = "7,7",
                süre = "85",
                konu = "Blackfish, SeaWorld'ün orka gösterilerinde kullanılan orka Tilikum'un hikayesini anlatıyor. Tilikum, üç kişinin ölümünden sorumlu tutulan ve SeaWorld'de tutulan en büyük orkadır. Film, SeaWorld'ün orkaları tutmanın ve eğitmenin tehlikelerini araştırıyor."
            });

            filmler.Add(new Film
            {
                Adi = "Icarus",
                Turu = "Belgesel",
                Yönetmen = "Bryan Fogel",
                cikisYılı = "2017",
                imbd = "7,9",
                süre = "109",
                konu = "Icarus, Rus doping skandalını araştıran bir Rus doping uzmanının hikayesini anlatıyor. Film, dopingin spordaki yaygınlığını ve sporcuların sağlığına olan etkilerini araştırıyor."
            });

            filmler.Add(new Film
            {
                Adi = "My Octopus Teacher",
                Turu = "Belgesel",
                Yönetmen = "Craig Foster",
                cikisYılı = "2020",
                imbd = "8,2",
                süre = "85",
                konu = "My Octopus Teacher, Güney Afrika kıyılarında bir belgeselci ile dost olan bir ahtapotun hikayesini anlatıyor. Film, insan ve doğa arasındaki ilişkiyi araştırıyor."
            });

            filmler.Add(new Film
            {
                Adi = "2001: A Space Odyssey",
                Turu = "Bilim Kurgu",
                Yönetmen = "Stanley Kubrick",
                cikisYılı = "1968",
                imbd = "8,3",
                süre = "143",
                konu = "A Space Odyssey, insanlığın uzaydaki gelişimini konu alan bir bilim kurgu filmidir. Film, dört adamın Ay'a yaptığı yolculuğu ve uzaydaki gizemli bir yapıyı araştırıyor."
            });

            filmler.Add(new Film
            {
                Adi = "Blade Runner",
                Turu = "Bilim Kurgu",
                Yönetmen = "Ridley Scott",
                cikisYılı = "1982",
                imbd = "8,2",
                süre = "127",
                konu = "Blade Runner, Los Angeles'ta geçen bir bilim kurgu filmidir. Film, yapay zekalı androidlerin peşine düşen bir avcının hikayesini anlatıyor."
            });

            filmler.Add(new Film
            {
                Adi = "Arrival",
                Turu = "Bilim Kurgu",
                Yönetmen = "Denis Villeneuve",
                cikisYılı = "2016",
                imbd = "8,2",
                süre = "130",
                konu = "Arrival, on altı uzaylı gemisi dünyanın farklı yerlerine indiğinde geçiyor. Dilbilimci Louise Banks, bu gemilerin arkasındaki gizemi çözmek için görevlendirilir."
            });


            filmler.Add(new Film
            {
                Adi = "A Beautiful Mind",
                Turu = "Biyografi",
                Yönetmen = "Ron Howard",
                cikisYılı = "2001",
                imbd = "8,2",
                süre = "134",
                konu = "John Nash, Princeton Üniversitesi'nde matematik okuyan bir dahidir. Nash, doktora tezini tamamladıktan sonra, gizli bir hükümet projesinde çalışmak üzere Washington'a davet edilir. Nash, bu projede, Sovyetler Birliği'nin nükleer silah geliştirme programını durdurmak için yeni bir şifre çözme yöntemi geliştirmeye çalışır. Nash, bu projede başarılı olur ve bir kahraman olarak ün kazanır. Ancak, Nash, zamanla paranoid şizofreni hastalığına yakalanır. Nash, bu hastalıkla mücadele ederken, kariyerini ve evliliğini korumaya çalışır."
            });

            filmler.Add(new Film
            {
                Adi = "First Man",
                Turu = "Biyografi",
                Yönetmen = "Damien Chazelle",
                cikisYılı = "2018",
                imbd = "7,1",
                süre = "140",
                konu = "Neil Armstrong, Apollo 11 görevinde Ay'a ilk ayak basan astronottur. Armstrong, bu görevi gerçekleştirirken, ailesinden ve arkadaşlarından uzakta, zorlu bir eğitim sürecinden geçer. Armstrong, bu süreçte, hem fiziksel hem de psikolojik olarak büyük zorluklar yaşar. Armstrong, bu zorlukların üstesinden gelerek, Ay'a ayak basan ilk insan olmanın gururunu yaşar."
            });

            filmler.Add(new Film
            {
                Adi = "Persepolis",
                Turu = "Biyografi",
                Yönetmen = "Marjane Satrapi, Vincent Paronnaud",
                cikisYılı = "2007",
                imbd = "7,9",
                süre = "93",
                konu = "Marjane Satrapi, 1970'lerde İran'da yaşayan genç bir kızdır. Marjane, İran'da yaşanan devrimle birlikte, hayatının değiştiğini fark eder. İran'da yaşanan siyasi ve toplumsal değişimler, Marjane'nin hayatını derinden etkiler. Marjane, bu değişimlere ayak uydurmaya çalışırken, hem kendi kimliğini hem de dünyasını keşfeder."
            });

            filmler.Add(new Film
            {
                Adi = "The Wicker Man",
                Turu = "Dram",
                Yönetmen = "Robin Hardy",
                cikisYılı = "1973",
                imbd = "7,1",
                süre = "87",
                konu = "The Wicker Man, bir polis memurunun bir adada kaybolan bir kızı aramak için gönderilmesini anlatıyor. Adanın sakinleri, pagan geleneklerine bağlıdır ve polis memuru, adanın karanlık sırlarını keşfetmeye başlar."
            });

            filmler.Add(new Film
            {
                Adi = "Dancer in the Dark",
                Turu = "Dram",
                Yönetmen = "Lars von Trier",
                cikisYılı = "2000",
                imbd = "7,6",
                süre = "140",
                konu = "Dancer in the Dark, Selma Jezkova adlı kör bir kadının hikayesini anlatıyor. Selma, oğlunun görme yeteneğini kaybetmesini önlemek için para biriktirmeye çalışıyor."
            });

            filmler.Add(new Film
            {
                Adi = "The Wrestler",
                Turu = "Dram",
                Yönetmen = "Darren Aronofsky",
                cikisYılı = "2008",
                imbd = "7,8",
                süre = "126",
                konu = "The Wrestler, Randy 'The Ram' Robinson adlı bir profesyonel güreşçinin hikayesini anlatıyor. Robinson, eski ihtişamını kaybetmiş ve emekli olmaya hazırlanıyor. Ancak, emeklilik ona göre değildir ve ringlere geri dönmeye karar verir."
            });

            filmler.Add(new Film
            {
                Adi = "The Ice Road",
                Turu = "Gerilim",
                Yönetmen = "Jonathan Hensleigh",
                cikisYılı = "2021",
                imbd = "5,2",
                süre = "108",
                konu = "Bir kar fırtınası sırasında, bir grup madencinin bulunduğu bir sondaj kulesine yakıt sağlamak için bir kar aracı ekibi gönderilir. Ancak, yol boyunca bir buz kütlesine çarparak mahsur kalırlar."
            });


            filmler.Add(new Film
            {
                Adi = "Malignant",
                Turu = "Gerilim",
                Yönetmen = "James Wan",
                cikisYılı = "2021",
                imbd = "5,3",
                süre = "106",
                konu = "Madison adlı genç bir kadın, geceleri garip kabuslar görmeye başlar. Kabuslarında, bir seri katilin kurbanlarını öldürdüğünü görür. Ancak, bir gün kabusları gerçeğe dönüşür."
            });

            filmler.Add(new Film
            {
                Adi = "Reminiscence",
                Turu = "Gerilim",
                Yönetmen = "Lisa Joy",
                cikisYılı = "2021",
                imbd = "5,1",
                süre = "123",
                konu = "Nick Bannister, Miami'de geçmişi hatırlama hizmeti veren bir şirketin sahibidir. Bir gün, Mae adlı gizemli bir kadın Nick'in müşterisi olur. Mae'nin geçmişini hatırlamaya çalışırken, Nick kendi geçmişiyle yüzleşmek zorunda kalır."
            });

            filmler.Add(new Film
            {
                Adi = "The Killing of a Sacred Deer",
                Turu = "Gizem",
                Yönetmen = "Yorgos Lanthimos",
                cikisYılı = "2017",
                imbd = "7,2",
                süre = "92",
                konu = "Steven Murphy, başarılı bir kalp cerrahıdır. Karısı Anna, çocukları Kim ve Bob ile birlikte mutlu bir hayat sürmektedir. Ancak, bir gün Steven'ın genç bir hastasının babası Martin, Steven'ın ailesini tehdit etmeye başlar. Martin, Steven'ın ailesinden birinin ölümünü istemektedir. Steven, Martin'in taleplerini yerine getirmeye çalışırken, ailesinin içinde giderek büyüyen bir karanlıkla yüzleşmek zorunda kalır."
            }); filmler.Add(new Film
            {
                Adi = "The Invitation",
                Turu = "Gizem",
                Yönetmen = "Karyn Kusama",
                cikisYılı = "2015",
                imbd = "7,1",
                süre = "89",
                konu = "Will ve Eden, evliliklerini kurtarmak için bir hafta sonu tatiline çıkarlar. Eden'ın ailesiyle birlikte katılacakları bu tatil, Will için oldukça gergin geçmektedir. Eden'ın ailesi, Will'e karşı oldukça mesafelidir ve ona karşı bir güvensizlik beslemektedirler. Will, bu tatilde Eden'ın ailesinin gizemli sırlarını keşfetmeye başlar."
            });

            filmler.Add(new Film
            {
                Adi = "The Lighthouse",
                Turu = "Gizem",
                Yönetmen = "Robert Eggers",
                cikisYılı = "2019",
                imbd = "7,2",
                süre = "109",
                konu = "Thomas Wake ve Ephraim Winslow, Maine kıyılarında bulunan bir deniz fenerinde birlikte görevlendirilmiş iki fener bekçisidir. Wake, Winslow'a sert bir şekilde davranmaktadır ve onu sürekli olarak eziyet etmektedir. Winslow, bu duruma dayanmaya çalışırken, deniz fenerinde yaşanan tuhaf olaylarla birlikte yavaş yavaş delirmeye başlar."
            });

            filmler.Add(new Film
            {
                Adi = "The Present",
                Turu = "Kısa Metrajlı",
                Yönetmen = "Jacob Frey",
                cikisYılı = "2014",
                imbd = "7,9",
                süre = "10",
                konu = "Bir çocuk, doğum günü hediyesini almak için bir mağazadan alışveriş yapar. Ancak hediyeyi seçerken, mağazanın içinde yaşayan tuhaf karakterlerle karşılaşır."
            });

            filmler.Add(new Film
            {
                Adi = "Bao",
                Turu = "Kısa Metrajlı",
                Yönetmen = "Domee Shi",
                cikisYılı = "2018",
                imbd = "8,4",
                süre = "8",
                konu = "Bir Çinli kadın, gençken kaybettiği oğlunu yeniden yaşamak için bir hamur işine hayat verir. Ancak hamur işi büyüdükçe, kadın onun bir yetişkin olarak nasıl bir hayat süreceğini kontrol etmeye çalışır."
            });

            filmler.Add(new Film
            {
                Adi = "If Anything Happens I Love You",
                Turu = "Kısa Metrajlı",
                Yönetmen = "Will McCormack ve Michael Govier",
                cikisYılı = "2020",
                imbd = "8,2",
                süre = "12",
                konu = "Bir çift, 11 Eylül saldırılarında çocuklarını kaybeder. Acılarını atlatmaya çalışırken, birbirlerine olan sevgilerini ve kaybettikleri çocuklarını hatırlamaya çalışırlar."
            });

            filmler.Add(new Film
            {
                Adi = "Sessiz Bir Yer",
                Turu = "Korku",
                Yönetmen = "John Krasinski",
                cikisYılı = "2018",
                imbd = "8,2",
                süre = "90",
                konu = "Dünya, sağır olmayan tüm insanları avlayan görme engelli yaratıklar tarafından istila edilmiştir. Bir aile, hayatta kalmak için sessiz kalmak zorundadır."
            });

            filmler.Add(new Film
            {
                Adi = "IT",
                Turu = "Korku",
                Yönetmen = "Andy Muschietti",
                cikisYılı = "2017",
                imbd = "7,6",
                süre = "135",
                konu = "Derry kasabasında, her 27 yılda bir ortaya çıkan ve çocuklara musallat olan bir palyaço olan Pennywise'ın hikayesi anlatılıyor."
            });

            filmler.Add(new Film
            {
                Adi = "Yüzüklerin Efendisi: Kralın Dönüşü",
                Turu = "Macera",
                Yönetmen = "Peter Jackson",
                cikisYılı = "2003",
                imbd = "8,9",
                süre = "251",
                konu = "Frodo Baggins, yüzüğü yok etmek için Mordor'a doğru yola çıkar. Yol boyunca, ona yoldaş olurlar ve birlikte zorlu bir yolculuğa çıkarlar."
            });

            filmler.Add(new Film
            {
                Adi = "Indiana Jones Kutsal Hazine Avcıları",
                Turu = "Macera",
                Yönetmen = "Steven Spielberg",
                cikisYılı = "1981",
                imbd = "8,7",
                süre = "115",
                konu = "Indiana Jones, kayıp Sankara Dişlisi'ni bulmak için bir yolculuğa çıkar. Yol boyunca, birçok tehlikeyle karşılaşır ve sonunda dişleri bulur."
            });

            filmler.Add(new Film
            {
                Adi = "La La Land",
                Turu = "Müzik",
                Yönetmen = "Damien Chazelle",
                cikisYılı = "2016",
                imbd = "8,2",
                süre = "128",
                konu = "Mia, Los Angeles'ta bir oyuncu olmak için çabalayan bir kadındır. Sebastian, bir jazz piyanisti olmak isteyen bir adamdır. İkisi, bir trafik sıkışıklığında karşılaştıklarında ve birbirlerine aşık olurlar. Ancak, hayallerini gerçekleştirmek için mücadele ederken, ilişkileri de zorlanır."
            });

            filmler.Add(new Film
            {
                Adi = "The Sound of Music",
                Turu = "Müzik",
                Yönetmen = "Robert Wise",
                cikisYılı = "1965",
                imbd = "8,0",
                süre = "174",
                konu = "Maria, bir manastırda yaşayan bir rahibedir. Ailesi dağılmış olan Von Trapp ailesinin çocuklarını eğitmek için görevlendirilir. Maria, çocukların sevgisini kazanır ve ailenin babasına da aşık olur. Ancak, Naziler Avusturya'yı işgal edince, ailenin ülkeyi terk etmesi gerekir."
            });

            filmler.Add(new Film
            {
                Adi = "Kuzuların Sessizliği",
                Turu = "Polisiye",
                Yönetmen = "Jonathan Demme",
                cikisYılı = "1991",
                imbd = "8,6",
                süre = "118",
                konu = "Clarice Starling, FBI'da stajyer bir ajandır. Starling, seri katil Buffalo Bill'i yakalamak için, akıl hastanesinde tutulan Hannibal Lecter'dan yardım ister. Lecter, Starling'e yardım etmek için, ondan bazı kişisel bilgiler vermesini ister."
            });

            filmler.Add(new Film
            {
                Adi = "Kabadayı",
                Turu = "Polisiye",
                Yönetmen = "Ömer Faruk Sorak",
                cikisYılı = "2007",
                imbd = "7,3",
                süre = "120",
                konu = "Ali Osman, artık nesli tükenen eski tür bir kabadayıdır. Ali Osman, yıllar sonra oğlunun olduğunu öğrenir. Ali Osman, oğlunu bulmak ve onu korumak için harekete geçer."
            });

            filmler.Add(new Film
            {
                Adi = "The Hunger Games",
                Turu = "Politik",
                Yönetmen = "Gary Ross",
                cikisYılı = "2012",
                imbd = "7,2",
                süre = "142",
                konu = "Katniss Everdeen, Panem adlı bir diyarda yaşayan bir genç kızdır. Panem, baskıcı bir rejimle yönetilmektedir. Katniss, kız kardeşinin yerine, Panem'in her yıl düzenlenen bir ölüm oyununa katılır. Katniss, oyunda hayatta kalmak için mücadele eder ve aynı zamanda, rejime karşı bir isyan başlatır."
            });

            filmler.Add(new Film
            {
                Adi = "Not Defteri",
                Turu = "Romantik",
                Yönetmen = "Nick Cassavetes",
                cikisYılı = "2004",
                imbd = "7,8",
                süre = "123",
                konu = "Noah ve Allie, 1940'lı yıllarda birbirlerine aşık olan iki gençtir. Ancak, ailelerin karşı çıkmasıyla birlikte ayrılmak zorunda kalırlar. Yıllar sonra, Noah, Allie'ye yazdığı mektupları bulmak için geri döner."
            });

            filmler.Add(new Film
            {
                Adi = "Schindler'in Listesi",
                Turu = "Savaş",
                Yönetmen = "Steven Spielberg",
                cikisYılı = "1993",
                imbd = "9,3",
                süre = "195",
                konu = "Oskar Schindler, İkinci Dünya Savaşı sırasında Polonya'da fabrika sahibidir. Schindler, Yahudi çalışanlarını Nazilerden kurtarmak için bir liste hazırlar. Schindler'in listesi, binlerce Yahudi'nin hayatta kalmasını sağlar."
            });

            filmler.Add(new Film
            {
                Adi = "The Mighty Ducks",
                Turu = "Spor",
                Yönetmen = "Stephen Herek",
                cikisYılı = "1992",
                imbd = "4,7",
                süre = "100",
                konu = "Bir lisede beyzbol koçu olan Gordon Bombay, buz hokeyi takımının koçu olmak zorunda kalır. Bombay, takımın başarısı için bir grup kaybedeni eğitmeye başlar."
            });

            filmler.Add(new Film
            {
                Adi = "Death Wish",
                Turu = "Suç",
                Yönetmen = "Michael Winner",
                cikisYılı = "1974",
                imbd = "4,7",
                süre = "93",
                konu = "Evini soyulup karısını öldüren bir adam, katilleri bulmak ve intikam almak için kendi başına harekete geçer."
            });

            filmler.Add(new Film
            {
                Adi = "Alexander",
                Turu = "Tarih",
                Yönetmen = "Oliver Stone",
                cikisYılı = "2004",
                imbd = "4,5",
                süre = "175",
                konu = "Makedonyalı Büyük İskender'in hayatını ve fetihlerini konu alan film, İskender'in yükselişini ve düşüşünü anlatıyor."
            });

            filmler.Add(new Film
            {
                Adi = "Cleopatra",
                Turu = "Tarih",
                Yönetmen = "Joseph L. Mankiewicz",
                cikisYılı = "1963",
                imbd = "4,6",
                süre = "243",
                konu = "Mısır Kraliçesi Kleopatra'nın, Romalı general Julius Caesar ve Roma imparatoru Mark Antony ile olan ilişkilerini konu alan film, Elizabeth Taylor'ın ikonik performansıyla öne çıkıyor."
            });
            filmler.Add(new Film
            {
                Adi = "The Ridiculous 6",
                Turu = "Western",
                Yönetmen = "Adam Sandler",
                cikisYılı = "2015",
                imbd = "4,5",
                süre = "121",
                konu = "Moses, babasının ölümünden sonra, onu hiç tanımadığı altı kardeşini bulmak için yola çıkar. Moses, kardeşleriyle birlikte birçok komik ve maceralı olay yaşar."
            });

            filmler.Add(new Film
            {
                Adi = "Babam ve Oğlum",
                Turu = "Yerli",
                Yönetmen = "Çağan Irmak",
                cikisYılı = "2005",
                imbd = "8,4",
                süre = "147",
                konu = "1980'li yıllarda, iki kuşak arasındaki çatışmayı konu alan film, baba-oğul ilişkisini ve toplumsal değişimi ele alıyor."
            });


            filmler.Add(new Film
            {
                Adi = "İklimler",
                Turu = "Yerli",
                Yönetmen = "Nuri Bilge Ceylan",
                cikisYılı = "2006",
                imbd = "7,9",
                süre = "108",
                konu = "Mimar olan İsa ve televizyonda çalışan Bahar, iki farklı iklimin yaşandığı Kaş ve Ağrı'da, birbirini takip eden süreçlerde bir araya gelirler."
            });


            filmler.Add(new Film
            {
                Adi = "Pan's Labyrinth",
                Turu = "Fantastik",
                Yönetmen = "Guillermo del Toro",
                cikisYılı = "2006",
                imbd = "8,4",
                süre = "120",
                konu = "Ofelia, İspanya İç Savaşı sırasında annesiyle birlikte yaşayan bir kızdır. Ofelia, bir gün faun ile tanışır ve faun, ona sihirli bir labirentin içinde bir görev verir."
            });

            filmler.Add(new Film
            {
                Adi = "The Big Lebowski",
                Turu = "Komedi",
                Yönetmen = "Joel ve Ethan Coen",
                cikisYılı = "1998",
                imbd = "8,1",
                süre = "117",
                konu = "Jeff Lebowski, bowlinge takıntılı, tembel ve ilgisiz bir adamdır. Bir gün, aynı adı taşıyan bir milyonere benzediği için yanlışlıkla ondan para ister. Jeff, parayı geri almaya çalışırken, kendisini bir suç işinin içinde bulur."
            });


            // Combobox1'e türleri ekle
            foreach (var film in filmler)
            {
                if (!comboBox1.Items.Contains(film.Turu))
                {
                    comboBox1.Items.Add(film.Turu);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string secilenTur = comboBox1.SelectedItem.ToString();

            // Seçilen türe ait filmleri combobox2'ye ekle
            foreach (var film in filmler)
            {
                if (film.Turu == secilenTur)
                {
                    comboBox2.Items.Add(film.Adi);
                }
            }
        }

        private void HesaplaVeYazdir()
        {
            StringBuilder stringBuilder = new StringBuilder();

            // Seçilen film
            var secilenFilm = filmler.FirstOrDefault(f => f.Adi == comboBox2.SelectedItem.ToString());

            if (secilenFilm != null)
            {
                double ucret = secilenFilm.HesaplaUcret(); // Seçilen filme özel ücret hesapla
                stringBuilder.AppendLine($"{ucret}"); // Sadece ücreti ekle
            }

            // TextBox'a yazdırma
            textBox1.Text = stringBuilder.ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenFilmAdi = comboBox2.SelectedItem.ToString();

            // Seçilen filmi bul
            Film secilenFilm = filmler.Find(f => f.Adi == secilenFilmAdi);

            // Film bilgilerini göster
            if (secilenFilm != null)
            {
                richTextBox1.Text = $"Yönetmen: {secilenFilm.Yönetmen}\n" +
                                    $"Çıkış Yılı: {secilenFilm.cikisYılı}\n" +
                                    $"IMDb Puanı: {secilenFilm.imbd}\n" +
                                    $"Süre: {secilenFilm.süre}\n" +
                                    $"Konu: {secilenFilm.konu}";
            }
        }
        //internetteb
        private void button5_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HesaplaVeYazdir();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            if (double.TryParse(textBox1.Text, out double tutar))
            {
                form3.toplamTutar = tutar;
                form3.fiyat = tutar;
                form3.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
   
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void RastgeleFilmOner(int sayi)
        {
            Random random = new Random();
            int indeks = random.Next(filmler.Count); // 0 ile filmler listesinin boyutu arasında rastgele bir indeks seç

            // Seçilen rastgele filmi göster
            Film rastgeleFilm = filmler[indeks];
            double imdb = 0.0;
            if (double.TryParse(rastgeleFilm.imbd, out imdb))
            {
                double fiyat = imdb * 0.6; // IMDb puanını 0.6 ile çarp

                richTextBox1.Text = $"Önerilen Film:\n{rastgeleFilm.Adi}\n" +
                                     $"Türü: {rastgeleFilm.Turu}\n" +
                                     $"Yönetmen: {rastgeleFilm.Yönetmen}\n" +
                                     $"Çıkış Yılı: {rastgeleFilm.cikisYılı}\n" +
                                     $"IMDb Puanı: {rastgeleFilm.imbd}\n" +
                                     $"Süre: {rastgeleFilm.süre}\n" +
                                     $"Konu: {rastgeleFilm.konu}";
                textBox1.Text = fiyat.ToString();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int sayi)) // Kullanıcının girdiği sayıyı al
            {
                RastgeleFilmOner(sayi); // Rastgele film öner
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!"); // Geçersiz sayı uyarısı
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
