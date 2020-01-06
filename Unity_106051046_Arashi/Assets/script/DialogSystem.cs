using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    [Header("介面")]
    public Text textName;
    public Text textContent;
    public CanvasGroup uiGroup;

    
    /// <summary>
    /// 顯示對話系統
    /// </summary>
    /// <param name="getName">取得名稱</param>
    /// <param name="getContent">取得內容</param>
    public void ShowDialog(string getName,string getContent)
    {
        uiGroup.alpha = 1;
        textName.text = getName;
        textContent.text = getContent;
    }

    public void HideDialog()
    {
        uiGroup.alpha = 0;
    }

}
