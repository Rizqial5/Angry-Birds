using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBird : Bird
{
    //Fitur burung meledak
    public float radius ;
    public float power ;
    public LayerMask LayerHit;

    public bool _isExplode = false;

    
    public override void Explode()
    {
        
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius, LayerHit);

        if (!_isExplode)
        {
            foreach (Collider2D hit in colliders)
            {
                Vector2 direction = hit.transform.position - transform.position;


                Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();

                rb.AddForce(direction * power);
            }
            _isExplode = true;
        }
       
    }
    
    
}

