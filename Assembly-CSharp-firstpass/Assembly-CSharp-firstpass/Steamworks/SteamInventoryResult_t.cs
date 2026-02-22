using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E2 RID: 738
	[Serializable]
	[StructLayout(2)]
	public struct SteamInventoryResult_t
	{
		// Token: 0x06002AC6 RID: 10950 RVA: 0x000B77AC File Offset: 0x000B59AC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryResult_t()
		{
			Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr);
			SteamInventoryResult_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, "Invalid");
			SteamInventoryResult_t.NativeFieldInfoPtr_m_SteamInventoryResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, "m_SteamInventoryResult");
			SteamInventoryResult_t.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668792);
			SteamInventoryResult_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668793);
			SteamInventoryResult_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668794);
			SteamInventoryResult_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668795);
			SteamInventoryResult_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668796);
			SteamInventoryResult_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668797);
			SteamInventoryResult_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamInventoryResult_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668798);
			SteamInventoryResult_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668799);
			SteamInventoryResult_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668800);
			SteamInventoryResult_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, 100668801);
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000B78CC File Offset: 0x000B5ACC
		[CallerCount(0)]
		public unsafe SteamInventoryResult_t(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x000B7900 File Offset: 0x000B5B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210821, XrefRangeEnd = 210824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x000B792C File Offset: 0x000B5B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210824, XrefRangeEnd = 210829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ACA RID: 10954 RVA: 0x000B7970 File Offset: 0x000B5B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x000B79A0 File Offset: 0x000B5BA0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x000B79EC File Offset: 0x000B5BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210829, XrefRangeEnd = 210832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamInventoryResult_t x, SteamInventoryResult_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000B7A38 File Offset: 0x000B5C38
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator SteamInventoryResult_t(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_op_Explicit_Public_Static_SteamInventoryResult_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000B7A78 File Offset: 0x000B5C78
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(SteamInventoryResult_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000B7AB8 File Offset: 0x000B5CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(SteamInventoryResult_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamInventoryResult_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000B7AF8 File Offset: 0x000B5CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210832, XrefRangeEnd = 210833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamInventoryResult_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventoryResult_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamInventoryResult_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x0001102F File Offset: 0x0000F22F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x000B7B38 File Offset: 0x000B5D38
		// (set) Token: 0x06002AD3 RID: 10963 RVA: 0x00011041 File Offset: 0x0000F241
		public unsafe static SteamInventoryResult_t Invalid
		{
			get
			{
				SteamInventoryResult_t steamInventoryResult_t;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryResult_t.NativeFieldInfoPtr_Invalid, (void*)(&steamInventoryResult_t));
				return steamInventoryResult_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryResult_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002926 RID: 10534
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002927 RID: 10535
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamInventoryResult;

		// Token: 0x04002928 RID: 10536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0;

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamInventoryResult_t_SteamInventoryResult_t_0;

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SteamInventoryResult_t_Int32_0;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_SteamInventoryResult_t_0;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamInventoryResult_t_0;

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamInventoryResult_t_0;

		// Token: 0x04002932 RID: 10546
		[FieldOffset(0)]
		public int m_SteamInventoryResult;
	}
}
