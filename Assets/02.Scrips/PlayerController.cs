using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    Vector3 pos;
    public float minPos_x;
    public float maxPos_x;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveSpeed, 0, 0);
        }

        if(transform.position.x >= maxPos_x)
        {
            pos.x = maxPos_x;
            transform.position = pos;
        }

        if (transform.position.x <= minPos_x)
        {
            pos.x = minPos_x;
            transform.position = pos;
        }
    }
}
