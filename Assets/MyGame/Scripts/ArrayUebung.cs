using UnityEngine;

public class ArrayUebung : MonoBehaviour
{
    int[] array;

    int[] array1 = new int[4];
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    string[] array4 = new string[10];

    private void Start()
    {
        array4[0] = "array4";
        GameObject[] arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        Debug.Log(array1[0]);

        Debug.Log(array1[0]);
        Debug.Log(array1[3]);
        Debug.Log(array2[0]);
        Debug.Log(array2[3]);
        Debug.Log(array3[0]);
        Debug.Log(array3[6]);
        Debug.Log(array4[0]);
        Debug.Log(array4[9]);
        Debug.Log(arrayColoredImagesRed[0].name);
        Debug.Log(arrayColoredImagesRed[3].name);

        WerteWiedergabe();
        StringWiedergabe();
    }


    private void WerteWiedergabe()
    {
        int[] werteArray = new int[5] { 1, 2, 3, 4, 5 };

        for (int i = 0; i < werteArray.Length; i++)
        { 
            Debug.Log(werteArray[i]++ + "= Element" + i);
        }
    }

    private void StringWiedergabe()
    {
        int[] stringWiedergabe = new int[4] { 1, 2, 3, 4};
        string text = " ";

        for (int i = 0; i < stringWiedergabe.Length; i++)
        {
            text += stringWiedergabe[i] + " ";
        }
        Debug.Log(text);

    }


}
