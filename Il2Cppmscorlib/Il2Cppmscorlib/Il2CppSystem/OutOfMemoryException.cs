using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D7 RID: 215
	[Serializable]
	public class OutOfMemoryException : SystemException
	{
		// Token: 0x06000E45 RID: 3653 RVA: 0x000631F0 File Offset: 0x000613F0
		// Note: this type is marked as 'beforefieldinit'.
		static OutOfMemoryException()
		{
			Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OutOfMemoryException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr);
			OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100665708);
			OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100665709);
			OutOfMemoryException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr, 100665710);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0006325C File Offset: 0x0006145C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290305, RefRangeEnd = 290307, XrefRangeStart = 290299, XrefRangeEnd = 290305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutOfMemoryException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00063298 File Offset: 0x00061498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290307, XrefRangeEnd = 290309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutOfMemoryException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutOfMemoryException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x000632E4 File Offset: 0x000614E4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutOfMemoryException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutOfMemoryException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutOfMemoryException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00005A9B File Offset: 0x00003C9B
		public OutOfMemoryException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
