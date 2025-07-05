using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public float passiveIncomeAmount = 1f;
    private float passiveIncomeRate = 0.1f;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        StartCoroutine(PassiveIncomeRoutine());
    }

    private IEnumerator PassiveIncomeRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(passiveIncomeRate);
            PointsManager.Instance.AddPoints(passiveIncomeAmount/10);
        }
    }

    public void IncreasePassiveIncome(float amount)
    {
        passiveIncomeAmount += amount;
    }
}
