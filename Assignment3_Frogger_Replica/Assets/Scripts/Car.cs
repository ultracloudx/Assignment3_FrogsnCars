using System.Collections;
using UnityEngine;

public class Car : MonoBehaviour
{

    public Rigidbody2D rb;

    [SerializeField]
    private float speedAdjustment = 1f;

    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    float speed = 1f;

    private void Start()
    {
        speedAdjustment = PlayerPrefs.GetFloat("carSpeed");
        minSpeed += speedAdjustment;
        maxSpeed += speedAdjustment;
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }

    
}
