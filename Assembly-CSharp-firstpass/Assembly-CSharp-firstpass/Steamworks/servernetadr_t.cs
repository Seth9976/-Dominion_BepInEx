using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002CE RID: 718
	[Serializable]
	[StructLayout(2)]
	public struct servernetadr_t
	{
		// Token: 0x0600298D RID: 10637 RVA: 0x000B27E8 File Offset: 0x000B09E8
		// Note: this type is marked as 'beforefieldinit'.
		static servernetadr_t()
		{
			Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "servernetadr_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr);
			servernetadr_t.NativeFieldInfoPtr_m_usConnectionPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, "m_usConnectionPort");
			servernetadr_t.NativeFieldInfoPtr_m_usQueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, "m_usQueryPort");
			servernetadr_t.NativeFieldInfoPtr_m_unIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, "m_unIP");
			servernetadr_t.NativeMethodInfoPtr_Init_Public_Void_UInt32_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668565);
			servernetadr_t.NativeMethodInfoPtr_GetQueryPort_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668566);
			servernetadr_t.NativeMethodInfoPtr_SetQueryPort_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668567);
			servernetadr_t.NativeMethodInfoPtr_GetConnectionPort_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668568);
			servernetadr_t.NativeMethodInfoPtr_SetConnectionPort_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668569);
			servernetadr_t.NativeMethodInfoPtr_GetIP_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668570);
			servernetadr_t.NativeMethodInfoPtr_SetIP_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668571);
			servernetadr_t.NativeMethodInfoPtr_GetConnectionAddressString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668572);
			servernetadr_t.NativeMethodInfoPtr_GetQueryAddressString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668573);
			servernetadr_t.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668574);
			servernetadr_t.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668575);
			servernetadr_t.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668576);
			servernetadr_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668577);
			servernetadr_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668578);
			servernetadr_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668579);
			servernetadr_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668580);
			servernetadr_t.NativeMethodInfoPtr_Equals_Public_Boolean_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668581);
			servernetadr_t.NativeMethodInfoPtr_CompareTo_Public_Int32_servernetadr_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, 100668582);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x000B29BC File Offset: 0x000B0BBC
		[CallerCount(0)]
		public unsafe void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usQueryPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usConnectionPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_Init_Public_Void_UInt32_UInt16_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x000B2A0C File Offset: 0x000B0C0C
		[CallerCount(0)]
		public unsafe ushort GetQueryPort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetQueryPort_Public_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002990 RID: 10640 RVA: 0x000B2A3C File Offset: 0x000B0C3C
		[CallerCount(0)]
		public unsafe void SetQueryPort(ushort usPort)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref usPort;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_SetQueryPort_Public_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002991 RID: 10641 RVA: 0x000B2A70 File Offset: 0x000B0C70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210360, RefRangeEnd = 210362, XrefRangeStart = 210360, XrefRangeEnd = 210360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort GetConnectionPort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetConnectionPort_Public_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002992 RID: 10642 RVA: 0x000B2AA0 File Offset: 0x000B0CA0
		[CallerCount(0)]
		public unsafe void SetConnectionPort(ushort usPort)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref usPort;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_SetConnectionPort_Public_Void_UInt16_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002993 RID: 10643 RVA: 0x000B2AD4 File Offset: 0x000B0CD4
		[CallerCount(0)]
		public unsafe uint GetIP()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetIP_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x000B2B04 File Offset: 0x000B0D04
		[CallerCount(0)]
		public unsafe void SetIP(uint unIP)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_SetIP_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000B2B38 File Offset: 0x000B0D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210362, XrefRangeEnd = 210363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetConnectionAddressString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetConnectionAddressString_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000B2B64 File Offset: 0x000B0D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210363, XrefRangeEnd = 210364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQueryAddressString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetQueryAddressString_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000B2B90 File Offset: 0x000B0D90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210387, RefRangeEnd = 210389, XrefRangeStart = 210364, XrefRangeEnd = 210387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(uint unIP, ushort usPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000B2BD8 File Offset: 0x000B0DD8
		[CallerCount(0)]
		public unsafe static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x000B2C24 File Offset: 0x000B0E24
		[CallerCount(0)]
		public unsafe static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x000B2C70 File Offset: 0x000B0E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210389, XrefRangeEnd = 210392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x000B2CB4 File Offset: 0x000B0EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210392, XrefRangeEnd = 210395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x000B2CE4 File Offset: 0x000B0EE4
		[CallerCount(0)]
		public unsafe static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x000B2D30 File Offset: 0x000B0F30
		[CallerCount(0)]
		public unsafe static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x000B2D7C File Offset: 0x000B0F7C
		[CallerCount(0)]
		public unsafe bool Equals(servernetadr_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_Equals_Public_Boolean_servernetadr_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x000B2DBC File Offset: 0x000B0FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210395, XrefRangeEnd = 210398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(servernetadr_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(servernetadr_t.NativeMethodInfoPtr_CompareTo_Public_Int32_servernetadr_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00010C75 File Offset: 0x0000EE75
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<servernetadr_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400280F RID: 10255
		private static readonly IntPtr NativeFieldInfoPtr_m_usConnectionPort;

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeFieldInfoPtr_m_usQueryPort;

		// Token: 0x04002811 RID: 10257
		private static readonly IntPtr NativeFieldInfoPtr_m_unIP;

		// Token: 0x04002812 RID: 10258
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_UInt32_UInt16_UInt16_0;

		// Token: 0x04002813 RID: 10259
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryPort_Public_UInt16_0;

		// Token: 0x04002814 RID: 10260
		private static readonly IntPtr NativeMethodInfoPtr_SetQueryPort_Public_Void_UInt16_0;

		// Token: 0x04002815 RID: 10261
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionPort_Public_UInt16_0;

		// Token: 0x04002816 RID: 10262
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionPort_Public_Void_UInt16_0;

		// Token: 0x04002817 RID: 10263
		private static readonly IntPtr NativeMethodInfoPtr_GetIP_Public_UInt32_0;

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeMethodInfoPtr_SetIP_Public_Void_UInt32_0;

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionAddressString_Public_String_0;

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryAddressString_Public_String_0;

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_UInt32_UInt16_0;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_servernetadr_t_servernetadr_t_0;

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_servernetadr_t_servernetadr_t_0;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_servernetadr_t_0;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_servernetadr_t_0;

		// Token: 0x04002824 RID: 10276
		[FieldOffset(0)]
		public ushort m_usConnectionPort;

		// Token: 0x04002825 RID: 10277
		[FieldOffset(2)]
		public ushort m_usQueryPort;

		// Token: 0x04002826 RID: 10278
		[FieldOffset(4)]
		public uint m_unIP;
	}
}
