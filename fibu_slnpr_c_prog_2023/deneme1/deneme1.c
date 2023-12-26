#include<stdio.h>
#include<stdlib.h>
#include<time.h> //filmi satin alis tarihi icin

//estetik gorunus :)
void printFibu() {
    printf("\t\t000000  00  0000000  00    00\n");
    printf("\t\t00          00  000  00    00\n");
    printf("\t\t000000  00  00000    00    00\n");
    printf("\t\t00      00  00  000  00    00\n");
    printf("\t\t00      00  0000000  00000000\n");
}

//filmleri tutmak icin struct yapisini kullandim
struct filmBilgi 
    {
    int filmID;
    int filmID2; 
    int filmID3; // her islem icin tekrar tanimlamak durumunda kaldim
    int filmID4;// DAHA SONRA ÝZLEME LÝSTESÝNE KAYDETMEK ÝÇÝN
    char filmadi[100];
    char tur[30]; // film turu
    char yonetmen[100];
    int cikisyili;
    double imdbPuan; // fiyatlandirmalar imdb puani uzerinden gerceklesti
    int sure;
    char konu[250];

   // double fiyat;
    };

double filmTutar(double imdbPuan) {
    if (imdbPuan >= 8.0) { //6 örn
        return 25.0;
    }
    else if (imdbPuan >= 6.0) { //f11 örn
        return 15.0;
    }
    else {
        return 5.0; //f3 örn
    }
}

