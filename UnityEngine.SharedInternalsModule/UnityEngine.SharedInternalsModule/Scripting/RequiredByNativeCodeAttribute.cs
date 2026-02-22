using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x0200001D RID: 29
	public class RequiredByNativeCodeAttribute : Attribute
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000451C File Offset: 0x0000271C
		// Note: this type is marked as 'beforefieldinit'.
		static RequiredByNativeCodeAttribute()
		{
			Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Scripting", "RequiredByNativeCodeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr);
			RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, "<Name>k__BackingField");
			RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Optional_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, "<Optional>k__BackingField");
			RequiredByNativeCodeAttribute.NativeFieldInfoPtr__GenerateProxy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, "<GenerateProxy>k__BackingField");
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663357);
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663358);
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663359);
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_Optional_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663360);
			RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_GenerateProxy_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr, 100663361);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000045EC File Offset: 0x000027EC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequiredByNativeCodeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004628 File Offset: 0x00002828
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequiredByNativeCodeAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequiredByNativeCodeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00002729 File Offset: 0x00000929
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00004674 File Offset: 0x00002874
		public unsafe string Name
		{
			get
			{
				return this._Name_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00002731 File Offset: 0x00000931
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x000046B8 File Offset: 0x000028B8
		public unsafe bool Optional
		{
			get
			{
				return this._Optional_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_Optional_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002739 File Offset: 0x00000939
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000046F8 File Offset: 0x000028F8
		public unsafe bool GenerateProxy
		{
			get
			{
				return this._GenerateProxy_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredByNativeCodeAttribute.NativeMethodInfoPtr_set_GenerateProxy_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000026CB File Offset: 0x000008CB
		public RequiredByNativeCodeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00004738 File Offset: 0x00002938
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x000026D4 File Offset: 0x000008D4
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00004760 File Offset: 0x00002960
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000026F3 File Offset: 0x000008F3
		public unsafe bool _Optional_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Optional_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__Optional_k__BackingField)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004788 File Offset: 0x00002988
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000270E File Offset: 0x0000090E
		public unsafe bool _GenerateProxy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__GenerateProxy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredByNativeCodeAttribute.NativeFieldInfoPtr__GenerateProxy_k__BackingField)) = value;
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr__Optional_k__BackingField;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr__GenerateProxy_k__BackingField;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_set_Optional_Public_set_Void_Boolean_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_set_GenerateProxy_Public_set_Void_Boolean_0;
	}
}
