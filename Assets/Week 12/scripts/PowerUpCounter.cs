using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace ChesterRocela
{
    public class PowerUpCounter : MonoBehaviour
    {
        // for our events system we need these thing:
        // Announce the event at particular times or when a particular collision occurs, etc...
        // we want to make sure our UI is LISTENING for the event
        // when the event is announced, we want to update our UI.

        [SerializeField] private TMPro.TextMeshProUGUI powerUpCounter;
        [SerializeField] private int powerUpCount = 0;

        private void OnEnable()
        {
            PowerUpEventManager.OnPowerUp += IncreasePowerUpCount;
        }

        private void OnDisable()
        {
            PowerUpEventManager.OnPowerUp -= IncreasePowerUpCount;
        }
        private void IncreasePowerUpCount()
        {
            powerUpCount++;
            powerUpCounter.text = "PowerUp PickUp: " + powerUpCount;
        }
    }
}