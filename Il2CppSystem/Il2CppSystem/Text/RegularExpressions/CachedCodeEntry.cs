using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000048 RID: 72
	public sealed class CachedCodeEntry : Object
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x00021760 File Offset: 0x0001F960
		// Note: this type is marked as 'beforefieldinit'.
		static CachedCodeEntry()
		{
			Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "CachedCodeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr);
			CachedCodeEntry.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_key");
			CachedCodeEntry.NativeFieldInfoPtr__code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_code");
			CachedCodeEntry.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_caps");
			CachedCodeEntry.NativeFieldInfoPtr__capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_capnames");
			CachedCodeEntry.NativeFieldInfoPtr__capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_capslist");
			CachedCodeEntry.NativeFieldInfoPtr__capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_capsize");
			CachedCodeEntry.NativeFieldInfoPtr__factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_factory");
			CachedCodeEntry.NativeFieldInfoPtr__runnerref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_runnerref");
			CachedCodeEntry.NativeFieldInfoPtr__replref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, "_replref");
			CachedCodeEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_SharedReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr, 100663946);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00021858 File Offset: 0x0001FA58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37565, RefRangeEnd = 37566, XrefRangeStart = 37564, XrefRangeEnd = 37565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedCodeEntry(string key, Hashtable capnames, Il2CppStringArray capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, SharedReference repl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedCodeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capnames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(capslist);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(code);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runner);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(repl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CachedCodeEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_SharedReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00003829 File Offset: 0x00001A29
		public CachedCodeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00021924 File Offset: 0x0001FB24
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00003832 File Offset: 0x00001A32
		public unsafe string _key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x0002194C File Offset: 0x0001FB4C
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00003851 File Offset: 0x00001A51
		public unsafe RegexCode _code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__code);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__code), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0002197C File Offset: 0x0001FB7C
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00003870 File Offset: 0x00001A70
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x000219AC File Offset: 0x0001FBAC
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x0000388F File Offset: 0x00001A8F
		public unsafe Hashtable _capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x000219DC File Offset: 0x0001FBDC
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x000038AE File Offset: 0x00001AAE
		public unsafe Il2CppStringArray _capslist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capslist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capslist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00021A0C File Offset: 0x0001FC0C
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x000038CD File Offset: 0x00001ACD
		public unsafe int _capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__capsize)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00021A34 File Offset: 0x0001FC34
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x000038E8 File Offset: 0x00001AE8
		public unsafe RegexRunnerFactory _factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexRunnerFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00021A64 File Offset: 0x0001FC64
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00003907 File Offset: 0x00001B07
		public unsafe ExclusiveReference _runnerref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__runnerref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExclusiveReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__runnerref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00021A94 File Offset: 0x0001FC94
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00003926 File Offset: 0x00001B26
		public unsafe SharedReference _replref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__replref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedCodeEntry.NativeFieldInfoPtr__replref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr__code;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr__capnames;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr__capslist;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr__capsize;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr__factory;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr__runnerref;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeFieldInfoPtr__replref;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Hashtable_Il2CppStringArray_RegexCode_Hashtable_Int32_ExclusiveReference_SharedReference_0;
	}
}
