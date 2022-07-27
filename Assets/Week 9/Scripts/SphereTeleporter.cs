using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{

    public class SphereTeleporter : MonoBehaviour
    {
        private void OnEnable()
        {
            EventManagerScript.OnClicked += Teleport;
            TriggerZone.OnTrigger += Teleport;
        }

        private void OnDisable()
        {
            EventManagerScript.OnClicked -= Teleport;
            TriggerZone.OnTrigger += Teleport;
        }
        
        private void Teleport()
        {
            transform.position = new Vector3(0, 6, 0);
        }
    }
}
