using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	public int health;
	public Sprite[] picture;
//	private int count= 0;
	public float lifetime;
	public AudioSource audioSource;
	public int damage;
//	public float speed;


	void Start(){
		audioSource.pitch = Random.Range (1f, 2f);
	}


	void Update () {
		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		other.GetComponent<Health> ().IncrementHealth (damage);
		Destroy (gameObject);
	}
}
