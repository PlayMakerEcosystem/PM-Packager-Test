﻿//-----------------------------------------------------------------------
// <copyright file="EditorCoroutine.cs" company="Hutong Games LLC">
// Copyright (c) Hutong Games LLC. All rights reserved.
// </copyright>
// <author name="Jean Fabre"</author>
//-----------------------------------------------------------------------

// orginal code: https://gist.github.com/benblo/10732554


using System.Collections;
using UnityEditor;

namespace com.hutonggames.playmakereditor.addons.ecosystem
{
	public class EditorCoroutine
	{

		public static EditorCoroutine start( IEnumerator _routine )
		{
			EditorCoroutine coroutine = new EditorCoroutine(_routine);
			coroutine.start();
			return coroutine;
		}

		public static EditorCoroutine startManual( IEnumerator _routine )
		{
			EditorCoroutine coroutine = new EditorCoroutine(_routine);
			return coroutine;
		}

		public readonly IEnumerator routine;
		EditorCoroutine( IEnumerator _routine )
		{
			routine = _routine;
		}
		
		void start()
		{
			//Debug.Log("start");
			EditorApplication.update += update;
		}
		public void stop()
		{
			//Debug.Log("stop");
			EditorApplication.update -= update;
		}
		
		void update()
		{
			/* NOTE: no need to try/catch MoveNext,
			 * if an IEnumerator throws its next iteration returns false.
			 * Also, Unity probably catches when calling EditorApplication.update.
			 */
			
			//Debug.Log("update");
			if (!routine.MoveNext())
			{
				stop();
			}
		}
	}
}