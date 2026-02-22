using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002E1 RID: 737
	[Serializable]
	[StructLayout(2)]
	public struct InputHandle_t
	{
		// Token: 0x06002ABA RID: 10938 RVA: 0x000B7434 File Offset: 0x000B5634
		// Note: this type is marked as 'beforefieldinit'.
		static InputHandle_t()
		{
			Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "InputHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr);
			InputHandle_t.NativeFieldInfoPtr_m_InputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, "m_InputHandle");
			InputHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668782);
			InputHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668783);
			InputHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668784);
			InputHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668785);
			InputHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputHandle_t_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668786);
			InputHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputHandle_t_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668787);
			InputHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_InputHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668788);
			InputHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668789);
			InputHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668790);
			InputHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, 100668791);
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x000B7540 File Offset: 0x000B5740
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x000B7574 File Offset: 0x000B5774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x000B75A0 File Offset: 0x000B57A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210818, XrefRangeEnd = 210821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x000B75E4 File Offset: 0x000B57E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x000B7614 File Offset: 0x000B5814
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InputHandle_t x, InputHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputHandle_t_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x000B7660 File Offset: 0x000B5860
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InputHandle_t x, InputHandle_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputHandle_t_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x000B76AC File Offset: 0x000B58AC
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator InputHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_InputHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x000B76EC File Offset: 0x000B58EC
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(InputHandle_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x000B772C File Offset: 0x000B592C
		[CallerCount(0)]
		public unsafe bool Equals(InputHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x000B776C File Offset: 0x000B596C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(InputHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0001101D File Offset: 0x0000F21D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeFieldInfoPtr_m_InputHandle;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InputHandle_t_InputHandle_t_0;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InputHandle_t_InputHandle_t_0;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_InputHandle_t_UInt64_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_InputHandle_t_0;

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputHandle_t_0;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InputHandle_t_0;

		// Token: 0x04002925 RID: 10533
		[FieldOffset(0)]
		public ulong m_InputHandle;
	}
}
