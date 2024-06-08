using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonicScrewdriver : MonoBehaviour
{
    [SerializeField] private ParticleSystem pSys;
    [SerializeField] private GameObject[] spawnpoints;
    [SerializeField] private GameObject Angel;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Angel")
        {
            Debug.Log("Melek öldü");
            Destroy(other.gameObject);
            pSys.Play();

            int randomSpawnPointNumber;

            randomSpawnPointNumber = UnityEngine.Random.Range(0, spawnpoints.Length);

            Instantiate(Angel, spawnpoints[randomSpawnPointNumber].transform.position, spawnpoints[randomSpawnPointNumber].transform.rotation);
        }
    }
}
