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
        Behavior();
    }

    void Update()
    {
        if (transform.position.y >= 6 || transform.position.y < -6)
        {
            Debug.Log("dead");
            EnemySpawnNew.deaths++;
            Destroy(gameObject);
        }
        if (transform.position.x >= 9 || transform.position.x < -9)
        {
            Debug.Log("dead");
            EnemySpawnNew.deaths++;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            GetComponent<AudioSource>().PlayOneShot(hit);
            Debug.Log("dead");
            EnemySpawnNew.deaths++;
            Destroy(gameObject);
        }
    }

    public virtual void Behavior()
    {
        Debug.Log("Set Speed");
    }
}
