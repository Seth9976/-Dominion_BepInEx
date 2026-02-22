using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002DB RID: 731
	[Serializable]
	[StructLayout(2)]
	public struct HHTMLBrowser
	{
		// Token: 0x06002A6C RID: 10860 RVA: 0x000B5ED4 File Offset: 0x000B40D4
		// Note: this type is marked as 'beforefieldinit'.
		static HHTMLBrowser()
		{
			Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "HHTMLBrowser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr);
			HHTMLBrowser.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, "Invalid");
			HHTMLBrowser.NativeFieldInfoPtr_m_HHTMLBrowser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, "m_HHTMLBrowser");
			HHTMLBrowser.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668719);
			HHTMLBrowser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668720);
			HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668721);
			HHTMLBrowser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668722);
			HHTMLBrowser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668723);
			HHTMLBrowser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668724);
			HHTMLBrowser.NativeMethodInfoPtr_op_Explicit_Public_Static_HHTMLBrowser_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668725);
			HHTMLBrowser.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668726);
			HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668727);
			HHTMLBrowser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HHTMLBrowser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, 100668728);
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000B5FF4 File Offset: 0x000B41F4
		[CallerCount(0)]
		public unsafe HHTMLBrowser(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x000B6028 File Offset: 0x000B4228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x000B6054 File Offset: 0x000B4254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210785, XrefRangeEnd = 210790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x000B6098 File Offset: 0x000B4298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x000B60C8 File Offset: 0x000B42C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HHTMLBrowser x, HHTMLBrowser y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x000B6114 File Offset: 0x000B4314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210790, XrefRangeEnd = 210793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HHTMLBrowser x, HHTMLBrowser y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x000B6160 File Offset: 0x000B4360
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator HHTMLBrowser(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Explicit_Public_Static_HHTMLBrowser_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x000B61A0 File Offset: 0x000B43A0
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(HHTMLBrowser that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HHTMLBrowser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x000B61E0 File Offset: 0x000B43E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HHTMLBrowser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HHTMLBrowser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x000B6220 File Offset: 0x000B4420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HHTMLBrowser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HHTMLBrowser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HHTMLBrowser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00010F87 File Offset: 0x0000F187
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HHTMLBrowser>.NativeClassPtr, ref this));
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x000B6260 File Offset: 0x000B4460
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x00010F99 File Offset: 0x0000F199
		public unsafe static HHTMLBrowser Invalid
		{
			get
			{
				HHTMLBrowser hhtmlbrowser;
				IL2CPP.il2cpp_field_static_get_value(HHTMLBrowser.NativeFieldInfoPtr_Invalid, (void*)(&hhtmlbrowser));
				return hhtmlbrowser;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HHTMLBrowser.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x040028CF RID: 10447
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeFieldInfoPtr_m_HHTMLBrowser;

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0;

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HHTMLBrowser_HHTMLBrowser_0;

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_HHTMLBrowser_UInt32_0;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_HHTMLBrowser_0;

		// Token: 0x040028D9 RID: 10457
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HHTMLBrowser_0;

		// Token: 0x040028DA RID: 10458
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HHTMLBrowser_0;

		// Token: 0x040028DB RID: 10459
		[FieldOffset(0)]
		public uint m_HHTMLBrowser;
	}
}
