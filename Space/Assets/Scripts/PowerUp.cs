using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	public enum Type {shield, zoomer, blastyblaster};
	public Type powerUptype;
	public Sprite[] images;

	void Start () {
		switch (powerUptype) {
		case Type.shield:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
			break;
		case Type.zoomer:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [1];
			break;
		case Type.blastyblaster:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [2];
			break;
		}
	}
	

	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("We hit a powerup!");

//		if (powerUptype == Type.zoomer) {
//		}

		switch (powerUptype) {
		case Type.zoomer:
			other.GetComponent<PlayerController> ().moveSpeed *= 2;
			break;
		case Type.shield:
			other.GetComponent<Health> ().health += 1;
			break;
		
		}

		Destroy (this.gameObject);
	}
}
