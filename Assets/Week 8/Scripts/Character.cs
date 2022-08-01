using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class Character : MonoBehaviour
    {
        public int health = 100;
        public int morale = 100;

        private void update()
        {
            if(morale <= 50)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}