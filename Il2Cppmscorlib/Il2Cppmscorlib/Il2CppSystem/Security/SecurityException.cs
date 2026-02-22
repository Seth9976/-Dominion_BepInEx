using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security
{
	// Token: 0x020002BF RID: 703
	[Serializable]
	public class SecurityException : SystemException
	{
		// Token: 0x06002F23 RID: 12067 RVA: 0x000ED9D4 File Offset: 0x000EBBD4
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityException()
		{
			Il2CppClassPointerStore<SecurityException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityException>.NativeClassPtr);
			SecurityException.NativeFieldInfoPtr_permissionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecurityException>.NativeClassPtr, "permissionState");
			SecurityException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityException>.NativeClassPtr, 100670772);
			SecurityException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityException>.NativeClassPtr, 100670773);
			SecurityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityException>.NativeClassPtr, 100670774);
			SecurityException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityException>.NativeClassPtr, 100670775);
			SecurityException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityException>.NativeClassPtr, 100670776);
			SecurityException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityException>.NativeClassPtr, 100670777);
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x000EDA90 File Offset: 0x000EBC90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337793, RefRangeEnd = 337794, XrefRangeStart = 337789, XrefRangeEnd = 337793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x000EDACC File Offset: 0x000EBCCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337795, RefRangeEnd = 337796, XrefRangeStart = 337794, XrefRangeEnd = 337795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x000EDB18 File Offset: 0x000EBD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337796, XrefRangeEnd = 337807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x000EDB7C File Offset: 0x000EBD7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337808, RefRangeEnd = 337809, XrefRangeStart = 337807, XrefRangeEnd = 337808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityException(string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecurityException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x000EDBDC File Offset: 0x000EBDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337809, XrefRangeEnd = 337823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SecurityException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F29 RID: 12073 RVA: 0x000EDC40 File Offset: 0x000EBE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337823, XrefRangeEnd = 337824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SecurityException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002F2A RID: 12074 RVA: 0x0001074F File Offset: 0x0000E94F
		public SecurityException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x000EDC84 File Offset: 0x000EBE84
		// (set) Token: 0x06002F2C RID: 12076 RVA: 0x00010758 File Offset: 0x0000E958
		public unsafe string permissionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityException.NativeFieldInfoPtr_permissionState);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecurityException.NativeFieldInfoPtr_permissionState), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040028C1 RID: 10433
		private static readonly IntPtr NativeFieldInfoPtr_permissionState;

		// Token: 0x040028C2 RID: 10434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028C3 RID: 10435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040028C4 RID: 10436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040028C5 RID: 10437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040028C6 RID: 10438
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040028C7 RID: 10439
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
