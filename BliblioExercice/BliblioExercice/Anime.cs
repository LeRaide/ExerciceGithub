using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BliblioExercice
{
    /// <summary>
    /// 
    /// </summary>
    public class Anime
    {
        public string Nom { get; set; }
        public List<Anime> animes = new List<Anime>();
        public event EventHandler<List<Anime>>? newAnime;
        public Anime(string nom)
        {
            Nom = nom;
        }

        public void AjouterAnime(string nom)
        {
            animes.Add(new Anime(nom));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>liste des animes </returns>
        public List<Anime> ObtenirAnimes()
        {
            return animes;
        }
    }
}
