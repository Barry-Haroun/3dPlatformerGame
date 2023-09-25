using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform player;
    public GameObject bullets;

    private float shotCooldown;
    public float startShotCooldown;

    private float dist;
    public float speed;
    public float howClose;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        shotCooldown = startShotCooldown;
    }

    private void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);
        if (dist <= howClose ) 
        { 
            transform.LookAt(player);
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        }
       // Vector3 direction = new Vector3(player.position.y - transform.position.y, player.position.x - transform.position.x);
       // transform.forward =  direction;

        if (shotCooldown <= 0) 
        {
            Instantiate(bullets, transform.position, transform.rotation);
            shotCooldown = startShotCooldown; 
        }
        else
        {
            shotCooldown -= Time.deltaTime;
        }
    }
}

