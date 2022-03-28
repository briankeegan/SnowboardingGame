using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] new ParticleSystem particleSystem;
    private void Restart()
    {
        // SceneManager.LoadScene(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            particleSystem.Play();
            Debug.Log("Ouch!");
            // Add small delay
            Invoke("Restart", 01f);
        }
    }
}
