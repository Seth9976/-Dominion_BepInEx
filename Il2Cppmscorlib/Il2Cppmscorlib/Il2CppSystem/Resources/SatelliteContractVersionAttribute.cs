using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000189 RID: 393
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		// Token: 0x06001B51 RID: 6993 RVA: 0x0009D53C File Offset: 0x0009B73C
		// Note: this type is marked as 'beforefieldinit'.
		static SatelliteContractVersionAttribute()
		{
			Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "SatelliteContractVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr);
			SatelliteContractVersionAttribute.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr, "_version");
			SatelliteContractVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr, 100667892);
			SatelliteContractVersionAttribute.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr, 100667893);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0009D5A8 File Offset: 0x0009B7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316803, XrefRangeEnd = 316804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SatelliteContractVersionAttribute(string version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SatelliteContractVersionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatelliteContractVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0009D5F4 File Offset: 0x0009B7F4
		public unsafe string Version
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SatelliteContractVersionAttribute.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0000968D File Offset: 0x0000788D
		public SatelliteContractVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x0009D62C File Offset: 0x0009B82C
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x00009696 File Offset: 0x00007896
		public unsafe string _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatelliteContractVersionAttribute.NativeFieldInfoPtr__version);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SatelliteContractVersionAttribute.NativeFieldInfoPtr__version), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;
	}
}
