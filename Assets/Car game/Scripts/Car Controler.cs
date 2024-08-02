using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarControler : MonoBehaviour
{
    private float carSpeed = 25;
    private float turnSpeed = 15;
    private float horizantalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizantalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        /// Move the car forward with Var seed
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed * verticalInput);
        /// Turn the car left And right 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizantalInput);
    }
}
