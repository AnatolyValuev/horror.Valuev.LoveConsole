using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float runSpeed = 5f;
    [SerializeField] private float speedJump = 1;

    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";
    private const string Running = "Running";
    private const string Jump = "Jump";




    private Vector3 direction;
    private bool isRunning;



    void Update()
    {
        direction.x = Input.GetAxis(Horizontal);
        direction.z = Input.GetAxis(Vertical);
        direction.y = Input.GetAxis(Jump);



        isRunning = Input.GetButton(Running);

        transform.position += direction * ((isRunning ? runSpeed : speed) * Time.deltaTime);





    }
}
