using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Purchasing;

public class CubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += transform.forward;
        }
        else if (Input.GetKeyDown(KeyCode.S)) {
            transform.position -= transform.forward;
                }
        else if (Input.GetKeyDown(KeyCode.D)) {
            transform.position += (new Vector3(-1, 0, 0));
                }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += (new Vector3(1, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.R))

            transform.Rotate(Vector3.up, 45);
        if (Input.GetKeyDown(KeyCode.Q))
            transform.Rotate(Vector3.up, -45);
        

        

    }
}
