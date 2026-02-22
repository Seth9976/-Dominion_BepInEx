using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000010 RID: 16
	public sealed class SafeStringMarshal : ValueType
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00023BD4 File Offset: 0x00021DD4
		// Note: this type is marked as 'beforefieldinit'.
		static SafeStringMarshal()
		{
			Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "SafeStringMarshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr);
			SafeStringMarshal.NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, "str");
			SafeStringMarshal.NativeFieldInfoPtr_marshaled_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, "marshaled_string");
			SafeStringMarshal.NativeMethodInfoPtr_StringToUtf8_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663349);
			SafeStringMarshal.NativeMethodInfoPtr_GFree_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663350);
			SafeStringMarshal.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663351);
			SafeStringMarshal.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663352);
			SafeStringMarshal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663353);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00023C90 File Offset: 0x00021E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258446, XrefRangeEnd = 258447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr StringToUtf8(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr_StringToUtf8_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00023CD4 File Offset: 0x00021ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258447, XrefRangeEnd = 258448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GFree(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr_GFree_Public_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00023D08 File Offset: 0x00021F08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 258449, RefRangeEnd = 258455, XrefRangeStart = 258448, XrefRangeEnd = 258449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeStringMarshal(string str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00023D58 File Offset: 0x00021F58
		public unsafe IntPtr Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 258458, RefRangeEnd = 258465, XrefRangeStart = 258455, XrefRangeEnd = 258458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00023D9C File Offset: 0x00021F9C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 258468, RefRangeEnd = 258482, XrefRangeStart = 258465, XrefRangeEnd = 258468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeStringMarshal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002149 File Offset: 0x00000349
		public SafeStringMarshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002152 File Offset: 0x00000352
		public SafeStringMarshal()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr))
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00023DD4 File Offset: 0x00021FD4
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002164 File Offset: 0x00000364
		public unsafe string str
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeStringMarshal.NativeFieldInfoPtr_str);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeStringMarshal.NativeFieldInfoPtr_str), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00023DFC File Offset: 0x00021FFC
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002183 File Offset: 0x00000383
		public unsafe IntPtr marshaled_string
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeStringMarshal.NativeFieldInfoPtr_marshaled_string);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeStringMarshal.NativeFieldInfoPtr_marshaled_string)) = value;
			}
		}

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_str;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_marshaled_string;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_StringToUtf8_Public_Static_IntPtr_String_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_GFree_Public_Static_Void_IntPtr_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
