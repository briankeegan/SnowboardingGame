using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour
{

    // This way drag and drop, 
    // [SerializeField] ParticleSystem particleSystem;
    ParticleSystem dustParticles;

    private void Start()
    {
        // This way through code.
        dustParticles = GameObject.Find("Dust").GetComponent<ParticleSystem>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustParticles.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            dustParticles.Stop();
        }
    }
}
