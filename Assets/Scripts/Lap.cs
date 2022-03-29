using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lap : MonoBehaviour
{


    [SerializeField] AudioClip lapSound;
    [SerializeField] new ParticleSystem particleSystem;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(lapSound);
            particleSystem.Play();
            Debug.Log("Play is gonna loop around!");
            transform.position = new Vector3(0, 27, 0);
        }
    }
}
