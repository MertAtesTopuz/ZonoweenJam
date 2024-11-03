using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [Header("UI")]
    public Image image;
    private BoxCollider2D col;

    public Vector2 screenPos;
    public Vector2 worldPos;

    [HideInInspector] public Item item;
    [HideInInspector] public int count = 12;
    [HideInInspector] public Transform parentAfterDrag;

    private void Start()
    {
        col = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        screenPos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(screenPos);
    }

    public void InitialiseItem(Item newItem)
    {
        item = newItem;
        image.sprite = newItem.image;
        RefreshCount();
    }

    public void RefreshCount()
    {
        bool textActive = count > 1;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        col.enabled = true;
        transform.SetAsLastSibling();

        
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = worldPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        image.raycastTarget = true;
        transform.SetParent(parentAfterDrag);
        col.enabled = false;
    }

    public void DestroyItem()
    {
        InventoryManager.instance.GetSelectedItem(true);
    }
}
