using UnityEngine;

public class Control : MonoBehaviour
{

    public int a;
    public int b;
    public string fruit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*   
     if(a>b)
         {
             Debug.Log("a가 b보다 큽니다");
         }
         else if(a<b)
         {
             Debug.Log("a가 b보다 작습니다");
         }
         else
         {
             Debug.Log("a와 b는 같습니다");
         }


         switch(this.fruit)
         {
             case "사과":
                 Debug.Log("사과는 빨개");
                 break;

             case "바나나":
                 Debug.Log("바나나는 길어");
                 break;

             case "포도":
                 Debug.Log("포도는 마시써");
                 break;

             default:
                 Debug.Log("아무 과일도 찾을 수 없습니다");
                 break;






         }

         for(int i = 0; i<5; i++)
         {
             Debug.Log("i의 값: " + i);
         }

         int j = 0;
         j++;
         Debug.Log("j 의 값" + j);

         while (a < 10)
         {
             Debug.Log("a 의 값" + a);
             a++;
         }
     }
     */
        string[] array = new string[5];
        array[0] = "김민주";
        array[1] = "김채원";
        array[2] = "오승아";
        array[3] = "임유정";
        array[4] = "김선화";

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        int[] scores = { 90, 85, 78, 92, 88 };
        int[] array2 = new int[3];

        for (int j = 0; j < array2.Length; j++)
        {
            Debug.Log("배열의 값" + j + ": " + array2[j]);
        }
        /*
        string[,] zoo = new string[3, 3];
        zoo[0, 0] = "사자";
        zoo[0, 1] = "사컴퍼스";
        zoo[0, 2] = "사스케";
        zoo[1, 0] = "사안토끼";
        zoo[1, 1] = "사지우개";
        zoo[1, 2] = "사연필";
        zoo[2, 0] = "사볼펜";
        zoo[2, 1] = "사인펜";
        zoo[2, 1] = "사랑해";
        */
      
       
    }
}
     // Update is called once per frame