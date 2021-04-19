using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_5_Nedas_Vinickas
{
/// <summary>
/// Klase kuri laiko atstovybiu duomenis
/// </summary>
    class Atstovybe
    {
        public const int didziausiasKlausimuSkaicius = 50;
        public string Pavadinimas { get; set; }
        public KlausimuKonteineris KlausimasSuVariantais { get; set; }
        public KlausimuKonteineris KlausimasBeVariantu { get; set; }
        public KlausimuKonteineris MuzikinisKlausimas { get; set; }
 
        public Atstovybe(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
            KlausimasSuVariantais = new KlausimuKonteineris(didziausiasKlausimuSkaicius);
            KlausimasBeVariantu = new KlausimuKonteineris(didziausiasKlausimuSkaicius);
            MuzikinisKlausimas = new KlausimuKonteineris(didziausiasKlausimuSkaicius);
        }

        public void PridetiKBeVariant(KlausimasBeVariantu klausimas)
        {
            KlausimasBeVariantu.Prideti(klausimas);
        }

        public void PridetiKSuVariant(KlausimasSuVariantais klausimas)
        {
            KlausimasSuVariantais.Prideti(klausimas);
        }

        public void PridetiKMuzikini(MuzikinisKlausimas klausimas)
        {
            MuzikinisKlausimas.Prideti(klausimas);
        }

       
    }
}
