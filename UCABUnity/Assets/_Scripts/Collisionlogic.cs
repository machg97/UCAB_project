using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionlogic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        //mi rtenderer
        renderer.color = Color.red;


        //el otro renderer
        // other.GetComponent<SpriteRenderer>().color = Color.blue;

        Destroy(other.gameObject);


        Debug.Log("triggerEnter");
    }

 
}
