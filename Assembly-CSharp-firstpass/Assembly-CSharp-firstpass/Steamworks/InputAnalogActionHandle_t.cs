using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002DF RID: 735
	[Serializable]
	[StructLayout(2)]
	public struct InputAnalogActionHandle_t
	{
		// Token: 0x06002AA2 RID: 10914 RVA: 0x000B6D44 File Offset: 0x000B4F44
		// Note: this type is marked as 'beforefieldinit'.
		static InputAnalogActionHandle_t()
		{
			Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "InputAnalogActionHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr);
			InputAnalogActionHandle_t.NativeFieldInfoPtr_m_InputAnalogActionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, "m_InputAnalogActionHandle");
			InputAnalogActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668762);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668763);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668764);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668765);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668766);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668767);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_InputAnalogActionHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668768);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668769);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668770);
			InputAnalogActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputAnalogActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, 100668771);
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000B6E50 File Offset: 0x000B5050
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputAnalogActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x000B6E84 File Offset: 0x000B5084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x000B6EB0 File Offset: 0x000B50B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210812, XrefRangeEnd = 210815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x000B6EF4 File Offset: 0x000B50F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000B6F24 File Offset: 0x000B5124
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000B6F70 File Offset: 0x000B5170
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InputAnalogActionHandle_t x, InputAnalogActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000B6FBC File Offset: 0x000B51BC
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator InputAnalogActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_InputAnalogActionHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000B6FFC File Offset: 0x000B51FC
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(InputAnalogActionHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputAnalogActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000B703C File Offset: 0x000B523C
		[CallerCount(0)]
		public unsafe bool Equals(InputAnalogActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputAnalogActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x000B707C File Offset: 0x000B527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(InputAnalogActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputAnalogActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputAnalogActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00010FF9 File Offset: 0x0000F1F9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputAnalogActionHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeFieldInfoPtr_m_InputAnalogActionHandle;

		// Token: 0x04002903 RID: 10499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002904 RID: 10500
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x04002908 RID: 10504
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputAnalogActionHandle_t_InputAnalogActionHandle_t_0;

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_InputAnalogActionHandle_t_UInt64_0;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputAnalogActionHandle_t_0;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputAnalogActionHandle_t_0;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputAnalogActionHandle_t_0;

		// Token: 0x0400290D RID: 10509
		[FieldOffset(0)]
		public ulong m_InputAnalogActionHandle;
	}
}
