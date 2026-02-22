using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000C4 RID: 196
	[Serializable]
	public class InvalidCastException : SystemException
	{
		// Token: 0x06000D83 RID: 3459 RVA: 0x0005F7E4 File Offset: 0x0005D9E4
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidCastException()
		{
			Il2CppClassPointerStore<InvalidCastException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "InvalidCastException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidCastException>.NativeClassPtr);
			InvalidCastException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidCastException>.NativeClassPtr, 100665574);
			InvalidCastException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidCastException>.NativeClassPtr, 100665575);
			InvalidCastException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidCastException>.NativeClassPtr, 100665576);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0005F850 File Offset: 0x0005DA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286962, XrefRangeEnd = 286967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidCastException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidCastException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidCastException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0005F88C File Offset: 0x0005DA8C
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 286969, RefRangeEnd = 287024, XrefRangeStart = 286967, XrefRangeEnd = 286969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidCastException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidCastException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidCastException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0005F8D8 File Offset: 0x0005DAD8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidCastException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidCastException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidCastException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0000586A File Offset: 0x00003A6A
		public InvalidCastException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
