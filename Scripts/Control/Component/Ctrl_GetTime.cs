/***
 * 
 *    Title: "FlappyBirdsByMVC" 项目
 *           主题： 控制层--> 得到时间。
 *    Description: 
 *           功能：控制脚本，每个1秒钟，取得一次时间。
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
	public class Ctrl_GetTime : MonoBehaviour {
        //模型代理
	    public Model_GameDataProxy dataProxy = null;
        //游戏是否开始
	    private bool IsStartGame = false;


        /// <summary>
        /// 游戏开始
        /// </summary>
	    public void StartGame()
        {
            //得到模型层类的对象实例
            //dataProxy = Facade.Instance.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;
	        IsStartGame = true;
	    }

        /// <summary>
        /// 游戏结束
        /// </summary>
	    public void StopGame()
	    {
	        IsStartGame = false;
	    }


	    void Start () {
            //得到模型层类的对象实例
            dataProxy = Facade.Instance.RetrieveProxy(Model_GameDataProxy.NAME) as Model_GameDataProxy;
			//启动协程，每隔一秒种，往PureMVC 模型层发送一条消息。
            StartCoroutine("GetTime");
		}

        /// <summary>
        /// 协程，得到时间
        /// </summary>
        /// <returns></returns>
	    private IEnumerator GetTime()
	    {
	        yield return new WaitForEndOfFrame();
	        while (true)
	        {
	            yield return new WaitForSeconds(1F);
                if (dataProxy != null && IsStartGame)
	            {
	                //调用(Mediator)模型层方法
                    dataProxy.AddGameTime();
                }
	        }

	    }



	}
}