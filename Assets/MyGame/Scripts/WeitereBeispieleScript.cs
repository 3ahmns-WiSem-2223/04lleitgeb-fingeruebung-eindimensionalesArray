using System;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class WeitereBeispieleScript : MonoBehaviour
{
    int[] array6 = new int[251];
    int[] array5 = new int[26];
    int[] array7 = new int[250];
    string[] array8 = new string[100];
    int[] array9 = new int[1000];
    int[] array11 = new int[1000];
    int[] array12 = new int[1000];
    int[] array13 = new int[20];
    int[] histogramm = new int[5];


    void Start()
    {
        GeradeNummern();
        GeradeZahlen();
        UngeradeZahlen();
        RandomValue(1);
        MinMaxValue();
        RandomNumbers();
        MergeArray();
        StringValues();
        Histogramm();
    }

    private void GeradeNummern()
    {
        int a = 0;
        for (int i = 0; i <= 500; i = i + 2)
        {
            array6[a] = i;
            Debug.Log(array6[a]);
            a++;
        }
    }


    private void GeradeZahlen()
    {
        int a = 0;
        for (int i = 20; i <= 70; i = i + 2)
        {
            array5[a] = i;
            Debug.Log(array5[a]);
            a++;
        }
    }


    private void UngeradeZahlen()
    {
        int a = 0;
        for (int i = 1; i <= 500; i = i + 2)
        {
            array7[a] = i;
            Debug.Log(array7[a]);
            a += 1;
        }
    }

    private void RandomValue(int a)
    {
        for (int i = 0; i < array12.Length; i++)
        {
            array12[i] = Random.Range(1, 1001);
        }

        Debug.Log("index: " + Array.IndexOf(array12, a));
    }


    private void MinMaxValue()
    {
        int max = array11[0];
        int min = array11[0];

        for (int i = 0; i < array11.Length; i++)
        {
            array11[i] = Random.Range(1, 1001);
            foreach (int value in array11)
            {
                if (value > max)
                {
                    max = value;
                }
                if (value < min)
                {
                    min = value;
                }
            }
        }

        Debug.Log("MinValue: " + min);
        Debug.Log("MaxValue: " + max);
    }


    private void RandomNumbers()
    {
        for (int i = 0; i < array9.Length; i++)
        {
            array9[i] = Random.Range(1, 1001);
            Debug.Log(array9[i]);
        }

        Array.Sort(array9);
        foreach (int i in array9)
        {
            Debug.Log(i + " ");
        }
    }


    private void MergeArray()
    {
        int[] array10 = array5.Concat(array6).ToArray();
        Debug.Log(array10[0]);
    }


    private void StringValues()
    {
        string lastString = "a";
        for (int i = 0; i < array8.Length; i++)
        {
            if (lastString == "a" || i == 0)
            {
                array8[i] = "b";
                lastString = array8[i];
                Debug.Log(array8[i]);
            }

            if (array8[i] != "b")
                if (lastString == "b")
                {
                    array8[i] = "a";
                    lastString = array8[i];
                    Debug.Log(array8[i]);
                }
        }
    }


    private void Histogramm()
    {
        for (int i = 0; i < array13.Length; i++)
        {
            array13[i] = Random.Range(1, 6);
        }

        foreach (int number in array13)
        {
            if (number == 5)
            {
                histogramm[0]++;
            }
            if (number == 4)
            {
                histogramm[1]++;
            }
            if (number == 3)
            {
                histogramm[2]++;
            }
            if (number == 2)
            {
                histogramm[3]++;
            }
            if (number == 1)
            {
                histogramm[4]++;
            }
        }
    }
}