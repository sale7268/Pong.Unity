using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPaddleLeft;
    public float speed = 5f;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPaddleLeft)
        {
            transform.Translate(0f, 0f, Input.GetAxis("Left_Paddle") * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(0f, 0f, Input.GetAxis("Right_Paddle") * speed * Time.deltaTime);
        }
    }

    public void Reset()
    {
        transform.position = startPosition;
    }
}
