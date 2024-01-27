using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;

public class EnnemiesController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Rigidbody2D rigidbodyEnnemie;
    public EnemmiesClass Class; 

    private void Start()
    {
        rigidbodyEnnemie = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

  
}
