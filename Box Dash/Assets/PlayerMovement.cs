using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 0f;
    public float sidewaysForce = 0f;
    void Start()
    {
        //Bu script ilk baþladýðýnda 1 kere start metodu çalýþýr
        //genellikle scriptin baþlangýç ayarlarýnýn yapýldýðý yerdir.
        //Debug.Log("Hello World");//Unitiy içerisindeki konsol'a bilgi yazdýrmak için kullanýlýr
        //rb.useGravity = false;RigidBody Nesnesinin Yerçekiminden etkilenmesini kapattýk
        //rb.AddForce(0, 200, 500);
    }

    void Update()
    {
        //Her FPS(FRAME PER SECOND) frame de çalýþýr
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        //if (Input.GetKey("w"))
        //{
        //    rb.AddForce(0, 50 , 0);
        //}
    }
}
