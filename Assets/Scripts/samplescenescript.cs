using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class samplescenescript : MonoBehaviour
{
    public GameObject pausepanel;
    public Text sayý1, sayý2, skortext, sayac,button1text,button2text,button3text;
    public int a, b, c, crandom, skor, bt1, bt2, bt3, tt;
    private float zamansayac = 16f;
    private void Awake()
    {
        button1text = GameObject.Find("Button1Text").GetComponent<Text>();
        button2text = GameObject.Find("Button2Text").GetComponent<Text>();
        button3text = GameObject.Find("Button3Text").GetComponent<Text>();
        a = Random.Range(0, 101);
        b = Random.Range(0, 101);
        c = a + b;
    }
    private void Start()
    {
        tt = 1;
        crandom = Random.Range(1, 4);
        skor = 0;
        PlayerPrefs.SetInt("skor", skor);
        pausepanel.SetActive(false);
        skortext.text = "Skor: " + skor.ToString();
        sayý1.text = a.ToString();
        sayý2.text = b.ToString();
    }
    private void Update()
    {
        sayac.text = "Sayaç: " + (int)zamansayac;
        zamansayac -= Time.deltaTime;
        if (zamansayac <= 0)
        {
            SceneManager.LoadScene("gameoverscene");
        }
        if (tt == 1)
        {
            for (int i = 1; i < 2; i++)
            {
                if (i == crandom)
                {
                    bt1 = c;
                    bt2 = c - 1;
                    bt3 = c + 1;
                    button1text.text = bt1.ToString();
                    button2text.text = bt2.ToString();
                    button3text.text = bt3.ToString();
                }
                else if (i + 1 == crandom)
                {
                    bt1 = c + 1;
                    bt2 = c;
                    bt3 = c - 1;
                    button1text.text = bt1.ToString();
                    button2text.text = bt2.ToString();
                    button3text.text = bt3.ToString();
                }
                else
                {
                    bt1 = c - 1;
                    bt2 = c + 1;
                    bt3 = c;
                    button1text.text = bt1.ToString();
                    button2text.text = bt2.ToString();
                    button3text.text = bt3.ToString();
                }
            }
            tt = 0;
        }
       
    }
    public void buton1()
    {
        if (c == bt1)
        {
            skor++;
            PlayerPrefs.SetInt("skor", skor);
            skortext.text = "Skor: " + skor.ToString();
            a = Random.Range(0, 101);
            b = Random.Range(0, 101);
            c = a + b;
            crandom = Random.Range(1,4);
            tt = 1;
            sayý1.text = a.ToString();
            sayý2.text = b.ToString();
            zamansayac = 16f;
        }
        else
        {
            SceneManager.LoadScene("gameoverscene");
        }
    }
    public void buton2()
    {
        if (c == bt2)
        {
            skor++;
            PlayerPrefs.SetInt("skor", skor);
            skortext.text = "Skor: " + skor.ToString();
            a = Random.Range(0, 101);
            b = Random.Range(0, 101);
            c = a + b;
            crandom = Random.Range(1,4);
            tt = 1;
            sayý1.text = a.ToString();
            sayý2.text = b.ToString();
            zamansayac = 16f;
        }
        else
        {
            SceneManager.LoadScene("gameoverscene");
        }
    }
    public void buton3()
    {
        if (c == bt3)
        {
            skor++;
            PlayerPrefs.SetInt("skor", skor);
            skortext.text = "Skor: " + skor.ToString();
            a = Random.Range(0, 101);
            b = Random.Range(0, 101);
            c = a + b;
            crandom = Random.Range(1, 4);
            tt = 1;
            sayý1.text = a.ToString();
            sayý2.text = b.ToString();
            zamansayac = 16f;
        }
        else
        {
            SceneManager.LoadScene("gameoverscene");
        }
    }
    public void pausebutton()
    {
        pausepanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void oyunadon()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void anamenu()
    {
        SceneManager.LoadScene("ekran1");
    }
    public void oyundancýk()
    {
        Application.Quit();
    }
}
