using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000075 RID: 117
	[Serializable]
	public class ArgumentException : SystemException
	{
		// Token: 0x0600070D RID: 1805 RVA: 0x000419B8 File Offset: 0x0003FBB8
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentException()
		{
			Il2CppClassPointerStore<ArgumentException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgumentException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr);
			ArgumentException.NativeFieldInfoPtr_m_paramName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, "m_paramName");
			ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664390);
			ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664391);
			ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664392);
			ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664393);
			ArgumentException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664394);
			ArgumentException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664395);
			ArgumentException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr, 100664396);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00041A88 File Offset: 0x0003FC88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275579, RefRangeEnd = 275580, XrefRangeStart = 275574, XrefRangeEnd = 275579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00041AC4 File Offset: 0x0003FCC4
		[CallerCount(103)]
		[CachedScanResults(RefRangeStart = 275582, RefRangeEnd = 275685, XrefRangeStart = 275580, XrefRangeEnd = 275582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00041B10 File Offset: 0x0003FD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275685, XrefRangeEnd = 275687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00041B70 File Offset: 0x0003FD70
		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 275689, RefRangeEnd = 275761, XrefRangeStart = 275687, XrefRangeEnd = 275689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException(string message, string paramName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00041BD0 File Offset: 0x0003FDD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275765, RefRangeEnd = 275768, XrefRangeStart = 275761, XrefRangeEnd = 275765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00041C34 File Offset: 0x0003FE34
		public unsafe override string Message
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 275772, RefRangeEnd = 275773, XrefRangeStart = 275768, XrefRangeEnd = 275772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00041C78 File Offset: 0x0003FE78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275783, RefRangeEnd = 275784, XrefRangeStart = 275773, XrefRangeEnd = 275783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00004494 File Offset: 0x00002694
		public ArgumentException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00041CDC File Offset: 0x0003FEDC
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x0000449D File Offset: 0x0000269D
		public unsafe string m_paramName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentException.NativeFieldInfoPtr_m_paramName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentException.NativeFieldInfoPtr_m_paramName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr_m_paramName;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
