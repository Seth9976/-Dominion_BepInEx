using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200039A RID: 922
	[Serializable]
	public class RemotingException : SystemException
	{
		// Token: 0x06003C11 RID: 15377 RVA: 0x0011ABF8 File Offset: 0x00118DF8
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingException()
		{
			Il2CppClassPointerStore<RemotingException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "RemotingException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingException>.NativeClassPtr);
			RemotingException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingException>.NativeClassPtr, 100672150);
			RemotingException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingException>.NativeClassPtr, 100672151);
			RemotingException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingException>.NativeClassPtr, 100672152);
			RemotingException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingException>.NativeClassPtr, 100672153);
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x0011AC78 File Offset: 0x00118E78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45967, RefRangeEnd = 45968, XrefRangeStart = 45967, XrefRangeEnd = 45968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x0011ACB4 File Offset: 0x00118EB4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 337841, RefRangeEnd = 337849, XrefRangeStart = 337841, XrefRangeEnd = 337849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x0011AD00 File Offset: 0x00118F00
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x0011AD64 File Offset: 0x00118F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingException(string message, Exception InnerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(InnerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00016ABC File Offset: 0x00014CBC
		public RemotingException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040031DF RID: 12767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031E0 RID: 12768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040031E1 RID: 12769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040031E2 RID: 12770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;
	}
}
