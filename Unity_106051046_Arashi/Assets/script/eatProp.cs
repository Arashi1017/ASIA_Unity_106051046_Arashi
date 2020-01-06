using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class eatProp : MonoBehaviour
{
    public DialogSystem Ds;

    [Header("道具數量")]
    public Text textCount;
    [Header("提示畫面")]
    public GameObject objTip;

    public int propCount;
    public int propTotal = 10;

    public bool finish;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "道具")
        {
            Destroy(collision.gameObject);
            propCount++;
            textCount.text = "道具數 : " + propCount;

            if (propCount == propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }

        }

        if (collision.gameObject.name =="紅藥水")
        {
            Ds.ShowDialog("小美", "這是...藥水?");
        }
        else if (collision.gameObject.name == "地板")
        {
            Ds.ShowDialog("小美", "前面好像是迷宮，總之先多找一些道具吧。");
        }


        

    }


    private void Update()
    {
        GameOver();
    }


    private void GameOver()
    {
        if (finish)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("場景");
            }
        }
    }

}
