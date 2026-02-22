using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E7 RID: 743
	[Serializable]
	[StructLayout(2)]
	public struct HServerQuery
	{
		// Token: 0x06002B08 RID: 11016 RVA: 0x000B8928 File Offset: 0x000B6B28
		// Note: this type is marked as 'beforefieldinit'.
		static HServerQuery()
		{
			Il2CppClassPointerStore<HServerQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HServerQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr);
			HServerQuery.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, "Invalid");
			HServerQuery.NativeFieldInfoPtr_m_HServerQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, "m_HServerQuery");
			HServerQuery.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668845);
			HServerQuery.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668846);
			HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668847);
			HServerQuery.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668848);
			HServerQuery.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerQuery_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668849);
			HServerQuery.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerQuery_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668850);
			HServerQuery.NativeMethodInfoPtr_op_Explicit_Public_Static_HServerQuery_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668851);
			HServerQuery.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668852);
			HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668853);
			HServerQuery.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100668854);
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000B8A48 File Offset: 0x000B6C48
		[CallerCount(0)]
		public unsafe HServerQuery(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x000B8A7C File Offset: 0x000B6C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x000B8AA8 File Offset: 0x000B6CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210870, XrefRangeEnd = 210875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x000B8AEC File Offset: 0x000B6CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x000B8B1C File Offset: 0x000B6D1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HServerQuery x, HServerQuery y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerQuery_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x000B8B68 File Offset: 0x000B6D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210875, XrefRangeEnd = 210878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HServerQuery x, HServerQuery y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerQuery_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x000B8BB4 File Offset: 0x000B6DB4
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HServerQuery(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Explicit_Public_Static_HServerQuery_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x000B8BF4 File Offset: 0x000B6DF4
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(HServerQuery that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x000B8C34 File Offset: 0x000B6E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HServerQuery other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerQuery_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x000B8C74 File Offset: 0x000B6E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HServerQuery other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerQuery_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x000110C1 File Offset: 0x0000F2C1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x000B8CB4 File Offset: 0x000B6EB4
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x000110D3 File Offset: 0x0000F2D3
		public unsafe static HServerQuery Invalid
		{
			get
			{
				HServerQuery hserverQuery;
				IL2CPP.il2cpp_field_static_get_value(HServerQuery.NativeFieldInfoPtr_Invalid, (void*)(&hserverQuery));
				return hserverQuery;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HServerQuery.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeFieldInfoPtr_m_HServerQuery;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerQuery_HServerQuery_0;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerQuery_HServerQuery_0;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HServerQuery_Int32_0;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_HServerQuery_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerQuery_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerQuery_0;

		// Token: 0x04002970 RID: 10608
		[FieldOffset(0)]
		public int m_HServerQuery;
	}
}
