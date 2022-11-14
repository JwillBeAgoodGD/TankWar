using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject[] multipleEnemys;
    public Transform closestEnemy;
    public bool enenmyContact;
    public GameObject bulletPrefab;
    public GameObject bulletLaunchPoint;
    // Start is called before the first frame update
    void Start()
    {
        closestEnemy = null;
        enenmyContact = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        closestEnemy = getClosestEnemy();
        closestEnemy.gameObject.GetComponent<SpriteRenderer>().material.color = new Color(1, 0.7f, 0, 1);
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

   public void ShootBullet()
    {
        if (Input.anyKeyDown)
        {
            Instantiate(bulletPrefab, bulletLaunchPoint.transform.position, bulletPrefab.transform.rotation);
        }
    }

}
