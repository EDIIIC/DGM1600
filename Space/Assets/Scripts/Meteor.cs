using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

	public int health;
	public Sprite[] picture;
	private int count = 0;
	private LevelManager levelManager;
	public float startingSpin;


	void Start () {
		GetComponent<Rigidbody2D> ().AddTorque (Random.Range(-startingSpin,startingSpin),ForceMode2D.Impulse);

		levelManager = FindObjectOfType<LevelManager> ();
	}


	void OnCollisionEnter2D (Collision2D myCollider) {

		//Take away health
		health--;
		count++;
		if (count > picture.Length - 1) {
			count--;
		}
		//if health is < 0 destroy brick
		GetComponent<SpriteRenderer>().sprite = picture[count];
		//change the picture
		if (health <= 0) {
			LevelManager.MeteorCount--;
//			levelManager.CheckMeteorCount ();
			Destroy (this.gameObject);

	}


	}

}