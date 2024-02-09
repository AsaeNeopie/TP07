using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToPlayer : MonoBehaviour
{
    public EnemmiesClass ennemieClass;
    private int degatsToPlayer;
    public GameObject player;
    private void Awake()
    {
        degatsToPlayer = ennemieClass.degats;
    }
   private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.tag == "Player")
        {
            player.SendMessage("ApplyDammages", degatsToPlayer);
        }
    }
}
