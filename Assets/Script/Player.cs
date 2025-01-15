using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum CDIR
{
    Up = 0,
    Down = 1,
    Left = 2,
    Right = 3
}

public class Player : MonoBehaviour
{
    public Vector3 Dir = Vector3.zero;
    public float TimeCnt = 0;
    public Transform Follow = null;
    public float Speed;
    public string Name = " ";
    int min = 999999999;
    int max = 0;
    public int Age = 0;
   public void asdf()
    { 
        //2.최댓값과 최솟값 찾기
        //정수 배열이 주어졌을 때 배열에서 가장 큰 값과 가장 작은 값을 찾아 출력하세요.
        //예시 입력: [10, 15, 3, 7, 22, 5]
        //예시 출력: 최댓값: 22, 최솟값: 3
        int[] a = { 10, 15, 3, 7, 22, 5, 10, 15, 3, 7, 22, 5 };
        
        for (int i = 0; i < 6; i++)
        {
            //min 과 현재값 비교해서 작으면 패스, 아니면 min값 바꾸고 첨부터 다시
            if (a[i] < min)
            {
                min = a[i];//10 3
            }

            //max 과 현재값 비교해서 작으면 패스, 아니면 max값 바꾸고 첨부터 다시
            if (a[i]> max)
            {
                max = a[i];
            }
        }
       
        Debug.Log("최소값은:" + min + " 최대값은:" + max);
    }
    public void Setting(string name, float speed, int age)
    {
        Speed = speed;
        Name = name;
        Age = age;
        
    }

    void Update()
    {
        
    }


    public void Move(CDIR pDir) //방향을 받는다
    {
        Quaternion rot = new Quaternion();

        Transform trCamera = GameObject.Find("MainCamera").transform;

        //카메라의 방향을 구하는 코드
        if (pDir == CDIR.Up)
        {
            Dir = new Vector3(trCamera.forward.x, 0, trCamera.forward.z); //new vector3(21.357, 207, 11);
            rot = Quaternion.Euler(0, 180, 0);
        }
        else if (pDir == CDIR.Down)
        {
            Dir = -new Vector3(trCamera.forward.x, 0, trCamera.forward.z);
            rot = Quaternion.Euler(0, 0, 0);
        }

        else if (pDir == CDIR.Left)
        {
            Dir = -GameObject.Find("MainCamera").transform.right; //new vector3(-1, 0, 0);
            rot = Quaternion.Euler(0, 90, 0);
        }
        else if (pDir == CDIR.Right)
        {
            Dir = GameObject.Find("MainCamera").transform.right;
            rot = Quaternion.Euler(0, 270, 0);
        }

        /*
        //카메라의 방향 기준으로 이동
        transform.position += dir * Speed * Time.deltaTime;
        */
        //이동할 방향으로 회전
        transform.rotation = rot;
        transform.position += transform.forward * Speed * Time.deltaTime;
        //직진
    }
    public void Move_Tan(Player pFisher)
    {
        //타켓 트렌스폼 쪽을 쳐다봄
        //transform.LookAt(pFisher.transform);
        GameObject a = new GameObject();
        a.transform.position = transform.position;
        a.transform.LookAt(pFisher.Follow);
        transform.rotation = Quaternion.Euler(0, a.transform.rotation.eulerAngles.y, 0);

        //앞으로 전진
        transform.position += transform.forward * Speed * Time.deltaTime;        
    }   
}
