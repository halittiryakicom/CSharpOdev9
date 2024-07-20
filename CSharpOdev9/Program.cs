//Pratik - Yol Arkadaşı Tatil Uygulaması
//burada değişkenlerin tanımlanması
bool active = true;
bool newHolidayActive = true;
string newHolidaySelect = "";
string name = "";
string locationChoice = "";
string locationOne = "bodrum";
string locationTwo = "marmaris";
string locationThree= "çeşme";
bool locationActive = true;
string locationActivity = "";
int holidayAmount = 0;
string people;
int peopleNumber=0;
bool peopleActive = true;
string transportVehicles = "";
bool transportActive = true;

//menü döngüsünün başlaması
while (active)
{   
    //kullanıcıyı karşılama ve isim bilgisinin alınması
    Console.WriteLine("Pratik yol arkadaşı uygulamımıza hoş geldiniz.");
    Console.WriteLine("<------------------------------------------------------>");
    Console.Write("Lütfen isiminizi giriniz: ");
    name = Console.ReadLine();
    Console.WriteLine("<------------------------------------------------------>");
    //burada gidilmek istenen yeri soru sorup doğru bilgi girilip girilmediğini kontrol ediyoruz. Konum bilgisini doğru aldıktan sonra konum ile alakalı bilgileri bir değişkene aktarıyoruz ve ücretlerini de total ücrete ekliyoruz.
    do
    {
        Console.Write("Lütfen gitmek istediğiniz tatil yerinin isimini giriniz (Bodrum / Marmaris / Çeşme):");
        locationChoice = Console.ReadLine().ToLower();

        if (locationChoice == locationOne || locationChoice == locationTwo || locationChoice == locationThree)
        {
            locationActive = true;
            if (locationChoice == locationOne)
            {
                holidayAmount += 4000;
                locationActivity = $"Harika {name.ToUpper()}! Gitmek İstediğiniz Lokasyon {locationChoice.ToUpper()}.Yapılabilecek Faaliyetler: (Kaydıraklı Su Parkları,Doğa Koşusu,Yüzme vb)";
            }
            else if (locationChoice == locationTwo)
            {
                holidayAmount += 3000;
                locationActivity = $"Harika {name.ToUpper()}! Gitmek İstediğiniz Lokasyon {locationChoice.ToUpper()}.Yapılabilecek Faaliyetler: (Sahil Koşusu,Orman Koşusu,Yüzme vb)";
            }
            else if (locationChoice == locationThree)
            {
                holidayAmount += 5000;
                locationActivity = $"Harika {name.ToUpper()}! Gitmek İstediğiniz Lokasyon {locationChoice.ToUpper()}.Yapılabilecek Faaliyetler: (Su Aerobiki,Parkur Koşusu,Yüzme vb)";
            }
        } 
        else
        {
            Console.WriteLine("Lütfen seçeneklerden bir tanesini seçiniz.");
            locationActive = false;
        }
    } while (locationActive != true);


    //burada gidilecek olan kişi sayısının rakam olarak girilip girilmediğini kontrol ediyoruz.
    do
    {
        Console.WriteLine("Lütfen kaç kişi gitmek istediğinizi belirtiniz (rakam ile 0,1,2,...):");
        people = Console.ReadLine();
        peopleActive = int.TryParse(people, out peopleNumber);
        if (peopleActive != true)
            Console.WriteLine("Lütfen rakam giriniz (rakam ile 0,1,2,...)");
    } while (peopleActive != true);

    //burada tatil yerinin yapılabilecek etkinliklerinin özet bilgisi
    Console.WriteLine(locationActivity);

    //burada hava yolu seçim olayını yapıyoruz.Bu yol seçimine göre fiyata ekleme yapıyoruz.
    do
    {
        Console.Write("Seçim yaptığınız lokasyona hangi ulaşım yolu ile ulaşmayı tercih ederisiniz. Seçimi RAKAM olarak yapınız \n (1) KARA YOLU \n (2) HAVA YOLU: ");
        transportVehicles = Console.ReadLine();
        if (transportVehicles == "1" || transportVehicles == "2")
        {
            transportActive = true;
            if (transportVehicles == "1")
                holidayAmount += 1500;
            else if (transportVehicles == "2")
                holidayAmount += 4000;
        }
        else
        {
            Console.WriteLine("Lütfen sadece 1 yada 2 rakamını seçiniz.");
            transportActive = false;
        }
    } while (transportActive != true);


    //burada kullanıcıya bilgi veriyoruz. Hesap bilgisini burada kişi sayısına göre güncelliyoruz.
    holidayAmount = holidayAmount * peopleNumber;
    Console.WriteLine($"{name} seçimlerin Burada listelenmiştir.\n Gideceğin Lokasyon : {locationChoice.ToUpper()} \n Kişi Sayısı: {peopleNumber} \n Ulaşım Tercihin: {transportVehicles}\nTatil için ödemen gereken miktar {holidayAmount}TL'dir.");

    //burada yeni bir tatil planlamak isteyip istemediklerini soruyoruz.
    do
    {
        Console.Write("Yeni bir tatil planlamak ister misiniz (evet) / (hayır): ");
        newHolidaySelect = Console.ReadLine();
        if (newHolidaySelect == "evet" || newHolidaySelect == "hayır")
        {
            newHolidayActive = true;
            if (newHolidaySelect == "evet")
                active = true;
            else if (newHolidaySelect == "hayır")
            {
                active = false;
                Console.WriteLine("Güzel bir tatil geçirmenizi dileriz. Hoşcakalın.");
            }
        }
        else
        {
            Console.WriteLine("Lütfen sadece evet yada hayır yazarak seçim yapınız.");
            newHolidayActive = false;
        }
    } while (newHolidayActive != true);
}