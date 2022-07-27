using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class NewBehaviourScript : MonoBehaviour
    {
       // Information about my favouite game, hours ive played it, and how much it cost
        private string favouriteGame = "Valorant";
        private int hoursPlayed = 400;
        private float costOfGame = 89.99f;

        // start is called before the first frame update
        void Start()
        {
            // operators:
            // + = add
            // - = subtract
            // / = divide 
            // * multiply 

            float dollarPerHour;
            dollarPerHour = costOfGame / hoursPlayed;

            Debug.Log("my favourite Game is" + " " + favouriteGame + " " + "i have played it for" + " " + hoursPlayed + " " + "hours, and it cost me" + " "+ costOfGame + " " + "therefore, my vaule of dollar per hour is" + " "+ dollarPerHour);


        }
    }
}
