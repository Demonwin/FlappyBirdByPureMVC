/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 控制层-->小鸟控制脚本
 *    Description: 
 *           功能：
 *                  
 *    Date: 2017
 *    Version: 0.1版本
 *    Modify Recoder: 
 *    
 *   
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PureMVCDemo
{
    [RequireComponent(typeof(Rigidbody2D))]
	public class Ctrl_HeroControl : MonoBehaviour {
        //升力
	    public float floUPPower = 3F;
        //2D刚体
	    private Rigidbody2D rd2D;
        //主角原始位置
	    private Vector2 _VecHeroOriginalPosition;
        //游戏是否开始
	    private bool _IsGameStart = false;



        //游戏开始
        public void StartGame()
        {
            _IsGameStart = true;
            //启用2D刚体
            this.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            //恢复小鸟的原始方位
            this.gameObject.transform.position = _VecHeroOriginalPosition;
        }

        //游戏结束
        public void StopGame()
        {
            _IsGameStart = false;
            //恢复小鸟的原始方位
            //this.gameObject.transform.position = _VecHeroOriginalPosition;
            //禁用2D刚体。
            DisableRigibody2D();
        }


        void Start () {
			//保存原始的方位
		    _VecHeroOriginalPosition = this.gameObject.transform.position;
		    //获取2D刚体
		    rd2D = this.gameObject.GetComponent<Rigidbody2D>();
		    //禁用2D刚体。
		    DisableRigibody2D();
        }

        /// <summary>
        /// 接收玩家的输入
        /// </summary>
        void Update()
        {
            if(_IsGameStart)
            {
                if (Input.GetButton(ProjectConsts.Fire1))
                {
                    rd2D.velocity = Vector2.up*floUPPower;
                }
            }        
        }

        //禁用2D刚体。
        private void DisableRigibody2D()
        {
            this.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        }

	}
}