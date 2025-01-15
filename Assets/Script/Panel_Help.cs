using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Help : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Show()
    {
        gameObject.SetActive(true);
        Refresh();
    }

    public void Refresh()
    {
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
    public void OnBTN_Cloes()
    {
        Hide();
    }
}
