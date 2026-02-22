using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000B RID: 11
	public class NativeNameAttribute : Attribute
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002FDC File Offset: 0x000011DC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeNameAttribute()
		{
			Il2CppClassPointerStore<NativeNameAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeNameAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeNameAttribute>.NativeClassPtr);
			NativeNameAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeNameAttribute>.NativeClassPtr, "<Name>k__BackingField");
			NativeNameAttribute.NativeMethodInfoPtr_set_Name_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeNameAttribute>.NativeClassPtr, 100663313);
			NativeNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeNameAttribute>.NativeClassPtr, 100663314);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000022FF File Offset: 0x000004FF
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00003048 File Offset: 0x00001248
		public unsafe virtual string Name
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeNameAttribute.NativeMethodInfoPtr_set_Name_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000308C File Offset: 0x0000128C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58913, XrefRangeEnd = 58917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeNameAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeNameAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000022D7 File Offset: 0x000004D7
		public NativeNameAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000030D8 File Offset: 0x000012D8
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000022E0 File Offset: 0x000004E0
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeNameAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeNameAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
