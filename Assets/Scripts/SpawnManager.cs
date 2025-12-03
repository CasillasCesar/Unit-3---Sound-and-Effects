using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 sparnPos = new Vector3(25, 0, 0);

    private float startDelay = 2, repeatRate = 2;

    private PlayerController playerControllerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Instantiate(obstaclePrefab, sparnPos, obstaclePrefab.transform.rotation);
        InvokeRepeating("SpawnObstacle", startDelay,repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, sparnPos, obstaclePrefab.transform.rotation);
        }
    }
}
