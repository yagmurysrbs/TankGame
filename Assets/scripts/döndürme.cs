using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d�nd�rme : MonoBehaviour
{
    public float d�nd�rmeh�z� = 90.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, d�nd�rmeh�z� * Time.deltaTime);
        
        
        }
        if (Input.GetKey(KeyCode.E))
        {

            transform.Rotate(Vector3.up, -d�nd�rmeh�z� * Time.deltaTime);



        }





    }
}
