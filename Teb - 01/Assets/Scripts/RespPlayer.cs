using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespPlayer : MonoBehaviour
{
    [SerializeField] Transform StartPosition;
    private float FallRespawn = -10f;
    private void Start()
    {
        Respawn();
    }
    private void Update()
    {
        if (transform.position.y < FallRespawn)
        {

            Respawn();

        }
    }

    public void Respawn()
    {
        Debug.Log("Respawn");
        transform.position = StartPosition.position;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        
    }
}
