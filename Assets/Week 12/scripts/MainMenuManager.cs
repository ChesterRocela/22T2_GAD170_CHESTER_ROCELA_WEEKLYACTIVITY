using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ChesterRocela
{
    public class MainMenuManager : MonoBehaviour
    {
        // we need some references to our menu panels
        // we want our panels to be set active/inactive when we click certain buttons

        [SerializeField] private GameObject mainMenuPanel;
        [SerializeField] private GameObject startPanel;
        [SerializeField] private GameObject creditsPanel;
        [SerializeField] private GameObject quitPanel;

        /// <summary>
        /// sets the main menu panel to active, and the credit panel to inactive.
        /// </summary>
        public void BackButtonClick()
        {
            Debug.Log("Back Button Activated");

            mainMenuPanel.SetActive(true);
            creditsPanel.SetActive(false);
        }

        /// <summary>
        /// sets the Credit panel to active, and the Back Button to inactive.
        /// </summary>
        public void CreditButtonClick()
        {
            Debug.Log("Credit Button Activated");

            mainMenuPanel?.SetActive(false);
            creditsPanel?.SetActive(true);
        }

        /// <summary>
        /// Sets Start button to active
        /// </summary>
        public void StartButtonClick()
        {
            Debug.Log("Startting the game");

            SceneManager.LoadScene(1);
        }

        /// <summary>
        /// sets quit button to active
        /// </summary>
        public void QuitButtonClick()
        {
            Debug.Log("Quitting the game");

            Application.Quit();
        }
    }
}