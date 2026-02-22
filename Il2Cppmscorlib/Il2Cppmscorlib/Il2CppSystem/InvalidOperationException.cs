using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000C5 RID: 197
	[Serializable]
	public class InvalidOperationException : SystemException
	{
		// Token: 0x06000D88 RID: 3464 RVA: 0x0005F93C File Offset: 0x0005DB3C
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidOperationException()
		{
			Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "InvalidOperationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr);
			InvalidOperationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr, 100665577);
			InvalidOperationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr, 100665578);
			InvalidOperationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr, 100665579);
			InvalidOperationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr, 100665580);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0005F9BC File Offset: 0x0005DBBC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 287029, RefRangeEnd = 287039, XrefRangeStart = 287024, XrefRangeEnd = 287029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidOperationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidOperationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0005F9F8 File Offset: 0x0005DBF8
		[CallerCount(1141)]
		[CachedScanResults(RefRangeStart = 287041, RefRangeEnd = 288182, XrefRangeStart = 287039, XrefRangeEnd = 287041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidOperationException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidOperationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0005FA44 File Offset: 0x0005DC44
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 288184, RefRangeEnd = 288192, XrefRangeStart = 288182, XrefRangeEnd = 288184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidOperationException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidOperationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0005FAA4 File Offset: 0x0005DCA4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidOperationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidOperationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidOperationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00005873 File Offset: 0x00003A73
		public InvalidOperationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
