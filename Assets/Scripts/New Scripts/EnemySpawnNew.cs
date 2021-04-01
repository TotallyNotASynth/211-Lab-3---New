using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawnNew : MonoBehaviour
{
    public GameObject[] enemies;
    float timeCheck = 0f;

    public static int waveNum = 1;
    int nextWave = 10;
    public static int deaths = 0;
    int spawned = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Logs number for text
        deaths = 0;
        waveNum = 1;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //Checks time 
        timeCheck += Time.deltaTime;
        //Checks if the amount of enemies spawned is less than what is required for a wave
        if (spawned < nextWave)
        {
            //checks if its time to spawn an enemy
            if (timeCheck >= 0.5f && spawned < nextWave)
            {
                //Logs spawn
                Debug.Log("spwan");
                //chooses which enemy generates
                int randomIndex = Random.Range(0, 3);
                //Generates enemy
                GameObject bulletsSpawn = Instantiate(enemies[randomIndex], transform.position, transform.rotation);
                //resets time
                timeCheck = 0;
                //Lists enemy as spawned
                spawned++;
            }
        }
        //Changes wave
        else
        {
            //gives breathing room between waves
            if (timeCheck >= 5f)
            {
                //Logs total enemy spawns this wave
                Debug.Log(deaths);
                //Logs wave num
                waveNum++;
                //Sets amount of enemies per wave
                nextWave = waveNum * 10;
                //logs the next wave is starting
                Debug.Log("next");
                //resets the amount of deaths/spawned for this wave
                deaths = 0;
                spawned = 0;
            }
        }
        //ends game
        if (waveNum > 10)
        {
            SceneManager.LoadScene("End");
        }
    }
}