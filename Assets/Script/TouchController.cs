using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public float velocity = 1f;
    public Vector2 pastPosition;
    private void Start()
    {
        
    }
    private void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Move(Input.mousePosition.x - pastPosition.x);
        }
        pastPosition = Input.mousePosition;
    }
    public void Move(float speed)
    {
        transform.position +=  Vector3.right * Time.deltaTime * speed * velocity;
    }
}
