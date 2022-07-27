using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{

    public class CharacterColourChange : MonoBehaviour
    {
        // we need a reference to the character we will change the colour of 

        [SerializeField] private MeshRenderer simpleCharacterRenderer;

        //update is called once per frame
        private void Update()
        {
            // we need to change the character's colour IF it has an x position < or > than 0 
            if (simpleCharacterRenderer.gameObject.transform.position.x > 0)
            {
                simpleCharacterRenderer.material.color = Color.yellow;
            }
            else
            {
                simpleCharacterRenderer.material.color = Color.red;
            }
        }
    }
}
