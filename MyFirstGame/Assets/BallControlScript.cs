using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallControlScript : MonoBehaviour
{
    Rigidbody rb;
    float kickStrenght = 1000;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Kickball(Transform kicker)
    {
        rb.AddExplosionForce(kickStrenght, kicker.position, 4);
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
