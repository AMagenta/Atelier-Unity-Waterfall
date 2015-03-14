using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	public Transform light ;
	public Transform porte ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		Debug.Log("coucou" + col.gameObject);
		light.GetComponent<Light> ().enabled = true;
		porte.GetComponent<Animator> ().SetBool ("Ouverte", true);
	}

	void OnTriggerExit (Collider col) {
		porte.GetComponent<Animator>().SetBool("Ouverte", false);
		light.GetComponent<Light> ().enabled = false;
	}



}