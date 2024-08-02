using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float playerSpeed;
    private float horizantalInput;
    public float xRange = 19;

    public GameObject food;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        /// keep player in x boundries left side
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        /// keep player in x boundries right side
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        /// Move the player left and right
        horizantalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * playerSpeed * Time.deltaTime * horizantalInput);

        /// this is for Food Shooting when press space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food, transform.position, Quaternion.identity);
        }

    }



}
