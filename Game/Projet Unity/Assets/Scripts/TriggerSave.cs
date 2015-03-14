using UnityEngine;
using System.Collections;

public class TriggerSave : MonoBehaviour {

	public Vector3 playerPosOnTrigger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			PlayerSave ps = col.transform.GetComponent<PlayerSave> ();
			ps.setTriggerSave(this);
			playerPosOnTrigger = col.transform.position;
			}
		}
}
