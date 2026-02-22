using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000EC RID: 236
	[Serializable]
	public class SystemException : Exception
	{
		// Token: 0x0600109F RID: 4255 RVA: 0x0006F3CC File Offset: 0x0006D5CC
		// Note: this type is marked as 'beforefieldinit'.
		static SystemException()
		{
			Il2CppClassPointerStore<SystemException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SystemException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemException>.NativeClassPtr);
			SystemException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100666156);
			SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100666157);
			SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100666158);
			SystemException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100666159);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0006F44C File Offset: 0x0006D64C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 298146, RefRangeEnd = 298150, XrefRangeStart = 298138, XrefRangeEnd = 298146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0006F488 File Offset: 0x0006D688
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 298155, RefRangeEnd = 298260, XrefRangeStart = 298150, XrefRangeEnd = 298155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0006F4D4 File Offset: 0x0006D6D4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 298265, RefRangeEnd = 298292, XrefRangeStart = 298260, XrefRangeEnd = 298265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0006F534 File Offset: 0x0006D734
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 298296, RefRangeEnd = 298345, XrefRangeStart = 298292, XrefRangeEnd = 298296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000060E7 File Offset: 0x000042E7
		public SystemException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
