using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private float moveSpeed = 100f;
    private Rigidbody myBody;


	// Use this for initialization
	void Start ()
    {
        this.myBody = this.GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        myBody.velocity = new Vector3(moveHorizontal * moveSpeed, 0.0f, moveVertical * moveSpeed);
    }
}
