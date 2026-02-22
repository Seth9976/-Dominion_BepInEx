using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Text
{
	// Token: 0x02000178 RID: 376
	public static class EncodingHelper : Object
	{
		// Token: 0x06001A3A RID: 6714 RVA: 0x00099380 File Offset: 0x00097580
		// Note: this type is marked as 'beforefieldinit'.
		static EncodingHelper()
		{
			Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncodingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr);
			EncodingHelper.NativeFieldInfoPtr_utf8EncodingWithoutMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "utf8EncodingWithoutMarkers");
			EncodingHelper.NativeFieldInfoPtr_lockobj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "lockobj");
			EncodingHelper.NativeFieldInfoPtr_i18nAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "i18nAssembly");
			EncodingHelper.NativeFieldInfoPtr_i18nDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "i18nDisabled");
			EncodingHelper.NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100667735);
			EncodingHelper.NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100667736);
			EncodingHelper.NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100667737);
			EncodingHelper.NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100667738);
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00099450 File Offset: 0x00097650
		public unsafe static Encoding UTF8Unmarked
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 315271, RefRangeEnd = 315274, XrefRangeStart = 315242, XrefRangeEnd = 315271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00099484 File Offset: 0x00097684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315275, RefRangeEnd = 315276, XrefRangeStart = 315274, XrefRangeEnd = 315275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalCodePage(ref int code_page)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &code_page;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x000994BC File Offset: 0x000976BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315294, RefRangeEnd = 315296, XrefRangeStart = 315276, XrefRangeEnd = 315294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetDefaultEncoding()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x000994F0 File Offset: 0x000976F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315296, XrefRangeEnd = 315358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InvokeI18N(string name, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncodingHelper.NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00008F2E File Offset: 0x0000712E
		public static Object InvokeI18N(string name, params Object[] args)
		{
			return EncodingHelper.InvokeI18N(name, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00008F3C File Offset: 0x0000713C
		public EncodingHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x00099554 File Offset: 0x00097754
		// (set) Token: 0x06001A42 RID: 6722 RVA: 0x00008F45 File Offset: 0x00007145
		public unsafe static Encoding utf8EncodingWithoutMarkers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_utf8EncodingWithoutMarkers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_utf8EncodingWithoutMarkers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x0009957C File Offset: 0x0009777C
		// (set) Token: 0x06001A44 RID: 6724 RVA: 0x00008F57 File Offset: 0x00007157
		public unsafe static Object lockobj
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_lockobj, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_lockobj, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x000995A4 File Offset: 0x000977A4
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x00008F69 File Offset: 0x00007169
		public unsafe static Assembly i18nAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_i18nAssembly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_i18nAssembly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x000995CC File Offset: 0x000977CC
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x00008F7B File Offset: 0x0000717B
		public unsafe static bool i18nDisabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(EncodingHelper.NativeFieldInfoPtr_i18nDisabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncodingHelper.NativeFieldInfoPtr_i18nDisabled, (void*)(&value));
			}
		}

		// Token: 0x040017E2 RID: 6114
		private static readonly IntPtr NativeFieldInfoPtr_utf8EncodingWithoutMarkers;

		// Token: 0x040017E3 RID: 6115
		private static readonly IntPtr NativeFieldInfoPtr_lockobj;

		// Token: 0x040017E4 RID: 6116
		private static readonly IntPtr NativeFieldInfoPtr_i18nAssembly;

		// Token: 0x040017E5 RID: 6117
		private static readonly IntPtr NativeFieldInfoPtr_i18nDisabled;

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0;

		// Token: 0x040017E7 RID: 6119
		private static readonly IntPtr NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0;

		// Token: 0x040017E8 RID: 6120
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0;

		// Token: 0x040017E9 RID: 6121
		private static readonly IntPtr NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0;
	}
}
