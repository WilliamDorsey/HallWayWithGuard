using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawner : MonoBehaviour
{
    float spawnX;
    float spawnY;
    float spawnZ;
    Vector3 upperBound;
    Vector3 lowerBound;
    Vector3 startPos;
    public GameObject marker1;
    public GameObject marker2;
    public Transform UpperMarker;
    public Transform LowerMarker;
    public Transform Key;

    // Start is called before the first frame update
    void Start()
    {
        //Spawn Height
        spawnY = UpperMarker.position.y;

        //Spawn Coords
        spawnX = Random.Range(UpperMarker.position.x,LowerMarker.position.x);
        spawnZ = Random.Range(UpperMarker.position.z, LowerMarker.position.z);

        //Create vector and set key to its position
        startPos = new Vector3(spawnX,spawnY,spawnZ);
        Key.position = startPos;

        //Make spawn markers invisible
        marker1.GetComponent<MeshRenderer>().enabled = false;
        marker2.GetComponent<MeshRenderer>().enabled = false;

    }
}
