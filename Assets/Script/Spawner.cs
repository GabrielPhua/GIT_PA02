using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Tire;
    public GameObject Walrus;
    public GameObject Ice;
    public GameObject Barrel;

    public int spawnNumber;

    public float xOffset;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner",1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawner()
    {
        spawnNumber = Random.Range(1, 5);

        xOffset = Random.Range(-3, 3);
        
        if(spawnNumber == 1)
        {
            Instantiate(Tire, new Vector3(xOffset, 0.1f, transform.position.z), Quaternion.identity);
        }
        if(spawnNumber == 2)
        {
            Instantiate(Walrus, new Vector3(xOffset, 0.1f, transform.position.z), Quaternion.identity);
        }
        if(spawnNumber ==3)
        {
            Instantiate(Ice, new Vector3(xOffset, 0.1f, transform.position.z), Quaternion.identity);
        }
        if(spawnNumber == 4)
        {
            Instantiate(Barrel, new Vector3(xOffset, 0.1f, transform.position.z), Quaternion.identity);
        }
    }
}
