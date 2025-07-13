using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private const int V = 0;
    [SerializeField]
    public float jumpSpeed = 20f;
    [SerializeField]
    int speed = V;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        if(rb2D == null)
        {
            Debug.LogError("Rigidbody component missing from this GameObject!");
        }

    }


    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        }

        float currentXPos = transform.position.x;
        float currentYPos = transform.position.y;

        if (Input.GetKeyDown(KeyCode.UpArrow) && Mathf.Approximately(currentYPos, -5.5f))
        {
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, jumpSpeed);
        }


        currentXPos = Mathf.Clamp(currentXPos, -16.0f, 16.0f);
        currentYPos = Mathf.Clamp(currentYPos, -5.5f, 11.13f);

        transform.position = new Vector3(currentXPos, currentYPos, transform.position.z);
    }
}