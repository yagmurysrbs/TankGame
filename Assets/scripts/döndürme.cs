using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class döndürme : MonoBehaviour
{
    public float döndürmehızı = 90.0f;
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, döndürmehızı * Time.deltaTime);
        
        
        }
        if (Input.GetKey(KeyCode.E))
        {

            transform.Rotate(Vector3.up, -döndürmehızı * Time.deltaTime);



        }





    }
}
