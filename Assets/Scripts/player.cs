using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Vector3 v;
    public Vector3 h;


    // Update is called once per frame
    void FixedUpdate()
    {
      

        if (Input.GetKey(KeyCode.UpArrow))
        {
           
            rigidbody.transform.position += v;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.transform.position -= v;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {

            rigidbody.transform.position +=h ;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.transform.position -= h;
        }

        if (rigidbody.position.y < -5)
        {
            FindObjectOfType<GameManger>().endGame();
        }

    }
}
