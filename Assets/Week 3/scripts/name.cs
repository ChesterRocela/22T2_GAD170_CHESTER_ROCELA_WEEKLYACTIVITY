using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class name : MonoBehaviour
    {
        private string firstName = "Chester";
        private string lastName = "Rocela";

        // start is called before the first frame update
        private void Start()
        {
            Debug.Log("My Name is" + " " + firstName + " " + lastName);

            PowerLevel1(10, 8, 10);
            
            PowerLevel2(2, 5, 14);

            void PowerLevel1(int strength, int agility, int intelligence)
            {
                // sum of strength * 2 plus agility * 1.5 and adds Intelligence 
                int result = 0;
                
                result = (int)(strength * 2f + agility * 1.5 + intelligence);

                Debug.Log("Power Level 1: " + result);
            }
            void PowerLevel2(int strength, int agility, int intelligence)
            {
                int result = 0;

                result = (int)(strength * 2f + agility * 1.5 + intelligence);

                Debug.Log("Power Level 2: " + result);
            }
        }

    }
}
