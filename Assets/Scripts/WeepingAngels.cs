using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;

public class WeepingAngels : MonoBehaviour
{
    [SerializeField] private NavMeshAgent ai;
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 dest;
    [SerializeField] private Camera playerCam;
    [SerializeField] private float aiSpeed, catchDistance;
    [SerializeField] private Renderer angelModelRenderer;
    [SerializeField] private AudioSource scratchSound;

    private void Update()
    {
        AngelMovement();
    }


    private void AngelMovement()
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(playerCam);

        float distance = Vector3.Distance(transform.position, player.position);

        if (GeometryUtility.TestPlanesAABB(planes, angelModelRenderer.bounds))
        {
            ai.speed = 0;
            ai.SetDestination(transform.position);

            if (scratchSound.isPlaying)
            {
                scratchSound.Stop();
            }
        }
        else
        {
            ai.speed = aiSpeed;
            dest = player.position;
            ai.destination = dest;

            if (!scratchSound.isPlaying)
            {
                scratchSound.Play();
            }

            if (distance <= catchDistance)
            {
                Debug.Log("öldün");
            }
        }
    }

    private void OnDestroy()
    {
        Debug.Log("patladım");
    }
}
