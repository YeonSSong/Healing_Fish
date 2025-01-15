using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Shop : MonoBehaviour
{
   public GameObject Prefab_ListItem_Shop_ = null;
   public Transform Content_ = null;
    //오브젝
   public List<ListItem_Shop> List_listItem_Shop_ = new List<ListItem_Shop>();
   public ShopItem[] ShopItems_ = null; //데이타
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
        // 임시 데이터
        ShopItems_ = new ShopItem[5];
        for (int i = 0; i < ShopItems_.Length; i++)
        {
            ShopItems_[i] = new ShopItem();
            ShopItems_[i].Name_ = "아이템 이름_" + i;
            ShopItems_[i].Price_ = 10000 + i; 
        }

        int dataCnt = ShopItems_.Length;
        int objCnt = Content_.childCount;
        int loopCnt = dataCnt;
        if(loopCnt < objCnt)
            loopCnt = objCnt;
        for (int i = 0; i < loopCnt; i++)
        {
            if (i >= List_listItem_Shop_.Count)
            {
                GameObject obj = Instantiate(Prefab_ListItem_Shop_);
                obj.transform.parent = Content_;
                obj.transform.localScale = Vector3.one;
                obj.transform.localPosition = new Vector3(i * 200, 0, 0);
                ListItem_Shop tListItem_Shop = obj.GetComponent<ListItem_Shop>();
                List_listItem_Shop_.Add(tListItem_Shop);
            }

            List_listItem_Shop_[i].Set(ShopItems_[i]);
        }
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
}
