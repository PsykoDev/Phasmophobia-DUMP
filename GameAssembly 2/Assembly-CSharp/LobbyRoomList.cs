﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

// Image 63: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 6838-8616

public class LobbyRoomList : MonoBehaviour, ILobbyCallbacks, IConnectionCallbacks, IMatchmakingCallbacks // TypeDefIndex: 7135
{
	// Fields
	public Dictionary<string, RoomInfo> u0922u091Fu0924u0922u091Cu0928u091Du0920u091Bu091Du091A; // 0x18
	public List<RoomInfo> u091Bu091Fu0928u0923u091Fu091Cu0928u091Eu0920u0929u091A; // 0x20

	// Constructors
	public LobbyRoomList() {} // 0x0000000180E297B0-0x0000000180E29850

	// Methods
	public void u091Eu091Du0928u091Bu091Du0929u091Fu091Au0928u0929u0929() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0926u0924u091Bu091Fu0924u091Cu0926u091Du091Eu091Cu091A() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu091Bu0928u0923u091Fu091Eu091Fu0929u091Cu091Bu0922(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnDisconnected(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E26520-0x0000000180E265D0
	public void OnRoomListUpdate(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E26740-0x0000000180E26950
	public void u0929u0926u0921u091Fu091Fu0923u091Du091Au091Cu091Cu0927(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnConnectedToMaster() {} // 0x0000000180E26310-0x0000000180E26450
	public void u0920u091Au0924u091Au0926u0928u0921u0928u0922u0928u0926(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnLeftLobby() {} // 0x0000000180E26630-0x0000000180E26680
	public void u0924u091Eu0926u091Eu0925u091Cu0921u0929u0920u0929u091A(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0925u0928u091Fu0922u0925u091Eu091Du091Au091Eu091Cu0925() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Au0924u0925u0921u091Cu0922u091Au0921u091Du091Bu0926() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnCreateRoomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0922u091Du091Fu0928u0922u0926u0922u091Cu0924u091Du0929(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E280B0-0x0000000180E282C0
	public void u0922u091Bu0922u091Au0928u0928u0926u0922u0923u091Cu0923() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnFriendListUpdate(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0920u0920u091Au091Cu091Fu0924u0922u091Du0922u0920u091F(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E277A0-0x0000000180E279B0
	public void u0920u0925u0924u091Fu0922u0924u0927u0920u0924u091Cu0924(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180E27A50-0x0000000180E27B10
	public void u091Eu0921u091Au091Du0929u0926u0920u091Fu091Eu0927u0925(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0929u0927u0923u091Eu091Au0926u091Eu0921u091Du091Au0926() {} // 0x0000000180E29670-0x0000000180E297B0
	public void u0920u091Eu0929u0929u0921u091Bu0921u091Au091Du0929u0925(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E276F0-0x0000000180E277A0
	public void u091Cu0922u091Du091Fu0925u0927u0921u091Eu0922u0923u091F() {} // 0x0000000180E26FD0-0x0000000180E27110
	public void u0923u091Fu091Bu0926u0923u091Au0926u0925u091Fu0925u0922() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0927u0926u0928u0927u0924u0922u0926u0920u091Bu0927u0924() {} // 0x0000000180E29120-0x0000000180E29180
	public void u0928u091Cu091Au091Du091Bu091Bu0921u0925u091Du091Eu0921(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E29180-0x0000000180E29230
	public void u0923u091Fu0924u0922u091Bu091Fu0927u091Fu0925u091Bu091B(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0925u0929u0921u0929u0928u091Du0929u0921u091Au091Au091F(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0923u091Au091Bu0926u091Eu0927u0923u0928u0921u0924u091A(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E28530-0x0000000180E285E0
	public void u091Bu0923u091Eu0922u091Au0927u0929u0920u0929u0924u0928(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E26C00-0x0000000180E26CB0
	public void u0928u0927u0921u0927u0929u091Fu0921u0921u0920u0923u0929(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180E29580-0x0000000180E29620
	public void u0922u0928u0926u091Du091Au0927u0928u091Bu0926u0921u0923(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0920u091Fu0924u0925u091Du0927u091Du0922u0925u091Fu0929() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Eu0928u091Fu0925u0923u0922u0921u0921u0922u0922u0929() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0924u0926u0921u091Du091Fu091Fu0920u0929u0924u0922u0922(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void OnEnable() {} // 0x0000000180E265D0-0x0000000180E26630
	public void u0921u0928u091Au091Eu091Au0929u0927u0922u091Au091Eu0923(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Cu0928u0927u0924u0924u0925u091Bu091Du0924u0922u0925() {} // 0x0000000180E27110-0x0000000180E27250
	public void u091Eu091Du091Bu091Eu0925u0925u091Bu0925u0923u0920u0924() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0925u0924u091Au0925u0929u091Bu0924u091Au0929u0922u0928(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Du091Au0926u091Du091Cu0929u091Du0925u0921u0920u0926() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0922u091Du091Bu0923u091Fu0921u0920u0923u091Fu0922u0921() {} // 0x0000000180E28050-0x0000000180E280B0
	public void u0920u0926u0922u0925u0920u0921u0921u0924u0929u0922u0923(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180E27B10-0x0000000180E27B80
	public void u091Du0921u0922u0921u0922u0921u0926u0921u0920u091Cu0924() {} // 0x0000000180E27360-0x0000000180E274A0
	public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180E26680-0x0000000180E26740
	public void OnJoinedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0926u0920u091Fu0922u0929u0924u0929u0927u091Au091Du0928(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0929u0926u0922u0920u091Du091Cu0926u091Eu091Au0928u0924(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu091Cu0927u0927u0921u0926u091Eu091Cu0926u091Bu0928(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0925u0920u0928u0921u091Bu091Fu0923u091Bu091Eu0920u0921(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180E28B50-0x0000000180E28BC0
	public void u0921u091Fu091Du091Au0924u0924u091Du0921u091Bu091Au0922(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E27D90-0x0000000180E27E40
	public void u091Cu0921u091Fu0928u0927u091Eu0926u091Bu0926u0927u0924(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E26DC0-0x0000000180E26FD0
	private void u0925u0920u0924u0929u0920u0924u091Du0921u091Bu0927u0922() {} // 0x0000000180E28AF0-0x0000000180E28B50
	public void u0927u091Cu091Cu0924u0927u091Fu0921u0921u091Fu0929u091E() {} // 0x0000000180E28FE0-0x0000000180E29120
	public void u0926u091Cu0925u0928u0924u0923u091Fu0921u091Cu0922u091B(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu0929u0920u0922u0925u091Eu091Bu091Bu0921u0928u0927(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0923u091Cu0924u091Du0920u0921u0924u091Eu091Cu0924u0926(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0926u0928u0926u091Fu091Cu0922u0922u091Bu091Au0920u0921() {} // 0x0000000180E28F30-0x0000000180E28F90
	public void u0920u0927u0922u0929u091Du0929u0921u0927u0923u091Cu091E(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E27B80-0x0000000180E27D90
	public void u0928u091Cu0925u091Fu0922u0927u0923u0929u0921u0922u0928(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnJoinRoomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0929u0927u0928u0920u0921u091Bu091Eu0922u091Cu0927u0924() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0922u091Fu091Cu0927u091Du0925u091Du0922u0929u0929u0924(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E282C0-0x0000000180E28370
	public void u091Bu0921u0925u091Cu0920u0923u0921u0926u0920u091Cu0924(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0923u0925u0928u091Du091Fu0920u0929u091Eu0924u091Eu0928() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0923u091Bu091Fu091Du0926u091Du0928u0926u0929u0926u0920(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E285E0-0x0000000180E287F0
	public void u0924u0922u091Au0923u0925u0926u0920u091Au0924u0921u0926(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Bu0923u0923u0920u091Au091Eu0926u091Au0925u0923u0929() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Du0929u091Fu0922u0923u091Cu091Eu0923u0928u0921u0929(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180E274A0-0x0000000180E27560
	public void u091Au091Bu0928u091Au0929u0925u0926u0923u091Fu091Eu091E() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Au0923u091Au0928u091Bu091Bu0927u0927u0920u0922u0926(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0926u0921u0925u091Fu0923u091Cu091Cu091Bu091Au091Bu0928(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E28CC0-0x0000000180E28ED0
	public void u0923u0922u0924u0920u091Du0926u091Du0929u0927u0926u0928(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180E28840-0x0000000180E288E0
	public void OnCustomAuthenticationFailed(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180E26450-0x0000000180E264C0
	public void u0922u091Bu091Du0921u0928u091Eu0929u091Cu0921u0926u091E(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E27E40-0x0000000180E28050
	public void u0928u0928u0924u0920u0927u0926u0921u091Bu0928u0926u0921(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu091Eu091Bu0921u091Du0920u091Bu0926u0921u091Bu091C() {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0926u0925u091Eu091Du091Du0923u0927u0924u091Fu0924u0921() {} // 0x0000000180E28ED0-0x0000000180E28F30
	public void u0928u091Du0928u0926u0924u0928u091Cu0929u0927u0920u0929() {} // 0x0000000180E29230-0x0000000180E29370
	public void u0924u0920u0929u0926u091Du0926u0923u0921u0927u0924u0926(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnCreatedRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnCustomAuthenticationResponse(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Bu091Fu0926u091Cu0921u0928u0922u0924u091Cu0925u091E(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Du091Eu091Bu0920u0929u091Bu0922u0920u0928u091Au0928(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void OnDisable() {} // 0x0000000180E264C0-0x0000000180E26520
	public void u091Eu0926u0928u091Eu091Bu0925u0923u0921u091Bu0921u091D(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Bu0923u0924u091Bu0922u091Fu0928u0924u0923u0922u0924(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0924u0923u0925u0922u0923u0920u091Eu091Bu0920u0925u0926(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0923u0921u091Au0927u0926u0921u091Cu0921u0920u091Cu091D() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Au091Du091Du0920u091Cu091Fu0927u091Fu091Cu091Au091B(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u0922u0926u0926u0926u091Fu091Eu091Cu0922u0924u091Eu091F() {} // 0x0000000180E284D0-0x0000000180E28530
	public void u0920u0925u091Eu0928u0929u0924u0920u091Au091Du0925u0922(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180E279B0-0x0000000180E27A50
	public void u0926u091Fu091Bu091Du0926u0920u0920u0921u0929u0923u091B() {} // 0x0000000180E28C70-0x0000000180E28CC0
	public void u0924u091Fu0926u0924u091Eu091Eu091Eu091Cu0925u091Bu0927() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0922u0920u0925u0927u091Fu0923u0920u0928u091Du0927u0920(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180E28370-0x0000000180E28410
	public void u0925u0926u0928u0929u0922u0922u091Eu0924u091Bu091Bu091D(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E28BC0-0x0000000180E28C70
	public void u0924u0924u0924u0929u091Cu091Eu091Cu0928u0927u091Du091E(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E288E0-0x0000000180E28AF0
	public void u0920u091Cu0925u091Fu0926u091Eu0929u0923u0921u091Du0923(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180E27680-0x0000000180E276F0
	public void u091Au091Cu091Au0929u0923u0927u0929u091Fu091Eu091Du0922(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu0924u091Au091Du091Au091Fu0927u091Cu091Fu091Du091A(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0928u0929u0929u091Eu091Cu091Eu091Bu091Cu0929u0920u0929() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0922u0923u0921u0922u091Bu0921u0929u0921u0927u0920u0920(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180E28410-0x0000000180E284D0
	public void u091Eu091Eu0923u0925u0926u091Cu0928u0921u0926u091Du0921(List<FriendInfo> u0929u0924u0929u0925u0922u0921u0927u0928u0922u091Cu091D) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu0928u0929u091Bu091Eu091Eu091Bu091Cu091Cu0920u0922(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Au0925u0925u0928u0927u091Fu091Fu091Fu0921u0922u0921() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnConnected() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0928u091Fu0924u0924u091Au091Cu0924u0924u0927u091Eu0927(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E29370-0x0000000180E29580
	public void u091Bu0925u0928u0926u0926u0922u091Du091Bu0929u0920u0924(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Cu0928u091Eu0926u0923u0925u0923u0929u091Eu091Bu091B() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnRegionListReceived(RegionHandler u0922u0925u0929u091Fu0928u0927u091Bu0924u091Cu0922u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Fu0920u091Fu091Eu0923u091Bu0928u0929u0921u0920u091D(string u0927u0927u091Bu091Au091Eu091Cu0927u0921u091Au091Eu091D) {} // 0x0000000180E275B0-0x0000000180E27620
	private void u091Fu0927u0927u0928u0921u0929u091Au091Fu0920u0922u0922() {} // 0x0000000180E27620-0x0000000180E27680
	public void u0927u091Au091Fu0921u0922u0922u0925u091Cu0925u0929u091C() {} // 0x0000000180E28F90-0x0000000180E28FE0
	private void u091Cu091Eu091Bu091Fu091Au0925u0922u0926u091Bu0920u091A() {} // 0x0000000180E26D60-0x0000000180E26DC0
	public void OnJoinedLobby() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0929u091Fu0920u0924u091Au0922u091Du0925u0922u0928u091F() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Cu0924u091Eu0922u0927u0923u091Du091Eu0927u0924u0924(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Au0926u0922u0923u091Bu091Bu091Du091Eu091Au0927u091E(List<TypedLobbyInfo> u091Au0920u091Bu0920u0923u091Fu091Cu0922u0926u0925u0926) {} // 0x0000000180E26B60-0x0000000180E26C00
	public void u0926u0929u0928u0923u0922u0921u0929u0924u0929u091Eu0927(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0925u0929u0928u0929u0925u0924u091Du091Du0922u0924u091E(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Cu091Au0929u091Fu0925u091Du0923u091Du091Bu091Du0924(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E26CB0-0x0000000180E26D60
	public void u0924u0928u0925u0926u091Du091Au0920u091Au091Du0922u0925() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnJoinRandomFailed(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Cu0923u0926u0926u0921u091Du0925u091Au091Bu0922u0924() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0920u0926u0926u0929u091Bu0920u0928u0926u091Bu0922u0929(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Au0924u0926u0926u0926u0928u091Au091Eu0926u091Fu091F(List<RoomInfo> u0929u0927u091Fu091Cu091Au091Au0923u0923u0923u091Au0927) {} // 0x0000000180E26950-0x0000000180E26B60
	public void u091Fu091Du091Bu0923u091Fu091Eu0921u091Bu0921u091Fu091A() {} // 0x0000000180E27560-0x0000000180E275B0
	public void u091Fu091Eu0921u091Bu0923u091Au091Au0920u091Bu0928u091D() {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0923u091Du0926u0925u0926u0921u0920u0920u091Au091Eu091A() {} // 0x0000000180E287F0-0x0000000180E28840
	public void u091Fu0924u0926u0921u0926u0928u0921u0922u0925u091Cu0926(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0928u0928u091Du0926u091Du091Bu091Du0929u0920u0926u0921() {} // 0x0000000180E29620-0x0000000180E29670
	public void u0929u091Bu0926u091Au0924u0923u0926u0923u091Fu0924u0926(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Du0920u091Bu0929u0929u0927u091Au0926u0924u0928u091E(DisconnectCause u091Eu091Cu091Eu091Au091Au0928u0921u091Bu091Bu091Du0929) {} // 0x0000000180E272B0-0x0000000180E27360
	public void u0922u091Fu0926u0926u091Eu091Cu091Fu0920u0920u091Du091D(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	private void u091Du091Eu0927u0927u091Bu0921u0921u091Du0922u091Au091C() {} // 0x0000000180E27250-0x0000000180E272B0
	public void u091Cu0924u0926u0923u0927u0921u091Fu0925u091Fu0924u091D(Dictionary<string, object> u091Fu0921u0922u0926u0922u0923u091Cu0924u091Cu0923u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u091Cu0921u0922u0926u0927u0922u091Du0926u0921u0921u0922(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void u0928u0926u0929u0924u0929u091Fu0924u091Au091Fu0921u0925(short u0926u0928u0927u091Eu091Eu0924u0923u091Eu091Au0925u0929, string u091Eu0926u091Eu0925u091Cu0926u0923u0924u091Du0928u0926) {} // 0x0000000180246DB0-0x0000000180246DC0
	public void OnLeftRoom() {} // 0x0000000180246DB0-0x0000000180246DC0
}

