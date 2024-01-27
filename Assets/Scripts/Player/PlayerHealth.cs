using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : PlayerController
{
    [SerializeField] TextMeshProUGUI healthPointText;
    private int hpPlayer;
 
    void Start()
    {
        
    }
    private void Awake()
    {
        hpPlayer = Class.healthPoint;
    }

    void Update()
    {
       healthPointText.text = ("HP: " + hpPlayer);
        if (hpPlayer == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ennemies")
        {
            Debug.Log("Touché");
            hpPlayer -= 2;
        }
    }
}
