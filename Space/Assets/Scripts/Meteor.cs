using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

	//public int health;
	//public Sprite[] picture;
	//private int count = 0;
	public float startingSpin;
	public float speed;

	private GameObject player;
	private Rigidbody2D rigid;

	void Start () {
		
		player = FindObjectOfType<PlayerController> ().gameObject;
		rigid = GetComponent<Rigidbody2D> ();

		//Where to go      
		transform.right = player.transform.position - transform.position;

		//speed
		rigid.AddRelativeForce(new Vector2(Random.Range(0,speed),0f),ForceMode2D.Force);

		//Random Rotation
		rigid.AddTorque (Random.Range(-startingSpin,startingSpin),ForceMode2D.Impulse);

	}

	private void OnCollisionEnter2D(Collision2D coll){
		coll.gameObject.GetComponent<Health> ().IncrementHealth (-1);
	}




	/*
	private void OnCollisionEnter2D(Collision2D coll){
		coll.gameObject.GetComponent<Health> ().IncrementHealth (-1);

				health--;
				count++;
				if (count > picture.Length - 1) {
					count--;
				}

				GetComponent<SpriteRenderer>().sprite = picture[count];

				if (health <= 0) {
					LevelManager.MeteorCount--;
					Destroy (this.gameObject);
		}

	}
	*/

}
