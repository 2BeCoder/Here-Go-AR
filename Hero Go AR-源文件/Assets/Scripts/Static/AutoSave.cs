using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSave 
{
    public static void Save()
    {
        ES3.Save<int>("GoodNum", StaticData.GoodNum);
        ES3.Save<int>("BadNum", StaticData.BadNum);
        //PlayerPrefs.SetInt("GoodNum", StaticData.GoodNum);
        //PlayerPrefs.SetInt("BadNum", StaticData.BadNum);
    }

    public static void Load()
    {
        if(ES3.KeyExists("GoodNum")&&ES3.KeyExists("BadNum"))
        {
            StaticData.GoodNum = ES3.Load<int>("GoodNum");
            StaticData.BadNum = ES3.Load<int>("BadNum");
        }
    }
}
