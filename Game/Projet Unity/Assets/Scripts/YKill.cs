using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerSave))]
public class YKill : MonoBehaviour {

	public float yDeath = -50f;

	private PlayerSave playerSave;

	// Use this for initialization
	void Start () {
		playerSave = transform.GetComponent<PlayerSave> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < yDeath)
			playerSave.goToLastSavePoint ();
	}
}
