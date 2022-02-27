using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsPoint : MonoBehaviour
{
    public GameObject Ava;//储存地图角色
    public GameObject PrePoint;//储存事件点预制体
    public float MinDis = 3;//距离在最小值
    public float MaxDis = 50;//距离最大值

    private Vector3 v3Ava;
    // Start is called before the first frame update
    void Start()
    {
       //InsPointFuc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InsPointFuc()
    {
        if (StaticData.GoodNum > 0)
        {
            for (int i = 0; i < 3; i++)
            {
                v3Ava = Ava.transform.position;//获取角色当前坐标位置
                float _dis = UnityEngine.Random.Range(MinDis, MaxDis);

                Vector2 _pOri = UnityEngine.Random.insideUnitCircle;
                Vector2 _pNor = _pOri.normalized;

                Vector3 _v3Point = new Vector3(v3Ava.x + _pNor.x * _dis, 0, v3Ava.z + _pNor.y * _dis);

                GameObject _poiMark = Instantiate(PrePoint, _v3Point, transform.rotation);   
            }
            StaticData.GoodNum--;
            UI_Man02.Instance.UpdateUIGoodNum();
        }
        else
        {
            UI_Man02.Instance.SetNoCoka(true);
        }
        UI_Man02.Instance.Timer();

    }
}
