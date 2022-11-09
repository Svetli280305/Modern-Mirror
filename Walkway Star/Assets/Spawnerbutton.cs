using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerbutton : MonoBehaviour
{
    public Transform parent;
    public Transform spawnPoint;
    public GameObject[] objectToSpawn;
    public Transform canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clicked ()
    {
        int selection = Random.Range(0, objectToSpawn.Length);
        Instantiate(objectToSpawn[selection], spawnPoint.position, Quaternion.identity, parent);
        Debug.Log("Clicky");

    }
}
