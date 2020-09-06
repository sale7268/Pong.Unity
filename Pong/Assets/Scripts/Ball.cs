using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 5;
    public Vector3 startPosition;
    public Rigidbody rb;
    public AudioSource impactSound;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        impactSound.Play();
    }
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
        Launch();
    }

    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float z = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector3(2 * speed * x, 0f, speed * z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
