using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000073 RID: 115
	[Serializable]
	public class AppDomainUnloadedException : SystemException
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x000416F4 File Offset: 0x0003F8F4
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomainUnloadedException()
		{
			Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomainUnloadedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr);
			AppDomainUnloadedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr, 100664384);
			AppDomainUnloadedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr, 100664385);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0004174C File Offset: 0x0003F94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275531, XrefRangeEnd = 275536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainUnloadedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainUnloadedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00041788 File Offset: 0x0003F988
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainUnloadedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainUnloadedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainUnloadedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00004482 File Offset: 0x00002682
		public AppDomainUnloadedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
