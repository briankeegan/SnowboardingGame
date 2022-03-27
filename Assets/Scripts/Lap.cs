using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("Play is gonna loop around!");
            transform.position = new Vector3(0, 27, 0);
        }
    }
}
