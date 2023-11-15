using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Purchasing;

public class CubeControl : MonoBehaviour
{
    public Transform footballCloneTemplate;
    private float walkingSpeed = 0.5f;
    public int balls = 25;
 
    // Start is called before the first frame update
    void Start()
    { 
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
            walkingSpeed = 3;
          else walkingSpeed = 0.5f;
        

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * walkingSpeed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.S)) {
            transform.position -= transform.forward * walkingSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position += (new Vector3(1, 0, 0)) * walkingSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += (new Vector3(-1, 0, 0)) * walkingSpeed* Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.R))

            transform.Rotate(Vector3.up, 45 * Time.deltaTime);
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up, -45 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (balls > 0)
            {
                Transform newBall = Instantiate(footballCloneTemplate, transform.position + 2 * transform.forward, Quaternion.identity);
                BallControlScript myNewBallScript = newBall.GetComponent<BallControlScript>();
                myNewBallScript.Kickball(transform);
                balls -= 1;
                print(balls);
                
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.rotation = Quaternion.Euler(0,transform.rotation.y,0);
        }


    }
        

    }

