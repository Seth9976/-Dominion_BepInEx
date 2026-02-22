using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200012A RID: 298
	[Serializable]
	public sealed class OperatingSystem : Object
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x00083D98 File Offset: 0x00081F98
		// Note: this type is marked as 'beforefieldinit'.
		static OperatingSystem()
		{
			Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OperatingSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr);
			OperatingSystem.NativeFieldInfoPtr__platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_platform");
			OperatingSystem.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_version");
			OperatingSystem.NativeFieldInfoPtr__servicePack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, "_servicePack");
			OperatingSystem.NativeMethodInfoPtr__ctor_Public_Void_PlatformID_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666952);
			OperatingSystem.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666953);
			OperatingSystem.NativeMethodInfoPtr_get_Platform_Public_get_PlatformID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666954);
			OperatingSystem.NativeMethodInfoPtr_get_Version_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666955);
			OperatingSystem.NativeMethodInfoPtr_get_ServicePack_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666956);
			OperatingSystem.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666957);
			OperatingSystem.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666958);
			OperatingSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr, 100666959);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00083EA4 File Offset: 0x000820A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307811, RefRangeEnd = 307812, XrefRangeStart = 307799, XrefRangeEnd = 307811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperatingSystem(PlatformID platform, Version version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr__ctor_Public_Void_PlatformID_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00083F00 File Offset: 0x00082100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307812, XrefRangeEnd = 307837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperatingSystem(SerializationInfo information, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperatingSystem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(information);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00083F64 File Offset: 0x00082164
		public unsafe PlatformID Platform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_get_Platform_Public_get_PlatformID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x00083FA0 File Offset: 0x000821A0
		public unsafe Version Version
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_get_Version_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x00083FE0 File Offset: 0x000821E0
		public unsafe string ServicePack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_get_ServicePack_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00084018 File Offset: 0x00082218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307837, XrefRangeEnd = 307852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00084058 File Offset: 0x00082258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307852, XrefRangeEnd = 307864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x000840B4 File Offset: 0x000822B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307864, XrefRangeEnd = 307898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatingSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00007745 File Offset: 0x00005945
		public OperatingSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x000840EC File Offset: 0x000822EC
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x0000774E File Offset: 0x0000594E
		public unsafe PlatformID _platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__platform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__platform)) = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00084114 File Offset: 0x00082314
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x00007769 File Offset: 0x00005969
		public unsafe Version _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__version);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__version), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00084144 File Offset: 0x00082344
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x00007788 File Offset: 0x00005988
		public unsafe string _servicePack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__servicePack);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatingSystem.NativeFieldInfoPtr__servicePack), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeFieldInfoPtr__platform;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeFieldInfoPtr__servicePack;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlatformID_Version_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Public_get_PlatformID_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Version_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePack_Public_get_String_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
