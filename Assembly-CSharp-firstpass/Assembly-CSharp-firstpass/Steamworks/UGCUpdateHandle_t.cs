using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000307 RID: 775
	[Serializable]
	[StructLayout(2)]
	public struct UGCUpdateHandle_t
	{
		// Token: 0x06002CAB RID: 11435 RVA: 0x000BF218 File Offset: 0x000BD418
		// Note: this type is marked as 'beforefieldinit'.
		static UGCUpdateHandle_t()
		{
			Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UGCUpdateHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr);
			UGCUpdateHandle_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, "Invalid");
			UGCUpdateHandle_t.NativeFieldInfoPtr_m_UGCUpdateHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, "m_UGCUpdateHandle");
			UGCUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669133);
			UGCUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669134);
			UGCUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669135);
			UGCUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669136);
			UGCUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669137);
			UGCUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669138);
			UGCUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCUpdateHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669139);
			UGCUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669140);
			UGCUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669141);
			UGCUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, 100669142);
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x000BF338 File Offset: 0x000BD538
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UGCUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x000BF36C File Offset: 0x000BD56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x000BF398 File Offset: 0x000BD598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211139, XrefRangeEnd = 211144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x000BF3DC File Offset: 0x000BD5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x000BF40C File Offset: 0x000BD60C
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x000BF458 File Offset: 0x000BD658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211144, XrefRangeEnd = 211147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UGCUpdateHandle_t x, UGCUpdateHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x000BF4A4 File Offset: 0x000BD6A4
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator UGCUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UGCUpdateHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x000BF4E4 File Offset: 0x000BD6E4
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(UGCUpdateHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x000BF524 File Offset: 0x000BD724
		[CallerCount(0)]
		public unsafe bool Equals(UGCUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x000BF564 File Offset: 0x000BD764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(UGCUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x00011699 File Offset: 0x0000F899
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UGCUpdateHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x000BF5A4 File Offset: 0x000BD7A4
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x000116AB File Offset: 0x0000F8AB
		public unsafe static UGCUpdateHandle_t Invalid
		{
			get
			{
				UGCUpdateHandle_t ugcupdateHandle_t;
				IL2CPP.il2cpp_field_static_get_value(UGCUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&ugcupdateHandle_t));
				return ugcupdateHandle_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UGCUpdateHandle_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002AD4 RID: 10964
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002AD5 RID: 10965
		private static readonly IntPtr NativeFieldInfoPtr_m_UGCUpdateHandle;

		// Token: 0x04002AD6 RID: 10966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002AD7 RID: 10967
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002AD8 RID: 10968
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002AD9 RID: 10969
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002ADA RID: 10970
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0;

		// Token: 0x04002ADB RID: 10971
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCUpdateHandle_t_UGCUpdateHandle_t_0;

		// Token: 0x04002ADC RID: 10972
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UGCUpdateHandle_t_UInt64_0;

		// Token: 0x04002ADD RID: 10973
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_UGCUpdateHandle_t_0;

		// Token: 0x04002ADE RID: 10974
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCUpdateHandle_t_0;

		// Token: 0x04002ADF RID: 10975
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCUpdateHandle_t_0;

		// Token: 0x04002AE0 RID: 10976
		[FieldOffset(0)]
		public ulong m_UGCUpdateHandle;
	}
}
