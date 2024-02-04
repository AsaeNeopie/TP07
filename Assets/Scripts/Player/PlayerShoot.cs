using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
 
    public GameObject bullletBasic;
    public GameObject crossHair;
    public int speedBullet;
    
    void BulletShoot()
    {
        Instantiate(bullletBasic, transform.position, transform.rotation);
        Vector2 bulletVelocity = new Vector2(crossHair.transform.position.x - transform.position.x, crossHair.transform.position.y - transform.position.y);
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            BulletShoot();
        }
    }
}
