using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Haslo")]
        public string Haslo { get; set; }
        [Required(ErrorMessage = "Prosze potwierdz Haslo")]
        public string Potw_Haslo { get; set; }
        [Required(ErrorMessage = "Prosze podaj numer telefonu")]
        public string Nr_telefonu { get; set; }
        [Required(ErrorMessage = "Prosze podaj swoj wiek")]
        public int Wiek { get; set; }
        [Required(ErrorMessage = "Prosze podaj Miasto z ktorego pochodzisz")]
        public string Miasto { get; set; }


    }
}