struct filmBilgi f1 = { 1,1,1,1,"Home Alone","Aile","Chris Columbus",1990,7.3,100,"Kevin evde unutulur ve hirsizlarla mucadele eder." };
struct filmBilgi f2 = { 2,2,2,2,"The Last Action Hero","Aksiyon","John McTiernan",1993,5.2,105,"Danny Schwarzenegger ile tanisir." };
struct filmBilgi f3 = { 3,3,3,3,"The Cat in the Hat","Animasyon","Bo Welch",2003,4.9,87,"Conrad ve Sally annelerinin iste olmasiyla evde yalniz kalirlar. Bir kediyle tanisirlar." };
struct filmBilgi f4 = { 4,4,4,4,"Blade Runner","Bilim Kurgu","Ridley Scott",1982,8.2,127,"Los Angeles'ta androidlerin hikayesi." };
struct filmBilgi f5 = { 5,5,5,5,"Arrival","Bilim Kurgu","Denis Villeneuve",2016,8.2,130,"Uzaylilar Dunya'ya iner ve dilbilimci Louise Banks onlarin amacini ogrenmeye calisir." };
struct filmBilgi f6 = { 6,6,6,6,"A Beautiful Mind","Biyografi","Ron Howard",2001,8.2,134,"Matematik dahisi John Nash'in hikayesi." };
struct filmBilgi f7 = { 7,7,7,7,"The Ice Road","Gerilim","Jonathan Hensleigh",2021,5.2,108,"Kar firtinasi sirasinda mahsur kalan madencilerin hikayesi." };
struct filmBilgi f8 = { 8,8,8,8,"Malignant","Gerilim","James Wan",2021,5.3,106,"Madison, seri bir katilin varligini ogrenir." };
struct filmBilgi f9 = { 9,9,9,9,"Bao","Kisa Metrajli","Domee Shi",2018,8.4,8,"Bir Cinli kadinin hikayesi." };
struct filmBilgi f10 = { 10,10,10,10,"Sessiz Bir Yer","Korku","John Krasinski",2018,8.2,90,"Dunya sessiz yaratiklar tarafindan istila edildi." };
struct filmBilgi f11 = { 11,11,11,11,"IT","Korku","Andy Muschietti",2017,7.6,135,"Pennywise'in cocuklara musallat olma hikayesi." };
struct filmBilgi f12 = { 12,12,12,12,"The Conjuring","Korku","James Wan",2013,8.1,112,"Gercek hayat hikayesi olan Warren ciftinin dogaustu olaylari arastirmasi." };
struct filmBilgi f13 = { 13,13,13,13,"La La Land","Muzik","Damien Chazelle",2016,8.2,128,"Los Angeles'ta ask ve hayaller." };
struct filmBilgi f14 = { 14,14,14,14,"Av Mevsimi","Polisiye","Emin Alper",2010,7.8,110,"Istanbul'da bir seri katili arastiran iki polis." };
struct filmBilgi f15 = { 15,15,15,15,"The Godfather","Politik","Francis Ford Coppola",1972,9.2,175,"Corleone ailesinin mafya dunyasindaki hikayesi." };
struct filmBilgi f16 = { 16,16,16,16,"Not Defteri","Romantik","Nick Cassavetes",2004,7.8,123,"1940'larda askin hikayesi." };
struct filmBilgi f17 = { 17,17,17,17,"Schindler'in Listesi","Savas","Steven Spielberg",1993,9.3,195,"Nazilerden Yahudileri kurtaran Oskar Schindler'in hikayesi." };
struct filmBilgi f18 = { 18, 18,18,18,"The Mighty Ducks","Spor","Stephen Herek",1992,4.7,100,"Buz hokeyi takiminin hikayesi." };
struct filmBilgi f19 = { 19,19,19,19,"The House That Jack Built","Suc","Lars von Trier",2018,4.5,158,"Seri katilin hikayesi." };
struct filmBilgi f20 = { 20, 20,20,20,"The Wicker Man","Suc","Robin Hardy",1973,4.7,87,"Kaybolan bir kizin hikayesi." };
struct filmBilgi f21 = { 21, 21,21,21,"Death Wish","Suc","Michael Winner",1974,4.7,93,"Katillerin intikamini alan bir adamin hikayesi." };
struct filmBilgi f22 = { 22,22,22,22,"Alexander","Tarih","Oliver Stone",2004,4.5,175,"Buyuk Iskender'in hayati ve fetihleri." };
struct filmBilgi f23 = { 23,23,23,23,"Cleopatra","Tarih","Joseph L. Mankiewicz",1963,4.6,243,"Kleopatra'nin Romali general ve imparatorlarla iliskisi." };
struct filmBilgi f24 = { 24,24,24,24,"The Alamo","Tarih","John Lee Hancock",2004,4.5,145,"Meksika'nin bagimsizlik savasindaki hikayesi." };
struct filmBilgi f25 = { 25,25,25,25,"Slither","Western","James Gunn",2006,4.6,88,"Kasabaya inen uzayli bir parazitin hikayesi." };
struct filmBilgi f26 = { 26,26,26,26,"Babam ve Oglum","Yerli","Cagan Irmak",2005,8.4,147,"1980'lerdeki baba-ogul iliskisinin hikayesi." };
struct filmBilgi f27 = { 27,27,27,27,"Iklimler","Yerli","Nuri Bilge Ceylan",2006,7.9,108,"Farkli iklimlerdeki bir ask hikayesi." };
struct filmBilgi f28 = { 28,28,28,28,"Pan's Labyrinth","Fantastik","Guillermo del Toro",2006,8.4,120,"Ispanya Ic Savasi sirasindaki bir kizin fantastik macerasi." };
struct filmBilgi f29 = { 29,29,29,29,"Monty Python and the Holy Grail","Komedi","Terry Jones",1975,8.1,92,"Kral Arthur'un Kutsal Kase'yi arayisi." };

