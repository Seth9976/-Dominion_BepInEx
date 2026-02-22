using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000302 RID: 770
	[Serializable]
	[StructLayout(2)]
	public struct RTime32
	{
		// Token: 0x06002C6E RID: 11374 RVA: 0x000BE1E0 File Offset: 0x000BC3E0
		// Note: this type is marked as 'beforefieldinit'.
		static RTime32()
		{
			Il2CppClassPointerStore<RTime32>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RTime32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTime32>.NativeClassPtr);
			RTime32.NativeFieldInfoPtr_m_RTime32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTime32>.NativeClassPtr, "m_RTime32");
			RTime32.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669085);
			RTime32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669086);
			RTime32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669087);
			RTime32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669088);
			RTime32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RTime32_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669089);
			RTime32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RTime32_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669090);
			RTime32.NativeMethodInfoPtr_op_Explicit_Public_Static_RTime32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669091);
			RTime32.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669092);
			RTime32.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669093);
			RTime32.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100669094);
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x000BE2EC File Offset: 0x000BC4EC
		[CallerCount(0)]
		public unsafe RTime32(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x000BE320 File Offset: 0x000BC520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x000BE34C File Offset: 0x000BC54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211085, XrefRangeEnd = 211088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x000BE390 File Offset: 0x000BC590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000BE3C0 File Offset: 0x000BC5C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RTime32 x, RTime32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RTime32_RTime32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x000BE40C File Offset: 0x000BC60C
		[CallerCount(0)]
		public unsafe static bool operator !=(RTime32 x, RTime32 y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RTime32_RTime32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x000BE458 File Offset: 0x000BC658
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator RTime32(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_op_Explicit_Public_Static_RTime32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000BE498 File Offset: 0x000BC698
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(RTime32 that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_RTime32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x000BE4D8 File Offset: 0x000BC6D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RTime32 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RTime32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x000BE518 File Offset: 0x000BC718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(RTime32 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RTime32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00011615 File Offset: 0x0000F815
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTime32>.NativeClassPtr, ref this));
		}

		// Token: 0x04002A96 RID: 10902
		private static readonly IntPtr NativeFieldInfoPtr_m_RTime32;

		// Token: 0x04002A97 RID: 10903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002A98 RID: 10904
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A99 RID: 10905
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A9A RID: 10906
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A9B RID: 10907
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RTime32_RTime32_0;

		// Token: 0x04002A9C RID: 10908
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RTime32_RTime32_0;

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_RTime32_UInt32_0;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_RTime32_0;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RTime32_0;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RTime32_0;

		// Token: 0x04002AA1 RID: 10913
		[FieldOffset(0)]
		public uint m_RTime32;
	}
}
