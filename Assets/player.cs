using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // public : on y accede de partout
    public float speed = 10f;
    new Rigidbody2D rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;
        
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput += 1;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            horizontalInput -= 1;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            verticalInput += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            verticalInput -= 1;
        }
        rigidbody.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
        Vector2 position = new Vector2(transform.position.x, transform.position.y);
}
    /*
    public static Vector2 GetPosition(Rigidbody2D rigidbody)
    {
        return rigidbody.position;
    }*/
}
