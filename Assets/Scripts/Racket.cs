using System;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float speed = 5f;
    
    private Rigidbody2D rb;
    private float vertical;
    public string axisName;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        vertical = Input.GetAxis(axisName);
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.up * (vertical * speed);
    }
}
