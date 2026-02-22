using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000181 RID: 385
	public sealed class NeutralResourcesLanguageAttribute : Attribute
	{
		// Token: 0x06001A84 RID: 6788 RVA: 0x0009A7C0 File Offset: 0x000989C0
		// Note: this type is marked as 'beforefieldinit'.
		static NeutralResourcesLanguageAttribute()
		{
			Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "NeutralResourcesLanguageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr);
			NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, "_culture");
			NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__fallbackLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, "_fallbackLoc");
			NeutralResourcesLanguageAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100667778);
			NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_CultureName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100667779);
			NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100667780);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0009A854 File Offset: 0x00098A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315810, XrefRangeEnd = 315811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NeutralResourcesLanguageAttribute(string cultureName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralResourcesLanguageAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0009A8A0 File Offset: 0x00098AA0
		public unsafe string CultureName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_CultureName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001A87 RID: 6791 RVA: 0x0009A8D8 File Offset: 0x00098AD8
		public unsafe UltimateResourceFallbackLocation Location
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x00009066 File Offset: 0x00007266
		public NeutralResourcesLanguageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001A89 RID: 6793 RVA: 0x0009A914 File Offset: 0x00098B14
		// (set) Token: 0x06001A8A RID: 6794 RVA: 0x0000906F File Offset: 0x0000726F
		public unsafe string _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__culture);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__culture), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0009A93C File Offset: 0x00098B3C
		// (set) Token: 0x06001A8C RID: 6796 RVA: 0x0000908E File Offset: 0x0000728E
		public unsafe UltimateResourceFallbackLocation _fallbackLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__fallbackLoc);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__fallbackLoc)) = value;
			}
		}

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeFieldInfoPtr__fallbackLoc;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Public_get_String_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0;
	}
}
