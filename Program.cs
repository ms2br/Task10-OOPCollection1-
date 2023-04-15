namespace Task10_OOPCollection1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Keçən dəfə dərsdə yazdığım məsələni bitirmək. Demək bir edit metodu yazacaqsınız, parameter kimi iki string göndərəcəksiniz, bunlardan birincisi bu string-in olub olmadığını yoxlayacaq, digəri isə tapılan dəyəri dəyişdirəcək. Əgər həmin string-ə uyğun nəticə tapılmasa, ekrana çıxmalıdır ki, belə ad mövcud deyil.

            ArrayControl rnd = new ArrayControl();

            rnd.Add("Ramazan");
            rnd.Add("Ramazan");
            rnd.Add("Ramin");
            rnd.Add("Abbas");

            //rnd.ValueDelete("Ramazan");

            rnd.UpdateMetot("Ramazan","Boran");

            List<string> rnda = rnd.myArray;
            #endregion
        }
    }
}