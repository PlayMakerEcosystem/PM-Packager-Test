﻿//-----------------------------------------------------------------------
// <copyright file="HttpWrapper.cs" company="Hutong Games LLC">
// Copyright (c) Hutong Games LLC. All rights reserved.
// </copyright>
// <author name="Jean Fabre"</author>
//-----------------------------------------------------------------------

using System;
using UnityEngine;
using System.Collections;

#pragma warning disable 618

namespace com.hutonggames.playmakereditor.addons.ecosystem
{
	public class HttpWrapper {


		public WWW GET(string url,WWWForm _form,Action<WWW> action)
		{
			CancelFlag = false;
			WWW www = new WWW(url,_form);
			EditorCoroutine.start(ProcessRequest(www,action));
			return www;
		}

		public WWW GET(string url,Action<WWW> action)
		{
			CancelFlag = false;
			WWW www = new WWW(url);
			EditorCoroutine.start(ProcessRequest(www,action));
			return www;
		}

		bool CancelFlag;
		public void Cancel()
		{
			CancelFlag = true;
		}

		IEnumerator ProcessRequest(WWW www,Action<WWW> action)
		{
		
			while (!www.isDone)
			{
				if (CancelFlag)
				{
					yield break;
				}
				yield return null;
			}

			action(www);

			yield break;
		}
	}
}
