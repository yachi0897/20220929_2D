using UnityEngine;


namespace FOX
{
    /// <summary>
    /// ���a�����޲z :���`�γq��
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        //�Q�R���ɷ|����@��
        private void OnDestroy()
        {
            //���`
            Fox.FinalManager.instance.GameOver("�D�ԥ���!");
        }
        //�I��Ŀ� Is Trigger ����ɷ|����@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //�L��
            Fox.FinalManager.instance.GameOver("�C���q�L");
        }
    }

}

