using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class PointsDisplayUI : MonoBehaviour
{
    public TextMeshProUGUI TotalPointsText;
    public TextMeshProUGUI PointsPerSecondText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TotalPointsText.text = "$" + math.round(PointsManager.Instance.points).ToString();
        PointsPerSecondText.text = "$" + GameManager.Instance.passiveIncomeAmount.ToString() + " Per Second";
    }
}
