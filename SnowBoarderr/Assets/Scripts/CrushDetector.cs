using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrushDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Surface")
        {
            crashEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
