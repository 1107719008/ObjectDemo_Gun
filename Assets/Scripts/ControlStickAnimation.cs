using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStickAnimation : MonoBehaviour
{
    [SerializeField] public int animateNum = 4;
    private int num;
    private Animator anim;

    void Update()
    {
        if (Input.GetButton("NextButton"))
        {
            anim.SetInteger("Int name", num);
            Debug.Log("btn press & num++");
            num++;
            if (num > animateNum)
            {
                num = 0;
            }
        }
    }
}
