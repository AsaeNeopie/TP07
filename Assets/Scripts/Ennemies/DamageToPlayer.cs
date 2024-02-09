using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
    public EnemmiesClass ennemieClass;
    private int degatsToPlayer;
    public float recul;
    private void Awake()
    {
        degatsToPlayer = ennemieClass.degats;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerHealth>().ApplyDammages(degatsToPlayer);

            other.GetComponent<Rigidbody2D>().AddForce((transform.position-other.transform.position).normalized*recul);
        }
    }
}
