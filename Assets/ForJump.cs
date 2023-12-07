using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForJump : MonoBehaviour
{
    float time = 0.0f;
    bool isMoving = false;
    bool isJumpPressed = false;

    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

 
    void Update()
    {
        isJumpPressed = Input.GetButtonDown("Jump");  //space tuşu 
    }

    void FixedUpdate()
    {
        if (isJumpPressed)
        {
            // the cube is going to move upwards in 10 units per second
            rb.velocity = new Vector3(0,5,0);
            isMoving = true;
            Debug.Log("Zıplama");
        }
        if (isMoving)
        {
            // when the cube has moved for 10 seconds, report its position
            time = time + Time.fixedDeltaTime;
            if(time > 10.0f)
            {
                Debug.Log(gameObject.transform.position.y + " : " + time);
                time = 0.0f;
            }
        }
    }
}
