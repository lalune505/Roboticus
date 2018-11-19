using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour {

    public Animator animator;
    public Animator animatorCanvasMain;
    public GameObject Buttons;
    public GameObject Panel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenPanel(){
        animator.SetTrigger("Open");
    }

    public void OnOpenComplete(){
        //Buttons.SetActive(false);
        animatorCanvasMain.SetTrigger("HideMain");
    }

    public void OnCloseComplete(){
        //Buttons.SetActive(true);
        animatorCanvasMain.SetTrigger("ShowMain");
    }

    public void ClosePanel(){
        animator.SetTrigger("Close");
    }

    public void OpenPanelZefirius()
    {
        animator.SetTrigger("OpenZefirius");
    }

    public void ClosePanelZefirius(){
        animator.SetTrigger("CloseZefirius");
    }

    public void OpenPanelNeonus(){
        animator.SetTrigger("OpenNeonus");
    }

    public void ClosePanelNeonus(){
        animator.SetTrigger("CloseNeonus");
    }
    
}
