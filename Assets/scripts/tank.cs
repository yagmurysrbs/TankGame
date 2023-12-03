using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public float harekethýzý = 5.0f;

    public float dönüshýzý = 120.0f;

    public GameObject[] sagtekerlekler;
    public GameObject[] soltekerlekler;
    public float tekerleklerindönüshýzý= 200.0f;

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

        tekerlekdöndür(hareketgiris, rotasyon);
        tankýdöndür(rotasyon);
    }


    private void FixedUpdate()
    {
        tankhareketObj(hareketgiris);
    }

    void tankhareketObj (float input )
    {
        Vector3 hareketyönü = transform.forward * input * harekethýzý * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + hareketyönü);
    
    
    
    }

    void tankýdöndür(float input )
    
    {

        float rotasyon = input * dönüshýzý * Time.fixedDeltaTime;
        Quaternion turnrotation = Quaternion.Euler(0.0f, rotasyon, 0.0f);
        rb.MoveRotation(rb.rotation * turnrotation);
    
    }

    void tekerlekdöndür(float hareketgiris, float rotasyon)
    {

        float tekerlekdönme = hareketgiris * tekerleklerindönüshýzý * Time.deltaTime;
        foreach (GameObject wheel in soltekerlekler)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(tekerlekdönme - rotasyon * tekerleklerindönüshýzý * Time.deltaTime, 0.0f, 0.0f);


            }
        
        }

        foreach (GameObject wheel in sagtekerlekler)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(tekerlekdönme +rotasyon* tekerleklerindönüshýzý * Time.deltaTime, 0.0f, 0.0f);


            }

        }




    }


}
