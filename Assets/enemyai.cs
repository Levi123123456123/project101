using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent meshagent;
    public List<Transform> points;
    public Playercontroller player;
    private bool playernoticed;
    public float FOV;
    void Start()
    {
        meshagent = GetComponent<NavMeshAgent>();
        hiu();
    }

    // Update is called once per frame
    void Update()
    {
        //пусть будет тут, не вижу смысла переносить вниз
        var direction = player.transform.position - transform.position;
        playernoticed =  false;
        if (Vector3.Angle(transform.forward, direction)<FOV/2)
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position + Vector3.up, direction, out hit))
            {
                if(hit.collider.gameObject == player.gameObject)
                {
                    playernoticed = true;
                }
            }
        }
        if (playernoticed==true)
            {
                meshagent.destination = player.transform.position;
            }
        else
        {
            if(meshagent.remainingDistance == 0)
            {
                hiu();
            }
        }

    }
    private void hiu()
    {
        meshagent.destination = points[Random.Range(0, points.Count)].position;
    }
}
