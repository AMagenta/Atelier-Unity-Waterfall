using UnityEngine;
using System.Collections;

public class TriggerTerrain : MonoBehaviour {
	public GameObject monTerrain ;

	// Use this for initialization
	void Start () {
		monTerrain.GetComponent<Terrain> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		monTerrain.GetComponent<Terrain> ().enabled = true;
	}
}
