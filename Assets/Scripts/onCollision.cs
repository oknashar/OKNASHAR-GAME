using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onCollision : MonoBehaviour
{
    public player movement;
    // Start is called before the first frame update
     void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "obstcal")
        {
            FindObjectOfType<GameManger>().endGame();
            movement.enabled = false;
           
        }
     
    }
}
