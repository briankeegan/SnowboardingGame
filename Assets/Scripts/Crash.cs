using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    bool hasPlayed = false;
    private void PlaySoundOnce(AudioSource audioSource)
    {
        if (!hasPlayed)
        {
            audioSource.Play();
            hasPlayed = true;
        }
    }
    [SerializeField] new ParticleSystem particleSystem;

    private void Restart()
    {
        // SceneManager.LoadScene(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<PlayerController>().EnableController();
        hasPlayed = false;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableController();
            AudioSource crashSound = GetComponent<AudioSource>();
            PlaySoundOnce(crashSound);
            particleSystem.Play();
            Debug.Log("Ouch!");
            // Add small delay
            Invoke("Restart", 01f);
        }
    }
}
