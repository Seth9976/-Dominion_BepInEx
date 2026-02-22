using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Net;

namespace Steamworks
{
	// Token: 0x02000305 RID: 773
	[Serializable]
	[StructLayout(2)]
	public struct SteamIPAddress_t
	{
		// Token: 0x06002C96 RID: 11414 RVA: 0x000BECA8 File Offset: 0x000BCEA8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamIPAddress_t()
		{
			Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamIPAddress_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr);
			SteamIPAddress_t.NativeFieldInfoPtr_m_ip0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr, "m_ip0");
			SteamIPAddress_t.NativeFieldInfoPtr_m_ip1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr, "m_ip1");
			SteamIPAddress_t.NativeFieldInfoPtr_m_eType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr, "m_eType");
			SteamIPAddress_t.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr, 100669117);
			SteamIPAddress_t.NativeMethodInfoPtr_ToIPAddress_Public_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr, 100669118);
			SteamIPAddress_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr, 100669119);
			SteamIPAddress_t.NativeMethodInfoPtr_GetIPType_Public_ESteamIPType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr, 100669120);
			SteamIPAddress_t.NativeMethodInfoPtr_IsSet_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr, 100669121);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x000BED78 File Offset: 0x000BCF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211107, XrefRangeEnd = 211108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamIPAddress_t(IPAddress iPAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iPAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIPAddress_t.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x000BEDB0 File Offset: 0x000BCFB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211128, RefRangeEnd = 211129, XrefRangeStart = 211108, XrefRangeEnd = 211128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPAddress ToIPAddress()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIPAddress_t.NativeMethodInfoPtr_ToIPAddress_Public_IPAddress_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x000BEDE4 File Offset: 0x000BCFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211129, XrefRangeEnd = 211131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIPAddress_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x000BEE10 File Offset: 0x000BD010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ESteamIPType GetIPType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIPAddress_t.NativeMethodInfoPtr_GetIPType_Public_ESteamIPType_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x000BEE40 File Offset: 0x000BD040
		[CallerCount(0)]
		public unsafe bool IsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamIPAddress_t.NativeMethodInfoPtr_IsSet_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x00011667 File Offset: 0x0000F867
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamIPAddress_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002ABC RID: 10940
		private static readonly IntPtr NativeFieldInfoPtr_m_ip0;

		// Token: 0x04002ABD RID: 10941
		private static readonly IntPtr NativeFieldInfoPtr_m_ip1;

		// Token: 0x04002ABE RID: 10942
		private static readonly IntPtr NativeFieldInfoPtr_m_eType;

		// Token: 0x04002ABF RID: 10943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IPAddress_0;

		// Token: 0x04002AC0 RID: 10944
		private static readonly IntPtr NativeMethodInfoPtr_ToIPAddress_Public_IPAddress_0;

		// Token: 0x04002AC1 RID: 10945
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002AC2 RID: 10946
		private static readonly IntPtr NativeMethodInfoPtr_GetIPType_Public_ESteamIPType_0;

		// Token: 0x04002AC3 RID: 10947
		private static readonly IntPtr NativeMethodInfoPtr_IsSet_Public_Boolean_0;

		// Token: 0x04002AC4 RID: 10948
		[FieldOffset(0)]
		public long m_ip0;

		// Token: 0x04002AC5 RID: 10949
		[FieldOffset(8)]
		public long m_ip1;

		// Token: 0x04002AC6 RID: 10950
		[FieldOffset(16)]
		public ESteamIPType m_eType;
	}
}
