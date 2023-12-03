using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    private float xRotation = 0.0f;
    public float mouseSensivity = 100f;
    public GameObject oyuncu;


    // Update is called once per frame
    void Update()
    {
       
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0); oyuncu.transform.Rotate(Vector3.up *mouseX);








    }
}
