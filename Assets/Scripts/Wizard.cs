using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public GameObject FireballPrefab;
    private Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1;
        bool wPressed = Input.GetKey("w");
        bool sPressed = Input.GetKey("s");
        bool aPressed = Input.GetKey("a");
        bool dPressed = Input.GetKey("d");
        bool spacePressed = Input.GetKeyUp(KeyCode.Space);
        int LastDirection = 0;


        if (wPressed ^ sPressed)
        {
            if (aPressed ^ dPressed)
            {
                speed = 0.7f;
            }
        }

        if (wPressed)
        {
            transform.position = transform.position + (Vector3.up * 0.02f) * speed;
            LastDirection = 0;
        }
        
        if (sPressed)
        {
            transform.position = transform.position + (Vector3.down * 0.02f) * speed;
            LastDirection = 1;
        }   
        
        if (aPressed)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            transform.position = transform.position + (Vector3.left * 0.02f) * speed;
            LastDirection = 2;
        }   
        
        if (dPressed)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            transform.position = transform.position + (Vector3.right * 0.02f) *speed;
            LastDirection = 3;
        }   

        if (spacePressed) {
            Instantiate(FireballPrefab, transform.position, quaternion.identity);
            
        }
        
    }
}
