using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChesterRocela
{
    public class MarbleManager : MonoBehaviour
    {
        // spawb a marble every few seconds
        // need to use "Instantiate" method

        [SerializeField] private GameObject marblespawnpoint;
        [SerializeField] private GameObject marblePrefab;

        [SerializeField] private float timer;
        [SerializeField] private float timeReset = 1;

        [SerializeField] private Vector3 averagerMarblePosition;

        public List<GameObject> allMarbles = new List<GameObject>();

        // Start is called before the first frame update
        void Start()
        {
            timer = timeReset;
        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                timer = timeReset;

                //spawn a marble
                GameObject newMarble = Instantiate(marblePrefab, marblespawnpoint.transform.position, Quaternion.identity);

                //add force to make our marble quicker
                newMarble.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 0));

                //add our new marble to the list of all marble
                allMarbles.Add(newMarble);
            }
            UpdateCameraLook();
        }

        private void UpdateCameraLook()
        {
            if(allMarbles.Count > 0)
            {
                for (int i = 0; i < allMarbles.Count; i++)
                {
                    averagerMarblePosition += allMarbles[i].transform.position;
                }
                averagerMarblePosition /= allMarbles.Count;

                Camera.main.transform.LookAt(averagerMarblePosition);
            }
        }
    }
}