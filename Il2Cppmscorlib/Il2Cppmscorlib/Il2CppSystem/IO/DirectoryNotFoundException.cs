using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x020001F8 RID: 504
	[Serializable]
	public class DirectoryNotFoundException : IOException
	{
		// Token: 0x06002070 RID: 8304 RVA: 0x000B4490 File Offset: 0x000B2690
		// Note: this type is marked as 'beforefieldinit'.
		static DirectoryNotFoundException()
		{
			Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "DirectoryNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr);
			DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr, 100668696);
			DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr, 100668697);
			DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr, 100668698);
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x000B44FC File Offset: 0x000B26FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320481, XrefRangeEnd = 320486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x000B4538 File Offset: 0x000B2738
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 320488, RefRangeEnd = 320492, XrefRangeStart = 320486, XrefRangeEnd = 320488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryNotFoundException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x000B4584 File Offset: 0x000B2784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x0000AF7D File Offset: 0x0000917D
		public DirectoryNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D4D RID: 7501
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
