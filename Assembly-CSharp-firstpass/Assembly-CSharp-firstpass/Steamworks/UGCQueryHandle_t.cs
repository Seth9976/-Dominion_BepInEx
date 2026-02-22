using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000306 RID: 774
	[Serializable]
	[StructLayout(2)]
	public struct UGCQueryHandle_t
	{
		// Token: 0x06002C9D RID: 11421 RVA: 0x000BEE70 File Offset: 0x000BD070
		// Note: this type is marked as 'beforefieldinit'.
		static UGCQueryHandle_t()
		{
			Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UGCQueryHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr);
			UGCQueryHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, "Invalid");
			UGCQueryHandle_t.NativeFieldInfoPtr_m_UGCQueryHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, "m_UGCQueryHandle");
			UGCQueryHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669122);
			UGCQueryHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669123);
			UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669124);
			UGCQueryHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669125);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669126);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669127);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCQueryHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669128);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669129);
			UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669130);
			UGCQueryHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100669131);
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x000BEF90 File Offset: 0x000BD190
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UGCQueryHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000BEFC4 File Offset: 0x000BD1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000BEFF0 File Offset: 0x000BD1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211131, XrefRangeEnd = 211136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000BF034 File Offset: 0x000BD234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000BF064 File Offset: 0x000BD264
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000BF0B0 File Offset: 0x000BD2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211136, XrefRangeEnd = 211139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UGCQueryHandle_t x, UGCQueryHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000BF0FC File Offset: 0x000BD2FC
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UGCQueryHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCQueryHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x000BF13C File Offset: 0x000BD33C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(UGCQueryHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x000BF17C File Offset: 0x000BD37C
		[CallerCount(0)]
		public unsafe bool Equals(UGCQueryHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCQueryHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000BF1BC File Offset: 0x000BD3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(UGCQueryHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCQueryHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00011679 File Offset: 0x0000F879
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x000BF1FC File Offset: 0x000BD3FC
		// (set) Token: 0x06002CAA RID: 11434 RVA: 0x0001168B File Offset: 0x0000F88B
		public unsafe static UGCQueryHandle_t Invalid
		{
			get
			{
				UGCQueryHandle_t ugcqueryHandle_t;
				IL2CPP.il2cpp_field_static_get_value(UGCQueryHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&ugcqueryHandle_t));
				return ugcqueryHandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UGCQueryHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002AC7 RID: 10951
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002AC8 RID: 10952
		private static readonly IntPtr NativeFieldInfoPtr_m_UGCQueryHandle;

		// Token: 0x04002AC9 RID: 10953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002ACA RID: 10954
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002ACB RID: 10955
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002ACC RID: 10956
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002ACD RID: 10957
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0;

		// Token: 0x04002ACE RID: 10958
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0;

		// Token: 0x04002ACF RID: 10959
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UGCQueryHandle_t_UInt64_0;

		// Token: 0x04002AD0 RID: 10960
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCQueryHandle_t_0;

		// Token: 0x04002AD1 RID: 10961
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCQueryHandle_t_0;

		// Token: 0x04002AD2 RID: 10962
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCQueryHandle_t_0;

		// Token: 0x04002AD3 RID: 10963
		[FieldOffset(0)]
		public ulong m_UGCQueryHandle;
	}
}
