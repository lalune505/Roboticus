using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalActivator : MonoBehaviour {

    [HideInInspector]
    public GlobalData GD;

    public List<GameObject> objectsToActivate;
	// Use this for initialization

	void Start () {

        GD = FindObjectOfType<GlobalData>();
        Debug.Log(GD.planetName);
        if (GD.planetName != "")
        {
            foreach (var item in objectsToActivate)
            {
                if (item.name == GD.planetName)
                {
                    item.SetActive(true);

                }
            }
        }

	}
	
	// Update is called once per frame
	void Update () {

    }

    public void SetInActive(){

        foreach (var item in objectsToActivate)
        {
            item.SetActive(false);
        }
    }
}
