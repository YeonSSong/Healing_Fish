using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player Fisher = null;    
    public Player Tan = null;
    public Player Friend = null;
    public GameObject[] FriendPoint = null;
    
    public int curFriendPoint = 0;

    public Transform[] Pos_Fish = null; // 각 물고기들의 시작 위치
    public Transform[] Fishes = null; // 각 물고기들
    public Transform Pos_Fish_Appear = null; // 물고기 등장 위치
    public bool isFishAppear = false; // 물고기 등장 여부

    public Panel_Menu Panel_Menu_ = null;
    

    void Start()
    {
        Fisher.Setting("Fisher", 5f, 27);
        Tan.Setting("Tan", 4f, 27);
        Friend.Setting("Friend", 5f, 25);
    }
    
    int test(int a)
    {
        int b;
        return 5;
        
    }
    void Update()
    {
        //0:앞 1:뒤 2:좌 3:우
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Debug.Log("UpArrow");
            //transform.forward;
            Fisher.Move(CDIR.Up);
            Tan.Move_Tan(Fisher);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Fisher.Move(CDIR.Down);
            Tan.Move_Tan(Fisher);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            Fisher.Move(CDIR.Left);
            Tan.Move_Tan(Fisher);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Fisher.Move(CDIR.Right);
            Tan.Move_Tan(Fisher);
        }
        FriendMove();

        FishMake();
    }
    void FriendMove()
    {        
        if (Friend.TimeCnt < 3)
        {
            Friend.TimeCnt += Time.deltaTime;
        }
        else
        {
            Friend.TimeCnt = 0;
            /*
            int random = UnityEngine.Random.Range(0, 4);
            
            if (random == (int)CDIR.Up)
            {
                Friend.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            else if (random == (int)CDIR.Down)
            {
                Friend.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else if (random == (int)CDIR.Left)
            {
                Friend.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            else if (random == (int)CDIR.Right)
            {
                Friend.transform.rotation = Quaternion.Euler(0, 270, 0);
            } */           
        }
        Transform target = FriendPoint[curFriendPoint].transform;
         Friend.transform.LookAt(target);
        Friend.transform.position += Friend.transform.forward * Time.deltaTime;
       
        //Friend.transform.rotation = Quaternion.Euler(0,FriendPoint.transform.y,0)
        if (Vector3.Distance(target.position, Friend.transform.position) < 0.5f)
        {
            curFriendPoint = UnityEngine.Random.Range(0,7);
           /* if (curFriendPoint > 6)
            {
                curFriendPoint = 0;
            }*/
            target = FriendPoint[curFriendPoint].transform;
        }
        
    }
    public void FishMake()
    {
        if (isFishAppear == false)
        {
            int selectedFish = 0;
            Fishes[0].position = Pos_Fish_Appear.position;



            isFishAppear = true;
        }
    }  
    public void OnBTN_Menu()
    {
        Panel_Menu_.Show();
        Debug.Log("OnBTN_Menu");
    }    
}
