using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNew : MonoBehaviour
{
    Rigidbody2D rbs;

    public AudioClip hit;
    // Start is called before the first frame update
    void Start()
    {
        //Calls the different behaviors based on enemy type
        Behavior();
    }

    void Update()
    {
        if (transform.position.y >= 6 || transform.position.y < -6)
        {
            //Destroies obj if it goes off screen.
            Debug.Log("dead");
            EnemySpawnNew.deaths++;
            Destroy(gameObject);
        }
        if (transform.position.x >= 9 || transform.position.x < -9)
        {
            //Destroies obj if it goes off screen.
            Debug.Log("dead");
            EnemySpawnNew.deaths++;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            //plays sound on bullet hit
            GetComponent<AudioSource>().PlayOneShot(hit);
            //logs death and destroies obj
            Debug.Log("dead");
            EnemySpawnNew.deaths++;
            Destroy(gameObject);
        }
    }

    public virtual void Behavior()
    {
        //The void connected to the other scripts
        Debug.Log("Set Speed");
    }
}
