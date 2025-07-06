using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public static PointManager Instance;
    public int money = 0;
    public Text moneyText;

    void Awake()
    {
        Instance = this;
    }

    public void AddPoints(int amount)
    {
        money += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (moneyText != null)
            moneyText.text = "$" + money.ToString();
    }
}

