using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public UpgradeDatabase upgradeDatabase;
    public Transform shopUIParent;
    public GameObject upgradeUIPrefab;

    void Start()
    {
        PopulateShop();
    }

    void PopulateShop()
    {
        foreach (UpgradeItem item in upgradeDatabase.upgrades)
        {
            GameObject upgradeUI = Instantiate(upgradeUIPrefab, shopUIParent);
            UpgradeUI uiScript = upgradeUI.GetComponent<UpgradeUI>();
            uiScript.Setup(item);
        }
    }
}
