using System.Diagnostics;

namespace NovenyGyujtes_lib
{
    public static class PlantFactory
    {
        public static IPlant Create()
        {
            return Random.Shared.Next(6) switch
            {
                0 => new Flower("Rózsa", "A rózsa (Rosa), a rózsafélék (Rosaceae) családjába tartozó egyik növénynemzetség, illetve az ide tartozó cserjék virága.", 10, 'R'),
                1 => new Flower("Bódor Virág", "Kedvenc pultvezetőm a Groupamában. :)", 2100, 'B'),
                2 => new Herb("Kamilla", "Az orvosi székfű vagy kamilla (Matricaria chamomilla) az őszirózsafélék (Asteraceae) családjába tartozó gyógynövény.", 15, 'K', "Megfázás tüneteinek enyhítése."),
                3 => new Herb("Citromfű", "A citromfű (Melissa officinalis), az árvacsalánfélék (Lamiaceae) családjába tartozó, kellemes, citromra emlékeztető illatú, fehér virágú, évelő növény.", 20, 'C', "Serkenti az emésztést, és gyakran alkalmazzák fejfájás, álmatlanság, alvászavarok esetén is."),
                4 => new Mushroom("Ízletes vargánya", "Az ízletes vargánya (Boletus edulis) a gombákhoz (Fungi), azon belül tinórugomba-alkatúak (Boletales)[r 1] rendjébe és a tinórufélék (Boletaceae) családjába tartozó faj.", 5, 'V', false),
                5 => new Mushroom("Gyilkos galóca", "A gyilkos galóca (Amanita phalloides) kalaposgombák rendjén belül a galócafélék családjába tartozó, világszerte közel 600 fajt számláló Amanita nemzetség egyik legismertebb képviselője.", 100, 'G', true),
                _ => throw new UnreachableException(),
            };
        }
    }
}
