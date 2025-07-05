using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeItem", menuName = "Shop/Upgrade Item")]
public class UpgradeItem : ScriptableObject
{
    public string upgradeName;
    public int cost;
    public int passiveIncomeIncrease;
    public Sprite icon;
}