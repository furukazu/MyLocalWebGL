using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour {

	private Rigidbody2D r2d;

	private Vector3 mpos;



	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			var t = Input.GetTouch (0);
		}
		if (Input.GetMouseButtonDown (0)) {
			var r = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			var hit = Physics2D.Raycast(r,Vector2.zero);
			if (hit != null) {
				if (hit.rigidbody != null) {
					r2d = hit.rigidbody;
					mpos = Input.mousePosition;
				}
			}
		}
		if (Input.GetMouseButtonUp (0)) {
			if (r2d != null) {
				var pow =  mpos- Input.mousePosition;
				r2d.AddForce (pow, ForceMode2D.Impulse);
			}
		}

	}
}
