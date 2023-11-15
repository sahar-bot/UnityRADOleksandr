using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class ZombieControlScript : MonoBehaviour
{
    CubeControl player;
    Animator zombieAnimator;
    enum ZombieState { Idle, Attack, Follow}
    ZombieState currentlyIs = ZombieState.Idle;
    private float aggroRadius = 100;
    private float walkingSpeed = 1;
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
                if (Vector3.Distance(player.transform.position, transform.position) > meleeDistance)
                {
                    currentlyIs = ZombieState.Follow;
                    zombieAnimator.SetBool("isAttacking", false);
                    zombieAnimator.SetBool("isWalking", true);
                }
                 

                break;

                case ZombieState.Follow:
                    Vector3 target = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
                    transform.LookAt(target);
                    transform.position += transform.forward * walkingSpeed * Time.deltaTime;

                if (Vector3.Distance(player.transform.position, transform.position) < meleeDistance)
                {
                    currentlyIs = ZombieState.Attack;
                    zombieAnimator.SetBool("isWalking", false);
                    zombieAnimator.SetBool("isAttacking", true);
                }
                break;
        }


    }

    internal void dieNow()
    {
        Destroy(gameObject);
    }
}
