using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002C8 RID: 712
	public static class SteamAPI : Object
	{
		// Token: 0x060028BD RID: 10429 RVA: 0x000B0334 File Offset: 0x000AE534
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPI()
		{
			Il2CppClassPointerStore<SteamAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr);
			SteamAPI.NativeMethodInfoPtr_Init_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100668485);
			SteamAPI.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100668486);
			SteamAPI.NativeMethodInfoPtr_RestartAppIfNecessary_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100668487);
			SteamAPI.NativeMethodInfoPtr_ReleaseCurrentThreadMemory_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100668488);
			SteamAPI.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100668489);
			SteamAPI.NativeMethodInfoPtr_IsSteamRunning_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100668490);
			SteamAPI.NativeMethodInfoPtr_GetHSteamPipe_Public_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100668491);
			SteamAPI.NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100668492);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000B0404 File Offset: 0x000AE604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209779, RefRangeEnd = 209780, XrefRangeStart = 209772, XrefRangeEnd = 209779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_Init_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000B0434 File Offset: 0x000AE634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209787, RefRangeEnd = 209788, XrefRangeStart = 209780, XrefRangeEnd = 209787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000B045C File Offset: 0x000AE65C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209790, RefRangeEnd = 209791, XrefRangeStart = 209788, XrefRangeEnd = 209790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unOwnAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_RestartAppIfNecessary_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x000B049C File Offset: 0x000AE69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209791, XrefRangeEnd = 209793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseCurrentThreadMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_ReleaseCurrentThreadMemory_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x000B04C4 File Offset: 0x000AE6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209797, RefRangeEnd = 209798, XrefRangeStart = 209793, XrefRangeEnd = 209797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunCallbacks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x000B04EC File Offset: 0x000AE6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209798, XrefRangeEnd = 209800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSteamRunning()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_IsSteamRunning_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x000B051C File Offset: 0x000AE71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209803, RefRangeEnd = 209804, XrefRangeStart = 209800, XrefRangeEnd = 209803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamPipe GetHSteamPipe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_GetHSteamPipe_Public_Static_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x000B054C File Offset: 0x000AE74C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209807, RefRangeEnd = 209808, XrefRangeStart = 209804, XrefRangeEnd = 209807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser GetHSteamUser()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x00010815 File Offset: 0x0000EA15
		public SteamAPI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002785 RID: 10117
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Boolean_0;

		// Token: 0x04002786 RID: 10118
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Void_0;

		// Token: 0x04002787 RID: 10119
		private static readonly IntPtr NativeMethodInfoPtr_RestartAppIfNecessary_Public_Static_Boolean_AppId_t_0;

		// Token: 0x04002788 RID: 10120
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCurrentThreadMemory_Public_Static_Void_0;

		// Token: 0x04002789 RID: 10121
		private static readonly IntPtr NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0;

		// Token: 0x0400278A RID: 10122
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamRunning_Public_Static_Boolean_0;

		// Token: 0x0400278B RID: 10123
		private static readonly IntPtr NativeMethodInfoPtr_GetHSteamPipe_Public_Static_HSteamPipe_0;

		// Token: 0x0400278C RID: 10124
		private static readonly IntPtr NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0;
	}
}
