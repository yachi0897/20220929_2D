using UnityEngine;
namespace FOX
{
    /// <summary>
    /// �ˮ`�t��
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        [SerializeField, Header("�z���w�m��")]
        private GameObject prefabExplosion;

        //�I���}�l�ƥ� �@��
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("�I��:" +collision.gameObject);
            //�p�G �I�쪫�󪺦W�� �]�t�ľ� �N�z��
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);
                //Destroy �R��
                //gameObject ������
                Destroy(gameObject);
            }
        }
        // �I�����}�ƥ� �@��
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }
        //�I������ƥ�
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }



}



        
  