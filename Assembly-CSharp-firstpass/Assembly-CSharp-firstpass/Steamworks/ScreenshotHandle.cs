using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002FC RID: 764
	[Serializable]
	[StructLayout(2)]
	public struct ScreenshotHandle
	{
		// Token: 0x06002C1C RID: 11292 RVA: 0x000BCC20 File Offset: 0x000BAE20
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotHandle()
		{
			Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ScreenshotHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr);
			ScreenshotHandle.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, "Invalid");
			ScreenshotHandle.NativeFieldInfoPtr_m_ScreenshotHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, "m_ScreenshotHandle");
			ScreenshotHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669020);
			ScreenshotHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669021);
			ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669022);
			ScreenshotHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669023);
			ScreenshotHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669024);
			ScreenshotHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669025);
			ScreenshotHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_ScreenshotHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669026);
			ScreenshotHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669027);
			ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669028);
			ScreenshotHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100669029);
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x000BCD40 File Offset: 0x000BAF40
		[CallerCount(0)]
		public unsafe ScreenshotHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000BCD74 File Offset: 0x000BAF74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x000BCDA0 File Offset: 0x000BAFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211041, XrefRangeEnd = 211046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x000BCDE4 File Offset: 0x000BAFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x000BCE14 File Offset: 0x000BB014
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ScreenshotHandle x, ScreenshotHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x000BCE60 File Offset: 0x000BB060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211046, XrefRangeEnd = 211049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ScreenshotHandle x, ScreenshotHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x000BCEAC File Offset: 0x000BB0AC
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ScreenshotHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_ScreenshotHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x000BCEEC File Offset: 0x000BB0EC
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(ScreenshotHandle that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_ScreenshotHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x000BCF2C File Offset: 0x000BB12C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScreenshotHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenshotHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x000BCF6C File Offset: 0x000BB16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ScreenshotHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenshotHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00011563 File Offset: 0x0000F763
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002C28 RID: 11304 RVA: 0x000BCFAC File Offset: 0x000BB1AC
		// (set) Token: 0x06002C29 RID: 11305 RVA: 0x00011575 File Offset: 0x0000F775
		public unsafe static ScreenshotHandle Invalid
		{
			get
			{
				ScreenshotHandle screenshotHandle;
				IL2CPP.il2cpp_field_static_get_value(ScreenshotHandle.NativeFieldInfoPtr_Invalid, (void*)(&screenshotHandle));
				return screenshotHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenshotHandle.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002A49 RID: 10825
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002A4A RID: 10826
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenshotHandle;

		// Token: 0x04002A4B RID: 10827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002A4C RID: 10828
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A4D RID: 10829
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A4E RID: 10830
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A4F RID: 10831
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0;

		// Token: 0x04002A50 RID: 10832
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0;

		// Token: 0x04002A51 RID: 10833
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ScreenshotHandle_UInt32_0;

		// Token: 0x04002A52 RID: 10834
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_ScreenshotHandle_0;

		// Token: 0x04002A53 RID: 10835
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenshotHandle_0;

		// Token: 0x04002A54 RID: 10836
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenshotHandle_0;

		// Token: 0x04002A55 RID: 10837
		[FieldOffset(0)]
		public uint m_ScreenshotHandle;
	}
}
