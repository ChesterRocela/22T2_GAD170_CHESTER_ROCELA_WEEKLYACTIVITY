using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ChesterRocela
{
    public class GameMenuManager : MonoBehaviour
    {
        // we need a game UI
        // we want to show the UI when we press the escape key (ESC)
        // lastly, we need some (or a) menu button/s to send the user to the main menu scene.

        [SerializeField] private GameObject gameMenuPanel;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // If our game menu panel is ACTIVE...
                if (gameMenuPanel.activeSelf == true)
                {
                    // ..Hide it 
                    HideGameMenuPanel();
                }
                // OtherWise....
                else
                {
                    // Show it..
                    ShowGameMenuPanel();
                }
            }
        }

        /// <summary>
        /// Sets the game menu panel to active 
        /// </summary>
        public void ShowGameMenuPanel()
        {
            gameMenuPanel.SetActive(true);
        }

        /// <summary>
        /// Sets the game menu panel to deactivate
        /// </summary>
        public void HideGameMenuPanel()
        {
            gameMenuPanel.SetActive(false);
        }

        public void ResumeGameButton()
        {
            HideGameMenuPanel();
        }

        public void LoadScene(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
