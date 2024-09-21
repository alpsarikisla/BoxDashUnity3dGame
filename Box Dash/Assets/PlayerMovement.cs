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
        //Bu script ilk ba�lad���nda 1 kere start metodu �al���r
        //genellikle scriptin ba�lang�� ayarlar�n�n yap�ld��� yerdir.
        //Debug.Log("Hello World");//Unitiy i�erisindeki konsol'a bilgi yazd�rmak i�in kullan�l�r
        //rb.useGravity = false;RigidBody Nesnesinin Yer�ekiminden etkilenmesini kapatt�k
        //rb.AddForce(0, 200, 500);
    }

    void Update()
    {
        //Her FPS(FRAME PER SECOND) frame de �al���r
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
