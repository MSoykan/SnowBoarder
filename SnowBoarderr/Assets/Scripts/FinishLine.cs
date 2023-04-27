using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float finishDelay = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Invoke("ReloadScene", finishDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
