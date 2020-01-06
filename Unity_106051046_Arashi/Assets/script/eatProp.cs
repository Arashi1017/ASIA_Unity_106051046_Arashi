using UnityEngine;
using UnityEngine.UI;

public class eatProp : MonoBehaviour
{
    public DialogSystem Ds;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "道具")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name =="紅藥水")
        {
            Ds.ShowDialog("小美", "這是...藥水?");
        }
        else if (collision.gameObject.name == "地板")
        {
            Ds.ShowDialog("小美", "前面好像是迷宮，總之先多找一些道具吧。");
        }
        else if(collision.gameObject.name == "地板 (1)")
        {
            Ds.HideDialog();
        }

    }

    
}
