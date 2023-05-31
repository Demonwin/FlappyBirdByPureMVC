/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题：控制层--> （管道）金币（隐藏）触发检测
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
using PureMVC.Patterns;
using UnityEngine;

namespace PureMVCDemo
{
	public class Ctrl_Golds : MonoBehaviour {
        //模型代理
	    private Model_GameDataProxy _proxyObj;  
        //是否开始
	    private bool _IsStartGame = false;



	    /// <summary>
        /// 开始游戏
        /// </summary>
	    public void StartGame()
	    {
            _proxyObj = Facade.Instance.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;
            //开始游戏
            _IsStartGame = true;
	    }

        /// <summary>
        /// 结束游戏
        /// </summary>
	    public void StopGame()
	    {
            _IsStartGame = false;
        }

        /// <summary>
        /// 触发检测
        /// </summary>
        /// <param name="collision"></param>
        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (_IsStartGame)
            {
                if (collision.gameObject.tag==ProjectConsts.Player)
                {
                    _proxyObj.AddScores();
                }

            }
        }
	}
}