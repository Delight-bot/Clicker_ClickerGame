using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public static PointsManager Instance;
    public float points = 0;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void AddPoints(float amount)
    {
        points += amount;
        //UIManager.Instance.UpdatePointDisplay(points);
    }
}