int main() // ana kisim 
{
    // yapilabilenler : film secme / fiyatlandirma / satin alma
    printFibu(); // estetik gorunus cagirildi
    printf("\t----------------*<FiBu>*-----------------------\n\n");
    printf("\t------------*<HOSGELDINIZ>*--------------------\n\n");

    int anasecim;
    //do - while & switch-case 
    do {
        printf("Ana menu islemlerinden birini seciniz: (1,2,3,4,5,6): \n\n");
        printf("1-film listesinden film sec!\n"); // bulundu - film2 - filmID2 -secilenFilmID
        printf("2-ture gore film listele!\n"); // bul - film - filmID
        printf("3-film satin al!\n"); // bulunacak - film3 - filmID3 -dosya1 // bakiye karsilastirarak filmi alinip alinamayacagi belirlenir
        printf("4-Satin alinan filmleri goruntule!!!\n"); // kullanicifilmsatinaldi.txt cagirildi -dosya1 
        printf("5-Daha sonra izleme/satin alma listesi olustur!!!\n"); // her kullaniciya özel olmadý maaalesef ama eklenirken isim aliniyor -bulunsun filmID4- dosya5
        printf("6-Cikis Yapmak icin 6 rakamini tuslayiniz!!!\n");
        scanf("%d", &anasecim);
        char tur[20];

        switch (anasecim) {
        case 1:
            printf("\t seciminiz : FILM LISTESINE GORE FILM LISTELE\n");

            printf("1.Home Alone \n");   printf("2.The Last Action Hero \n"); printf("3.The Cat in the Hat \n");  printf("4.Blade Runner \n");
            printf("5.Arrival \n");   printf("6.A Beautiful Mind \n"); printf("7.The Ice Road \n");  printf("8.Malignant \n");
            printf("9.Bao \n");   printf("10.Sessiz Bir Yer \n"); printf("11.IT \n");  printf("12.The Conjuring \n");
            printf("13.La La Land \n");   printf("14.Av Mevsimi \n"); printf("15 The Godfather \n");  printf("16.Not Defteri \n");
            printf("17.Schindler'in Listesi \n");   printf("18.The Mighty Ducks \n"); printf("19.The House That Jack Built \n");  printf("20.The Wicker Man \n");
            printf("21.Death Wish \n"); printf("22.Alexander \n");  printf("23.Cleopatra \n"); printf("24.The Alamo \n"); printf("25.Slither \n");  printf("26.Babam ve Oglum \n");
            printf("27.Iklimler \n"); printf("28.Pan's Labyrinth \n");  printf("29.Monty Python and the Holy Grail \n\n\n");

            int secilenFilmID;
            printf("Bilgi almak istediginiz film ID giriniz: ");
            scanf("%d", &secilenFilmID);

            int bulundu = 0;
            struct filmBilgi film2[] = { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18, f19, f20, f21, f22, f23, f24, f25, f26, f27, f28, f29 };
            int filmID2 = sizeof(film2) / sizeof(film2[0]);
            printf("Sectiginiz Filme ait bilgiler\n");
            printf("--------------------------------------------------------\n");
            for (int i = 0; i < filmID2; ++i) {
                if (film2[i].filmID2 == secilenFilmID) {
                    bulundu = 1;
                    printf("***Filminiz***\n");
                    printf("**************\n");
                    printf("Film Adi: %s\n", film2[i].filmadi);
                    printf("Yonetmen: %s\n", film2[i].yonetmen);
                    printf("Cikis Yili: %d\n", film2[i].cikisyili);
                    printf("IMDb Puani: %.1f\n", film2[i].imdbPuan);
                    printf("Sure: %d\n", film2[i].sure);
                    printf("Film Konusu: %s\n", film2[i].konu);
                    printf("<<<Filmi almak istiyorsaniz film ID unutmayiniz>>>\n\n");
                    printf("--------------------------------------------------------\n");

                    break; //film bulundu

                }
            }
            if (!bulundu) {
                printf("!!!\n");
                printf("Hatali ID. Tekrar deneyiniz!!!\n");
                printf("!!!\n");
            }
            break;



        case 2:
            printf("\t seciminiz : TURE GORE FILM LISTELE\n");
            printf("Aile\n" "Aksiyon\n" "Animasyon\n" "Belgesel\n" "Bilim Kurgu\n" "Dram\n" "Biyografi\n"
                "Gerilim\n" "Gizem\n" "Kisa Metrajli\n" "Korku\n" "Macera\n" "Muzik\n" "Polisiye\n" "Politik\n" "Romantik\n"
                "Savas\n" "Spor\n" "Suc\n" "Tarih\n" "Western\n" "Yerli\n" "Fantastik\n" "Komedi\n");

            printf("Film turunu giriniz: ");
            scanf("%s", tur);

            struct filmBilgi film[] = { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18, f19, f20, f21, f22, f23, f24, f25, f26, f27, f28, f29 };

            int filmID = sizeof(film) / sizeof(film[0]);
            int bul = 0;
            printf("Sectiginiz %s turune ait filmler:\n", tur);
            printf("--------------------------------------------------------\n");
            for (int i = 0; i < filmID; ++i) {
                if (strcmp(film[i].tur, tur) == 0) {
                    bul = 1;
                    printf("Film ID: %d\n", film[i].filmID);
                    printf("Film Adi: %s\n", film[i].filmadi);
                    printf("Yonetmen: %s\n", film[i].yonetmen);
                    printf("Cikis Yili: %d\n", film[i].cikisyili);
                    printf("IMDb Puani: %.1f\n", film[i].imdbPuan);
                    printf("Sure: %d\n", film[i].sure);
                    printf("Film Konusu: %s\n", film[i].konu);
                    printf("<<<Filmi almak istiyorsaniz film ID unutmayiniz>>>\n\n");
                    printf("--------------------------------------------------------\n");
                }

            }
            if (!bul) {
                printf("!!!\n");
                printf("Bu turde film bulunamadi.\n");
                printf("!!!\n");
            }

            break;



        case 3:
            printf("\t seciminiz : FILM SATIN AL\n");
            int alinacakFilmID;

            printf("Satin almak istediginiz filme ait ID giriniz: ");
            scanf("%d", &alinacakFilmID);

            int bulunacak = 0;
            struct filmBilgi film3[] = { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18, f19, f20, f21, f22, f23, f24, f25, f26, f27, f28, f29 };
            int filmID3 = sizeof(film3) / sizeof(film3[0]);
            printf("***Satin Almak Istediginiz Film***\n\n");
            printf("--------------------------------------------------------\n");
            for (int i = 0; i < filmID3; ++i) {
                if (film3[i].filmID3 == alinacakFilmID) {
                    bulunacak = 1;
                    printf("Film Adi: %s\n", film3[i].filmadi);
                    printf("Yonetmen: %s\n", film3[i].yonetmen);
                    printf("Cikis Yili: %d\n", film3[i].cikisyili);
                    printf("IMDb Puani: %.1f\n", film3[i].imdbPuan);
                    printf("Sure: %d\n", film3[i].sure);
                    printf("Film Konusu: %s\n", film3[i].konu);
                    // Secilen film icin fiyati hesapla ve goster
                    double secilenFilmFiyati = filmTutar(film3[i].imdbPuan);
                    printf("Film Fiyati: %.2f TL\n", secilenFilmFiyati);
                    printf("--------------------------------------------------------\n");
                    printf("--Satin almaktan vazgec : 1 --\n");
                    printf("--Odeme islemine gec : 2 --\n");
                    printf("--------------------------------------------------------\n");
                    int kullaniciSonSecim;
                    printf("Secim yapiniz : (1,2) ");
                    scanf("%d", &kullaniciSonSecim);



                    if (kullaniciSonSecim == 2) {
                        FILE* dosya1;
                        dosya1 = fopen("kullanicifilmsatinaldi.txt", "a");
                        if (dosya1 == NULL) {
                            printf("Dosya acilamadi.\n");
                            return -1;
                        }

                        char ad[50], soyad[50];
                        int kartNo;
                        double kartBak;
                        printf("------------------------------\n");
                        printf("Adinizi giriniz: ");
                        scanf("%s", ad);

                        if (strlen(ad) == 0) {
                            printf("Ad bos gecilemez!");
                            return 1;
                        }

                        printf("Soyadinizi giriniz: ");
                        scanf("%s", soyad);
                        printf("------------------------------\n");

                        printf("Kart Numaranizi Giriniz (16 haneli): ");
                        if (scanf("%16d", &kartNo) != 1) {
                            printf("Gecerli bir kart numarasi girilmelidir.\n");
                            fclose(dosya1);
                            return -1;
                        }
                        printf("------------------------------\n");

                        printf("Kart Bakiyenizi Giriniz: ");
                        if (scanf("%lf", &kartBak) != 1 || kartBak < 0) {
                            printf("Geçerli bir bakiye girilmelidir.\n");
                            fclose(dosya1);
                            return -1;
                        }
                        printf("------------------------------\n");

                        // Film fiyatý, kart bakiyesinden fazlaysa iþlemi iptal et
                        if (secilenFilmFiyati > kartBak) {
                            printf("Yetersiz bakiye. Film satin alinamadi.\n");
                            fclose(dosya1);
                            return -1;
                        }
                        printf("------------------------------\n");

                        // Bugünkü tarihi dosyaya yazma
                       // internetten alindi :)
                        time_t t = time(NULL); // Þuanki zamaný alma
                        struct tm today = *localtime(&t); // Yerel zamaný al



                        fprintf(dosya1, "\n%s \t%s \t%.2lf \t%s \t%.2f \t%02d/%02d/%d", ad, soyad, kartBak, film3[i].filmadi, secilenFilmFiyati, today.tm_mday, today.tm_mon + 1, today.tm_year + 1900);
                        fclose(dosya1);

                        printf("Islem basariyla tamamlandi. Tesekkur ederiz iyi seyirler!\n");

                        return 0;
                    }
                    else { // kullanici secimi = 1
                        printf("!!!!!!!! Satin alma isleminden vazgecildi. !!!!!!!!\n");
                    }
                    printf("--------------------------------------------------------\n");

                    break;
                }
            }
            if (!bulunacak) {
                printf("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                printf("Hatali ID. Tekrar deneyiniz!!!\n");
                printf("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
            }
            break;

            break;

            //4-Satin alinan filmleri goruntule!!! 
        case 4:
        {
            printf("\t seciminiz : SATIN ALINAN FILMLERI GORUNTULE\n");
            FILE* dosya1; // Dosya iþaretçisi
            char karakter;

            // Dosyayý açma iþlemi
            dosya1 = fopen("kullanicifilmsatinaldi.txt", "r"); //okuma modu             
            // Dosya açýlma kontrolü
            if (dosya1 == NULL) {
                printf("Dosya açma hatasi!\n");
                return 1;
            }
            // Dosyanýn sonuna kadar okuma ve ekrana yazdýrma
            while ((karakter = fgetc(dosya1)) != EOF) {
                printf("%c", karakter);
            }
            // Dosyayý kapatma
            fclose(dosya1);
            return 0;

        }
        break;

        //5 - Daha sonra izleme / satin alma listesi olustur!!!
        case 5:
            printf("\t seciminiz : SONRA IZLEME/SATIN ALMA LISTESI OLUSTUR\n");
            int filmID4;
            printf("1.Home Alone \n");   printf("2.The Last Action Hero \n"); printf("3.The Cat in the Hat \n");  printf("4.Blade Runner \n");
            printf("5.Arrival \n");   printf("6.A Beautiful Mind \n"); printf("7.The Ice Road \n");  printf("8.Malignant \n");
            printf("9.Bao \n");   printf("10.Sessiz Bir Yer \n"); printf("11.IT \n");  printf("12.The Conjuring \n");
            printf("13.La La Land \n");   printf("14.Av Mevsimi \n"); printf("15 The Godfather \n");  printf("16.Not Defteri \n");
            printf("17.Schindler'in Listesi \n");   printf("18.The Mighty Ducks \n"); printf("19.The House That Jack Built \n");  printf("20.The Wicker Man \n");
            printf("21.Death Wish \n"); printf("22.Alexander \n");  printf("23.Cleopatra \n"); printf("24.The Alamo \n"); printf("25.Slither \n");  printf("26.Babam ve Oglum \n");
            printf("27.Iklimler \n"); printf("28.Pan's Labyrinth \n");  printf("29.Monty Python and the Holy Grail \n\n\n");

            printf("Film ID'sini giriniz: ");
            scanf("%d", &filmID4);
            int bulunsun = 0;
            struct filmBilgi film5[] = { f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18, f19, f20, f21, f22, f23, f24, f25, f26, f27, f28, f29 };
            int filmID5 = sizeof(film5) / sizeof(film5[0]);

            for (int i = 0; i < filmID5; ++i) {
                if (film5[i].filmID == filmID4) {
                    bulunsun = 1;
                    printf("***Filminiz***\n");          
                    printf("Film Adi: %s\n", film5[i].filmadi);
                    printf("Yonetmen: %s\n", film5[i].yonetmen);
                    printf("Cikis Yili: %d\n", film5[i].cikisyili);
                    printf("IMDb Puani: %.1f\n", film5[i].imdbPuan);
                    printf("Sure: %d\n", film5[i].sure);
                    printf("Film Konusu: %s\n", film5[i].konu);

                    // Kullanýcý bilgilerini al
                    char adsoyad[50];
                    printf("Adinizi soyadinizi giriniz: ");
                    scanf("%s", adsoyad);

                    

                    // Tarih bilgisini al
                    time_t t = time(NULL);
                    struct tm today = *localtime(&t);

                    FILE* dosya5;
                    dosya5 = fopen("sonra_izle_listem.txt", "a");
                    if (dosya5 == NULL) {
                        printf("Dosya acilamadi.\n");
                        return -1;
                    }
                    fprintf(dosya5, "---------------------------------------\n");
                    fprintf(dosya5, "Ekleyen Kullanici:%s\n", adsoyad);
                    fprintf(dosya5, "Eklenme Tarihi: %02d/%02d/%d\n", today.tm_mday, today.tm_mon + 1, today.tm_year + 1900);
                    fprintf(dosya5, "\nFilm Adi: %s\n", film5[i].filmadi);
                    fprintf(dosya5, "Yonetmen: %s\n", film5[i].yonetmen);
                    fprintf(dosya5, "Cikis Yili: %d\n", film5[i].cikisyili);
                    fprintf(dosya5, "IMDb Puani: %.1f\n", film5[i].imdbPuan);
                    fprintf(dosya5, "Sure: %d\n", film5[i].sure);
                    fprintf(dosya5, "Film Konusu: %s\n", film5[i].konu);                  
                    fprintf(dosya5, "---------------------------------------\n");

                    fclose(dosya5);

                    printf("Film basariyla listenize eklendi!\n");
                    break;
                }
            }

            if (!bulundu) {
                printf("Hatali ID. Tekrar deneyiniz!!!\n"); // harf giriminde herhangi bir kontrol olmadan atiyor uygulamadan ama 1-29 dýþýndaki her sayida hatali ID diyor !!!
            }

            break;


            //6 - Cikis Yapmak icin 6 rakamini tuslayiniz!!!
        case 6:
            printf("Cikis yapiliyor...\n");
            const char* cikiscumle[] = { "Ben istiyorum ki;film, siz sinema salonunu terk ettikten sonra baslasin.",
                 "Zulumler, sinifsal konular vs. sinemada yeterince anlatiliyor. Ben de belki bunlarin arkasinda olabilecek, daha muglak, daha benim de anlayamadigim seyleri anlatmaya calisiyorum.",
                 "Kotu adam ne kadar basariliysa film de o kadar basarilidir. Bu en onemli kuraldir.",
                 "Iyi bir filmin kusurlari olmasi gerekir.Hayat gibi, insanlar gibi.",
                 "Fotograf gercektir, sinema ise saniyede yirmi dort kere gercektir.",
            };

            srand((unsigned int)time(NULL));

            int cumleno = sizeof(cikiscumle) / sizeof(cikiscumle[0]);

            int random_index = rand() % cumleno;

            printf("- '%s'\n", cikiscumle[random_index]);

            return 0;
            break;

        default:
            printf("!!!\n");
            printf("Gecersiz secim! Lutfen tekrar deneyin.\n");
            printf("!!!\n");
            break;
        }
    } 

while (anasecim != 5);
}
