using UnityEngine;

public class CollectibleCount : MonoBehaviour
{

    TMPro.TMP_Text text;
    int count;
    private int total;

    void Awake()
    {
        text= GetComponent<TMPro.TMP_Text>();
    }

    void Start()
    {
        total = Collectible.total;
        UpdateCount();
    }
    void OnEnable() => Collectible.OnCollected += OnCollectibleCollected;
    void OnDisable() => Collectible.OnCollected -= OnCollectibleCollected;

    void OnCollectibleCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"Coin: {count} / {total}";
    }
}
