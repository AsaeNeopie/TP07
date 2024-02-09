using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthPointText;
    private int hpPlayer;
    public PlayerClass playerClass;
    private void Awake()
    {
        hpPlayer = playerClass.healthPoint;
    }

    void Update()
    {
        healthPointText.text = ("HP: " + hpPlayer);
        if (hpPlayer == 0)
        {
            Destroy(gameObject);
        }
    }

    void ApplyDammages(int degatToPlayer)
    {
        hpPlayer -= degatToPlayer;
    }
}
