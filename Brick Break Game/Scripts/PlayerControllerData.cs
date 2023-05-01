using Better.Attributes.Runtime.Select;
using UnityEngine;

[CreateAssetMenu(menuName = "Data")]
public class PlayerControllerData : ScriptableObject
{
    [SerializeField]
    private float speed;

    [SelectEnum]
    [SerializeField]
    private KeyCode leftKey;

    [SelectEnum]
    [SerializeField]
    private KeyCode rightKey;

    public float Speed => speed;
    public KeyCode LeftKey => leftKey;
    public KeyCode RightKey => rightKey;
}