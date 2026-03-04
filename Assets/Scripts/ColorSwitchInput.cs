using UnityEngine;

public class ColorSwitchInput : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ColorSwitch.ToggleColor();
        }
    }
}
