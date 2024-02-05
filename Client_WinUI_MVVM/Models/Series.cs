using System.ComponentModel.DataAnnotations;

namespace Client_WinUI_MVVM.Models
{
    public class Series
    {
        int id;
        string? nomDevise;
        double taux;


        public Series()
        {
        }

        public Series(int id, string? nomDevise, double taux)
        {
            this.Id = id;
            this.NomDevise = nomDevise;
            this.Taux = taux;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        [Required]
        public string? NomDevise
        {
            get
            {
                return nomDevise;
            }

            set
            {
                nomDevise = value;
            }
        }

        public double Taux
        {
            get
            {
                return this.taux;
            }

            set
            {
                this.taux = value;
            }
        }

        public override string ToString()
        {
            return NomDevise;
        }
    }
}