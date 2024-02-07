using System.ComponentModel.DataAnnotations;

namespace Client_WinUI_MVVM.Models
{
    public class Series
    {
        int? serieid;
        string? titre;
        string? resume;
        int? nbsaisons;
        int? nbepisode;
        int? anneecreation;
        string? network;

        public Series()
        {
        }

        public Series( string titre)
        {
            Titre = titre;
        }

        public Series(int? serieid, string titre, string resume, int? nbsaisons, int? nbepisode, int? anneecreation, string network)
        {
            Serieid = serieid;
            Titre = titre;
            Resume = resume;
            Nbsaisons = nbsaisons;
            Nbepisode = nbepisode;
            Anneecreation = anneecreation;
            Network = network;
        }

        public int? Serieid
        {
            get
            {
                return serieid;
            }

            set
            {
                serieid = value;
            }
        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public string Resume
        {
            get
            {
                return resume;
            }

            set
            {
                resume = value;
            }
        }

        public int? Nbsaisons
        {
            get
            {
                return nbsaisons;
            }

            set
            {
                nbsaisons = value;
            }
        }

        public int? Nbepisode
        {
            get
            {
                return nbepisode;
            }

            set
            {
                nbepisode = value;
            }
        }

        public int? Anneecreation
        {
            get
            {
                return anneecreation;
            }

            set
            {
                anneecreation = value;
            }
        }

        public string Network
        {
            get
            {
                return network;
            }

            set
            {
                network = value;
            }
        }

        public override string ToString()
        {
            return Titre;
        }
    }
}