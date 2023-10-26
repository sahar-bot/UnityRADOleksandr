using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Purchasing;

public class CubeControl : MonoBehaviour
{
    private float walkingSpeed = 1;
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {  walkingSpeed = 2; }
            else walkingSpeed = 1;
            transform.position += transform.forward * walkingSpeed *Time.deltaTime;
        }

       if (Input.GetKey(KeyCode.S)) {
            transform.position -= transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position += (new Vector3(-1, 0, 0)) * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (new Vector3(1, 0, 0)) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.R))

            transform.Rotate(Vector3.up, 45 * Time.deltaTime);
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up, -45 * Time.deltaTime);
        

        

    }
}
