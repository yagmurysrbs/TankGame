using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class döndürme : MonoBehaviour
{
    public float döndürmehýzý = 90.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, döndürmehýzý * Time.deltaTime);
        
        
        }
        if (Input.GetKey(KeyCode.E))
        {

            transform.Rotate(Vector3.up, -döndürmehýzý * Time.deltaTime);



        }





    }
}
