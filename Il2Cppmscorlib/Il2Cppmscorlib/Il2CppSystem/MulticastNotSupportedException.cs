using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000CE RID: 206
	[Serializable]
	public sealed class MulticastNotSupportedException : SystemException
	{
		// Token: 0x06000DE5 RID: 3557 RVA: 0x00061228 File Offset: 0x0005F428
		// Note: this type is marked as 'beforefieldinit'.
		static MulticastNotSupportedException()
		{
			Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MulticastNotSupportedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr);
			MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr, 100665635);
			MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr, 100665636);
			MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr, 100665637);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00061294 File Offset: 0x0005F494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288527, XrefRangeEnd = 288532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastNotSupportedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000612D0 File Offset: 0x0005F4D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288534, RefRangeEnd = 288535, XrefRangeStart = 288532, XrefRangeEnd = 288534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastNotSupportedException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0006131C File Offset: 0x0005F51C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastNotSupportedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0000598A File Offset: 0x00003B8A
		public MulticastNotSupportedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
