using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoReduce : MonoBehaviour {

	public Rigidbody2D target;


	void FixedUpdate(){
		target.velocity = target.velocity * 0.95f;
	}

}
