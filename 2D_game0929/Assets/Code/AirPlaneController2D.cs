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
        }

    }

}
