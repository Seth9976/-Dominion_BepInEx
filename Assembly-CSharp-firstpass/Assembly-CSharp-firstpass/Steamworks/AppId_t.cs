using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002FE RID: 766
	[Serializable]
	[StructLayout(2)]
	public struct AppId_t
	{
		// Token: 0x06002C36 RID: 11318 RVA: 0x000BD340 File Offset: 0x000BB540
		// Note: this type is marked as 'beforefieldinit'.
		static AppId_t()
		{
			Il2CppClassPointerStore<AppId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AppId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppId_t>.NativeClassPtr);
			AppId_t.NativeFieldInfoPtr_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, "Invalid");
			AppId_t.NativeFieldInfoPtr_m_AppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, "m_AppId");
			AppId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669041);
			AppId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669042);
			AppId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669043);
			AppId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669044);
			AppId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AppId_t_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669045);
			AppId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AppId_t_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669046);
			AppId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669047);
			AppId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669048);
			AppId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669049);
			AppId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, 100669050);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000BD460 File Offset: 0x000BB660
		[CallerCount(0)]
		public unsafe AppId_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000BD494 File Offset: 0x000BB694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210650, RefRangeEnd = 210652, XrefRangeStart = 210650, XrefRangeEnd = 210652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000BD4C0 File Offset: 0x000BB6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211052, XrefRangeEnd = 211057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000BD504 File Offset: 0x000BB704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000BD534 File Offset: 0x000BB734
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 210658, RefRangeEnd = 210665, XrefRangeStart = 210658, XrefRangeEnd = 210665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(AppId_t x, AppId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AppId_t_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000BD580 File Offset: 0x000BB780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211060, RefRangeEnd = 211061, XrefRangeStart = 211057, XrefRangeEnd = 211060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(AppId_t x, AppId_t y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AppId_t_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x000BD5CC File Offset: 0x000BB7CC
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator AppId_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_AppId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x000BD60C File Offset: 0x000BB80C
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint(AppId_t that)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref that;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000BD64C File Offset: 0x000BB84C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210745, RefRangeEnd = 210746, XrefRangeStart = 210745, XrefRangeEnd = 210746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AppId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000BD68C File Offset: 0x000BB88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(AppId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AppId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00011595 File Offset: 0x0000F795
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AppId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002C42 RID: 11330 RVA: 0x000BD6CC File Offset: 0x000BB8CC
		// (set) Token: 0x06002C43 RID: 11331 RVA: 0x000115A7 File Offset: 0x0000F7A7
		public unsafe static AppId_t Invalid
		{
			get
			{
				AppId_t appId_t;
				IL2CPP.il2cpp_field_static_get_value(AppId_t.NativeFieldInfoPtr_Invalid, (void*)(&appId_t));
				return appId_t;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppId_t.NativeFieldInfoPtr_Invalid, (void*)(&value));
			}
		}

		// Token: 0x04002A62 RID: 10850
		private static readonly IntPtr NativeFieldInfoPtr_Invalid;

		// Token: 0x04002A63 RID: 10851
		private static readonly IntPtr NativeFieldInfoPtr_m_AppId;

		// Token: 0x04002A64 RID: 10852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002A65 RID: 10853
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002A66 RID: 10854
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002A67 RID: 10855
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002A68 RID: 10856
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AppId_t_AppId_t_0;

		// Token: 0x04002A69 RID: 10857
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AppId_t_AppId_t_0;

		// Token: 0x04002A6A RID: 10858
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AppId_t_UInt32_0;

		// Token: 0x04002A6B RID: 10859
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt32_AppId_t_0;

		// Token: 0x04002A6C RID: 10860
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AppId_t_0;

		// Token: 0x04002A6D RID: 10861
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AppId_t_0;

		// Token: 0x04002A6E RID: 10862
		[FieldOffset(0)]
		public uint m_AppId;
	}
}
