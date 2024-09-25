#region Menu_Baslangici


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;

Console.WriteLine("Api Consume İşlemine Hoş Geldiniz");
Console.WriteLine();
Console.WriteLine("### Yapmak İstediğiniz İşlemi Seçin ###");
Console.WriteLine();
Console.WriteLine("1-Şehir Listesini Getirin");
Console.WriteLine("2-Şehir ve Hava Durumu Listesini Getirin");
Console.WriteLine("3-Yeni Şehir Ekleme");
Console.WriteLine("4-Şehir Silme İşlemi");
Console.WriteLine("5-Şehir Güncelleme İşlemi");
Console.WriteLine("6-ID'ye Göre Şehir Getirme");
Console.WriteLine();

#endregion

string number;

Console.Write("Tercihiniz: ");
number = Console.ReadLine();
Console.WriteLine();

if (number == "1")
{
    Console.WriteLine("Şehir Listesi Alanı");
    Console.WriteLine("---------------------------------------------------------");
    string url = "https://localhost:7056/api/Weathers";     //API'den veri çekeceğimiz URL'yi tanımlar.
    using (HttpClient client = new HttpClient())            // `HttpClient` sınıfını kullanarak API'ye istek göndermek için bir nesne oluşturur. `using` yapısı, iş bitince bu nesneyi temizler.
    {
        HttpResponseMessage response = await client.GetAsync(url);           //API'ye GET isteği gönderir ve yanıtını alır
        string responseBody = await response.Content.ReadAsStringAsync();    //API'nin döndürdüğü veriyi (JSON içerik) string formatında okur.
        JArray jArray = JArray.Parse(responseBody);                          //JSON stringini bir JArray (JSON dizisi) nesnesine çevirir.
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();                  //JSON nesnesindeki "cityName" alanını alıp, string formatına dönüştürür ve cityName değişkenine atar.
            Console.WriteLine($"Şehir: {cityName}");
        }
    }
}
if (number == "2")
{
    Console.WriteLine("Şehir ve Hava Durumu Listesi");
    Console.WriteLine("---------------------------------------------------------");

    string url = "https://localhost:7056/api/Weathers";
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url);
        string responseBody = await response.Content.ReadAsStringAsync();
        JArray jArray = JArray.Parse(responseBody);
        foreach (var item in jArray)
        {
            string cityName = item["cityName"].ToString();
            string temp = item["temp"].ToString();
            string country = item["country"].ToString();
            Console.WriteLine(cityName + " - " + country + " --> " + temp + " Derece.");
        }
    }
}


if (number == "3")
{
    Console.WriteLine("Yeni Şehir Ekleme Alanı");
    Console.WriteLine("---------------------------------------------------------");

    string cityName, country, detail;
    decimal temp;

    Console.WriteLine("Şehir Adı: ");
    cityName = Console.ReadLine();

    Console.WriteLine("Ülke Adı: ");
    country = Console.ReadLine();

    Console.WriteLine("Hava Durumu Detayı: ");
    detail = Console.ReadLine();

    Console.WriteLine("Sıcaklık: ");
    temp = decimal.Parse(Console.ReadLine());

    string url = "https://localhost:7056/api/Weathers";             //API'den veri çekeceğimiz URL'yi tanımlar.
    var newWeatherCity = new                                        // Dinamik bir anonim nesne (newWeatherCity) oluşturulur
    {
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };

    using (HttpClient client = new HttpClient())                                                 //API'ye HTTP isteği göndermek için bir HttpClient nesnesi oluşturulur. using bloğu, iş tamamlandığında bu nesnenin otomatik olarak temizlenmesini sağlar.
    {
        string json = JsonConvert.SerializeObject(newWeatherCity);                              //newWeatherCity anonim nesnesi JSON formatına dönüştürülür. Bu işlem API'ye göndereceğimiz veriyi JSON formatında hazırlamak için yapılır.
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");     //HTTP POST isteğinde kullanılacak olan verinin içeriğini temsil eder. Veriler UTF-8 olarak kodlanır ve içerik türü application/json olarak ayarlanır.
        HttpResponseMessage response = await client.PostAsync(url, content);                     //belirtilen url adresine bir POST isteği gönderilir. JSON formatında hazırlanan content verisi bu isteğin gövdesinde yer alır. İstek asenkron olarak gerçekleştirilir ve sonucunda bir HttpResponseMessage nesnesi döndürülür.
        response.EnsureSuccessStatusCode();                                                      //İsteğin başarılı bir şekilde tamamlanıp tamamlanmadığını kontrol eder.
    }
    
}

