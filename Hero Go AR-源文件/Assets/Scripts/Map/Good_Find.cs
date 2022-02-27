using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good_Find : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Avatar")
        {
            UI_Man02.Instance.AddGoodNum();
            Destroy(gameObject);
        }
    }
}
