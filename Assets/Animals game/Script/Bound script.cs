using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundscript : MonoBehaviour
{
    private float screenBound = 19f;

    // Update is called once per frame
    void Update()
    {
        /// destroy the game object if it is out the screen
        if (transform.position.z > screenBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -screenBound)
        {
            Destroy(gameObject);
        }


    }
}
