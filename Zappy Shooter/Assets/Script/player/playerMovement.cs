using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private PlayerInputData inputData;
    [SerializeField] private float moveSpeed = 5f;

    private void Update()
    {
        transform.position += inputData.input * moveSpeed * Time.deltaTime;
    }
}
