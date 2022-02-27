using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEvent : MonoBehaviour
{
    public GameObject[] Heros;
    public GameObject[] Goods;
    public GameObject[] Bads;
    // Start is called before the first frame update

    void Awake()
    {
        Heros = Resources.LoadAll<GameObject>("Hero");
        Goods = Resources.LoadAll<GameObject>("Good");
        Bads = Resources.LoadAll<GameObject>("Bad");
    }

    void Start()
    {
        int _randomEvent = Random.Range(0, 2);
        if (_randomEvent == 0)
        {
            InsHero();
        }
        /*else if (_randomEvent == 1)
        {
            InsHero();
        }*/
        else if (_randomEvent == 1)
        {
            InsBad();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InsHero()
    {
        int _heroIndex = Random.Range(0, Heros.Length);
        GameObject _hero=Instantiate(Heros[_heroIndex], transform.position, transform.rotation);
        _hero.GetComponent<Hero_Find>().Hero_Index = _heroIndex;
    }

    private void InsGood()
    {
        int _goodIndex = Random.Range(0, Goods.Length);
        GameObject _good = Instantiate(Goods[_goodIndex], transform.position + new Vector3(0, 12, 0), transform.rotation);
        _good.transform.localEulerAngles = new Vector3(-30f, 0, 0);
        _good.AddComponent<SphereCollider>();
        _good.GetComponent<SphereCollider>().isTrigger = true;
        _good.GetComponent<SphereCollider>().radius = 0.011f;
        _good.AddComponent<Rigidbody>();
        _good.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        _good.AddComponent<MoveEffect>();
        _good.AddComponent<Good_Find>();
    }
    private void InsBad()
    {
        int _badIndex = Random.Range(0, Bads.Length);
        GameObject _bad = Instantiate(Bads[0], transform.position + new Vector3(0, 12, 0), transform.rotation);
        _bad.transform.localEulerAngles = new Vector3(-30f, 0, 0);
        _bad.AddComponent<SphereCollider>();
        _bad.GetComponent<SphereCollider>().isTrigger = true;
        _bad.GetComponent<SphereCollider>().radius = 0.011f;
        _bad.AddComponent<Rigidbody>();
        _bad.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        _bad.AddComponent<MoveEffect>();
        _bad.AddComponent<Bad_Find>();
    }
}
