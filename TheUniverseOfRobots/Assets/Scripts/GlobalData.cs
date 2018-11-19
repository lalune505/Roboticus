using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalData : MonoBehaviour {

    public static GlobalData control = null;
    [HideInInspector]
    public string planetName = "";

	// Use this for initialization
	void Awake () {

       
        if (control == null)
        {
            //if not, set instance to this
            control = this;
        }
        //If instance already exists and it's not this:
        else if (control != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(transform.gameObject);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Setup(string newName)
    {
        planetName = newName;
    }

   public void ResetName()
    {
       planetName = "";
    }
}
