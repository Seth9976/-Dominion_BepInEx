using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000053 RID: 83
	public sealed class RegexPrefix : Object
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x000254D8 File Offset: 0x000236D8
		// Note: this type is marked as 'beforefieldinit'.
		static RegexPrefix()
		{
			Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexPrefix");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr);
			RegexPrefix.NativeFieldInfoPtr__prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "_prefix");
			RegexPrefix.NativeFieldInfoPtr__caseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "_caseInsensitive");
			RegexPrefix.NativeFieldInfoPtr__empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "_empty");
			RegexPrefix.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664039);
			RegexPrefix.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664040);
			RegexPrefix.NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664041);
			RegexPrefix.NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664042);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00025594 File Offset: 0x00023794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39185, RefRangeEnd = 39187, XrefRangeStart = 39184, XrefRangeEnd = 39185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexPrefix(string prefix, bool ci)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ci;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x000255F0 File Offset: 0x000237F0
		public unsafe string Prefix
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr_get_Prefix_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00025628 File Offset: 0x00023828
		public unsafe bool CaseInsensitive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00025664 File Offset: 0x00023864
		public unsafe static RegexPrefix Empty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39187, XrefRangeEnd = 39191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexPrefix.NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr3) : null;
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000427F File Offset: 0x0000247F
		public RegexPrefix(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00025698 File Offset: 0x00023898
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00004288 File Offset: 0x00002488
		public unsafe string _prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x000256C0 File Offset: 0x000238C0
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x000042A7 File Offset: 0x000024A7
		public unsafe bool _caseInsensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__caseInsensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexPrefix.NativeFieldInfoPtr__caseInsensitive)) = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x000256E8 File Offset: 0x000238E8
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x000042C2 File Offset: 0x000024C2
		public unsafe static RegexPrefix _empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexPrefix.NativeFieldInfoPtr__empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexPrefix.NativeFieldInfoPtr__empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr__prefix;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitive;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr__empty;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Internal_get_String_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0;
	}
}
