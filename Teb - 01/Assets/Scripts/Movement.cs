using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]float speed = 5.0f;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

   
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");  
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX,0f, moveY) * speed;

        rb.velocity = movement;
    }
}
