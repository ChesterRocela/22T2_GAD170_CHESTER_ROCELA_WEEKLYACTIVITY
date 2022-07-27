using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{

    public class Health : MonoBehaviour
    {
        public int health = 5;

        private void Update()
        {
            if (health < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

