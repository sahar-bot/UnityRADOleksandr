using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class ZombieControlScript : MonoBehaviour
{
    CubeControl player;
    Animator zombieAnimator;
    enum ZombieState { Idle, Attack, Follow}
    ZombieState currentlyIs = ZombieState.Idle;
    private float aggroRadius = 30;
    private float walkingSpeed = 0.2f;
    private float meleeDistance = 2;

    // Start is called before the first frame update
    void Start()
    {
        zombieAnimator = GetComponent<Animator>();
        player = FindObjectOfType<CubeControl>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentlyIs)
        {
            case ZombieState.Idle:
                if (Vector3.Distance(player.transform.position, transform.position) < aggroRadius)
                {
                    currentlyIs = ZombieState.Follow;
                    zombieAnimator.SetBool("isWalking", true);
                }
                
                break;

                case ZombieState.Attack:

                break;

                case ZombieState.Follow: 
                    transform.LookAt(player.transform.position);
                    transform.position = player.transform.position * walkingSpeed * Time.deltaTime;

                if (Vector3.Distance(player.transform.position, transform.position) < meleeDistance)
                    currentlyIs = ZombieState.Attack;
                
                break;
        }


        if (Input.GetKey(KeyCode.Space))
            zombieAnimator.SetBool("isWalking", true);
        else
            zombieAnimator.SetBool("isWalking", false);

    }
}
