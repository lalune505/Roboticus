using System.Collections;
using System.Collections.Generic;
using System.IO;
//using NatShareU;
using UnityEngine;
using UnityEngine.UI;

public class TakeScreenShotScript : MonoBehaviour
{

    public Flash _Flash;

    public GameObject Panel;

    public Button b1, b2;

    public GameObject _InputController;

    public RawImage previewImage;

    private Texture2D screenImage;

    public Animator animator;

    public AudioSource audioFlash;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeScreenShot()
    {
        audioFlash.Play();
        _Flash.CameraFlash();
        _InputController.SetActive(false);
        animator.SetTrigger("HideOnFlash");

    }

    public void PlayCoroutine()
    {

        StartCoroutine(CaptureScreenshot());

    }

    IEnumerator CaptureScreenshot()
    {
        //yield return null;
        //GameObject.Find("MainCanvas").GetComponent<Canvas>().enabled = false;
        //Wait for end of frame
        yield return new WaitForEndOfFrame();

        screenImage = new Texture2D(Screen.width, Screen.height);

        //Get Image from screen
        screenImage.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        screenImage.Apply();

        //NatShare.SaveToCameraRoll(screenImage);


        //GameObject.Find("MainCanvas").GetComponent<Canvas>().enabled = true;


        previewImage.texture = screenImage;

      

        yield return new WaitForSeconds(0.5f);

       // Panel.SetActive(true);

        animator.SetTrigger("ShowPreviewPanel");

        //Texture2D.Destroy(screenImage);

    }

    public string ScreenshotName = "screenshot.png";


    public void ShareScreenshotWithText(string text)
    {

        string screenShotPath = Application.persistentDataPath + "/" + ScreenshotName;
        if (File.Exists(screenShotPath)) File.Delete(screenShotPath);

        b1.gameObject.SetActive(false);
        b2.gameObject.SetActive(false);

        ScreenCapture.CaptureScreenshot(ScreenshotName);
        StartCoroutine(delayedShare(screenShotPath, text));
    }

    IEnumerator delayedShare(string screenShotPath, string text)
    {
        Debug.Log("Sshare delayed");
        while (!File.Exists(screenShotPath))
        {
            Debug.Log("Sshare waiting yeild");
            yield return new WaitForSeconds(.05f);
        }
        NativeShare.Share(text, screenShotPath, "", "", "image/png", true, "");
        Invoke("delayedUIVisibility", 2f);
    }

    private void delayedUIVisibility()
    {
        b1.gameObject.SetActive(true);
        b2.gameObject.SetActive(true);
    }



    public void HidePreviewPanel()
    {
        animator.SetTrigger("HidePreviewPanel");
       // Texture2D.Destroy(screenImage);
        _InputController.SetActive(true);
        //animator.SetTrigger("Show");
    }

    //---------- Helper Variables ----------//
    private float width
    {
        get
        {
            return Screen.width;
        }
    }

    private float height
    {
        get
        {
            return Screen.height;
        }
    }

}
