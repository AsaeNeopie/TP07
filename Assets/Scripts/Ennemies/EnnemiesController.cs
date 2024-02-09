using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;

public class EnnemiesController : MonoBehaviour
{
    public GameObject player;
    private float speed;
    public Rigidbody2D rigidbodyEnnemie;
    public EnemmiesClass Class;
    public int hpEnemie;
    public int degatToPlayer;

    private void Awake()
    {
        hpEnemie = Class.healthPoint;
        speed = Class.speed;
        degatToPlayer = Class.degats;
    }

    private void Start()
    {
        rigidbodyEnnemie = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
   
    private void Update()
    {
        if (hpEnemie == 0) 
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            hpEnemie -= 2;
            Debug.Log(hpEnemie);
        }

       if (other.tag == "Player")
        {
            player.SendMessage("ApplyDammages", degatToPlayer);
        }
    }
}
