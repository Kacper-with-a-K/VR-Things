using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class  Waypoints
{
    public GameObject waypoint;

    public bool spotted;

    public GameObject player;

    public float time;

}
public class AI : MonoBehaviour
{
    public GameObject target;

    //public GameObject trap;

    public enum Spider
    {
        Spotted,
        Patrol,
        Trap
    };

    public Spider state = Spider.Patrol;

    public Waypoints[] waypoint_Pattern;

    private int patternIndex = 0;

    public float speed = 1;

    


    // Start is called before the first frame update
    void Start()
    {
        state = Spider.Patrol;
    }

    // Update is called once per frame
    void Update()
    {
        float speedDelta = (speed * Time.deltaTime);
        switch (state)
        {
            case Spider.Patrol:
                Waypoints waypointsCD = waypoint_Pattern[patternIndex];
                Vector3 rangeToClose = waypointsCD.waypoint.transform.position - transform.position;
                Debug.DrawRay(transform.position, rangeToClose, Color.green);
                float distance = rangeToClose.magnitude;

                if (distance <= speedDelta)
                {
                    patternIndex++;

                    if (patternIndex >= waypoint_Pattern.Length)
                    {
                        patternIndex = 0;
                    }

                    waypointsCD = waypoint_Pattern[patternIndex];

                    rangeToClose = waypointsCD.waypoint.transform.position - transform.position;
                }
                Vector3 normalizedRangeToClose = rangeToClose.normalized;

                Debug.DrawRay(transform.position, normalizedRangeToClose, Color.red);
            break;
        }

    }
}
