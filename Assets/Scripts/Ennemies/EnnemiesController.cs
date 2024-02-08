using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;

public class EnnemiesController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Rigidbody2D rigidbodyEnnemie;
    public EnemmiesClass Class;
    public int hpEnemie;

    private void Awake()
    {
        hpEnemie = Class.healthPoint;
    }

    private void Start()
    {
        rigidbodyEnnemie = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            hpEnemie -- 2;
            Debug.Log(hpEnemie);
        }
        
    }

    private void Update()
    {
        if (hpEnemie == 0) 
        {
            Destroy(gameObject);
        }
    }
}
