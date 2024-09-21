using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //Collision collisionInfo Dokunulan ner Nesnenin collision bilgisi
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Debug.Log("Engel'e Dokunduk!");
            movement.enabled = false;
        }
    }
}
