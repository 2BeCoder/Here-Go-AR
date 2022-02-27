using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class ARInsHero : MonoBehaviour
{
    public Transform[] traPos;
    private GameObject[] heros;
    // Start is called before the first frame update
    void Start()
    {
        heros=Resources.LoadAll<GameObject>("Hero");
        InsHero();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InsHero()
    {
        int _Index = UnityEngine.Random.Range(0, traPos.Length);
        Transform _tra = traPos[_Index];
        GameObject _hero= Instantiate(heros[StaticData.FightingHeroIndex],_tra.position,_tra.rotation);
        _hero.transform.localScale = new Vector3(4f, 4f, 4f);
    }
}
