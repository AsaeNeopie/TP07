using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MooveBullet : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera cam;
    private Rigidbody2D rigibody;
    public float force;
    public float destroyBullet;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rigibody = GetComponent<Rigidbody2D>();
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rigibody.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,rot);
        Destroy(gameObject, destroyBullet);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ennemies")
        {
            Destroy(gameObject);
        }
    }

}
