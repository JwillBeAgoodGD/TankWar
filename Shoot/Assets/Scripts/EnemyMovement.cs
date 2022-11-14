using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    
    public float speed;

    public void FixedUpdate()
    {
        var moveSpeed = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
    }

   

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collWith = collision.gameObject;
        if (collWith.tag == "Player")
        {
            Destroy(this.gameObject);

            Debug.Log(1);
        }
    }


}
