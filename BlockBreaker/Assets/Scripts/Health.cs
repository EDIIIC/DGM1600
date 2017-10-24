using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int health;
	public Sprite[] picture;
	private int count = 0;

	void OnCollisionEnter2D (Collision2D myCollider) {

		//Take away health
		health--;
		count++;
		//if health is < 0 destroy brick

		//change the picture

		if (health <= 0) {
			Destroy (this.gameObject);
		}
		
		GetComponent<SpriteRenderer> ().sprite = picture [count];
	}
	
}