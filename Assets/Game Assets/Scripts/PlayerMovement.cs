using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myBody;

    [SerializeField]
    int speed;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();

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
        currentXPos = Mathf.Clamp(currentXPos, -2.3f, 2.3f);
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z);
    }
}