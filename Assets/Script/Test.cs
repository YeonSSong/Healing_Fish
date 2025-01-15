using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        //for문 문제 10개
        //@1. 1부터 10까지 출력하기
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i + 1);
            //Debug.Log(a[i]);
        }

        //@2. 1부터 20까지의 숫자 중 짝수만 출력하세요.
        for (int i = 0; i < 20; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i + 1);
            }
        }

        //@3.1부터 50까지의 숫자 중 홀수의 합을 계산하고 출력하세요.
        int sum = 0;
        for (int i = 0; i < 50; i++)
        {
            if (!(i % 2 == 0))
            {
                sum += (i + 1);   
            }
        }
        Debug.Log(sum);


        //@4. 구구단 2단 출력하기.
        for (int i = 0; i < 9; i++) 
        {
            //2 4 6 8 10 12 14 16
            //1,2,3,4,5,6,7,8,9.
            Debug.Log((i + 1) * 2);
        }

        //@5. 1부터 10까지 곱한 값을 출력
        int multiple = 1;
        for (int i = 0; i < 10; i++) //0123456789
        {
            multiple *= (i + 1); //multiple = multiple * (i + 1)            
        }
        Debug.Log(multiple);

        //@6. 10부터 1까지 거꾸로 숫자를 출력하세요.
        for (int i = 10; i > 0; i--)
        {
            Debug.Log(i);
        }


        //@7. 1부터 30까지의 숫자 중 3의 배수만 출력하세요.
        for (int i = 1; i <= 30; i++)
        {            
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }

        //@8. 1부터 20까지의 평균을 계산하세요.
        int Average = 0;
        for (int i = 0; i < 20; i++)
        {
            //다더해
            Average += (i + 1);            
        }
        Debug.Log(Average / 20);

        //@9. 1부터 100까지 숫자 중 홀수의 합과 짝수의 합을 각각 계산한 후, 어느 합이 더 큰지 출력하세요.
        int H = 0;
        int Z = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Z += (i);
            }
            else
            {
                H += (i);
            }
        }
        if (H > Z)
        {
            Debug.Log(H);
        }
        else if (Z > H)
        {
            Debug.Log(Z);
        }



        //배열 문제 10개
        //@1. 배열 값 출력하기
        int[] numbers1 = { 1, 2, 3, 4, 5 };


        //@2. 다음 배열에서 가장 큰 값을 찾아 출력하세요.
        int[] numbers2 = { 3, 5, 7, 2, 8 };

        //@3. 배열 역순 출력
        int[] numbers3 = { 10, 20, 30, 40, 50 };

        //@4.배열 값 합계 계산
        //다음 배열의 모든 값의 합을 계산하세요.
        int[] numbers4 = { 1, 2, 3, 4, 5 };

        //@5.짝수 값만 출력하기
        //다음 배열에서 짝수 값만 출력하세요.
        int[] numbers5 = { 10, 15, 20, 25, 30 };

        //@6.배열의 특정 값 개수 세기
        //배열에서 숫자 5가 몇 번 등장하는지 출력하세요.
        int[] numbers6 = { 5, 1, 5, 7, 5, 3, 5 };

        //@7.배열 평균 계산하기
        //다음 배열의 평균 값을 계산하세요.
        int[] numbers7 = { 10, 20, 30, 40, 50 };

        //@8.배열 중복 값 확인하기
        //배열에 중복된 값이 있는지 확인하고, 있다면 어떤 값인지 출력하세요.
        int[] numbers8 = { 1, 2, 3, 4, 5, 3, 2 };

        //@9.배열 정렬하기(오름차순)
        //배열을 오름차순으로 정렬하세요.
        int[] numbers9 = { 7, 3, 9, 1, 5 };

        //@10.두 배열 합치기
        //두 배열을 합쳐 하나의 배열로 출력하세요.
        int[] array1 = { 1, 2, 3 };
                int[] array2 = { 4, 5, 6 };



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
