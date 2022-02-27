using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using UnityEngine;


public class ARBadContral : MonoBehaviour
{
    public static ARBadContral Instance;

    public Transform PosInsBad;
    private GameObject[] Bads;

    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Bads = Resources.LoadAll<GameObject>("Bad");

        UI_Man03.Instance.UpdateUIBadNum();

        InsNewBad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InsNewBad()
    {
        if(StaticData.BadNum>0)
        {
            GameObject _bad = Instantiate(Bads[1], PosInsBad.position, PosInsBad.rotation);
            _bad.transform.SetParent(PosInsBad);
            _bad.gameObject.AddComponent<SphereCollider>();
            _bad.gameObject.AddComponent<ARShoot>();

            _bad.transform.localScale = new Vector3(5f, 5f, 5f);
            //_bad.GetComponent<SphereCollider>().radius = 0.01f;
        }
    }

  
}
