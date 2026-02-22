using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002DE RID: 734
	[Serializable]
	[StructLayout(2)]
	public struct InputActionSetHandle_t
	{
		// Token: 0x06002A96 RID: 10902 RVA: 0x000B69CC File Offset: 0x000B4BCC
		// Note: this type is marked as 'beforefieldinit'.
		static InputActionSetHandle_t()
		{
			Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "InputActionSetHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr);
			InputActionSetHandle_t.NativeFieldInfoPtr_m_InputActionSetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, "m_InputActionSetHandle");
			InputActionSetHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668752);
			InputActionSetHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668753);
			InputActionSetHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668754);
			InputActionSetHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668755);
			InputActionSetHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputActionSetHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668756);
			InputActionSetHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputActionSetHandle_t_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668757);
			InputActionSetHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_InputActionSetHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668758);
			InputActionSetHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668759);
			InputActionSetHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668760);
			InputActionSetHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputActionSetHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, 100668761);
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x000B6AD8 File Offset: 0x000B4CD8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputActionSetHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x000B6B0C File Offset: 0x000B4D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x000B6B38 File Offset: 0x000B4D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210809, XrefRangeEnd = 210812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x000B6B7C File Offset: 0x000B4D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x000B6BAC File Offset: 0x000B4DAC
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InputActionSetHandle_t x, InputActionSetHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputActionSetHandle_t_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x000B6BF8 File Offset: 0x000B4DF8
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InputActionSetHandle_t x, InputActionSetHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputActionSetHandle_t_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000B6C44 File Offset: 0x000B4E44
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator InputActionSetHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_InputActionSetHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000B6C84 File Offset: 0x000B4E84
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(InputActionSetHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputActionSetHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000B6CC4 File Offset: 0x000B4EC4
		[CallerCount(0)]
		public unsafe bool Equals(InputActionSetHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputActionSetHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x000B6D04 File Offset: 0x000B4F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(InputActionSetHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputActionSetHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputActionSetHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x00010FE7 File Offset: 0x0000F1E7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputActionSetHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeFieldInfoPtr_m_InputActionSetHandle;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputActionSetHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputActionSetHandle_t_InputActionSetHandle_t_0;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_InputActionSetHandle_t_UInt64_0;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputActionSetHandle_t_0;

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputActionSetHandle_t_0;

		// Token: 0x04002900 RID: 10496
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputActionSetHandle_t_0;

		// Token: 0x04002901 RID: 10497
		[FieldOffset(0)]
		public ulong m_InputActionSetHandle;
	}
}
