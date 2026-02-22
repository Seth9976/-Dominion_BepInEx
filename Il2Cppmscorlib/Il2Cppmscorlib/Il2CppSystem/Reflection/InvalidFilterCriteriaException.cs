using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A5 RID: 421
	[Serializable]
	public class InvalidFilterCriteriaException : ApplicationException
	{
		// Token: 0x06001BB2 RID: 7090 RVA: 0x0009E948 File Offset: 0x0009CB48
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidFilterCriteriaException()
		{
			Il2CppClassPointerStore<InvalidFilterCriteriaException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "InvalidFilterCriteriaException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidFilterCriteriaException>.NativeClassPtr);
			InvalidFilterCriteriaException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidFilterCriteriaException>.NativeClassPtr, 100667923);
			InvalidFilterCriteriaException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidFilterCriteriaException>.NativeClassPtr, 100667924);
			InvalidFilterCriteriaException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidFilterCriteriaException>.NativeClassPtr, 100667925);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0009E9B4 File Offset: 0x0009CBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316830, XrefRangeEnd = 316835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidFilterCriteriaException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidFilterCriteriaException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidFilterCriteriaException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0009E9F0 File Offset: 0x0009CBF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316837, RefRangeEnd = 316838, XrefRangeStart = 316835, XrefRangeEnd = 316837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidFilterCriteriaException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidFilterCriteriaException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidFilterCriteriaException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0009EA3C File Offset: 0x0009CC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316838, XrefRangeEnd = 316839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidFilterCriteriaException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidFilterCriteriaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidFilterCriteriaException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0000991F File Offset: 0x00007B1F
		public InvalidFilterCriteriaException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
