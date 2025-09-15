using UnityEngine;

public class ExceoptionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string inputnumber = "3.14";
        int number = 0;

        try
        {
            number = System.Convert.ToInt32(inputnumber);
            Debug.Log($"입력한 값은: {number}");
        }
        catch(System.FormatException ex)
        {
            Debug.Log(ex.Message);
        }

        /*catch (System.FormatException fe)
        {
            Debug.Log(fe.Message);
            Debug.Log($"{inputnumber}는 정수이어야 합니다.");
        }*/


    }

}
