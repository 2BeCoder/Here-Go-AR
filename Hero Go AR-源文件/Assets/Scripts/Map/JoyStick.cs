using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyStick : ScrollRect
{


    float radius = 0f;
    public Vector3 stickPos;
    // Start is called before the first frame update
    protected override void Start()
    {
        radius = viewport.rect.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (content.localPosition.magnitude > radius)
            content.localPosition = content.localPosition.normalized * radius;
        stickPos = content.localPosition.normalized;

    }
}
