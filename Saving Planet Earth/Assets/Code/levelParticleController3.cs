using UnityEngine;
using System.Collections;

public class levelParticleController3 : MonoBehaviour {




	IEnumerator levelStart(){


		yield return new WaitForSeconds(2f);
		Application.LoadLevel (3);


		}
	void Start () {

		StartCoroutine ("levelStart");


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
