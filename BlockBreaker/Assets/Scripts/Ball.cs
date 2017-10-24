using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject paddle;

	private bool playing = false;
	private Vector3 paddleToBallVector;  //distance from ball to paddle
	private Rigidbody2D rigid;

	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		rigid = this.GetComponent<Rigidbody2D> ();
	}

	void Update () {

		if (!playing) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
		
			//if push start button
			if (Input.GetMouseButtonDown (0)) {
				
				//ball goes flying
				rigid.velocity = new Vector2 (4,20);
				playing = true;
			}

		
		
		}
		
		
		}
}
