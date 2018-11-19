using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallTakeScreenShot : MonoBehaviour {

    public TakeScreenShotScript _TakeScreenShotScript;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CallTakeSS(){
        _TakeScreenShotScript.PlayCoroutine();
    }
}
