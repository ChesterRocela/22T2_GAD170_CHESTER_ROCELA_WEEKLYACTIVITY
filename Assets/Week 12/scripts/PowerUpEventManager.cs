using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class PowerUpEventManager : MonoBehaviour
    {
        public delegate void PowerUpAction();
        public static event PowerUpAction OnPowerUp;

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(OnPowerUp != null)
                {
                    OnPowerUp();
                }
            }
        }

    }
}