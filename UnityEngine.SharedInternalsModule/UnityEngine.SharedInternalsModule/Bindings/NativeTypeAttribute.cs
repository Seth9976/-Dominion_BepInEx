using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000012 RID: 18
	public class NativeTypeAttribute : Attribute
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000038D8 File Offset: 0x00001AD8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeTypeAttribute()
		{
			Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr);
			NativeTypeAttribute.NativeFieldInfoPtr__Header_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<Header>k__BackingField");
			NativeTypeAttribute.NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<IntermediateScriptingStructName>k__BackingField");
			NativeTypeAttribute.NativeFieldInfoPtr__CodegenOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<CodegenOptions>k__BackingField");
			NativeTypeAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663331);
			NativeTypeAttribute.NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663332);
			NativeTypeAttribute.NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663333);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663334);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663335);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663336);
			NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663337);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000024D9 File Offset: 0x000006D9
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000039D0 File Offset: 0x00001BD0
		public unsafe virtual string Header
		{
			get
			{
				return this._Header_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000024E1 File Offset: 0x000006E1
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00003A14 File Offset: 0x00001C14
		public unsafe string IntermediateScriptingStructName
		{
			get
			{
				return this._IntermediateScriptingStructName_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000024E9 File Offset: 0x000006E9
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00003A58 File Offset: 0x00001C58
		public unsafe virtual CodegenOptions CodegenOptions
		{
			get
			{
				return this._CodegenOptions_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003A98 File Offset: 0x00001C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58932, XrefRangeEnd = 58933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeTypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003AD4 File Offset: 0x00001CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58933, XrefRangeEnd = 58934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeTypeAttribute(CodegenOptions codegenOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codegenOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003B1C File Offset: 0x00001D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58934, XrefRangeEnd = 58938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeTypeAttribute(string header)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003B68 File Offset: 0x00001D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58938, XrefRangeEnd = 58939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codegenOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(intermediateStructName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002477 File Offset: 0x00000677
		public NativeTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003BC4 File Offset: 0x00001DC4
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002480 File Offset: 0x00000680
		public unsafe string _Header_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__Header_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__Header_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003BEC File Offset: 0x00001DEC
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000249F File Offset: 0x0000069F
		public unsafe string _IntermediateScriptingStructName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003C14 File Offset: 0x00001E14
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000024BE File Offset: 0x000006BE
		public unsafe CodegenOptions _CodegenOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__CodegenOptions_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeTypeAttribute.NativeFieldInfoPtr__CodegenOptions_k__BackingField)) = value;
			}
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr__Header_k__BackingField;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr__CodegenOptions_k__BackingField;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0;
	}
}
