using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public float hareketh�z� = 5.0f;

    public float d�n�sh�z� = 120.0f;

    public GameObject[] sagtekerlekler;
    public GameObject[] soltekerlekler;
    public float tekerleklerind�n�sh�z�= 200.0f;

    private Rigidbody rb;
    private float hareketgiris;
    private float rotasyon;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        hareketgiris = Input.GetAxis("Vertical");
        rotasyon = Input.GetAxis("Horizontal");

        tekerlekd�nd�r(hareketgiris, rotasyon);
        tank�d�nd�r(rotasyon);
    }


    private void FixedUpdate()
    {
        tankhareketObj(hareketgiris);
    }

    void tankhareketObj (float input )
    {
        Vector3 harekety�n� = transform.forward * input * hareketh�z� * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + harekety�n�);
    
    
    
    }

    void tank�d�nd�r(float input )
    
    {

        float rotasyon = input * d�n�sh�z� * Time.fixedDeltaTime;
        Quaternion turnrotation = Quaternion.Euler(0.0f, rotasyon, 0.0f);
        rb.MoveRotation(rb.rotation * turnrotation);
    
    }

    void tekerlekd�nd�r(float hareketgiris, float rotasyon)
    {

        float tekerlekd�nme = hareketgiris * tekerleklerind�n�sh�z� * Time.deltaTime;
        foreach (GameObject wheel in soltekerlekler)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(tekerlekd�nme - rotasyon * tekerleklerind�n�sh�z� * Time.deltaTime, 0.0f, 0.0f);


            }
        
        }

        foreach (GameObject wheel in sagtekerlekler)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(tekerlekd�nme +rotasyon* tekerleklerind�n�sh�z� * Time.deltaTime, 0.0f, 0.0f);


            }

        }




    }


}
