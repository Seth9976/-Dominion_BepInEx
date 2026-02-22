using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000273 RID: 627
	[Serializable]
	public class SemaphoreFullException : SystemException
	{
		// Token: 0x06002B15 RID: 11029 RVA: 0x000DDB04 File Offset: 0x000DBD04
		// Note: this type is marked as 'beforefieldinit'.
		static SemaphoreFullException()
		{
			Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SemaphoreFullException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr);
			SemaphoreFullException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr, 100670149);
			SemaphoreFullException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr, 100670150);
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000DDB5C File Offset: 0x000DBD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332324, XrefRangeEnd = 332328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreFullException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreFullException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x000DDB98 File Offset: 0x000DBD98
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreFullException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreFullException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x0000F05F File Offset: 0x0000D25F
		public SemaphoreFullException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
