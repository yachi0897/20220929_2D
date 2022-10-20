using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
///  <summary>
///  第一個程式
///  </summary>

    #region 
    // 縮排 快捷鍵 Tab
    // 格式化文件 ctrl +KD
    // 單行註解
    /*
    *
    *BLABLABLA
    */
    #endregion


#region  事件區域
// 喚醒事件:遊戲開始時執行一次
    private void Awake()
    {
     //輸出(訊息);
     print("Hello,WORLD");
    }
// 開始事件 : 在 Awake 後執行一次
private void Start()
{
     print("<color=yellow>這是開始事件</color>");
}

//更新事件 : 在 Start 後執行 , 執行次數約 60 FPS
private void update()
{
    print ("<color=red>更新事件 ! </color>");
}



#endregion


}

    
