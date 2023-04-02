using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronWall : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mattone")
            Destroy(gameObject);
        if (collision.gameObject.tag == "Bordo")
            Destroy(gameObject);
    }
}
