using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject mushroom;

    private List<GameObject> shrooms;

    [SerializeField]
    private Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        shrooms = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(shrooms.Count < 3)
        {
            float xPos = Random.RandomRange(-3.5f, 3.5f);
            Vector3 newSpawn = new Vector3(spawnPos.x + xPos, spawnPos.y, spawnPos.z);
            shrooms.Add(Instantiate(mushroom, newSpawn, Quaternion.identity));
        }
    }
}
