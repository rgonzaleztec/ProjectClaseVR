using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.XR.Management;


public class CargarMenu : MonoBehaviour
{
    private IEnumerator couroutine;
    public VideoPlayer mivideo;

    public void Cargando()
    {
        couroutine = WaitVideoandLoadScene(9.0f);
        StartCoroutine(couroutine);
    }


    private IEnumerator WaitVideoandLoadScene(float waitTime)
    {
        while (true)
            { 
                yield return new WaitForSeconds(waitTime);
                XRGeneralSettings.Instance.Manager.InitializeLoader();
                if (XRGeneralSettings.Instance.Manager.activeLoader == null)
                {
                    Debug.LogError("Initializing XR Failed. Check Editor or Player log for details.");
                }
                else
                {
                    Debug.Log("Starting XR...");
                    XRGeneralSettings.Instance.Manager.StartSubsystems();
                }
                SceneManager.LoadScene(1);
             }
        

    }

    private void Start()
    {
        mivideo.Play();
        Cargando(); 
    }
}
