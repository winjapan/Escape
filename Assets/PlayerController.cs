using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5;
    private Rigidbody rgbody;

    private Vector3 Player_Pos;
    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
        Player_Pos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rgbody.AddForce(x * Speed,0, z* Speed);

        Vector3 diff = transform.position - Player_Pos;

        if (diff.magnitude > 0.01f)
        {

            transform.rotation = Quaternion.LookRotation(diff);
           
        }
       
        Player_Pos = transform.position;
    }
}
