using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000208 RID: 520
	[Serializable]
	public class PathTooLongException : IOException
	{
		// Token: 0x06002157 RID: 8535 RVA: 0x000B7FAC File Offset: 0x000B61AC
		// Note: this type is marked as 'beforefieldinit'.
		static PathTooLongException()
		{
			Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "PathTooLongException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr);
			PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr, 100668813);
			PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr, 100668814);
			PathTooLongException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr, 100668815);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x000B8018 File Offset: 0x000B6218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321141, XrefRangeEnd = 321146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathTooLongException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x000B8054 File Offset: 0x000B6254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321148, RefRangeEnd = 321150, XrefRangeStart = 321146, XrefRangeEnd = 321148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathTooLongException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathTooLongException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000B80A0 File Offset: 0x000B62A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathTooLongException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathTooLongException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathTooLongException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x0000B4D6 File Offset: 0x000096D6
		public PathTooLongException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
