using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;        
    public Vector3 zoom;         
    public float Speed = 5f;  

    void Start()
    {
       
    
    }

    void Update()
    {
        
        Vector3 targetPosition = target.position + zoom;
        transform.position = Vector3.Lerp(transform.position, targetPosition,Speed * Time.deltaTime);
    }
}
