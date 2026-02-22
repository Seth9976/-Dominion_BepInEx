using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000C0 RID: 192
	[Serializable]
	public sealed class IndexOutOfRangeException : SystemException
	{
		// Token: 0x06000D12 RID: 3346 RVA: 0x0005D4B8 File Offset: 0x0005B6B8
		// Note: this type is marked as 'beforefieldinit'.
		static IndexOutOfRangeException()
		{
			Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IndexOutOfRangeException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr);
			IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr, 100665481);
			IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr, 100665482);
			IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr, 100665483);
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0005D524 File Offset: 0x0005B724
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286112, RefRangeEnd = 286114, XrefRangeStart = 286107, XrefRangeEnd = 286112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexOutOfRangeException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0005D560 File Offset: 0x0005B760
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 286116, RefRangeEnd = 286121, XrefRangeStart = 286114, XrefRangeEnd = 286116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexOutOfRangeException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x0005D5AC File Offset: 0x0005B7AC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexOutOfRangeException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x000057D7 File Offset: 0x000039D7
		public IndexOutOfRangeException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
