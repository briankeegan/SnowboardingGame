using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    private void Restart()
    {
        // SceneManager.LoadScene(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("Ouch!");
            // Add small delay
            Invoke("Restart", 0.5f);
        }
    }
}
