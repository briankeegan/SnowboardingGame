using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour
{

    // particle sysetm with get
    [SerializeField] ParticleSystem particleSystem;
    // ParticleSystem dustParticles;

    // private void Start()
    // {
    //     dustParticles = GetComponent<ParticleSystem>();
    // }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            particleSystem.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            particleSystem.Stop();
        }
    }
}
