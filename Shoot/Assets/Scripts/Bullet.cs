using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Player player;
    public float speed;

    public Transform enemy;
    private Vector2 target;


    private void Start()
    {
        
        


    }

    private void Update()
    {

        enemy = player.closestEnemy;
        target = new Vector2(enemy.position.x, enemy.position.y);

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }

}
