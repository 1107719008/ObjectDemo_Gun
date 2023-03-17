using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnable : MonoBehaviour
{
    
    Collider m_Collider;
    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        m_Collider = GetComponent<Collider>();
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            toggleSpaceTrigger();
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            EnableCol();
        }
        else
        {
            DisableCol();
        }
    }
    public void toggleSpaceTrigger()
    {
        //Toggle the Collider on and off when pressing the space bar
        m_Collider.enabled = !m_Collider.enabled;

        //Output to console whether the Collider is on or not
        //Debug.Log("Collider.enabled = " + m_Collider.enabled);
    }
    public void toggleSwitch(bool isOpen)
    {
        if (isOpen)
        {
            m_Collider.enabled = true;
        }
        else
        {
            m_Collider.enabled = false;
        }
        

       
    }
    private void EnableCol()
    {
        m_Collider.enabled = true;
    }
    private void DisableCol()
    {
        m_Collider.enabled = false;
    }
}
