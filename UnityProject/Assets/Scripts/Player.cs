using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 playerCoordinatesL_wrist, playerCoordinatesR_wrist;
    public static Player Instance;
    [SerializeField] Transform leftWrist, rightWrist;
    [HideInInspector] public int count = 0;

    private void Start()
    {
        Instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        leftWrist.position = ConvertCoordinates(playerCoordinatesL_wrist);
        rightWrist.position = ConvertCoordinates(playerCoordinatesR_wrist);
    }
    Vector3 ConvertCoordinates(Vector2 coordinates)
    {
        float X = Screen.width - coordinates.x;
        float Y = Screen.height - coordinates.y;
        return Camera.main.ScreenToWorldPoint(new Vector3(X, Y, Camera.main.nearClipPlane));
    }
}
