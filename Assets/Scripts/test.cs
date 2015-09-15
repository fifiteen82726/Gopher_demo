using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public GameObject target;
	// Use this for initialization
	void Start () {
	
			iTween.MoveTo(target, iTween.Hash("x", 1, "onComplete", "ShakeComplete"));


	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void ShakeComplete(){
		Debug.Log("The shake completed!");	
	}
}


