using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text text;

    private void Start()
    {
        string decimals = "" + Time.timeSinceLevelLoad % 1;
        
        text.text = "" + Mathf.Floor(Time.timeSinceLevelLoad) + ":" + decimals.Substring(2,2) + " Seconds" ;
    }
}
