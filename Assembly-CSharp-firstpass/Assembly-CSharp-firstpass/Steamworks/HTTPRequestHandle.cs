using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002DD RID: 733
	[Serializable]
	[StructLayout(2)]
	public struct HTTPRequestHandle
	{
		// Token: 0x06002A88 RID: 10888 RVA: 0x000B6624 File Offset: 0x000B4824
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestHandle()
		{
			Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HTTPRequestHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr);
			HTTPRequestHandle.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, "Invalid");
			HTTPRequestHandle.NativeFieldInfoPtr_m_HTTPRequestHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, "m_HTTPRequestHandle");
			HTTPRequestHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668741);
			HTTPRequestHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668742);
			HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668743);
			HTTPRequestHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668744);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668745);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668746);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668747);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668748);
			HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668749);
			HTTPRequestHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100668750);
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x000B6744 File Offset: 0x000B4944
		[CallerCount(0)]
		public unsafe HTTPRequestHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x000B6778 File Offset: 0x000B4978
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x000B67A4 File Offset: 0x000B49A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210801, XrefRangeEnd = 210806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000B67E8 File Offset: 0x000B49E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000B6818 File Offset: 0x000B4A18
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x000B6864 File Offset: 0x000B4A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210806, XrefRangeEnd = 210809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HTTPRequestHandle x, HTTPRequestHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x000B68B0 File Offset: 0x000B4AB0
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HTTPRequestHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x000B68F0 File Offset: 0x000B4AF0
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(HTTPRequestHandle that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000B6930 File Offset: 0x000B4B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HTTPRequestHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPRequestHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x000B6970 File Offset: 0x000B4B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HTTPRequestHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPRequestHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x00010FC7 File Offset: 0x0000F1C7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x000B69B0 File Offset: 0x000B4BB0
		// (set) Token: 0x06002A95 RID: 10901 RVA: 0x00010FD9 File Offset: 0x0000F1D9
		public unsafe static HTTPRequestHandle Invalid
		{
			get
			{
				HTTPRequestHandle httprequestHandle;
				IL2CPP.il2cpp_field_static_get_value(HTTPRequestHandle.NativeFieldInfoPtr_Invalid, (void*)(&httprequestHandle));
				return httprequestHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HTTPRequestHandle.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x040028E9 RID: 10473
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeFieldInfoPtr_m_HTTPRequestHandle;

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HTTPRequestHandle_UInt32_0;

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HTTPRequestHandle_0;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPRequestHandle_0;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPRequestHandle_0;

		// Token: 0x040028F5 RID: 10485
		[FieldOffset(0)]
		public uint m_HTTPRequestHandle;
	}
}
