using Better.Attributes.Runtime.DrawInspector;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [DrawInspector]
    [SerializeField]
    private PlayerControllerData data;
    
    [SerializeField]
    private Rigidbody2D playerRigidbody;

    private bool _isMoveLeft;
    private bool _isMoveRight;

    private void Update()
    {
        _isMoveLeft = Input.GetKey(data.LeftKey);
        _isMoveRight = Input.GetKey(data.RightKey);
    }

    private void FixedUpdate()
    {
        if (_isMoveLeft)
        {
            playerRigidbody.velocity = data.Speed * Time.deltaTime * Vector3.left;
        }

        if (_isMoveRight)
        {
            playerRigidbody.velocity = data.Speed * Time.deltaTime * Vector3.right;
        }
    }

}
