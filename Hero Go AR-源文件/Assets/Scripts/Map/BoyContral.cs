using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyContral : MonoBehaviour
{
    private Animator ator;
    private MoveAvatar moveAvatar;

    //private Joystaick js;
    // Start is called before the first frame update
    void Start()
    {
        ator = gameObject.GetComponent<Animator>();
        moveAvatar = transform.parent.GetComponent<MoveAvatar>();

        /*js = GameObject.FindObjectOfType<Joystaick>();
        js.OnJoyStickTouchBegin += OnJoyStickBegin;
        js.OnJoyStickTouchMove += OnJoyStickMove;
        js.OnJoyStickTouchEnd += OnJoyStickEnd;*/
    }

    // Update is called once per frame
    void Update()
    {
        if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Idle)
        {
            ator.SetTrigger("Idle");
        }
        else if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Walk)
        {
            if (!ator.GetCurrentAnimatorStateInfo(0).IsName("Walk"))
            {
                ator.SetTrigger("Walk");
            }
        }
        else if (moveAvatar.animationState == MoveAvatar.AvatarAnimationState.Run)
        {
            if (!ator.GetCurrentAnimatorStateInfo(0).IsName("Run"))
            {
                ator.SetTrigger("Run");
            }
        }
    }
}
