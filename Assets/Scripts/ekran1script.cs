using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ekran1script : MonoBehaviour
{
    public GameObject nasilOynanırPanel,creditpanel;

   
    public void OpenNasilOynanır()
    {
        nasilOynanırPanel.SetActive(true);
    }
    public void CloseNasılOynanır()
    {
        nasilOynanırPanel.SetActive(false);
    }
    public void creditspanel()
    {
        creditpanel.SetActive(true);
    }
    public void creditsclosebutton()
    {
        creditpanel.SetActive(false);
    }
    public void baslabutton()
    {
        SceneManager.LoadScene("ekran2");
    }
    public void basla()
    {
        SceneManager.LoadScene("samplescene");
    }
}
