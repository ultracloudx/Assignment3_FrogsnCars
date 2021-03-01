using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    public GameObject frog;
    public Rigidbody2D rb;

    private void OnTriggerEnter2D(Collider2D col)
    {

        rb.MovePosition(rb.position + Vector2.up);
    }
    /*private void OnTriggerEnterLeft2D(Collider2D col)
    {

        rb.MovePosition(rb.position + Vector2.right);
    }
    private void OnTriggerEnterRight2D(Collider2D col)
    {

        rb.MovePosition(rb.position + Vector2.left);
    }*/
}
