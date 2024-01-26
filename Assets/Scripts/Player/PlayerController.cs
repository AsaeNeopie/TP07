using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2;
    Rigidbody2D rigidbodyPlayer;
    
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
    }

    void  FixedUpdate()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector3(x, y);
        rigidbodyPlayer.velocity = movement * speed;
    }
}
