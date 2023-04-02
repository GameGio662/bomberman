using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    [SerializeField] float speed;

    bool move;
    Vector3 pos;

    Rigidbody rb;

    void Start()
    {
        pos = transform.position;
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
        else
        {
            move = false;
        }

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
            if (pos.z % 1 != 0)
                Mathf.Round(pos.z);

            if (pos.x % 1 != 0)
                Mathf.Round(pos.x);

            rb.velocity = Vector3.zero;
            rb.inertiaTensor = Vector3.zero;
        }
    }
}
