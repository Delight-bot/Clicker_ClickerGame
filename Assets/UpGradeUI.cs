using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeUI : MonoBehaviour
{
    public Text nameText;
    public Text descriptionText;
    public Text costText;
    //public Image icon;

    public int timesPurchased = 0;
    public float currentCost;

    private UpgradeItem upgradeItem;
    private Button button;

    void Start()
    { 
        button = GetComponent<Button>();
    }

    void Update()
    {
        if (PointsManager.Instance.points >= currentCost)
        {
            button.interactable = true;
        }
        else
        { 
            button.interactable = false;
        }

    }

    public void Setup(UpgradeItem item)
    {
        currentCost = math.round(item.cost * math.pow(1.4f, timesPurchased));

        upgradeItem = item;
        nameText.text = item.upgradeName;
        descriptionText.text = "Produces +$" + item.passiveIncomeIncrease + " per second";
        costText.text = "$" + currentCost.ToString();
        //icon.sprite = item.icon;

    }

    public void OnBuyClicked()
    {

        if (PointsManager.Instance.points >= currentCost)
        {
            timesPurchased++;
            PointsManager.Instance.AddPoints(-currentCost);
            GameManager.Instance.IncreasePassiveIncome(upgradeItem.passiveIncomeIncrease);

            Setup(upgradeItem);
        }
    }
}
