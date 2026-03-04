using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public float followSpeed;


    private Vector3 offset;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetMovement = (target.position + offset) - transform.position;

        transform.Translate((targetMovement/10) * followSpeed * Time.deltaTime);

    }
}
