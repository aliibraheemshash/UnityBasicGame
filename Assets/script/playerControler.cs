using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody playerRP;
    public float jumpForce;
    public float gravityModifier;
    void Start()
    {
        playerRP = GetComponent<Rigidbody>();

        Physics.gravity*=gravityModifier;
        //playerRP.AddForce(Vector3.up*500 );
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRP.AddForce(Vector3.up * 500);

        }
    }
}
