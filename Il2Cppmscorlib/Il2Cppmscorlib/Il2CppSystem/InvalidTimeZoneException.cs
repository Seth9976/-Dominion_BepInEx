using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000C7 RID: 199
	[Serializable]
	public class InvalidTimeZoneException : Exception
	{
		// Token: 0x06000D93 RID: 3475 RVA: 0x0005FC60 File Offset: 0x0005DE60
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidTimeZoneException()
		{
			Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "InvalidTimeZoneException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr);
			InvalidTimeZoneException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr, 100665584);
			InvalidTimeZoneException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr, 100665585);
			InvalidTimeZoneException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr, 100665586);
			InvalidTimeZoneException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr, 100665587);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x0005FCE0 File Offset: 0x0005DEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288199, XrefRangeEnd = 288203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidTimeZoneException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidTimeZoneException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0005FD2C File Offset: 0x0005DF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288203, XrefRangeEnd = 288207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidTimeZoneException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidTimeZoneException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0005FD8C File Offset: 0x0005DF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288207, XrefRangeEnd = 288211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidTimeZoneException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidTimeZoneException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0005FDF0 File Offset: 0x0005DFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288211, XrefRangeEnd = 288215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidTimeZoneException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidTimeZoneException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidTimeZoneException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00005885 File Offset: 0x00003A85
		public InvalidTimeZoneException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
