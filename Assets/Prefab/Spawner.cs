using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public int initial;
    public float minFrequency = 5;
    public float maxFrequency = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initial; i++)
        {
            Instantiate(prefab, this.transform.position, Quaternion.identity);
        }
        
        Spawn();
    }

    void Spawn()
    {
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minFrequency, maxFrequency));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
