using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float x_rotateSpeed = 0.5f;

    [SerializeField] private float y_rotateSpeed = 0.5f;

    [SerializeField] private float z_rotateSpeed = 0.5f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(x_rotateSpeed, y_rotateSpeed, z_rotateSpeed);
        transform.position = new Vector3(0, Mathf.Sin(Time.time) + 2, 0);
    }
}