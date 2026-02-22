using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E0 RID: 736
	[Serializable]
	[StructLayout(2)]
	public struct InputDigitalActionHandle_t
	{
		// Token: 0x06002AAE RID: 10926 RVA: 0x000B70BC File Offset: 0x000B52BC
		// Note: this type is marked as 'beforefieldinit'.
		static InputDigitalActionHandle_t()
		{
			Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "InputDigitalActionHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr);
			InputDigitalActionHandle_t.NativeFieldInfoPtr_m_InputDigitalActionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, "m_InputDigitalActionHandle");
			InputDigitalActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668772);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668773);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668774);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668775);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668776);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668777);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_InputDigitalActionHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668778);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668779);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668780);
			InputDigitalActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputDigitalActionHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, 100668781);
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000B71C8 File Offset: 0x000B53C8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputDigitalActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x000B71FC File Offset: 0x000B53FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x000B7228 File Offset: 0x000B5428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210815, XrefRangeEnd = 210818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000B726C File Offset: 0x000B546C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000B729C File Offset: 0x000B549C
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x000B72E8 File Offset: 0x000B54E8
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InputDigitalActionHandle_t x, InputDigitalActionHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000B7334 File Offset: 0x000B5534
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator InputDigitalActionHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_InputDigitalActionHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x000B7374 File Offset: 0x000B5574
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(InputDigitalActionHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputDigitalActionHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000B73B4 File Offset: 0x000B55B4
		[CallerCount(0)]
		public unsafe bool Equals(InputDigitalActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDigitalActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x000B73F4 File Offset: 0x000B55F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(InputDigitalActionHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDigitalActionHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputDigitalActionHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0001100B File Offset: 0x0000F20B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDigitalActionHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeFieldInfoPtr_m_InputDigitalActionHandle;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputDigitalActionHandle_t_InputDigitalActionHandle_t_0;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_InputDigitalActionHandle_t_UInt64_0;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputDigitalActionHandle_t_0;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDigitalActionHandle_t_0;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputDigitalActionHandle_t_0;

		// Token: 0x04002919 RID: 10521
		[FieldOffset(0)]
		public ulong m_InputDigitalActionHandle;
	}
}
