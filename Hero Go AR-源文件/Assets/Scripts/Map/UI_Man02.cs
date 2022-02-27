using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Man02 : MonoBehaviour
{
    public Text Tx_GoodNum;
    public Text Tx_BadNum;
    public GameObject Im_Find;
    public GameObject NoCoka;
    public GameObject NoPapsi;
    public Text text;
    public GameObject Im_Timer;
    
    public static UI_Man02 Instance;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Tx_GoodNum.text = StaticData.GoodNum.ToString();
        Tx_BadNum.text = StaticData.BadNum.ToString();
        if (StaticData.GoodNum < 10)
        {
            SetTimer(true);
            StartCoroutine(CountDown());
        }
    }
    void update()
    {
        AutoSave.Save();
    }
   
    public void AddGoodNum()
    {
        //int _num = Int32.Parse(Tx_GoodNum.text);
        //_num++;
        //Tx_GoodNum.text = _num.ToString();
        StaticData.GoodNum++;
        Tx_GoodNum.text = StaticData.GoodNum.ToString();
    }

    public void AddBadNum()
    {
        StaticData.BadNum++;
        Tx_BadNum.text =StaticData.BadNum.ToString();
        
    }

    public void UpdateUIGoodNum()
    {
        Tx_GoodNum.text = StaticData.GoodNum.ToString();//new
    }

    public void SetIm_War(bool b)
    {
        Im_Find.SetActive(b);
    }

    public void SetNoCoka(bool b)
    {
        NoCoka.SetActive(b);
    }

    public void SetNoPapsi(bool b)
    {
        NoPapsi.SetActive(b);
    }

    public void SetTimer(bool b)
    {
        Im_Timer.SetActive(b);
    }

    public void Btn_GoARScn()
    {
        if (StaticData.BadNum > 0)
        {
            SceneManager.LoadScene("03_AR");
        }
        else
        {
            SetNoPapsi(true);
            SetIm_War(false);
        }
            
    }
    public void Btn_GoStartScn()
    {
        SceneManager.LoadScene("01_Start");
    }


    IEnumerator CountDown()
    {
        while (StaticData.TotalTime >= 0)
        {
            text.GetComponent<Text>().text = StaticData.TotalTime.ToString();
            yield return new WaitForSeconds(1);
            StaticData.TotalTime--;
        }
        if(StaticData.TotalTime <=0)
        {
            StaticData.GoodNum=10;
            UI_Man02.Instance.UpdateUIGoodNum();
            SetTimer(false);
            if (StaticData.GoodNum == 10)
            {
                StaticData.TotalTime = 100;
                text.GetComponent<Text>().text = StaticData.TotalTime.ToString();
            }
        }
    }

    public void Timer()
    {
        if (StaticData.GoodNum == 9)
        {
            StartCoroutine(CountDown());
            SetTimer(true);
        }
    }
}
