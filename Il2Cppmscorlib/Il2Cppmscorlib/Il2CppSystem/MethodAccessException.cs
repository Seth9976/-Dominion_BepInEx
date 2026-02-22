using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000CA RID: 202
	[Serializable]
	public class MethodAccessException : MemberAccessException
	{
		// Token: 0x06000DC1 RID: 3521 RVA: 0x00060880 File Offset: 0x0005EA80
		// Note: this type is marked as 'beforefieldinit'.
		static MethodAccessException()
		{
			Il2CppClassPointerStore<MethodAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MethodAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodAccessException>.NativeClassPtr);
			MethodAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodAccessException>.NativeClassPtr, 100665615);
			MethodAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodAccessException>.NativeClassPtr, 100665616);
			MethodAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodAccessException>.NativeClassPtr, 100665617);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x000608EC File Offset: 0x0005EAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288383, XrefRangeEnd = 288388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00060928 File Offset: 0x0005EB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288388, XrefRangeEnd = 288390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodAccessException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodAccessException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00060974 File Offset: 0x0005EB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x000058EA File Offset: 0x00003AEA
		public MethodAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
