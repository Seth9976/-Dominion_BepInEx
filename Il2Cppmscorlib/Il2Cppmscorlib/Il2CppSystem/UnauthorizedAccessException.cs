using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000FD RID: 253
	[Serializable]
	public class UnauthorizedAccessException : SystemException
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x00078F6C File Offset: 0x0007716C
		// Note: this type is marked as 'beforefieldinit'.
		static UnauthorizedAccessException()
		{
			Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnauthorizedAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr);
			UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr, 100666563);
			UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr, 100666564);
			UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr, 100666565);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00078FD8 File Offset: 0x000771D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303174, XrefRangeEnd = 303179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnauthorizedAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00079014 File Offset: 0x00077214
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 303181, RefRangeEnd = 303185, XrefRangeStart = 303179, XrefRangeEnd = 303181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnauthorizedAccessException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00079060 File Offset: 0x00077260
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnauthorizedAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00006668 File Offset: 0x00004868
		public UnauthorizedAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
