using UnityEngine;

public class ColorSwitch : MonoBehaviour
{
    public static CurrentColor activeColor = CurrentColor.Red;
    public static bool playerInCollider;

    [Header("References")]
    private MeshRenderer meshRenderer;
    private Collider objCollider;


    [Header("ColorSwitch settings")]
    [SerializeField] private CurrentColor objectColor = CurrentColor.Red;
    [SerializeField] private Material activatedMaterial;
    [SerializeField] private Material deactivatedMaterial;


    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        objCollider = GetComponent<Collider>();
    }

    public void OnColorSwitch()
    {
        if (playerInCollider)
            return;

        activeColor = activeColor == CurrentColor.Red ? CurrentColor.Blue : CurrentColor.Red;

        ColorSwitch[] ColorSwitchObjects = FindObjectsByType<ColorSwitch>(FindObjectsSortMode.None);

        foreach (ColorSwitch csObject in ColorSwitchObjects)
        {
            csObject.ChangeState();
        }
    }

    private void ChangeState()
    {
        if (activeColor == objectColor)
        {
            meshRenderer.material = activatedMaterial;
            objCollider.isTrigger = false;
        }
        else
        {
            meshRenderer.material = deactivatedMaterial;
            objCollider.isTrigger = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInCollider = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInCollider = false;
        }
    }

    public enum CurrentColor
    {
        Red,
        Blue
    }
}
