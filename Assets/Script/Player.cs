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
        //2.�ִ񰪰� �ּڰ� ã��
        //���� �迭�� �־����� �� �迭���� ���� ū ���� ���� ���� ���� ã�� ����ϼ���.
        //���� �Է�: [10, 15, 3, 7, 22, 5]
        //���� ���: �ִ�: 22, �ּڰ�: 3
        int[] a = { 10, 15, 3, 7, 22, 5, 10, 15, 3, 7, 22, 5 };
        
        for (int i = 0; i < 6; i++)
        {
            //min �� ���簪 ���ؼ� ������ �н�, �ƴϸ� min�� �ٲٰ� ÷���� �ٽ�
            if (a[i] < min)
            {
                min = a[i];//10 3
            }

            //max �� ���簪 ���ؼ� ������ �н�, �ƴϸ� max�� �ٲٰ� ÷���� �ٽ�
            if (a[i]> max)
            {
                max = a[i];
            }
        }
       
        Debug.Log("�ּҰ���:" + min + " �ִ밪��:" + max);
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


    public void Move(CDIR pDir) //������ �޴´�
    {
        Quaternion rot = new Quaternion();

        Transform trCamera = GameObject.Find("MainCamera").transform;

        //ī�޶��� ������ ���ϴ� �ڵ�
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
        //ī�޶��� ���� �������� �̵�
        transform.position += dir * Speed * Time.deltaTime;
        */
        //�̵��� �������� ȸ��
        transform.rotation = rot;
        transform.position += transform.forward * Speed * Time.deltaTime;
        //����
    }
    public void Move_Tan(Player pFisher)
    {
        //Ÿ�� Ʈ������ ���� �Ĵٺ�
        //transform.LookAt(pFisher.transform);
        GameObject a = new GameObject();
        a.transform.position = transform.position;
        a.transform.LookAt(pFisher.Follow);
        transform.rotation = Quaternion.Euler(0, a.transform.rotation.eulerAngles.y, 0);

        //������ ����
        transform.position += transform.forward * Speed * Time.deltaTime;        
    }   
}
