using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000EC RID: 236
	public class CookieParser : Object
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x000443D0 File Offset: 0x000425D0
		// Note: this type is marked as 'beforefieldinit'.
		static CookieParser()
		{
			Il2CppClassPointerStore<CookieParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieParser>.NativeClassPtr);
			CookieParser.NativeFieldInfoPtr_m_tokenizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, "m_tokenizer");
			CookieParser.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100665238);
			CookieParser.NativeMethodInfoPtr_Get_Internal_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100665239);
			CookieParser.NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieParser>.NativeClassPtr, 100665240);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00044450 File Offset: 0x00042650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48151, XrefRangeEnd = 48156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieParser(string cookieString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cookieString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieParser.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0004449C File Offset: 0x0004269C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48221, RefRangeEnd = 48222, XrefRangeStart = 48156, XrefRangeEnd = 48221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cookie Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieParser.NativeMethodInfoPtr_Get_Internal_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cookie>(intPtr3) : null;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000444DC File Offset: 0x000426DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 48226, RefRangeEnd = 48229, XrefRangeStart = 48222, XrefRangeEnd = 48226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CheckQuoted(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieParser.NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00007706 File Offset: 0x00005906
		public CookieParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00044518 File Offset: 0x00042718
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x0000770F File Offset: 0x0000590F
		public unsafe CookieTokenizer m_tokenizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieParser.NativeFieldInfoPtr_m_tokenizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieTokenizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieParser.NativeFieldInfoPtr_m_tokenizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_m_tokenizer;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Cookie_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_CheckQuoted_Internal_Static_String_String_0;
	}
}
