using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerNew : MonoBehaviour
{
    float quickTimer = 0f;
    public GameObject[] bullets;
    public AudioClip firing;

    public Sprite[] levels;
    public int cost;
    public static int level = 0;
    int levelCounter = 1;
    private TowerLevel stats;
    public float speed = 110f;

    private void Start()
    {
        stats = new TowerLevel();
    }

    void FixedUpdate()
    {
        //Sets time
        quickTimer++;
        // changes stats on upgrade
        if (level == levelCounter && level < 10)
        {
            //Changes sprite
            GetComponent<SpriteRenderer>().sprite = levels[level];
            //changes attack speed
            stats.speed -= 10;
            //changes tower cost
            stats.cost += 5;
            //logs stats
            cost = stats.cost;
            speed = stats.speed;
            //changes level counter to next lv
            levelCounter++;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //temp check for enemy
        if (collision.gameObject.tag == "enemy")
        {
            //logs enemy detection
            Debug.Log("enemy sighted");
            //launches attack
            if (quickTimer >= speed)
            {
                //logs attack
                Debug.Log("firing");
                //chooses bullet sprite
                int randomIndex = Random.Range(0, 4);
                //plays SFX
                GetComponent<AudioSource>().PlayOneShot(firing);
                //Spawns bullet
                GameObject bulletsSpawn = Instantiate(bullets[randomIndex], transform.position, transform.rotation);
                //Resets timer
                quickTimer = 0f;
            }
        }
    }
}
