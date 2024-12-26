using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Setting")]
    public GameObject[] buildings;

    public float randomDevitation = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Spawn", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject spawnObject = buildings[Random.Range(0, buildings.Length)];

        Instantiate(spawnObject, transform.position, Quaternion.identity);

        Invoke("Spawn", 1.0f + Random.RandomRange(-randomDevitation, +randomDevitation));
    }
}
