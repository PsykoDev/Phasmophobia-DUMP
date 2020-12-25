﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class PCFlashlight : MonoBehaviour // TypeDefIndex: 7189
{
	// Fields
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Light headLight; // 0x18
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private PCPropGrab pcPropGrab; // 0x20
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Player player; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private AudioSource source; // 0x30
	private PhotonView u0921u0929u0927u0928u0923u0927u091Bu091Fu0926u091Fu0926; // 0x38
	private bool u091Du091Au0928u091Cu091Au0926u0925u0922u091Au091Du091A; // 0x40
	private Light u0922u0923u091Cu0921u0924u0924u091Eu0927u0921u0926u0920; // 0x48
	private bool u091Cu0927u091Au0923u0920u0922u0924u0923u091Au0925u091E; // 0x50
	private float u091Bu0925u091Du0927u091Fu0925u0929u091Au091Eu0929u091A; // 0x54
	private float u0921u0925u0922u091Cu091Eu0928u091Fu091Au0927u091Eu0923; // 0x58

	// Constructors
	public PCFlashlight() {} // 0x0000000180276E90-0x0000000180276EA0

	// Methods
	public void u0925u0928u0923u091Du091Cu0926u0929u091Fu091Bu0922u0925(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x000000018100A3D0-0x000000018100A700
	private void u0921u091Eu0925u091Cu091Bu0927u0925u091Au0922u0929u091F() {} // 0x0000000181006F40-0x0000000181006FB0
	private void u0928u0927u0923u0928u0928u0920u0926u091Cu0922u0923u091D() {} // 0x000000018100CBF0-0x000000018100CC60
	private void u0928u0921u0927u091Au091Au0925u0921u0927u0928u0922u091B(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	public void u0924u091Eu0922u0921u0922u0922u0928u091Du0928u0920u091E(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x00000001810088B0-0x0000000181008BE0
	private void u091Bu0925u0925u091Cu0929u091Fu0924u0926u0925u0927u091D(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181002F30-0x0000000181003190
	public void EnableOrDisableLight(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x00000001810006F0-0x0000000181000A20
	private void u091Au0924u0921u0925u091Cu091Bu0920u091Cu091Bu0926u0929(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	private void u0920u0922u091Eu0928u0921u0925u091Bu091Fu0926u091Bu0923(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	private void u091Du0924u0928u091Au091Au0921u0922u0929u0927u0926u0921(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181003F50-0x00000001810041B0
	public void u0921u091Eu0922u091Cu091Bu0925u0921u091Fu091Eu091Eu0924(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181006BC0-0x0000000181006F40
	private void u0925u0929u0926u091Au0921u091Fu091Au0926u0928u0925u0928() {} // 0x000000018100AAF0-0x000000018100AB60
	public void u091Cu0924u0927u091Cu091Bu0927u091Du091Bu0922u0925u0929(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x00000001810035C0-0x0000000181003950
	public void u0921u0923u0925u091Bu0920u0928u0927u091Cu0926u091Cu091C(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181007020-0x0000000181007370
	public void u091Eu091Eu091Fu0920u0920u091Cu0922u0921u0929u0922u0920(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181004670-0x00000001810049F0
	private void u0925u0920u091Eu0921u0921u091Cu091Cu0925u0928u0929u0925() {} // 0x0000000181009A70-0x0000000181009AE0
	private void u091Du0928u0926u091Cu091Au0920u0920u0922u0926u0924u091E() {} // 0x0000000181004600-0x0000000181004670
	private void u0926u0923u091Fu0928u0929u091Au0920u091Au091Cu0921u0924() {} // 0x000000018100AC90-0x000000018100ADA0
	public void u0923u0925u0929u0925u0928u0923u0921u0920u0925u0925u091B(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x0000000181008360-0x00000001810086F0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void EnableOrDisableLightNetworked(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181000490-0x00000001810006F0
	private void u091Cu0928u091Fu091Du0920u091Au091Bu091Cu0923u0929u0921() {} // 0x00000001810039C0-0x0000000181003A80
	private void u0924u0922u091Au091Du0929u091Fu091Au0920u0928u0922u0926() {} // 0x0000000181008BE0-0x0000000181008C50
	private void u091Bu0928u0922u0920u091Du0927u091Fu0925u0924u091Cu0922(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	private void u0920u0924u0925u0928u091Eu0920u091Cu0922u091Eu0925u0926() {} // 0x00000001810064D0-0x0000000181006540
	public void u091Au0920u091Du0928u091Fu091Au091Bu091Au0927u091Fu091C(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x00000001810019B0-0x0000000181001D30
	private void u091Bu091Fu091Du0920u0928u091Bu0921u091Au091Fu0929u0929() {} // 0x0000000181002BF0-0x0000000181002C60
	private void u0922u0920u0925u0922u0928u0928u0927u0928u0920u091Du091D() {} // 0x0000000181007730-0x00000001810077A0
	private void u0926u0923u0921u091Bu0928u0926u091Eu091Bu091Du091Fu091F(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	private void u0920u0924u0920u0926u0926u0920u0923u091Fu0929u091Du091F() {} // 0x0000000181006460-0x00000001810064D0
	public void u091Du0922u091Fu091Au0928u0920u0924u0928u091Fu0927u0920(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x0000000181003A80-0x0000000181003E00
	public void TurnBlinkOnOrOff(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000181001190-0x0000000181001220
	private void u0923u091Fu091Au0923u0928u091Fu0928u0926u0920u0921u0920() {} // 0x0000000181007F70-0x0000000181007FE0
	public void u091Bu091Bu0926u0922u0925u091Au0929u091Fu0920u0921u091F(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x00000001810027D0-0x0000000181002860
	private void u0925u0924u091Eu0927u091Bu091Cu0921u0929u091Du091Cu0921() {} // 0x0000000181009D40-0x0000000181009DB0
	private void u0925u0929u0925u091Au091Eu0923u0929u0922u0924u091Au0922() {} // 0x000000018100AA80-0x000000018100AAF0
	public void u0925u091Du0924u091Du0925u091Cu091Cu0923u091Du091Cu091D(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x0000000181009480-0x0000000181009810
	private void u091Au0920u0922u091Fu0924u091Cu091Eu0923u0925u0926u091D(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	public void u0927u0922u091Du0928u091Cu0926u091Bu0925u091Eu0927u0923(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x000000018100BF20-0x000000018100C2B0
	private void u0924u0929u0925u0928u0924u0924u0925u0929u0922u091Cu0929() {} // 0x0000000181009110-0x0000000181009220
	private void u091Bu091Au0924u0920u0925u091Fu0920u0927u0920u0921u0927(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x00000001810024B0-0x0000000181002710
	private void u091Au091Eu091Au0920u091Bu0927u091Eu0921u0920u0927u091B(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x00000001810013C0-0x0000000181001620
	public void u0926u0924u091Cu0927u0923u0925u0926u091Bu0923u0923u091E(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x000000018100ADA0-0x000000018100B130
	private void u0921u0922u0924u0921u091Au091Du091Fu0923u0924u091Fu0929() {} // 0x0000000181006FB0-0x0000000181007020
	public void u0923u0928u0922u0925u0922u091Du091Eu0920u0925u091Eu0924(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x00000001810086F0-0x0000000181008780
	private void u091Au091Au0920u0925u0920u0929u0920u0924u0925u091Eu091B() {} // 0x0000000181001220-0x0000000181001330
	public void u0928u0921u091Fu0927u091Eu0920u0921u091Fu091Au0927u0924(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x000000018100C2B0-0x000000018100C630
	public void u0920u091Au091Bu0925u0922u0928u091Au0921u0925u0929u0927(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x00000001810055D0-0x0000000181005920
	public void u0923u091Eu0921u0923u091Fu0922u091Eu091Bu091Du0927u0921(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181007BF0-0x0000000181007F70
	private void u091Cu0925u0924u091Du0923u091Eu091Eu0923u091Cu091Cu091F() {} // 0x0000000181003950-0x00000001810039C0
	private void u0928u091Cu0920u091Eu0923u091Du0921u0920u091Cu091Fu0921(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	private void u0925u091Eu0928u0927u0928u091Au0922u0922u0920u0925u091B(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181009810-0x0000000181009A70
	private void u091Au0927u091Du0929u0924u0921u0924u0924u091Du0923u0927() {} // 0x0000000181002440-0x00000001810024B0
	private void u091Fu0927u091Bu0927u091Cu0925u0928u0920u0920u0929u091B() {} // 0x0000000181005560-0x00000001810055D0
	private void u091Cu091Au0926u091Fu0926u0927u0922u0921u0921u0923u091A() {} // 0x00000001810032A0-0x0000000181003360
	public void GrabbedOrDroppedFlashlight(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x0000000181000A90-0x0000000181000E10
	private void u0921u0928u0924u0929u0925u0929u0922u091Fu0921u0922u091F() {} // 0x00000001810076C0-0x0000000181007730
	private void u0922u0925u0922u0924u0928u091Bu0929u091Du0929u0926u091D() {} // 0x0000000181007860-0x00000001810078D0
	private void Awake() {} // 0x0000000181000420-0x0000000181000490
	private void u091Bu0921u0929u0929u0924u091Fu0923u0920u0926u0926u091C(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181002C60-0x0000000181002EC0
	private void u0925u0928u091Fu0920u091Du091Bu091Eu0921u0926u0922u091E(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x000000018100A170-0x000000018100A3D0
	[PunRPC] // 0x00000001800D4E50-0x00000001800D4E60
	private void GrabbedOrDroppedFlashlightNetworked(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	public void u0920u0921u091Du0928u0928u0922u0921u0921u0921u091Au0921(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000181006170-0x0000000181006200
	public void u091Au0922u091Au0924u0923u091Bu0921u0923u091Au0920u0922(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181001D30-0x00000001810020B0
	private void u0920u0925u0925u0929u0924u0924u0923u0926u091Cu0920u091A(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181006540-0x00000001810067A0
	private void u0923u0920u0922u0928u091Au091Cu0929u091Bu0924u0921u0926(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	private void Update() {} // 0x000000018100D0A0-0x000000018100D1B0
	private void u0924u0926u0925u0923u091Cu0924u091Bu091Fu0927u0927u0926(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181008EB0-0x0000000181009110
	public void u0929u0928u091Du0923u091Au0921u0921u0929u0921u091Au0925(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x000000018100CCD0-0x000000018100D0A0
	private void u0926u091Bu0926u0923u091Eu0927u091Fu091Au0925u091Du0928() {} // 0x000000018100AB60-0x000000018100ABD0
	private void u0921u0921u0922u0923u0928u0922u0927u0929u0924u091Cu0928(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	public void u0926u0927u0923u091Au0926u091Eu091Au0924u0927u091Cu091B(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x000000018100B130-0x000000018100B4B0
	public void u091Au0924u0926u091Du0921u0924u0925u091Fu0923u091Fu091C(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x00000001810020B0-0x0000000181002440
	private void u091Du0927u091Fu0920u0926u0920u0926u091Du091Fu0926u091B() {} // 0x00000001810041B0-0x0000000181004220
	public void u0925u0925u0924u0922u091Fu0922u0927u091Bu0926u091Cu0920(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x0000000181009DB0-0x000000018100A170
	private void u091Bu0923u091Au0929u091Bu091Fu0921u0924u0924u091Bu0921(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	private void u0929u0921u0920u091Bu0924u091Bu0929u091Au0928u0923u091F() {} // 0x000000018100CC60-0x000000018100CCD0
	private void u0928u0924u091Au091Eu0923u0922u0927u091Fu0929u091Bu0927() {} // 0x000000018100C920-0x000000018100C990
	public void u091Bu091Eu0922u091Du091Eu091Eu0921u0926u0920u091Au0929(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181002860-0x0000000181002BF0
	private void u091Du0922u0927u091Bu0925u091Du091Fu0929u0927u0923u091A() {} // 0x0000000181003E00-0x0000000181003EC0
	private void u0922u0927u0928u0927u091Du091Du091Fu091Fu0923u0929u0920() {} // 0x00000001810078D0-0x0000000181007990
	private void u0922u0929u0927u091Fu091Bu0925u091Bu0926u091Du091Bu0928(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181007990-0x0000000181007BF0
	public void u0923u091Fu0922u0928u091Cu091Cu0921u091Eu091Fu0923u091F(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x0000000181007FE0-0x0000000181008360
	public void u0925u0928u0924u0922u0927u091Eu0920u0928u091Bu0924u0921(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x000000018100A700-0x000000018100AA80
	private void u0922u0925u0920u0922u0920u091Fu0925u0923u091Du0924u0922() {} // 0x00000001810077A0-0x0000000181007860
	public void u0926u0928u0928u0929u0926u0927u0926u0927u0928u0928u091C(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x000000018100B4B0-0x000000018100B840
	private void u091Eu0928u091Eu0929u091Eu0928u091Du091Fu0926u0926u0927() {} // 0x0000000181005200-0x0000000181005270
	private void u091Bu0923u091Du0928u091Cu091Fu0924u091Bu0923u0927u091C() {} // 0x0000000181002EC0-0x0000000181002F30
	private void u091Eu0926u0928u091Eu0922u0924u091Fu0927u0922u091Bu0921(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181004FA0-0x0000000181005200
	private void u0925u0921u091Eu091Bu0927u091Au0927u091Fu0928u091Du0926(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181009AE0-0x0000000181009D40
	private void u0926u0923u091Bu091Eu091Bu0925u0929u091Fu091Eu0926u091C() {} // 0x000000018100ABD0-0x000000018100AC90
	private void u0924u0926u091Cu0929u0921u0920u091Du091Du0923u091Bu0925(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181008C50-0x0000000181008EB0
	public void u0928u0921u0924u0922u0929u0926u0925u0925u0925u091Du091C(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x000000018100C630-0x000000018100C6C0
	private void u091Fu0925u0920u091Au0924u0924u0928u0925u0922u0920u0928(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181005300-0x0000000181005560
	private void u0925u0925u0920u091Bu0927u091Fu091Bu0923u0925u0921u091D(float u091Eu0928u0927u0924u0929u091Eu0925u091Fu0920u0924u0926, float u091Au091Eu091Du0925u0928u091Du0928u091Au091Cu0922u091C, float u0927u0926u0926u091Du0923u0927u0921u0924u0920u091Eu0924) {} // 0x0000000181000A20-0x0000000181000A90
	public void u0920u091Du0921u0929u0925u0928u0927u0925u0924u091Cu091A(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181005D60-0x00000001810060B0
	public void u091Eu091Eu0922u091Bu0924u0928u0928u0926u0923u0920u0922(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x00000001810049F0-0x0000000181004D40
	public void u091Au091Bu0929u0925u091Au0929u091Eu091Au0926u091Au091F(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000181001330-0x00000001810013C0
	public void OnTorchUse(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181000E10-0x0000000181001190
	public void u0927u091Du0921u091Au0922u0920u0921u0925u0921u0926u091F(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x000000018100B840-0x000000018100BB90
	public void u091Du0928u091Bu0926u0926u0925u0920u0925u0921u0929u0923(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181004220-0x0000000181004570
	public void u0920u0926u0925u091Du091Fu0928u0929u0928u091Du091Eu0925(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x0000000181006830-0x0000000181006BC0
	public void u0921u0928u0924u0922u0923u0923u091Bu0924u091Fu0925u091C(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181007370-0x00000001810076C0
	private void u091Bu0928u0923u091Au091Fu0927u091Au0920u091Du0920u091B() {} // 0x0000000181003190-0x00000001810032A0
	private void u091Cu091Cu091Du0921u0922u0924u091Au091Fu0923u0920u0927(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181003360-0x00000001810035C0
	private void u0920u091Au091Cu0927u091Eu091Cu091Fu091Bu0920u091Cu0929() {} // 0x0000000181005920-0x0000000181005990
	public void u091Du0928u091Eu0926u0924u0925u0929u0928u0927u091Au0923(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000181004570-0x0000000181004600
	public void u091Fu0921u0926u0929u0921u0921u0923u0921u091Bu0922u0926(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000181005270-0x0000000181005300
	private void u0925u091Au0922u0927u091Eu091Du0928u0928u0926u091Au0926(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181009220-0x0000000181009480
	public void u0927u091Du0925u0920u0924u0921u091Du0924u0922u091Au0923(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x000000018100BB90-0x000000018100BF20
	private void u0924u091Cu0924u091Bu0926u0928u0922u0921u091Fu0926u0927() {} // 0x0000000181008840-0x00000001810088B0
	private void u0923u0929u0920u0923u0928u0929u091Cu091Du091Eu091Bu0926() {} // 0x0000000181008780-0x0000000181008840
	public void u0920u091Bu091Du0921u0926u0929u0928u0921u091Cu091Du0926(Torch u0924u0923u0924u0929u0927u091Au0921u091Au0922u0924u0922, bool u0925u0923u0925u091Au0929u091Eu0928u0927u0924u0926u0925) {} // 0x0000000181005990-0x0000000181005D60
	private void u0920u0922u0924u0923u0929u0925u0927u0923u091Cu091Au091D(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181006200-0x0000000181006460
	private void u091Eu0926u091Fu0920u0921u091Cu091Au0927u0929u0925u091E(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x0000000181004D40-0x0000000181004FA0
	public void u091Au0920u091Au091Cu0925u091Du0922u0928u0920u0922u091C(InputAction.CallbackContext u091Cu0921u0920u0927u0923u0921u091Au0929u0926u0920u0926) {} // 0x0000000181001620-0x00000001810019B0
	private void u0928u0927u091Du0925u091Au091Eu091Fu0924u091Du0929u091D(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x000000018100C990-0x000000018100CBF0
	private void u091Bu091Au0924u0928u091Fu0929u091Fu0924u0925u091Fu091A() {} // 0x0000000181002710-0x00000001810027D0
	private void u0920u0920u091Bu091Cu0928u0925u0921u091Du0921u0921u0925() {} // 0x00000001810060B0-0x0000000181006170
	public void u091Du0923u0922u0925u091Au091Cu091Du0923u0922u0928u0924(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x0000000181003EC0-0x0000000181003F50
	private void u0928u0923u0927u091Fu0925u0926u0923u0924u0926u091Bu091E(bool u0921u0927u0925u0923u0923u091Eu0925u0925u0921u0925u091F, bool u0921u0924u0921u091Eu0923u0928u0922u091Eu0921u091Au0929) {} // 0x000000018100C6C0-0x000000018100C920
	public void u0920u0925u0928u091Du091Eu0929u0923u0928u0929u0924u091E(bool u091Au0924u0922u0922u0924u0925u0922u091Eu0920u091Eu091A) {} // 0x00000001810067A0-0x0000000181006830
}
