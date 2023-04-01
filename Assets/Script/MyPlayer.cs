using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    [SerializeField] float speed;
    bool move;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
            move = true;
        }
        else move = false;

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(speed, 0, 0);
            move = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(0, 0, -speed);
            move = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(0, 0, speed);
            move = true;
        }



        if (move == false)
        {
            rb.velocity = Vector3.zero;
        }
    }
}
