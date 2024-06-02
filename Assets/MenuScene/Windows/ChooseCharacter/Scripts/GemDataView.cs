using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GemDataView : AbstractDataView<GemData>, IPointerClickHandler
{
    [SerializeField] TextMeshProUGUI Name;
    [SerializeField] Image sprite;
    [SerializeField] Image SelectorImage;

    public override void Init(GemData data)
    {
        Name.text = data.Name;
        sprite.sprite = data.sprite;
        SelectorImage.gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnSelected();
    }

    public override void Select()
    {
        SelectorImage.gameObject.SetActive(true);
    }
    public override void UnSelect()
    {
        SelectorImage.gameObject.SetActive(false);
    }


}
