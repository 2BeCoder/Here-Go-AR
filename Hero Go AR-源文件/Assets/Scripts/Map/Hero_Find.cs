using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Hero_Find : MonoBehaviour
{
    public int Hero_Index;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(GameObject.FindGameObjectWithTag("Avatar").transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Avatar")
        {
            UI_Man02.Instance.SetIm_War(true);

            StaticData.FightingHeroIndex = Hero_Index;

            Destroy(gameObject);
        }
        if(other.tag=="Bad")
        {
            playWin();
            StartCoroutine(ShowWinPn());
        }
    }

    IEnumerator ShowWinPn()
    {
        yield return new WaitForSeconds(3f);
        UI_Man03.Instance.Show_PnWin();
        //Destroy(transform.gameObject);
    }

    private void playWin()
    {
        transform.GetComponent<Animator>().SetTrigger("Death");
    }
}
