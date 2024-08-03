using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ekran2script : MonoBehaviour
{
    public Slider slider;
    public float zaman;
    public Text tx;

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    void Start()
    {
        zaman = 15f;
    }
    void Update()
    {
        tx.text = slider.value.ToString();
        zaman-=Time.deltaTime;
        slider.value = zaman;
        if (slider.value <= 0)
        {
            SceneManager.LoadScene("ekran3");
        }
    }
}
