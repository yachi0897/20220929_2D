using UnityEngine;


namespace FOX
{
    /// <summary>
    /// 玩家結束管理 :死亡或通關
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        //被刪除時會執行一次
        private void OnDestroy()
        {
            //死亡
            Fox.FinalManager.instance.GameOver("Youdie");
        }
        //碰到勾選 Is Trigger 物件時會執行一次
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //過關
            Fox.FinalManager.instance.GameOver("遊戲通過");
        }
    }

}

