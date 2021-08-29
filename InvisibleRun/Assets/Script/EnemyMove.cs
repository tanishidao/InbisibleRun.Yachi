using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
     public Vector2 lightMove;
    private void FixedUpdate()
    {
        Rigidbody2D rigid2D = this.GetComponent<Rigidbody2D>();

        Vector2 force = lightMove;
        rigid2D.AddForce(force);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Destroy"))
            {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("GAMEOVER");
        }
    }
}
