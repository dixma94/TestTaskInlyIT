using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GemDataView : AbstractDataView<GemData>, IPointerClickHandler
{
    [SerializeField] TextMeshProUGUI Name;
    [SerializeField] Image sprite;
    [SerializeField] Image SelectorImage;

    public override async void Init(GemData data)
    {
        this.data = data;
        Name.text = data.Name;
        sprite.sprite = Resources.Load<Sprite>(data.spriteName);
        SelectorImage.gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnSelected();
    }

    public override void Select()
    {
        SelectorImage.gameObject.SetActive(true);
        DataSaveLoader.instance.Save(data);
    }
    public override void UnSelect()
    {
        SelectorImage.gameObject.SetActive(false);
    }


}
