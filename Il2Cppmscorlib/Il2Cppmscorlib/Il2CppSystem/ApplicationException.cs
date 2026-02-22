using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000074 RID: 116
	[Serializable]
	public class ApplicationException : Exception
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x000417EC File Offset: 0x0003F9EC
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationException()
		{
			Il2CppClassPointerStore<ApplicationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ApplicationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationException>.NativeClassPtr);
			ApplicationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationException>.NativeClassPtr, 100664386);
			ApplicationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationException>.NativeClassPtr, 100664387);
			ApplicationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationException>.NativeClassPtr, 100664388);
			ApplicationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationException>.NativeClassPtr, 100664389);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0004186C File Offset: 0x0003FA6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275544, RefRangeEnd = 275545, XrefRangeStart = 275536, XrefRangeEnd = 275544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000418A8 File Offset: 0x0003FAA8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 275550, RefRangeEnd = 275558, XrefRangeStart = 275545, XrefRangeEnd = 275550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000418F4 File Offset: 0x0003FAF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275563, RefRangeEnd = 275565, XrefRangeStart = 275558, XrefRangeEnd = 275563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00041954 File Offset: 0x0003FB54
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 275569, RefRangeEnd = 275574, XrefRangeStart = 275565, XrefRangeEnd = 275569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0000448B File Offset: 0x0000268B
		public ApplicationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
