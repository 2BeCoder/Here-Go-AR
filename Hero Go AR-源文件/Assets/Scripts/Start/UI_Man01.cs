using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Man01 : MonoBehaviour
{
    public GameObject Introduce;
    // Start is called before the first frame update
    void Start()
    {
        AutoSave.Load();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetIntroduce(bool b)
    {
        Introduce.SetActive(b);
    }

    public void Btn_StartGame()
    {
        SceneManager.LoadScene("02_Map");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
