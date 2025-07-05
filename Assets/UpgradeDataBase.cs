using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "UpgradeDatabase", menuName = "Shop/Upgrade Database")]
public class UpgradeDatabase : ScriptableObject
{
    public List<UpgradeItem> upgrades;
}