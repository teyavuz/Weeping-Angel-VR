using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Angel;
    [SerializeField] private GameObject[] spawnPoints;


    void Start()
    {
        SpawnAtOnce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnAtOnce()
    {
        foreach (var item in spawnPoints)
        {
            Instantiate(Angel, item.transform.position, item.transform.rotation);
        }
    }
}
