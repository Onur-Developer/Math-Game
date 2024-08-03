using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameoverscript : MonoBehaviour
{
    public Text skor,hskor;
    GameObject rspanel;
    Button rsclosebutton;
    void Start()
    {
        rspanel = GameObject.Find("rspanel");
        rsclosebutton=GameObject.Find("rsbutton").GetComponent<Button>();
        rsclosebutton.onClick.AddListener(rspanelbutton);
        rspanel.SetActive(false);
        skor.text = "Skorunuz: " + PlayerPrefs.GetInt("skor");
        if (PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("skor"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("skor"));
            PlayerPrefs.Save();
        }
        hskor.text = "En Yüksek Skor: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void anamenu()
    {
        SceneManager.LoadScene("ekran1");
    }
    public void rs()
    {
        PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("skor"));
        PlayerPrefs.Save();
        hskor.text = "En Yüksek Skor: " + PlayerPrefs.GetInt("HighScore").ToString();
        rspanel.SetActive(true);

    }
    void rspanelbutton()
    {
        rspanel.SetActive(false);
    }
    public void tekraroyna()
    {
        SceneManager.LoadScene("samplescene");
    }
    public void oyundancýk()
    {
        Application.Quit();
    }
   
}
