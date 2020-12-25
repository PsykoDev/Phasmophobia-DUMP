﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class MapController : MonoBehaviour // TypeDefIndex: 6975
{
	// Fields
	public static MapController u0925u091Fu0920u091Cu0925u091Fu0927u091Cu091Au0925u0927; // 0x00
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private List<Transform> playerIcons; // 0x18
	private List<Player> u0920u091Au0927u0929u091Eu091Bu0928u0928u0922u091Bu091A; // 0x20
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Transform basementFloor; // 0x28
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Transform firstFloor; // 0x30
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private Transform secondFloor; // 0x38
	private int u0920u0923u0925u0927u091Bu0928u091Du091Fu091Du0928u0929; // 0x40
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private int minFloorIndex; // 0x44
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private int maxFloorIndex; // 0x48
	[SerializeField] // 0x00000001800D4E50-0x00000001800D4E60
	private float iconScale; // 0x4C

	// Constructors
	public MapController() {} // 0x0000000180C173D0-0x0000000180C17480

	// Methods
	public void u0927u0929u0926u0927u0929u0920u0923u0926u091Fu091Bu091C() {} // 0x0000000180C16C50-0x0000000180C16D90
	public void u091Cu091Fu0924u0924u091Au091Au091Cu0928u091Eu0922u0922(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C13F80-0x0000000180C140C0
	public void u0925u0928u091Cu0929u091Fu0929u091Eu0923u0927u0928u091A(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C162D0-0x0000000180C16450
	private void u091Du091Fu0928u091Eu091Fu091Bu0921u091Fu0926u0928u091B() {} // 0x0000000180C14650-0x0000000180C14710
	public void u0926u091Eu091Au0927u0921u0922u091Eu0928u0923u091Eu0922(LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C16450-0x0000000180C16530
	public void AssignSensor(Transform u0924u0926u0921u091Au091Du091Cu091Du0922u091Eu0924u0920, Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, int u091Fu0922u091Au091Du091Au0920u091Au0927u0920u091Bu091D, MotionSensor u0927u091Au091Eu0923u0926u0924u0924u0923u0924u0924u091A) {} // 0x0000000180C12D50-0x0000000180C12F90
	private void u091Bu0928u0923u091Au091Fu0927u091Au0920u091Du0920u091B() {} // 0x0000000180C13B20-0x0000000180C13C90
	public void u0922u091Du0924u091Bu091Fu0923u0929u091Fu0920u091Bu0929() {} // 0x0000000180C155C0-0x0000000180C157B0
	public void u0927u0928u0926u0927u0923u091Cu0920u091Au091Bu0920u091A() {} // 0x0000000180C16A60-0x0000000180C16C50
	public void u091Fu0927u0923u0927u091Cu091Du0929u0928u0921u0924u0920(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C14ED0-0x0000000180C150B0
	public void AssignIcon(Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C12C50-0x0000000180C12D50
	public void u0927u091Fu0925u091Fu0927u091Fu091Eu091Fu091Eu091Fu0922(Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C16780-0x0000000180C16880
	public void u0923u0922u091Fu091Fu091Du0927u0923u0924u0925u0922u091D() {} // 0x0000000180C15BA0-0x0000000180C15CF0
	public void u091Au0923u0925u0926u091Fu0927u0928u0922u091Bu091Eu0922(Transform u0924u0926u0921u091Au091Du091Cu091Du0922u091Eu0924u0920, Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, int u091Fu0922u091Au091Du091Au0920u091Au0927u0920u091Bu091D, MotionSensor u0927u091Au091Eu0923u0926u0924u0924u0923u0924u0924u091A) {} // 0x0000000180C13800-0x0000000180C139E0
	public void RemovePlayer(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C13410-0x0000000180C13600
	private void u0922u0920u0925u0922u0928u0928u0927u0928u0920u091Du091D() {} // 0x0000000180C158F0-0x0000000180C15950
	public void u0922u091Au0921u0927u0925u091Cu0922u0923u0928u091Bu091C(Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C154C0-0x0000000180C155C0
	private void u0922u0924u0923u0927u091Au091Du0928u091Bu0922u0928u0921(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C15950-0x0000000180C15A30
	public void ChangePlayerFloor(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C13290-0x0000000180C13410
	private void u0924u091Cu091Du091Fu091Eu0920u0927u0921u0928u0924u0927() {} // 0x0000000180C15E50-0x0000000180C15FE0
	public void u0922u091Fu0921u0928u0927u091Eu0922u0925u0923u0924u091F() {} // 0x0000000180C157B0-0x0000000180C158F0
	public void u0927u0921u0926u0922u091Bu091Au0924u0924u091Eu091Au0925(Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C16880-0x0000000180C16980
	public void u091Cu091Cu091Eu0929u0921u091Cu091Fu0926u0923u091Fu091D(Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C13E80-0x0000000180C13F80
	public void ChangeFloorMonitor(LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C12FF0-0x0000000180C130C0
	public void u0920u0927u091Cu0925u0926u0922u0928u091Bu091Fu0926u0928(Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C152F0-0x0000000180C153E0
	private void u091Cu0922u0924u091Fu091Au091Au0920u0920u091Cu0920u0929() {} // 0x0000000180C140C0-0x0000000180C14120
	public void u091Cu091Bu091Fu0925u091Au091Cu0922u091Du0929u0927u091C(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C13C90-0x0000000180C13E80
	public void u091Cu0925u0920u091Au091Eu0925u0928u0926u0927u091Bu091A(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C14120-0x0000000180C14300
	private void u0929u091Cu091Eu091Fu0929u0926u091Du091Bu0929u091Du0924(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C16F00-0x0000000180C16FE0
	public void u091Fu091Eu0923u091Cu0927u0925u091Eu0924u0923u091Fu0924(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C14C20-0x0000000180C14E10
	private void u091Du0925u0923u0920u091Au0925u0922u0928u0926u0926u0925(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C14710-0x0000000180C147F0
	private void u0929u091Fu0925u091Cu0921u0925u0921u0926u0926u0920u091B() {} // 0x0000000180C16FE0-0x0000000180C17040
	public void u0929u0926u091Fu0928u0924u0922u091Fu091Eu0927u0923u0922(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C17040-0x0000000180C17180
	private void u0923u0925u091Eu0926u0929u091Bu091Fu0924u0923u0923u091B() {} // 0x0000000180C15CF0-0x0000000180C15E50
	public void u091Eu0921u091Du091Eu0928u0926u0925u0920u0928u0920u0923(Transform u0924u0926u0921u091Au091Du091Cu091Du0922u091Eu0924u0920, Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, int u091Fu0922u091Au091Du091Au0920u091Au0927u0920u091Bu091D, MotionSensor u0927u091Au091Eu0923u0926u0924u0924u0923u0924u0924u091A) {} // 0x0000000180C14920-0x0000000180C14B20
	public void u091Au091Bu0926u0925u0921u091Bu091Fu091Du091Au0922u091F(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C136C0-0x0000000180C13800
	public void ChangeFloor() {} // 0x0000000180C130C0-0x0000000180C13290
	private void u0922u0928u0923u091Eu091Au0920u0920u091Fu0928u0921u0924() {} // 0x0000000180C15A30-0x0000000180C15BA0
	public void u0928u0926u0920u0923u0926u091Fu0927u0922u0928u091Fu0924(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C16D90-0x0000000180C16F00
	public void u0925u091Fu0923u0922u091Cu0925u0923u091Fu0920u0921u0920(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C160E0-0x0000000180C162D0
	private void u0926u091Fu0927u0924u0928u0920u091Au0924u0924u0927u091F() {} // 0x0000000180C16530-0x0000000180C16610
	private void Awake() {} // 0x0000000180C12F90-0x0000000180C12FF0
	private void u091Du091Bu0928u091Eu0924u091Bu091Bu0928u0929u091Fu091E() {} // 0x0000000180C14300-0x0000000180C143C0
	public void u091Bu091Au0928u091Bu0923u0920u091Au091Eu091Cu0920u091B(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C139E0-0x0000000180C13B20
	private void u0927u0923u0923u0927u0920u091Cu091Du091Eu091Du0920u0925(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C16980-0x0000000180C16A60
	private void u0921u0920u0928u0928u0923u091Bu091Fu091Bu091Fu091Bu0924(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C153E0-0x0000000180C154C0
	private void u091Du091Eu0925u0928u0921u0924u091Cu0925u0920u0925u0925() {} // 0x0000000180C143C0-0x0000000180C14570
	private void u0929u0928u0926u091Bu0924u0926u0924u0929u091Au091Eu091A(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C17180-0x0000000180C17260
	public void u091Eu091Au0922u091Au0925u0929u091Cu0927u0926u091Au0924(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C147F0-0x0000000180C14920
	public void u0920u091Eu091Du0925u091Bu0925u0925u091Fu091Cu0925u091B(Transform u0924u0926u0921u091Au091Du091Cu091Du0922u091Eu0924u0920, Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, int u091Fu0922u091Au091Du091Au0920u091Au0927u0920u091Bu091D, MotionSensor u0927u091Au091Eu0923u0926u0924u0924u0923u0924u0924u091A) {} // 0x0000000180C150B0-0x0000000180C152F0
	private void u091Du091Eu0928u0929u0924u0922u0922u0921u091Au0920u0929(Player u0921u0926u0925u0929u0922u0927u0924u0928u091Cu0920u0923) {} // 0x0000000180C14570-0x0000000180C14650
	public void u0924u0920u091Bu091Du0927u091Fu091Au091Cu0923u091Fu0923(Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C15FE0-0x0000000180C160E0
	private void u0926u0921u0920u091Cu0922u0923u0921u0924u0928u0921u0927() {} // 0x0000000180C16610-0x0000000180C16780
	private void u091Fu0923u0922u091Eu091Fu091Bu0924u091Eu0928u091Au0929() {} // 0x0000000180C14E10-0x0000000180C14ED0
	private void Update() {} // 0x0000000180C17260-0x0000000180C173D0
	private void Start() {} // 0x0000000180C13600-0x0000000180C136C0
	public void u091Eu0924u0925u0925u0928u091Fu0922u0922u0920u0923u091D(Transform u091Du091Eu0927u0924u091Au0922u0922u091Eu0922u0922u091A, LevelRoom.u0920u091Fu0926u0929u0927u0929u0921u0928u0923u0920u0922 u0924u0924u0929u0921u091Au0926u0925u091Eu0929u0925u091E) {} // 0x0000000180C14B20-0x0000000180C14C20
}

