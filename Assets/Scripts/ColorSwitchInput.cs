using UnityEngine;

public class ColorSwitchInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("ColorSwitch"))
        {
            ColorSwitch.ToggleColor();
        }
    }
}
