using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002C9 RID: 713
	public static class GameServer : Object
	{
		// Token: 0x060028C7 RID: 10439 RVA: 0x000B057C File Offset: 0x000AE77C
		// Note: this type is marked as 'beforefieldinit'.
		static GameServer()
		{
			Il2CppClassPointerStore<GameServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameServer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameServer>.NativeClassPtr);
			GameServer.NativeMethodInfoPtr_Init_Public_Static_Boolean_UInt32_UInt16_UInt16_UInt16_EServerMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServer>.NativeClassPtr, 100668493);
			GameServer.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServer>.NativeClassPtr, 100668494);
			GameServer.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServer>.NativeClassPtr, 100668495);
			GameServer.NativeMethodInfoPtr_ReleaseCurrentThreadMemory_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServer>.NativeClassPtr, 100668496);
			GameServer.NativeMethodInfoPtr_BSecure_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServer>.NativeClassPtr, 100668497);
			GameServer.NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServer>.NativeClassPtr, 100668498);
			GameServer.NativeMethodInfoPtr_GetHSteamPipe_Public_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServer>.NativeClassPtr, 100668499);
			GameServer.NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameServer>.NativeClassPtr, 100668500);
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000B064C File Offset: 0x000AE84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209808, XrefRangeEnd = 209823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init(uint unIP, ushort usSteamPort, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usSteamPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usGamePort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usQueryPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eServerMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersionString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServer.NativeMethodInfoPtr_Init_Public_Static_Boolean_UInt32_UInt16_UInt16_UInt16_EServerMode_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000B06D4 File Offset: 0x000AE8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209823, XrefRangeEnd = 209830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServer.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x000B06FC File Offset: 0x000AE8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209830, XrefRangeEnd = 209834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunCallbacks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServer.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x000B0724 File Offset: 0x000AE924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209834, XrefRangeEnd = 209836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseCurrentThreadMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServer.NativeMethodInfoPtr_ReleaseCurrentThreadMemory_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x000B074C File Offset: 0x000AE94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209836, XrefRangeEnd = 209838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BSecure()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServer.NativeMethodInfoPtr_BSecure_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000B077C File Offset: 0x000AE97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209838, XrefRangeEnd = 209844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetSteamID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServer.NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000B07AC File Offset: 0x000AE9AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209847, RefRangeEnd = 209848, XrefRangeStart = 209844, XrefRangeEnd = 209847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamPipe GetHSteamPipe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServer.NativeMethodInfoPtr_GetHSteamPipe_Public_Static_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x000B07DC File Offset: 0x000AE9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209851, RefRangeEnd = 209852, XrefRangeStart = 209848, XrefRangeEnd = 209851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser GetHSteamUser()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameServer.NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0001081E File Offset: 0x0000EA1E
		public GameServer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400278D RID: 10125
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Boolean_UInt32_UInt16_UInt16_UInt16_EServerMode_String_0;

		// Token: 0x0400278E RID: 10126
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Void_0;

		// Token: 0x0400278F RID: 10127
		private static readonly IntPtr NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0;

		// Token: 0x04002790 RID: 10128
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCurrentThreadMemory_Public_Static_Void_0;

		// Token: 0x04002791 RID: 10129
		private static readonly IntPtr NativeMethodInfoPtr_BSecure_Public_Static_Boolean_0;

		// Token: 0x04002792 RID: 10130
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0;

		// Token: 0x04002793 RID: 10131
		private static readonly IntPtr NativeMethodInfoPtr_GetHSteamPipe_Public_Static_HSteamPipe_0;

		// Token: 0x04002794 RID: 10132
		private static readonly IntPtr NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0;
	}
}
