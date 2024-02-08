using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "EnnemiesClass", menuName = "EC/EnnemieBasic", order = 1)]
public class EnemmiesClass : ScriptableObject
{
    public float speed = 2f;
    public int healthPoint = 4;
    public int degats = 2;
}
