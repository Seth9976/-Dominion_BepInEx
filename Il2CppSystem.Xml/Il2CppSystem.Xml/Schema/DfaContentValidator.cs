using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000085 RID: 133
	public sealed class DfaContentValidator : ContentValidator
	{
		// Token: 0x0600096A RID: 2410 RVA: 0x000314CC File Offset: 0x0002F6CC
		// Note: this type is marked as 'beforefieldinit'.
		static DfaContentValidator()
		{
			Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DfaContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr);
			DfaContentValidator.NativeFieldInfoPtr_transitionTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, "transitionTable");
			DfaContentValidator.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, "symbols");
			DfaContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_SymbolsDictionary_XmlSchemaContentType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr, 100664803);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00031538 File Offset: 0x0002F738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22017, XrefRangeEnd = 22021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DfaContentValidator(Il2CppReferenceArray<Il2CppStructArray<int>> transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DfaContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transitionTable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DfaContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_SymbolsDictionary_XmlSchemaContentType_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00005083 File Offset: 0x00003283
		public DfaContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x000315C0 File Offset: 0x0002F7C0
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x0000508C File Offset: 0x0000328C
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> transitionTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DfaContentValidator.NativeFieldInfoPtr_transitionTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DfaContentValidator.NativeFieldInfoPtr_transitionTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x000315F0 File Offset: 0x0002F7F0
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x000050AB File Offset: 0x000032AB
		public unsafe SymbolsDictionary symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DfaContentValidator.NativeFieldInfoPtr_symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolsDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DfaContentValidator.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr_transitionTable;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr_symbols;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_SymbolsDictionary_XmlSchemaContentType_Boolean_Boolean_0;
	}
}
