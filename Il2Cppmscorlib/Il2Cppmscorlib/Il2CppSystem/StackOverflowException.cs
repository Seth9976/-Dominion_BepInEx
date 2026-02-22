using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000E6 RID: 230
	[Serializable]
	public sealed class StackOverflowException : SystemException
	{
		// Token: 0x06000F9F RID: 3999 RVA: 0x00069A88 File Offset: 0x00067C88
		// Note: this type is marked as 'beforefieldinit'.
		static StackOverflowException()
		{
			Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "StackOverflowException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr);
			StackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr, 100665951);
			StackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr, 100665952);
			StackOverflowException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr, 100665953);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00069AF4 File Offset: 0x00067CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292275, XrefRangeEnd = 292280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackOverflowException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00069B30 File Offset: 0x00067D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292280, XrefRangeEnd = 292282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackOverflowException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00069B7C File Offset: 0x00067D7C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackOverflowException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackOverflowException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00005EDF File Offset: 0x000040DF
		public StackOverflowException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
