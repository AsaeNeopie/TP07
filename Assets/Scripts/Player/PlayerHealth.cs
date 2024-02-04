using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthPointText;
    private int hpPlayer;
    public GameObject playerDps;
    private void Awake()
    {

         hpPlayer = playerDps
    }

    void Update()
    {
        healthPointText.text = ("HP: " + hpPlayer);
        if (hpPlayer == 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Ennemies")
        {
            Debug.Log("Touché");
            hpPlayer -= 2;
        }
    }
}
