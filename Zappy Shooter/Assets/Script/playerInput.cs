using UnityEngine;
using UnityEngine.InputSystem;
public class playerInput : MonoBehaviour
{
    [SerializeField] private PlayerInputData inputData;
    private void OnMove(InputValue value)
    {
        inputData.input = new Vector3(value.Get<Vector2>().x, 0, value.Get<Vector2>().y);
    }
}