if (number == "4")
{
    Console.WriteLine("Şehir Silme Alanı");
    Console.WriteLine("---------------------------------------------------------");
    string url = "https://localhost:7056/api/Weathers?id=";     //API'den veri çekeceğimiz URL'yi tanımlar. sonuns?id eklendi id kontrolü için

    Console.WriteLine("Silmek İstediğiniz Id Değeri: ");
    int id = int.Parse(Console.ReadLine());                 //id değeri tanımlama

    using(HttpClient client = new HttpClient())             //API'ye HTTP isteği göndermek için bir HttpClient nesnesi oluşturulur. using bloğu, iş tamamlandığında bu nesnenin otomatik olarak temizlenmesini sağlar.
    {
        HttpResponseMessage response = await client.DeleteAsync(url + id);      //belirtilen id'ye sahip bir kaynağı silmek için sunucuya bir DELETE isteği gönderiliyor.
        response.EnsureSuccessStatusCode();
    }


}
if (number == "5")
{

    Console.WriteLine("Şehir Güncelleme Alanı");
    Console.WriteLine("---------------------------------------------------------");
    string url = "https://localhost:7056/api/Weathers";

    string cityName, country, detail;
    decimal temp;
    int cityId;

    Console.WriteLine("Şehir Adı: ");
    cityName = Console.ReadLine();

    Console.WriteLine("Ülke Adı: ");
    country = Console.ReadLine();

    Console.WriteLine("Hava Durumu Detayı: ");
    detail = Console.ReadLine();

    Console.WriteLine("Sıcaklık: ");
    temp = decimal.Parse(Console.ReadLine());

    Console.WriteLine("İd: ");
    cityId = int.Parse(Console.ReadLine());


    var updateWeatherValues = new
    {
        CityId = cityId,
        CityName = cityName,
        Country = country,
        Detail = detail,
        Temp = temp
    };

    using(HttpClient client = new HttpClient())                         //API'ye HTTP isteği göndermek için bir HttpClient nesnesi oluşturulur. using bloğu, iş tamamlandığında bu nesnenin otomatik olarak temizlenmesini sağlar.
    {
        string json = JsonConvert.SerializeObject(updateWeatherValues);     //updateWeatherValues anonim nesnesi JSON formatına dönüştürülüyor. Bu, sunucuya göndereceğimiz verinin JSON olarak hazırlanmasını sağlar.
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");     //JSON verisi, HTTP isteğinin gövdesinde gönderilecek içerik olarak hazırlanıyor. StringContent ile JSON verisi UTF-8 formatında kodlanıyor ve içerik tipi application/json olarak ayarlanıyor.
        HttpResponseMessage response = await client.PutAsync(url, content);     //HTTP PUT isteği gönderiliyor. url, API'nin adresini ve güncelleme yapılacak kaynağın yerini gösterir, content ise güncellenecek veriyi içerir. PutAsync metodu asenkron çalışır ve sunucudan dönen yanıtı HttpResponseMessage nesnesine atar.
    }
}
if (number == "6")
{
    Console.WriteLine("ID'ye Göre Şehir Alanı");
    Console.WriteLine("---------------------------------------------------------");

    string url = "https://localhost:7056/api/Weathers/GetByIdWeatherCity?id=";
    Console.Write("Tercihiniz: ");
    int id = int.Parse(Console.ReadLine());

    using(HttpClient client = new HttpClient())                         //API'ye HTTP isteği göndermek için bir HttpClient nesnesi oluşturulur. using bloğu, iş tamamlandığında bu nesnenin otomatik olarak temizlenmesini sağlar.
    {
        HttpResponseMessage response = await client.GetAsync(url + id);     //API'ye belirtilen id ile GET isteği gönderilir. url + id, API'nin uç noktasına kullanıcıdan alınan ID'nin eklenmesiyle tam URL oluşturulur ve GET isteği asenkron olarak gönderilir. Sunucudan gelen yanıt, response değişkenine atanır.
        response.EnsureSuccessStatusCode();                                 //GET isteğinin başarılı olup olmadığını kontrol eder. 
        string responseBody = await response.Content.ReadAsStringAsync();   //Sunucudan gelen yanıtın içeriği asenkron olarak okunur ve bir string olarak responseBody değişkenine atanır. Bu içerik, API'nin döndürdüğü JSON verisidir.
        JObject weatherCityObject = JObject.Parse(responseBody);            //responseBody adlı JSON formatındaki veriyi bir JObject (JSON nesnesi) olarak ayrıştırır ve bu nesne weatherCityObject değişkenine atanır.

        string cityName = weatherCityObject["cityName"].ToString();
        string detail = weatherCityObject["detail"].ToString();
        string country = weatherCityObject["country"].ToString();
        decimal temp = decimal.Parse(weatherCityObject["temp"].ToString());

        Console.WriteLine("Girmiş olduğunuz Id değerine ait bilgiler");
        Console.WriteLine();
        Console.WriteLine("Şehir: "+cityName + " Ülke: " + country + " Detay: " + detail + " Sıcaklık: " + temp);

    }

}
Console.Read();