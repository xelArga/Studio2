using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;

    private Rigidbody ballRB;
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();

        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
    void Update()
    {
        
    }
}
