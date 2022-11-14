using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    
    public Vector3 direction;
    public Animator anima;

    private void Start()
    {
        
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        direction = new Vector3(horizontal, vertical);
        this.transform.position += direction * speed * Time.deltaTime;
        AnimateMovement(direction);
    }

    void AnimateMovement(Vector3 direction)
    {
        if(anima !=null)
        {
            if (direction.magnitude > 0)
            {
                
                anima.SetFloat("horzontal", direction.x);
                anima.SetFloat("vertical", direction.y);

            }
        }
    }

    
}
