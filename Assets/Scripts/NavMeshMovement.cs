using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");

        GameObject nearestObject = obstacles[0];
        float distanceToNearest = Vector3.Distance(transform.position, nearestObject.transform.position);

        for (int i = 1; i < obstacles.Length; i++)
        {
            float distanceToCurrent = Vector3.Distance(transform.position, obstacles[i].transform.position);

            if (distanceToCurrent < distanceToNearest)
            {
                nearestObject = obstacles[i];
                distanceToNearest = distanceToCurrent;
            }
        }

        agent.destination = nearestObject.transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
