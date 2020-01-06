using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    #region 欄位區域
    [Header("動畫參數名稱")]

    public string perRun = "跑步開關";
    public string perJump = "跳躍開關";
    #endregion

    public Animator ani;

    public DialogSystem Ds;

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

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ani.SetBool("跳躍開關", true);
        }
        else
        {
            ani.SetBool("跳躍開關", false);
        }
    }


    #endregion

    private void Update()
    {
        Run();
        Jump();

    }


}
