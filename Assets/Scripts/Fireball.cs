using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,3);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.up * 4;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime * speed;
    }
}
