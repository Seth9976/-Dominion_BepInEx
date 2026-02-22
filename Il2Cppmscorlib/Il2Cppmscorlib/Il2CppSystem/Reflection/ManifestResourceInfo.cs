using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A7 RID: 423
	public class ManifestResourceInfo : Object
	{
		// Token: 0x06001BBA RID: 7098 RVA: 0x0009EAEC File Offset: 0x0009CCEC
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestResourceInfo()
		{
			Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ManifestResourceInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr);
			ManifestResourceInfo.NativeFieldInfoPtr__containingAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, "_containingAssembly");
			ManifestResourceInfo.NativeFieldInfoPtr__containingFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, "_containingFileName");
			ManifestResourceInfo.NativeFieldInfoPtr__resourceLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, "_resourceLocation");
			ManifestResourceInfo.NativeMethodInfoPtr__ctor_Public_Void_Assembly_String_ResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100667927);
			ManifestResourceInfo.NativeMethodInfoPtr_get_ReferencedAssembly_Public_Virtual_New_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100667928);
			ManifestResourceInfo.NativeMethodInfoPtr_get_FileName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100667929);
			ManifestResourceInfo.NativeMethodInfoPtr_get_ResourceLocation_Public_Virtual_New_get_ResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr, 100667930);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0009EBA8 File Offset: 0x0009CDA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 22030, RefRangeEnd = 22036, XrefRangeStart = 22030, XrefRangeEnd = 22036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestResourceInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(containingAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containingFileName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resourceLocation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestResourceInfo.NativeMethodInfoPtr__ctor_Public_Void_Assembly_String_ResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x0009EC14 File Offset: 0x0009CE14
		public unsafe virtual Assembly ReferencedAssembly
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManifestResourceInfo.NativeMethodInfoPtr_get_ReferencedAssembly_Public_Virtual_New_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x0009EC60 File Offset: 0x0009CE60
		public unsafe virtual string FileName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManifestResourceInfo.NativeMethodInfoPtr_get_FileName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x0009ECA4 File Offset: 0x0009CEA4
		public unsafe virtual ResourceLocation ResourceLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManifestResourceInfo.NativeMethodInfoPtr_get_ResourceLocation_Public_Virtual_New_get_ResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00009960 File Offset: 0x00007B60
		public ManifestResourceInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x0009ECEC File Offset: 0x0009CEEC
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x00009969 File Offset: 0x00007B69
		public unsafe Assembly _containingAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__containingAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__containingAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x0009ED1C File Offset: 0x0009CF1C
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x00009988 File Offset: 0x00007B88
		public unsafe string _containingFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__containingFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__containingFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x0009ED44 File Offset: 0x0009CF44
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x000099A7 File Offset: 0x00007BA7
		public unsafe ResourceLocation _resourceLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__resourceLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestResourceInfo.NativeFieldInfoPtr__resourceLocation)) = value;
			}
		}

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeFieldInfoPtr__containingAssembly;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeFieldInfoPtr__containingFileName;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeFieldInfoPtr__resourceLocation;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_String_ResourceLocation_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferencedAssembly_Public_Virtual_New_get_Assembly_0;

		// Token: 0x0400193C RID: 6460
		private static readonly IntPtr NativeMethodInfoPtr_get_FileName_Public_Virtual_New_get_String_0;

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceLocation_Public_Virtual_New_get_ResourceLocation_0;
	}
}
