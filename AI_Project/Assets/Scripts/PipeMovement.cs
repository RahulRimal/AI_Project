using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float pipeSpeed = 2f;
    public float maxPipeSpeed = 7f;


    void Update()
    {
        transform.Translate(Vector2.left * pipeSpeed * Time.deltaTime);
        Invoke("distroyPipes", 3.3f);
    }


    void distroyPipes()
    {
        Destroy(gameObject);
    }




}
