using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public Animator animator;
   
    private string sceneName;

    public GlobalData GD;

    public portalActivator _portalActivator;

    // Use this for initialization
    void Start()
    {
        GD = FindObjectOfType<GlobalData>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadSceneZefirius()
    {
        FadeToScene("ZefiriusScene");
    }

    public void LoadSceneLedus()
    {
        FadeToScene("LedusScene");
    }


    public void LoadSceneNeonus()
    {
        FadeToScene("NeonusScene");
    }

    public void FadeToScene(String scene)
    {
        sceneName = scene;
        animator.SetTrigger("FadeOut");
    }

    public void LoadSceneMain()
    {

        _portalActivator.SetInActive();
        GD.ResetName();
        FadeToScene("MainScene");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(sceneName);
    }


    public void LoadScenePortalLedus()
    {
        FadeToScene("PortalScene");
        GD.Setup("portalLedus");

    }

    public void LoadScenePortalNeonus()
    {
        FadeToScene("PortalScene");
        GD.Setup("portalNeonus");

    }

    public void LoadScenePortalZefirius(){
        FadeToScene("PortalScene");
        GD.Setup("portalZefirius");

    }
}
