using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class SimpleCharacter : MonoBehaviour
    {
        /// <summary>
        /// Determines how far this character will move, in unity units per seconds.
        /// </summary>
        [SerializeField] public float movementspeed = 4;
        
        
        // Update is called once per frame
        void Update()
        {
            // Input.GetAxisRaw("Horizontal") will have a value on the X axis from -1 to 1 by pressing A/D, or left/right arrow keys 
            //Input.GetAxisRaw("vertical") will have vakye ib tge Y Axis from -1 by pressing W/S, or up/down arrow keys

            GetComponent<Transform>().position += new Vector3(Input.GetAxisRaw("Horizontal") * movementspeed * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * movementspeed * Time.deltaTime);
        }
    }
}
