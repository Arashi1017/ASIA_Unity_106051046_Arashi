using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位區域
    [Header("動畫參數名稱")]
    public string perRun = "跑步開關";
    #endregion

    public Animator ani;

    #region 方法區域
    /// <summary>
    /// 跑步方法
    /// </summary>
    private void Run()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        ani.SetBool("跑步開關", h != 0 || v != 0);
    }

    #endregion

    private void Update()
    {
        Run();
    }


}
