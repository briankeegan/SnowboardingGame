using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lap : MonoBehaviour
{


    [SerializeField] new ParticleSystem particleSystem;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            particleSystem.Play();
            Debug.Log("Play is gonna loop around!");
            transform.position = new Vector3(0, 27, 0);
        }
    }
    // This is bad practice, but fuck it, I hate this game. Its just for learning!
}
