using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoAnimate : MonoBehaviour
{
    public Animator m_Animator1;
    public Animator m_Animator2;
    public Animator m_Animator3;
    public Animator m_Animator4;
    private int num = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void ButtonCallAnimation()
    {
        switch (num)
        {
            case 0:
                m_Animator1.SetBool("Play", true);
                break;
            case 1:
                m_Animator2.SetBool("Play", true);
                break;
            case 2:
                m_Animator3.SetBool("Play", true);
                break;
            case 3:
                m_Animator4.SetBool("Play", true);
                break;
        }

        Debug.Log("btn press & num++");
        num++;
        if (num > 4)
        {
            num = 0;
        }
    }
}
