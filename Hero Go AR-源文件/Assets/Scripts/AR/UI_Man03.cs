using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Man03 : MonoBehaviour
{
    public static UI_Man03 Instance;

    public Text Tx_BadNum;

    public GameObject PnWin;

    public Text InputHeroNote;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (StaticData.GoodNum < 10)
        {
            UI_Man02.Instance.Timer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        AutoSave.Save();
    }
    public void Btn_GoMapScn()
    {
        SceneManager.LoadScene("02_Map");
    }

    public void UpdateUIBadNum()
    {
        Tx_BadNum.text= StaticData.BadNum.ToString();
    }

    public void Show_PnWin()
    {
        PnWin.SetActive(true);
    }

    
}
