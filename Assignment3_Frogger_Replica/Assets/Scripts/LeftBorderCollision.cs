using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBorderCollision : MonoBehaviour
{
    public GameObject frog;
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D col)
    {

        rb.MovePosition(rb.position + Vector2.right);
    }
    
}
