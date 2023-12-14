using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibu
{
    public class Film
    {

        public string Adi { get; set; }
        public string Turu { get; set; }
        public string Yönetmen { get; set; }
        public string cikisYılı { get; set; }
        public string imbd { get; set; }
        public string süre { get; set; }
        public string konu { get; set; }

        public double HesaplaUcret()
        {
            // IMDb puanını double türüne dönüştür
            if (double.TryParse(imbd, out double imdbPuani))
            {
                // IMDb puanını 0.5 ile çarparak ücreti hesapla
                double ucret = imdbPuani * 0.5;
                return ucret;
            }

            return 0; // Eğer IMDb puanı geçerli bir sayı değilse, 0 döndür
        }
    }
}
