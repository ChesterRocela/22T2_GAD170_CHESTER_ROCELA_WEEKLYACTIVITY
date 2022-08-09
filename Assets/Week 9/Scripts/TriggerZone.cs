using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class TriggerZone : MonoBehaviour
    {
        public delegate void TriggerAction();

        public static event TriggerAction OnTrigger;

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger Zone");

            // other.transform.position = new vector3 (0, 3, 0,);

            if (OnTrigger != null) 
            {
                OnTrigger();
            }
        }
    }
