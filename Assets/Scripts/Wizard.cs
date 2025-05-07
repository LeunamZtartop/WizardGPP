using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public GameObject FireballPrefab;
    private Rigidbody2D RB;
    public float health = 100;
    public float mana = 100;

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
        }
        
        if (sPressed)
        {
            transform.position = transform.position + (Vector3.down * 0.02f) * speed;
        }   
        
        if (aPressed)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            transform.position = transform.position + (Vector3.left * 0.02f) * speed;
        }   
        
        if (dPressed) {
            GetComponent<SpriteRenderer>().flipX = false;
            transform.position = transform.position + (Vector3.right * 0.02f) *speed;
        }   

        if (mana < 100) {
            
        }

        if (spacePressed && mana > 20) {
            Instantiate(FireballPrefab, transform.position, quaternion.identity);   
        }
    }
}
