using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class FavouriteThings : MonoBehaviour
    {
        string[] favouriteFruits = { "Mango", "Apple", "Banana" };

        List<string> favouriteSuperHeroes = new List<string>();

        private void Start()
        {
            favouriteSuperHeroes.Add("Captain America");
            favouriteSuperHeroes.Add("Green lantern");
            favouriteSuperHeroes.Add("Antman");
            favouriteSuperHeroes.Add("Spider-man");

            Debug.Log(favouriteFruits[0]);
            Debug.Log(favouriteFruits[1]);
            Debug.Log(favouriteFruits[2]);

            for (int i = 0; i < favouriteFruits.Length; i++)
            {
                Debug.Log(favouriteFruits[i]);
            }
            for (int i = 0; i < favouriteSuperHeroes.Count; i++)
            {
                Debug.Log(favouriteSuperHeroes[i]);
            }
        }
    }
    
    

}
