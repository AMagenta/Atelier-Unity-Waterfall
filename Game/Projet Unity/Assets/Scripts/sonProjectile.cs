using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class sonProjectile : MonoBehaviour {

	private AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		//float force = collision.relativeVelocity.magnitude;
		//audioSrc.volume = force / 50;
		Debug.Log ("what");
		audioSrc.Play ();
	}

}
