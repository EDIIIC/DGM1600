using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

//speed variable
	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;
	public float moveSpeed;
	private Rigidbody2D rb;

	void Update () {

		if (Input.GetButtonDown ("Fire1")) {
			GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
		}

		float h = Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed;
		float v = Input.GetAxis ("Vertical") * Time.deltaTime * moveSpeed;

		transform.Translate (new Vector3 (h, v, 0f));


		//if (Input.GetKey (KeyCode.UpArrow))
		//{
		//	Vector3 position = this.transform.position;
		//	position.y+=0.35f;
		//	this.transform.position = position;
		//}
		//if (Input.GetKey(KeyCode.DownArrow))
		//{
		//	Vector3 position = this.transform.position;
		//	position.y-=0.35f;
		//	this.transform.position = position;
		//}	
		//if (Input.GetKey(KeyCode.RightArrow))
		//{
		//	Vector3 position = this.transform.position;
		//	position.x+=0.35f;
		//	this.transform.position = position;
		//}
		//if (Input.GetKey (KeyCode.LeftArrow))
		//{
		//	Vector3 position = this.transform.position;
		//	position.x-=0.35f;
		//	this.transform.position = position;
		//}


	}
}