using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0,0,-speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -10)
        {
            Destroy(this);
        }
    }
}
