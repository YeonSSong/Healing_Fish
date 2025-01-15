using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Menu : MonoBehaviour
{
    public Panel_Shop Panel_Shop_ = null;
    public Panel_Setting Panel_Setting_ = null;
    public Panel_Help Panel_Help_ = null;
    public Panel_OG Panel_OG_ = null;

    void Start()
    {
        
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
     public void Hide()
    {
        gameObject.SetActive(false);
    }
    void Update()
    {
        
    }
    public void OnBTN_Cloes()
    {
        Hide();
    }
    public void OnBTN_Shop()
    {
        Panel_Shop_.Show();
    }
    public void OnBTN_Setting()
    {
        Panel_Setting_.Show();
        Debug.Log("OnBTN_Setting");
    }
    public void OnBTN_Help()
    {
        Panel_Help_.Show();        
    }
    public void OnBTN_OG()
    {
        Panel_OG_.Show();
    }
    public void OnBTN_Quit()
    {
        Application.Quit();
    }
}
