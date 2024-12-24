using UnityEngine;

public class PhysicTest : MonoBehaviour
{
    public LayerMask layer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.OverlapCircle(gameObject.transform.position, 2f, layer)){
            Debug.Log("!");
        }   
    }
}
