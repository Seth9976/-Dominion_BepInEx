using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044C RID: 1100
	public sealed class DllImportAttribute : Attribute
	{
		// Token: 0x060042C4 RID: 17092 RVA: 0x001329D4 File Offset: 0x00130BD4
		// Note: this type is marked as 'beforefieldinit'.
		static DllImportAttribute()
		{
			Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "DllImportAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr);
			DllImportAttribute.NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "_val");
			DllImportAttribute.NativeFieldInfoPtr_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "EntryPoint");
			DllImportAttribute.NativeFieldInfoPtr_CharSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "CharSet");
			DllImportAttribute.NativeFieldInfoPtr_SetLastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "SetLastError");
			DllImportAttribute.NativeFieldInfoPtr_ExactSpelling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "ExactSpelling");
			DllImportAttribute.NativeFieldInfoPtr_PreserveSig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "PreserveSig");
			DllImportAttribute.NativeFieldInfoPtr_CallingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "CallingConvention");
			DllImportAttribute.NativeFieldInfoPtr_BestFitMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "BestFitMapping");
			DllImportAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "ThrowOnUnmappableChar");
			DllImportAttribute.NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100672974);
			DllImportAttribute.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100672975);
			DllImportAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100672976);
			DllImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100672977);
			DllImportAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100672978);
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x00132B1C File Offset: 0x00130D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 357438, RefRangeEnd = 357439, XrefRangeStart = 357426, XrefRangeEnd = 357438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(RuntimeMethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
			}
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x00132B60 File Offset: 0x00130D60
		[CallerCount(0)]
		public unsafe static bool IsDefined(RuntimeMethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00132BA4 File Offset: 0x00130DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357439, XrefRangeEnd = 357440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dllName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charSet;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exactSpelling;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setLastError;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveSig;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callingConvention;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bestFitMapping;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnUnmappableChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x00132C64 File Offset: 0x00130E64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DllImportAttribute(string dllName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dllName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x060042C9 RID: 17097 RVA: 0x00132CB0 File Offset: 0x00130EB0
		public unsafe string Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DllImportAttribute.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x000199C4 File Offset: 0x00017BC4
		public DllImportAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x060042CB RID: 17099 RVA: 0x00132CE8 File Offset: 0x00130EE8
		// (set) Token: 0x060042CC RID: 17100 RVA: 0x000199CD File Offset: 0x00017BCD
		public unsafe string _val
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr__val);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr__val), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x060042CD RID: 17101 RVA: 0x00132D10 File Offset: 0x00130F10
		// (set) Token: 0x060042CE RID: 17102 RVA: 0x000199EC File Offset: 0x00017BEC
		public unsafe string EntryPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_EntryPoint);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_EntryPoint), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x060042CF RID: 17103 RVA: 0x00132D38 File Offset: 0x00130F38
		// (set) Token: 0x060042D0 RID: 17104 RVA: 0x00019A0B File Offset: 0x00017C0B
		public unsafe CharSet CharSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CharSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CharSet)) = value;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x060042D1 RID: 17105 RVA: 0x00132D60 File Offset: 0x00130F60
		// (set) Token: 0x060042D2 RID: 17106 RVA: 0x00019A26 File Offset: 0x00017C26
		public unsafe bool SetLastError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_SetLastError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_SetLastError)) = value;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x060042D3 RID: 17107 RVA: 0x00132D88 File Offset: 0x00130F88
		// (set) Token: 0x060042D4 RID: 17108 RVA: 0x00019A41 File Offset: 0x00017C41
		public unsafe bool ExactSpelling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ExactSpelling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ExactSpelling)) = value;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x060042D5 RID: 17109 RVA: 0x00132DB0 File Offset: 0x00130FB0
		// (set) Token: 0x060042D6 RID: 17110 RVA: 0x00019A5C File Offset: 0x00017C5C
		public unsafe bool PreserveSig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_PreserveSig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_PreserveSig)) = value;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x060042D7 RID: 17111 RVA: 0x00132DD8 File Offset: 0x00130FD8
		// (set) Token: 0x060042D8 RID: 17112 RVA: 0x00019A77 File Offset: 0x00017C77
		public unsafe CallingConvention CallingConvention
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CallingConvention);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_CallingConvention)) = value;
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x060042D9 RID: 17113 RVA: 0x00132E00 File Offset: 0x00131000
		// (set) Token: 0x060042DA RID: 17114 RVA: 0x00019A92 File Offset: 0x00017C92
		public unsafe bool BestFitMapping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_BestFitMapping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_BestFitMapping)) = value;
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x00132E28 File Offset: 0x00131028
		// (set) Token: 0x060042DC RID: 17116 RVA: 0x00019AAD File Offset: 0x00017CAD
		public unsafe bool ThrowOnUnmappableChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DllImportAttribute.NativeFieldInfoPtr_ThrowOnUnmappableChar)) = value;
			}
		}

		// Token: 0x0400368C RID: 13964
		private static readonly IntPtr NativeFieldInfoPtr__val;

		// Token: 0x0400368D RID: 13965
		private static readonly IntPtr NativeFieldInfoPtr_EntryPoint;

		// Token: 0x0400368E RID: 13966
		private static readonly IntPtr NativeFieldInfoPtr_CharSet;

		// Token: 0x0400368F RID: 13967
		private static readonly IntPtr NativeFieldInfoPtr_SetLastError;

		// Token: 0x04003690 RID: 13968
		private static readonly IntPtr NativeFieldInfoPtr_ExactSpelling;

		// Token: 0x04003691 RID: 13969
		private static readonly IntPtr NativeFieldInfoPtr_PreserveSig;

		// Token: 0x04003692 RID: 13970
		private static readonly IntPtr NativeFieldInfoPtr_CallingConvention;

		// Token: 0x04003693 RID: 13971
		private static readonly IntPtr NativeFieldInfoPtr_BestFitMapping;

		// Token: 0x04003694 RID: 13972
		private static readonly IntPtr NativeFieldInfoPtr_ThrowOnUnmappableChar;

		// Token: 0x04003695 RID: 13973
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0;

		// Token: 0x04003696 RID: 13974
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0;

		// Token: 0x04003697 RID: 13975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0;

		// Token: 0x04003698 RID: 13976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003699 RID: 13977
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
