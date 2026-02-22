using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D8 RID: 216
	[Serializable]
	public class OverflowException : ArithmeticException
	{
		// Token: 0x06000E4A RID: 3658 RVA: 0x00063348 File Offset: 0x00061548
		// Note: this type is marked as 'beforefieldinit'.
		static OverflowException()
		{
			Il2CppClassPointerStore<OverflowException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OverflowException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverflowException>.NativeClassPtr);
			OverflowException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverflowException>.NativeClassPtr, 100665711);
			OverflowException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverflowException>.NativeClassPtr, 100665712);
			OverflowException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverflowException>.NativeClassPtr, 100665713);
			OverflowException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverflowException>.NativeClassPtr, 100665714);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000633C8 File Offset: 0x000615C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290309, XrefRangeEnd = 290314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverflowException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverflowException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverflowException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00063404 File Offset: 0x00061604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290316, RefRangeEnd = 290317, XrefRangeStart = 290314, XrefRangeEnd = 290316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverflowException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverflowException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverflowException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00063450 File Offset: 0x00061650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290317, XrefRangeEnd = 290319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverflowException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverflowException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverflowException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000634B0 File Offset: 0x000616B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverflowException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverflowException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverflowException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00005AA4 File Offset: 0x00003CA4
		public OverflowException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
