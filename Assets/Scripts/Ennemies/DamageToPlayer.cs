using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
    public EnemmiesClass ennemieClass;
    private int degatsToPlayer;
    public GameObject player;
    public float recul;
    private void Awake()
    {
        degatsToPlayer = ennemieClass.degats;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            print(other.name);
            player.SendMessage("ApplyDammages", degatsToPlayer);
            player.GetComponent<Rigidbody2D>().AddForce((transform.position-player.transform.position).normalized*recul);
        }
    }
}