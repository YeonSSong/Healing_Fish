using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListItem_Shop : MonoBehaviour
{
    public Image BG_ = null;
    public Text Text_Name_ = null;
    public Image Image_Item_ = null;
    public Text Text_Price_ = null;

    public ShopItem ShopItem_ = null;

    public void Start()
    {
        
    }
    public void Set(ShopItem pShopItem)
    {
        gameObject.SetActive(true);
        BG_.color = new Color32((byte)UnityEngine.Random.Range(0, 256), (byte)UnityEngine.Random.Range(0, 256), (byte)UnityEngine.Random.Range(0, 256), 255);
        ShopItem_ = pShopItem;
        Text_Name_.text = ShopItem_.Name_;

        // 이미지는 다음시간에...

        Text_Price_.text = "" + ShopItem_.Price_;
    }    
}
