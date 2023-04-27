using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrushDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Surface"){
            Debug.Log("Oh no i will choke in the snow.");
        }
    }
}
