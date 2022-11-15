using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject[] multipleEnemys;
    public Transform closestEnemy;
    public bool enenmyContact;
    public List<GameObject> enemyInRange;
    public CircleCollider2D attackRange;
    // Start is called before the first frame update
    void Start()
    {
        enemyInRange = new List<GameObject>();
        attackRange = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            enemyInRange.Add(collision.gameObject);
        }
    }
    public Transform getClosestEnemy()
    {
        multipleEnemys = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = Mathf.Infinity;
        Transform trans = null;

        foreach(GameObject go in multipleEnemys)
        {
            float currentDistance;
            currentDistance = Vector3.Distance(transform.position, go.transform.position);
            if (currentDistance < closestDistance)
            {
                trans = go.transform;
            }
        }

        return trans;
    }

   public void ShootTarget()
    {
        Destroy(enemyInRange.Remove())
    }

}
