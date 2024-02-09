using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbodyPlayer;
    public PlayerClass Class;
   
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody2D>();
    }

    void  FixedUpdate()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);
        rigidbodyPlayer.velocity = movement * Class.speed;
  
    }
}
