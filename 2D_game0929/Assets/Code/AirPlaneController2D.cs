using UnityEngine;
namespace FOX

{
    ///<summary>
    ///飛機控制器 2D 模式
    ///</summary>
    public class AirPlaneController2D : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField]
        private Sprite pictureUP;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;

        [SerializeField,Header("圖片渲染元件")]
        private SpriteRenderer spr;

        private void Update()
        {

            // 上下 WS Vertical
            // 左右 AD Horizontal

            // 上 W +1
            // 下 S -1
            // 沒按 0
            float v = Input.GetAxis("Vertical");
            // 右 D +1
            // 左 A-1
            // 沒按 0 
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHorizontal * Time.deltaTime*h,
                speedVertical * Time.deltaTime*v, 0);


            //如果 v 大於 0 圖片 換成 往上
            if (v > 0 )
            {
                print("往上");
                spr.sprite = pictureUP;
            }
            // 如果 v 小於 0 圖片 換成 往下
            if (v < 0)
            {
                print("往下");
                spr.sprite = pictureDown;
            }
            //如果 V 等於 0 圖片 換成 中間
            if (v == 0)
            {
                print("中間");
                spr.sprite = pictureMiddle;
            }










        }

    }

}
