using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000309 RID: 777
	[Serializable]
	[StructLayout(2)]
	public struct SteamLeaderboard_t
	{
		// Token: 0x06002CC5 RID: 11461 RVA: 0x000BF938 File Offset: 0x000BDB38
		// Note: this type is marked as 'beforefieldinit'.
		static SteamLeaderboard_t()
		{
			Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamLeaderboard_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr);
			SteamLeaderboard_t.NativeFieldInfoPtr_m_SteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, "m_SteamLeaderboard");
			SteamLeaderboard_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669154);
			SteamLeaderboard_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669155);
			SteamLeaderboard_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669156);
			SteamLeaderboard_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669157);
			SteamLeaderboard_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669158);
			SteamLeaderboard_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669159);
			SteamLeaderboard_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamLeaderboard_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669160);
			SteamLeaderboard_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669161);
			SteamLeaderboard_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669162);
			SteamLeaderboard_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100669163);
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000BFA44 File Offset: 0x000BDC44
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamLeaderboard_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x000BFA78 File Offset: 0x000BDC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x000BFAA4 File Offset: 0x000BDCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211150, XrefRangeEnd = 211153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x000BFAE8 File Offset: 0x000BDCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x000BFB18 File Offset: 0x000BDD18
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x000BFB64 File Offset: 0x000BDD64
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamLeaderboard_t x, SteamLeaderboard_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x000BFBB0 File Offset: 0x000BDDB0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamLeaderboard_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamLeaderboard_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000BFBF0 File Offset: 0x000BDDF0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(SteamLeaderboard_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x000BFC30 File Offset: 0x000BDE30
		[CallerCount(0)]
		public unsafe bool Equals(SteamLeaderboard_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboard_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000BFC70 File Offset: 0x000BDE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamLeaderboard_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboard_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000116CB File Offset: 0x0000F8CB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002AED RID: 10989
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamLeaderboard;

		// Token: 0x04002AEE RID: 10990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002AEF RID: 10991
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002AF0 RID: 10992
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002AF1 RID: 10993
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002AF2 RID: 10994
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0;

		// Token: 0x04002AF3 RID: 10995
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0;

		// Token: 0x04002AF4 RID: 10996
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamLeaderboard_t_UInt64_0;

		// Token: 0x04002AF5 RID: 10997
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_SteamLeaderboard_t_0;

		// Token: 0x04002AF6 RID: 10998
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboard_t_0;

		// Token: 0x04002AF7 RID: 10999
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboard_t_0;

		// Token: 0x04002AF8 RID: 11000
		[FieldOffset(0)]
		public ulong m_SteamLeaderboard;
	}
}
