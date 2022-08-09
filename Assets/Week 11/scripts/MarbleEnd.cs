using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class MarbleEnd : MonoBehaviour
    {
        [SerializeField] private MarbleManager marbleManager;
        private void OnTriggerEnter(Collider other)
        {
            // remove marble from the list on the manager list 
            marbleManager.allMarbles.Remove(other.gameObject);

            Destroy(other.gameObject);
        }
    }
}

