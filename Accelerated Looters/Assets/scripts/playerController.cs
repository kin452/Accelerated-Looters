using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class playerController : MonoBehaviour
{

	public float moveSpeed;
	public Rigidbody2D myRigidbody;
	
	
	
	
	// Use this for initialization
	void Start ()
	{
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Horizontal")>0f)
		{
			myRigidbody.velocity=new Vector3(moveSpeed, myRigidbody.velocity.y,0);
			
		}
		if (Input.GetAxisRaw("Vertical")>0f)
		{
			myRigidbody.velocity=new Vector3(myRigidbody.velocity.x,moveSpeed,0);
			
		}
	}
}
