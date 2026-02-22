using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000180 RID: 384
	[Serializable]
	public class MissingSatelliteAssemblyException : SystemException
	{
		// Token: 0x06001A7D RID: 6781 RVA: 0x0009A618 File Offset: 0x00098818
		// Note: this type is marked as 'beforefieldinit'.
		static MissingSatelliteAssemblyException()
		{
			Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "MissingSatelliteAssemblyException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr);
			MissingSatelliteAssemblyException.NativeFieldInfoPtr__cultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, "_cultureName");
			MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, 100667775);
			MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, 100667776);
			MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, 100667777);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x0009A698 File Offset: 0x00098898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315802, XrefRangeEnd = 315807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingSatelliteAssemblyException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0009A6D4 File Offset: 0x000988D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315809, RefRangeEnd = 315810, XrefRangeStart = 315807, XrefRangeEnd = 315809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingSatelliteAssemblyException(string message, string cultureName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0009A734 File Offset: 0x00098934
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0000903E File Offset: 0x0000723E
		public MissingSatelliteAssemblyException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0009A798 File Offset: 0x00098998
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x00009047 File Offset: 0x00007247
		public unsafe string _cultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingSatelliteAssemblyException.NativeFieldInfoPtr__cultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingSatelliteAssemblyException.NativeFieldInfoPtr__cultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeFieldInfoPtr__cultureName;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
