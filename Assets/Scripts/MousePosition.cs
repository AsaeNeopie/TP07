using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    Vector3 posMouse;

    public void Awake()
    {
        
    }
    void Update()
    {
       posMouse.z = 0;
        posMouse = Input.mousePosition;
        gameObject.transform.position = posMouse;
    
    }
}
