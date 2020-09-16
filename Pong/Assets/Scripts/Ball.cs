using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class Ball : MonoBehaviour
{

    public float speed = 5;
    public Vector3 startPosition;
    public Rigidbody rb;
    public AudioSource impactSound;
    public AudioClip clip1;
    public AudioClip clip2;
    public float leftPaddleHitCount = 0;
    public float rightPaddleHitCount = 0;
    public Vector3 startVelocity;

    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "PaddleLeft")
        {
            soundEffect();
            leftPaddleHitCount++;
            if(leftPaddleHitCount % 3 == 0)
            {
                collision.gameObject.transform.localScale += new Vector3(0, 1, 1);
                speed += 1;
                rb.velocity += new Vector3(speed, 0f, speed);
                leftPaddleHitCount = 0;
            }
        }
        if (collision.gameObject.name == "PaddleRight")
        {
            soundEffect();
            rightPaddleHitCount++; 
            if (rightPaddleHitCount % 3 == 0)
            {
                collision.gameObject.transform.localScale += new Vector3(0, 1, 1);
                speed += 1;
                rb.velocity += new Vector3(-(speed), 0f, speed);
                rightPaddleHitCount = 0;
            }
        }

    }

    private void soundEffect()
    {
        print(speed);
        if(speed<=6)
        {
            impactSound.clip = clip1;
            impactSound.Play();
        }
        else
        {
            impactSound.clip = clip2;
            impactSound.Play();
        }
    }
    void Start()
    {
        startPosition = transform.position;
        impactSound = GetComponent<AudioSource>();
        Launch();
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
        leftPaddleHitCount = 0;
        rightPaddleHitCount = 0;
        speed = 5;
        Launch();
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float z = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector3(2 * speed * x, 0f, speed * z);
        startVelocity = rb.velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
