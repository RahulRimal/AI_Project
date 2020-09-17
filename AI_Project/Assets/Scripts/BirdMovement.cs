using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    Rigidbody2D rb;
    Transform transform;
    
    public float jumpForce = 0f;
    [SerializeField]
    KeyCode keyUp;

    Quaternion upAngle = Quaternion.Euler(0, 0, 45f);
    public float upTurningRate = 100f;

    Quaternion downAngle = Quaternion.Euler(0, 0, -60f);
    public float downTurningRate = 150f; 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }


    void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            rb.velocity = new Vector2(0, jumpForce * Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, upAngle, upTurningRate * Time.deltaTime);
        }

        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, downAngle, downTurningRate * Time.deltaTime);
        }
    }


}
