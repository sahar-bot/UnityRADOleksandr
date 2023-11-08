using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallControlScript : MonoBehaviour
{
    Rigidbody rb;
    float kickStrenght = 4;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Kickball(Transform kicker)
    {
        rb.AddForce(kickStrenght * kicker.forward, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane"   ) 
        {
            print("Boing!");
        }
        else 
        {
            print("Ouch!");
            Kickball(collision.transform);
         }

        print("Hello World!");
    }
}
