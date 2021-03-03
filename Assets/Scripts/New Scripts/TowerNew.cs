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
        quickTimer++;

        if (level == levelCounter)
        {
            GetComponent<SpriteRenderer>().sprite = levels[level];
            stats.speed -= 10;
            stats.cost += 5;
            cost = stats.cost;
            speed = stats.speed;
            levelCounter++;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("enemy sighted");

            if (quickTimer >= speed)
            {
                Debug.Log("firing");
                int randomIndex = Random.Range(0, 4);
                GetComponent<AudioSource>().PlayOneShot(firing);
                GameObject bulletsSpawn = Instantiate(bullets[randomIndex], transform.position, transform.rotation);
                quickTimer = 0f;
            }
        }
    }
}
