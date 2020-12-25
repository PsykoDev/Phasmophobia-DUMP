﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

namespace VRTK
{
	public abstract class VRTK_BaseObjectControlAction : MonoBehaviour // TypeDefIndex: 7613
	{
		// Fields
		public VRTK_ObjectControl u0925u0920u091Cu091Au0928u0926u091Du091Fu091Fu0923u091D; // 0x18
		public u0927u091Fu0929u0924u091Du091Bu091Bu091Eu091Au0922u0924 u0929u091Eu0920u0927u0922u0921u0926u0922u0927u0928u091E; // 0x20
		protected Collider u091Fu0925u091Cu0922u0927u0924u091Au091Au091Au091Du091D; // 0x28
		protected Vector3 u0926u0922u091Bu0929u0924u0928u0921u091Cu091Du0926u0922; // 0x30
		protected float u0922u0925u0923u091Bu091Cu0925u091Bu0920u0929u0926u0929; // 0x3C
		protected float u0924u091Bu0925u091Eu0928u091Bu0923u091Eu091Cu0928u0922; // 0x40
		protected Transform u091Cu091Bu0921u0921u091Du091Au0929u091Du0924u0927u0922; // 0x48
		protected Transform u0923u0926u091Du091Bu091Eu091Eu0926u091Du0922u0925u091F; // 0x50
		protected Vector3 u091Eu0925u0923u091Eu0929u091Bu091Du0923u0921u091Eu0927; // 0x58
		protected Transform u0921u0922u0926u091Eu0921u0929u0925u091Fu091Au0928u0923; // 0x68
		protected bool u091Fu0929u091Bu0929u0929u091Eu0926u0921u091Cu0928u091A; // 0x70
	
		// Nested types
		public enum u0927u091Fu0929u0924u091Du091Bu091Bu091Eu091Au0922u0924 // TypeDefIndex: 7614
		{
			XAxisChanged = 0,
			YAxisChanged = 1
		}
	
		// Constructors
		protected VRTK_BaseObjectControlAction() {} // 0x0000000180E09890-0x0000000180E09900
	
		// Methods
		protected abstract void u0922u0925u0925u091Du091Cu0922u091Cu0925u091Eu091Bu0928(GameObject u091Cu0929u0923u091Fu0920u0928u0925u0929u091Eu0928u0929, Transform u091Fu0928u091Fu091Du0922u0927u091Fu0929u0927u091Au0924, Vector3 u0926u0921u0928u0922u091Eu091Au0920u0920u091Du0922u0929, float u0929u0922u0922u0925u091Cu091Du0925u091Cu091Fu0929u0928, float u0929u0929u091Eu0924u091Du091Bu091Au0926u0924u0922u0926, bool u0926u091Du0921u0920u091Fu091Bu0922u0929u091Fu0923u0921, bool u0923u0920u0927u0922u0924u0925u0925u0928u0927u091Bu0927);
		protected virtual void Awake() {} // 0x0000000180E08720-0x0000000180E08790
		protected virtual void OnEnable() {} // 0x0000000180E08910-0x0000000180E08A50
		protected virtual void OnDisable() {} // 0x0000000180E08800-0x0000000180E08910
		protected virtual void OnDestroy() {} // 0x0000000180E08790-0x0000000180E08800
		protected virtual void u0920u0925u0926u091Fu091Cu0924u091Eu091Au091Du0927u091F(object u0922u091Fu091Bu0921u091Cu0921u0925u0924u0925u091Eu0929, u0925u0922u0929u0926u0925u0927u0920u091Bu0923u091Au0927 u0929u091Fu091Eu0922u0928u091Cu0929u0924u0927u091Eu091C) {} // 0x0000000180E08E40-0x0000000180E08F00
		protected virtual void u091Du0923u091Bu0920u0922u0921u0927u0924u0923u091Du091D(GameObject u091Cu0929u0923u091Fu0920u0928u0925u0929u091Eu0928u0929, float u0925u091Du0929u091Cu0925u091Bu0922u0921u091Bu0924u0922) {} // 0x0000000180E08A50-0x0000000180E08C80
		protected virtual void u0922u0927u0928u0927u091Du091Du091Fu091Fu0923u0929u0920(float u0922u0924u0921u091Bu091Bu091Du0922u0929u091Bu0928u0920) {} // 0x0000000180E08F00-0x0000000180E08FC0
		protected virtual void u0927u0920u0929u0921u0927u0924u091Bu091Bu0922u0928u0922(float u0922u0924u0921u091Bu091Bu091Du0922u0929u091Bu0928u0920) {} // 0x0000000180E09800-0x0000000180E09890
		protected virtual Vector3 u0925u0921u0923u0920u091Fu0920u091Du091Du0929u0925u0924(Transform u0924u0921u091Du0923u091Au0920u091Cu0920u0928u0921u091B) => default; // 0x0000000180E08FC0-0x0000000180E09500
		protected virtual int u091Fu0925u0924u0920u0923u091Cu091Au091Fu0929u091Du091F(float u0929u0922u0922u0925u091Cu091Du0925u091Cu091Fu0929u0928) => default; // 0x0000000180E08C80-0x0000000180E08CA0
		protected virtual bool u0925u0922u0922u0927u091Eu0924u0927u091Bu0923u091Fu091B(VRTK_BodyPhysics u0929u0921u0923u091Du0929u091Bu0920u0923u091Du0926u0927, Vector3 u091Bu0927u091Cu091Cu0929u091Du0926u091Du091Bu0928u0922, Vector3 u0921u091Du091Du091Fu091Du0928u091Cu091Au091Eu091Bu0922) => default; // 0x0000000180E09500-0x0000000180E09690
		protected virtual void u0927u0920u091Du0921u0927u091Cu0920u0925u0928u091Cu0928(GameObject u091Cu0929u0923u091Fu0920u0928u0925u0929u091Eu0928u0929) {} // 0x0000000180E09690-0x0000000180E09800
		protected virtual void u0920u0920u0920u091Cu0929u0927u0921u0925u0927u0920u0925(GameObject u091Cu0929u0923u091Fu0920u0928u0925u0929u091Eu0928u0929) {} // 0x0000000180E08CA0-0x0000000180E08E40
	}
}