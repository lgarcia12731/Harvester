using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public float speed;
    public float dist;
    private float distMin = -25f;
    private float distMax = 25f;
    private Vector3 temp;



    // Start is called before the first frame update
    void Update()
    {
        Move();
    }
    

    //this will make the tree move
    private void Move()
    {
        if (transform.position.x >= -dist) 
        {
            temp = Vector3.left;
            SetRandomDirectionSwitch();
        }
        else
        {
            if (transform.position.x <= dist)
            {
                temp = Vector3.right;
                SetRandomDirectionSwitch();
            }
        }
        transform.position += temp * Time.deltaTime * speed;
    }

   //Switch the tree's direction randomly between min and max distances
   private void SetRandomDirectionSwitch()
    {
        dist = Random.Range(distMin, distMax);
    }


    
}
