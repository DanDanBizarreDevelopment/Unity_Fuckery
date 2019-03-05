using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public GameObject triggerPoint;
    public GameObject spawnPoint;
    public GameObject currObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (triggerPoint.transform.position.x >= currObject.transform.position.x)
        {
            currObject = Instantiate(currObject, new Vector3(spawnPoint.transform.position.x, Random.Range(spawnPoint.transform.position.y,
                triggerPoint.transform.position.y)), spawnPoint.transform.rotation); // New trigger point added when player passes trigger.
        }
    }
}