using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicScrewdriver : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Angel")
        {
            Debug.Log("Melek öldü");
            Destroy(other.gameObject);
        }
    }
}
