using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002DC RID: 732
	[Serializable]
	[StructLayout(2)]
	public struct HTTPCookieContainerHandle
	{
		// Token: 0x06002A7A RID: 10874 RVA: 0x000B627C File Offset: 0x000B447C
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPCookieContainerHandle()
		{
			Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPCookieContainerHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr);
			HTTPCookieContainerHandle.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, "Invalid");
			HTTPCookieContainerHandle.NativeFieldInfoPtr_m_HTTPCookieContainerHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, "m_HTTPCookieContainerHandle");
			HTTPCookieContainerHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668730);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668731);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668732);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668733);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668734);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668735);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPCookieContainerHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668736);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668737);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668738);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100668739);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x000B639C File Offset: 0x000B459C
		[CallerCount(0)]
		public unsafe HTTPCookieContainerHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x000B63D0 File Offset: 0x000B45D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x000B63FC File Offset: 0x000B45FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210793, XrefRangeEnd = 210798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x000B6440 File Offset: 0x000B4640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000B6470 File Offset: 0x000B4670
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x000B64BC File Offset: 0x000B46BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210798, XrefRangeEnd = 210801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HTTPCookieContainerHandle x, HTTPCookieContainerHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x000B6508 File Offset: 0x000B4708
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HTTPCookieContainerHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPCookieContainerHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000B6548 File Offset: 0x000B4748
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(HTTPCookieContainerHandle that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x000B6588 File Offset: 0x000B4788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HTTPCookieContainerHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPCookieContainerHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x000B65C8 File Offset: 0x000B47C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HTTPCookieContainerHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPCookieContainerHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00010FA7 File Offset: 0x0000F1A7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x000B6608 File Offset: 0x000B4808
		// (set) Token: 0x06002A87 RID: 10887 RVA: 0x00010FB9 File Offset: 0x0000F1B9
		public unsafe static HTTPCookieContainerHandle Invalid
		{
			get
			{
				HTTPCookieContainerHandle httpcookieContainerHandle;
				IL2CPP.il2cpp_field_static_get_value(HTTPCookieContainerHandle.NativeFieldInfoPtr_Invalid, (void*)(&httpcookieContainerHandle));
				return httpcookieContainerHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPCookieContainerHandle.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x040028DC RID: 10460
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeFieldInfoPtr_m_HTTPCookieContainerHandle;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040028DF RID: 10463
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040028E0 RID: 10464
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040028E1 RID: 10465
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040028E2 RID: 10466
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0;

		// Token: 0x040028E3 RID: 10467
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0;

		// Token: 0x040028E4 RID: 10468
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPCookieContainerHandle_UInt32_0;

		// Token: 0x040028E5 RID: 10469
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPCookieContainerHandle_0;

		// Token: 0x040028E6 RID: 10470
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPCookieContainerHandle_0;

		// Token: 0x040028E7 RID: 10471
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPCookieContainerHandle_0;

		// Token: 0x040028E8 RID: 10472
		[FieldOffset(0)]
		public uint m_HTTPCookieContainerHandle;
	}
}
