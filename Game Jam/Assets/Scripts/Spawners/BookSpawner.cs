using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookSpawner : MonoBehaviour
{
    //This prefab books is set manually from the unity editor
    public GameObject[] bookPrefabs;
    //This is how long it takes before we start clocks
    public float spawnDelay = 2.0f;
    //This is how many seconds it is between each time we spawn a clock
    public float spawnInterval = 2.0f;
    //These help us decide the position of the clock to spawn
    public float maxSpawnX = 130.0f;
    public float minSpawnX = 10.0f;
    public float maxSpawnZ = 60.0f;
    public float minSpawnZ = 10f;
    public float spawnPosY = 25.0f;
    //These are vairables which we will use to track how many books are in the scene already
    private GameObject[] numberOfBooks;
    public int maxBooks = 5;

    // Start is called before the first frame update
    void Start()
    {
        //When the game starts then we starts spawning enemies from the array assigned every spawnInterval number of seconds
        InvokeRepeating("SpawnBook", spawnDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

    }
    //We will spawn a clock at a random x and z position, the y will always be the same
    void SpawnBook()
    {
        numberOfBooks = GameObject.FindGameObjectsWithTag("Book");
        if (numberOfBooks.Length <= maxBooks)
        {
            int bookIndex = Random.Range(0, bookPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(minSpawnX, maxSpawnX), spawnPosY, Random.Range(minSpawnZ, maxSpawnZ));
            Instantiate(bookPrefabs[bookIndex], spawnPos, bookPrefabs[bookIndex].transform.rotation);
        }
    }

}

/*Note from Daniel:  To make this script work we must maually assign a prefab to spawn from the unity editor.
 * The assigned prefab will be what the spawner creates.
 * We can use this same spawner scripts to spawn benificial items as well.  They would only spawn in a certain position though.*/



