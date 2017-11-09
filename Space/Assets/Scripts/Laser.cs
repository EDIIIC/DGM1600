using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
//
	public int health;
	public Sprite[] picture;
	private int count= 0;
	private LevelManager levelManager;
//
	public float lifetime;
	public float speed;



//
	void Start(){
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
		GetComponent<SpriteRenderer> ().sprite = picture [count];
		//change the picture
		if (health <= 0) {
			LevelManager.LaserCount--;
			//levelManager.CheckLaserCount ();
			Destroy (this.gameObject);

		}
	}
//
	void Update () {

		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}

		transform.Translate (Vector3.up * speed * Time.deltaTime);
		//

	
	}
}
