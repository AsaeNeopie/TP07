using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerCLass", menuName = "PC/PlayerDPS", order =1)]
public class PlayerClass : ScriptableObject
{
    public float speed = 4;
    public int healthPoint = 50;
    public float timeBeatwingShoot = 0.3f;
    public int degats = 2;
}
