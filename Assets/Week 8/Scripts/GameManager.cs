using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*namespace ChesterRocela 
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Character playerOne;
        [SerializeField] private Character playerTwo;

        [SerializeField] private Character[] players;
        private int length;

        private void update()
        {
            // the check 
            if  (Input.GetKeyDown(KeyCode.Space))
            {
                if (int i = 0; i < length; i++)
                {
                    if (players[i] ! = null)
                    {
                        players[i].enabled = false;
                    }
                }

                if (playerOne != null)
                {
                    // the adjustment:
                    playerOne.morale -= Random.Range(1, 13);
                    playerOne.health -= Random.Range(1, 9);
                }

                if(playerOne.health <= 0)
                {
                    Destroy(playerOne.gameObject);
                    playerOne = null;
                }
       
        
                if(playerTwo != null)
                {
                    playerTwo.morale -= Random.Range(1, 13);
                    playerTwo.health -= Random.Range(1, 9);
                
                    if(playerTwo.health <= 0)
                    {
                        Destroy(playerTwo.gameObject);
                        playerTwo = null;
                    }
                }
            }

        }
    }
}*/