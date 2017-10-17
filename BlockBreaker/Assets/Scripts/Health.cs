using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int health;


	void OnCollisionEnter2D (Collision2D myCollider) {

		//Take away health
		health--;
		//if health is < 0 destroy brick
		if (health <= 0) {
			Destroy (this.gameObject);
		}
		
		
	}
	
}